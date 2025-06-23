# Ahh... nothing to say here, just a "terminal" for the NexusCore

# Code by Byt3z :3 (no coffee this time, is 12pm)

import os
import sys
import subprocess
import time

Running = False

def Clear():

    print(" \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n ")
    print(" \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n ")

    print(" \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n ")
    print(" \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n ")

    # Yes... this is a "clear" function, but it is not really clear, just prints a lot of new lines

def Shell():

    Clear()

    Running = True

    while Running == True:
        cmd = input("> ")

        if cmd == "help":

            print("Available commands:") # Nothing yet LMAO

        elif cmd == "exit":

            print("Exiting shell...")
            Running = False

        else:

            print("Unknown command:", cmd)

def Main():

    print ("Hello, World!")
    print ("Loading Shell...")
    time.sleep(1)
    Shell()