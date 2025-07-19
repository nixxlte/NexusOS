# I think this is a architecture module, and... yes, isn't in C#
# I will use Python to write this module
# Probably this module won't be integrated in C#, cause... its another language

# Im making this module while play Animal Crossing Wild World
# I'm addicted to this game

# Code by Byt3z :3

import os
import platform
import subprocess
import sys
from tkinter import *
import tkinter as tk

def Garquiteture():
    arch = platform.architecture()[0] # I dont even know what is this, but it works :D
    if arch == '64bit':
        print("returned x64")
    elif arch == '32bit':
        print("returned x86")
    else:
        print("error returning architecture")

def MGRarch():

    AARCHTXT = tk.Label(text="Architecture: " + platform.architecture()[0]) # I love the fate that
    # Python is million times easier than C#, i made 51 lines in 5 minutes
    # In C# i would take 1 hour to do this
    AARCHTXT.pack(pady=5)

def GUI():

    root = tk.Tk()
    root.title("NexusOS architecture manager")
    root.geometry("300x100")

    label = tk.Label(root, text="NexusCore Architecture Checker")
    label.pack(pady=10)

    MNGRAARCH = tk.Button(root, text="Manage Arch", command=MGRarch)
    MNGRAARCH.pack(pady=5)

    EXTMGR = tk.Button(root, text="Exit", command=root.quit)
    EXTMGR.pack(pady=5)

    root.mainloop()

def Main():

    Garquiteture()
    GUI()
    print("NexusCore Architecture Manager is not running...")

Main()