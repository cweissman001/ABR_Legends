from channels.generic.websocket import WebsocketConsumer
import json
import logging
from threading import Thread, Event
from queue import Queue
from .engine_connector import engine

logger = logging.getLogger('django.server')

class AbrMessageRecieve(WebsocketConsumer):
    def __init__(self, *args, **kwargs):
        self.ws_forwarding_thread = None
        self.to_client_queue = Queue()
        self.running = Event()
        super().__init__(*args, **kwargs)

    def connect(self):
        self.accept()
        logger.info('New client connected')
        engine.subscribe(self._send_to_client)

        self.running.set()
        self.ws_forwarding_thread = Thread(target=self._client_sender)
        self.ws_forwarding_thread.start()

    def disconnect(self, status):
        logger.info('AbrMessageReceive WebSocket Disconnected: {}'.format(status))
        engine.unsubscribe(self._send_to_client)
        self.ws_forwarding_thread.join()
        self.ws_forwarding_thread = None

    def receive(self, text_data):
        engine.send(text_data.encode('utf-8'))
    
    def _send_to_client(self, message):
        self.to_client_queue.put(message)

    def _client_sender(self):
        # Forward messages in the queue to the client
        logger.info('Started client forwarding')
        while self.running.is_set():
            while not self.to_client_queue.empty():
                msg = self.to_client_queue.get()
                self.send(text_data=msg.decode('utf-8'))
        logger.info('Stopped client forwarding')
