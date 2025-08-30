# idk what to say here
# just... this code has been weiten in a paper, when i'm at school
# ppls asked to me what the heck is this lines of "strange language"

# Code by Byt3z :3
import sys
import kernel
import nexusos as nexus

arg = "invalid"

if len(sys.argv) > 1:
    arg = sys.argv[1]
else:
    arg = "close" # I think that this will not be used, but if anyone wants to change something in the system
                  # And broke the kernel, this can be used to not execute any command

def main(s):
    if s == "close":
        kernel.CloseW()
    elif s == "hls": # Command: python /home/NexusCore/Kernel/Python/main.py hls don't worry, Ill make a alias for this command
                     # you'll just need to type "hls" in the terminal
        kernel.FileList()
    else:
        print("Invalid kernel command")

if __name__ == "__main__":
    main(arg)