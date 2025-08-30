#!/bin/bash/

# this is almost "dependencies2.sh" but it dont just install some dependencies, this script turns ubuntu into NexusOS
# this script is supposed to be used into cubic

# Code by Byt3z :3

sudo apt update && sudo apt upgrade

echo installing dependencies...
./dependencies1.sh

sudo nala install fastfetch

echo sucess

echo applying changes...

sudo apt-get remove ubuntu-desktop
cd /.NexusCore/nexusos/Plymouth
mv spinner /usr/share/plymouth/themes -y

fastfetch --logo tiny