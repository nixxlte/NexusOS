# This is an PROTOTYPE
# I need to test the UI and the logic, probably it will be rewritten
# And maybe I`ll just compile to a x86_64 binary, to run on NexusOS (with py2exe
# or something similar that compiles to linux)
# This is exclusively for NexusOS, so it will not run on other systems, not YET
# Thats it, I guess

# Code by Byt3z :3 (and cofee)

import sys
import os
from tkinter import Tk, Frame, Button, Label, Entry, Text, Scrollbar, messagebox
from tkinter import ttk
import subprocess
#import pyqt as qt # I have to comment it... I don't have it on my PC lmao

class App:
    def __init__(self, root):
        self.root = root

        self.root.title("PathX B1")
        self.root.geometry("800x600")
        self.root.resizable(True, True)

        # -- Sidebar --

        self.sidebar = Frame(self.root, width=200, bg="#2c3e50")
        self.sidebar.pack(side="left", fill="y")
        self.sidebar.pack_propagate(False)

        # - Content -

        self.separator1 = Frame(self.root, height=2, bg="#34495e")
        self.separator1.pack(side="left", padx=5, pady=5)

        self.separator2 = Frame(self.root, height=2, bg="#34495e")  
        self.separator2.pack(fill="x", padx=5, pady=5)

        # -- End-Sidebar --

        self.root.mainloop() # For now is just this

if __name__ == "__main__": # Thanks for ChatGPT to do this part, I never used a class in Python before
    root = Tk()
    app = App(root)