#!/bin/bash

# This script don't have ANY verifications, 'cause i'm lazy
# So you can run it on any debian-based distro, or any distro with APT/Nala

# I made this thing to use into cubic, so it don't appears on installed system, only on chroot
# (In this case, cubic)

# Code by Byt3z :3

echo resolving dependencies for PathX, Python, Electron and NexusCore

# Install PathX dependencies
sudo apt update && sudo apt upgrade -y
sudo apt install python3 python3-pip python3-venv python3-dev build-essential libssl-dev libffi-dev python3-setuptools git curl wget -y

# Install NexusCore dependencies
sudo apt update
sudo apt install gnome-session gnome-shell gnome-tweaks python3 python3-tkinter python3-qt
sudo apt install nala
sudo apt install --fix-missing
echo "alias apt='nala'" >> ~/.bashrc && source ~/.bashrc
sudo apt install neofetch
sudo apt auto-remove

# Set System packages (this is helpfull only in the chroot, but no in the system
# Maybe I'll make a .sh that removes those files)
sudo su
cd /
mkdir .NexusCore
cd .NexusCore
git clone https://github.com/oByteszOficial/NexusOS.git
mkdir /usr/share/Electron
cd /usr/share/Electron
git clone https://github.com/electron/electron
npm start
cd /.NexusCore/NexusOS/
npm start

# Install File Manager
sudo apt install nemo
xdg-mime default nemo.desktop inode/directory
xdg-mime default nemo.desktop application/x-gnome-saved-search
gsettings set org.gnome.desktop.background show-desktop-icons false

# Version list #I'm doing this just to see if the packages works correctly

neofetch
python3 --version
nemo --version
nala --version
git --version

# This thing works on chroot and on the system, probably...