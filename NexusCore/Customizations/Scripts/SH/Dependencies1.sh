#!/bin/bash

# This script don't have ANY verifications, 'cause i'm lazy
# So you can run it on any debian-based distro, or any distro with APT/Nala

# I made this thing to use into cubic, so it don't appears on installed system, only on chroot
# (In this case, cubic)

# A message to the human being who said that this OS is just a skin for Ubuntu: you suck-
# Just kidding, but it is'nt just a skin, at the point that I COMPILE the kernel and boot it on a real PC
# This "skin" became a full OS, that I compiled, and I made the utilities like PathX
# I really put effort into making NexusOS and I hope you enjoy it, or destroy, you decide

# Code by Byt3z :3 (rage and coffee helped too)

echo resolving dependencies to PathX, Python, Electron and NexusCore

# Install PathX dependencies
sudo apt update && sudo apt upgrade -y
sudo apt install python3 python3-pip python3-venv python3-dev build-essential libssl-dev libffi-dev python3-setuptools git curl wget -y

# Install NexusCore dependencies
sudo apt update
sudo apt install gnome-session gnome-shell gnome-tweaks python3 python3-tkinter python3-qt
sudo apt install nala
sudo apt install python3-gi gir1.2-gtk-3.0
sudo apt install --fix-missing
echo "alias apt='nala'" >> ~/.bashrc && source ~/.bashrc
sudo apt install neofetch
sudo apt remove snapd --purge -y
sudo apt remove Ubuntu-desktop --purge -y
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
cd /.NexusCore/nexusos/
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

# I reached the end of this script, so I can say that I did it
# My sanity scream for help now, but I don't care
# I don't want to sleep now