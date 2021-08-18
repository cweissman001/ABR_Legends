# engine_connector.py
#
# Copyright (c) 2020, University of Minnesota
# Author: Bridger Herman <herma582@umn.edu>
#
# Socket connection to the ABR Engine
import sys
import time
import socket
import logging
from threading import Thread, Event
from queue import Queue

ADDRESS, PORT = '127.0.0.1', 9000
BUF_SIZE = 4096

logger = logging.getLogger('django.server')

class EngineConnector:
    def __init__(self):
        self.receiver_thread = None
        self.sender_thread = None
        self.abr_engine_socket = None
        self.connected_to_engine = Event()

        logger.info('Initializing ABR engine socket')
        self.abr_engine_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        self._try_engine_connect()

        self.subscribers = set()
        self.to_engine_queue = Queue()

        self.receiver_thread = Thread(target=self._receiver)
        self.sender_thread = Thread(target=self._sender)
        self.receiver_thread.start()
        self.sender_thread.start()

    def subscribe(self, callback):
        logger.info('New client subscribed to engine messages')
        self.subscribers.add(callback)
    
    def unsubscribe(self, callback):
        logger.info('A client disconnected from engine messages')
        self.subscribers.remove(callback)

    def send(self, message):
        '''
            `message` is a bytestring of the JSON message
        '''
        self.to_engine_queue.put(message)

    def _try_engine_connect(self):
        try:
            self.abr_engine_socket.connect((ADDRESS, PORT))
            self.abr_engine_socket.setblocking(False)
            self.connected_to_engine.set()
            return True
        except OSError:
            err = 'Unable to connect to ABR Engine'
            logger.error(err)
            return False

    def _receiver(self):
        # Keep going until the server is killed
        # Ping every 1s. The sender will set self.connected_to_engine to true
        # if it successfully sent bytes to the engine.
        while True:
            if self.connected_to_engine.is_set():
                logger.info('Started receiving from ABR engine')

            while self.connected_to_engine.is_set():
                # Wait for messages from the ABR engine, then forward them to the
                # composition client
                try:
                    # Receive the length of the next message (an Int32, assumed to be
                    # little endian)
                    length = int.from_bytes(self.abr_engine_socket.recv(4), 'little')

                    # Construct the whole message from the socket
                    bytes_read = 0
                    message = bytes()
                    while bytes_read < length:
                        received_bytes = self.abr_engine_socket.recv(min(length - bytes_read, BUF_SIZE))
                        if received_bytes:
                            bytes_read += len(received_bytes)
                            message += received_bytes

                    # Send message to all subscribing clients
                    for callback in self.subscribers:
                        callback(message)

                except BlockingIOError:
                    pass
                except:
                    self.connected_to_engine.clear()
                    logger.info('Stopped receiving from ABR engine')

            time.sleep(1)


    def _sender(self):
        # Keep going until the server is killed
        # Ping every 1s.
        while True:
            # Try to a zero int to the engine. If success, set self.connected_to_engine
            if self._try_engine_connect() and self.abr_engine_socket.send(int.to_bytes(0, 4, 'little')):
                self.connected_to_engine.set()
                logger.info('Started sending to ABR engine')

            while self.connected_to_engine.is_set():
                # Send messages from the design client to the ABR engine
                while not self.to_engine_queue.empty():
                    try:
                        message = self.to_engine_queue.get()

                        # Send the message length to the engine
                        length = len(message)
                        total_bytes = 0
                        while total_bytes < 4:
                            total_bytes += self.abr_engine_socket.send(int.to_bytes(length, 4, 'little'))

                        total_bytes = 0
                        while total_bytes < length:
                            total_bytes += self.abr_engine_socket.send(message)

                    except BlockingIOError:
                        pass
                    except:
                        self.connected_to_engine.clear()
                        logger.info('Stopped sending to ABR engine')

            time.sleep(1)
if 'runserver' in sys.argv:
    engine = EngineConnector()
