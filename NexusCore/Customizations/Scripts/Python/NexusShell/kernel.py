import os
import sys

def CloseW():
    pass

def FileList():
    if sys.platform.startswith('win'):
        path = 'c:\\'
    else:
        path = '/home'
    try:
        files = os.listdir(path)
        for f in files:
            print(f)
    except Exception as e:
        print(f"Error listing files in {path}: {e}")