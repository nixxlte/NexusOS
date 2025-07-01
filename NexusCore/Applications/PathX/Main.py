# This is an PROTOTYPE
# I need to test the UI and the logic, probably it will be rewritten
# And maybe I`ll just compile to a x86_64 binary, to run on NexusOS (with py2exe
# or something similar that compiles to linux)
# This is exclusively for NexusOS, so it will not run on other systems, not YET
# Thats it, I guess

# Code by Byt3z :3 (and cofee)

import os
import tkinter as tk
from tkinter import NS, filedialog, messagebox

class FileManager(tk.Tk):
    def __init__(self):

        super().__init__()
        self.title("PathX B2")
        self.geometry("800x600") # I think any monitor can run this size, if your monitor is smaller...
                                 # Buy a new one, or use the terminal version :3
                                 # The terminal version is made in CPP, so its faster :3

        # Path label
        self.path_label = tk.Label(self, text="", anchor="w")
        self.path_label.grid(row=0, column=2)

        # Control buttons
        top_frame = tk.Frame(self)
        top_frame.grid(row=0, column=0, sticky="we")

        self.up_button = tk.Button(top_frame, text="↑", command=self.go_up)
        self.up_button.grid(row=0, column=0, padx=3, pady=5)

        self.choose_button = tk.Button(top_frame, text="📁", command=self.choose_folder)
        self.choose_button.grid(row=0, column=1, padx=3, pady=5)

        # File List
        self.listbox = tk.Listbox(self)
        self.listbox.grid(row=1, column=0, sticky="ns") # This crap don't fills the left side >:[
        self.listbox.bind("<Double-1>", self.open_item)

        # Personal folder
        self.current_path = os.path.expanduser("~")
        self.load_directory()

    def load_directory(self):

        self.listbox.delete(0, tk.END)
        self.path_label.config(text=self.current_path)
        try:
            for item in os.listdir(self.current_path):
                self.listbox.insert(tk.END, item)
        except PermissionError:
            messagebox.showwarning("Error", "Wrong permissions to open this folder. Maybe a system folder?")

    def go_up(self):

        self.current_path = os.path.dirname(self.current_path)
        self.load_directory()

    def choose_folder(self):

        folder = filedialog.askdirectory(initialdir=self.current_path)
        if folder:
            self.current_path = folder
            self.load_directory()

    def open_item(self, event):

        selection = self.listbox.curselection()
        if selection:
            selected = self.listbox.get(selection[0])
            path = os.path.join(self.current_path, selected)
            if os.path.isdir(path):
                self.current_path = path
                self.load_directory()

if __name__ == "__main__":
    app = FileManager()
    app.mainloop()