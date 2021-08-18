from django.urls import path
from . import abr_msg_recv

websocket_urlpatterns = [
    path('ws/composition/', abr_msg_recv.AbrMessageRecieve),
]