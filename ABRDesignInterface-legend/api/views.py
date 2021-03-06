import os
import sys
import shutil
import json
import base64
import fnmatch
from django.http import HttpResponse
from django.conf import settings
from django.views.decorators.csrf import csrf_exempt

if 'runserver' in sys.argv:
    from composition.engine_connector import engine

VISASSET_JSON = 'artifact.json'

# Dummy index, users should never need to go here
def index(request):
    return HttpResponse("Nothing to see here")

# Access the list of screenshots that are available to the engine
def screenshot_list(request, state_name):
    # Get a list of the screenshots in the screenshot directory
    screenshot_path = os.path.join(settings.MEDIA_ROOT, 'screenshots', state_name)
    try:
        all_files = os.listdir(screenshot_path)
        screenshots = list(map(
            lambda f: f.rstrip('.png'),
            filter(
                lambda f: fnmatch.fnmatch(f, '*.png') and '#thumbnail' not in f,
                all_files,
            )
        ))
    except:
        screenshots = []

    # Serialize them and send to the client
    serialized = json.dumps({'screenshots': screenshots})
    return HttpResponse(serialized, content_type='application/json')

# Make a state-specific copy of the colormap VisAsset
@csrf_exempt
def copy_colormap(request):
    data = json.loads(request.body)
    old_uuid = data.get('oldUuid')
    new_uuid = data.get('newUuid')
    force_copy = data.get('forceCopy', False) # Force copy an already-state-specific VisAsset
    visasset_path = os.path.join(settings.MEDIA_ROOT, 'visassets')
    old_path = os.path.join(visasset_path, old_uuid)
    new_path = os.path.join(visasset_path, new_uuid)

    # Check if the old artifact is state-specific
    with open(os.path.join(old_path, VISASSET_JSON)) as fin:
        old_artifact = json.load(fin)
    
    # If yes (and not forcing a copy), don't actually copy it
    print(old_artifact)
    if old_artifact.get('stateSpecific', False) and not force_copy:
        return HttpResponse('VisAsset already state specific and copy not forced')

    shutil.copytree(old_path, new_path)

    # Make sure that the `stateSpecific` field is set on the artifact json
    with open(os.path.join(new_path, VISASSET_JSON)) as fin:
        artifact = json.load(fin)

    artifact['stateSpecific'] = True
    artifact['uuid'] = new_uuid

    with open(os.path.join(new_path, VISASSET_JSON), 'w') as fout:
        json.dump(artifact, fout)

    engine_uuid_msg(4, new_uuid)

    return HttpResponse('VisAsset copied')

# Update a colormap VisAsset
@csrf_exempt
def update_colormap(request):
    data = json.loads(request.body)
    uuid = data.get('uuid')
    png_b64 = data.get('pngB64')
    colormap_xml = data.get('colormapXML')
    visasset_path = os.path.join(settings.MEDIA_ROOT, 'visassets', uuid)

    # Find out if the VisAsset is already state-specific
    with open(os.path.join(visasset_path, VISASSET_JSON)) as fin:
        artifact = json.load(fin)
    
    if not artifact.get('stateSpecific', False):
        return HttpResponse('VisAsset is not state-specific. Please make a copy first.', status_code=400)

    img_bytes = base64.b64decode(png_b64)
    with open(os.path.join(visasset_path, 'thumbnail.png'), 'wb') as fout:
        fout.write(img_bytes)

    with open(os.path.join(visasset_path, 'colormap.xml'), 'w') as fout:
        fout.write(colormap_xml)

    # ReloadVisAsset
    engine_uuid_msg(3, uuid)

    return HttpResponse('Updated VisAsset')

def engine_uuid_msg(msg_type, uuid):
    msgJson = {
        'type': msg_type,
        'message': uuid,
    }
    message = json.dumps(msgJson).encode('utf-8')
    engine.send(message)

