from django.urls import path

from . import views

urlpatterns = [
    path('', views.index, name='index'),
    path('screenshot-list/<str:state_name>', views.screenshot_list),
    path('update-colormap/', views.update_colormap),
    path('copy-colormap/', views.copy_colormap),
]