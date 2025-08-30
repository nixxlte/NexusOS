// KernelMod.cpp : This file contains the 'main' function. Program execution begins and ends there.
// I know visual studio, im not dumb

// Yes... im not using C# anymore... idk why, i can program in C#
// I want to make a reference of my dog here, but i dont know how to do it

#include <iostream>
#include <chrono>
#include <thread>
#include <string>
#include "Modules.h"

std::string CMD = "Unchanged";

void start()
{

    ASCII(4);

}

void cmdCheck()
{

    if (CMD == "?" || CMD == "help")
    {

        std::cout << "Avaible commands:" << std::endl;
        printf("? or help - Show this message\n"); // I thing if the people type "help" they already know this command
        printf("std::clear - Clear the console\n"); // Just a C++ command, nothing special
        printf("exit(0) - Exit the kernel\n");
        printf("ASCII(<4-5>) - Print ASCII lines\n"); // Yes, now we have ASCII support >w<

    }
    else if (CMD == "std::clear")
    {

        system("cls"); // Thats very simple, just a convertion from C to C++ (i guess)

    }
    else if (CMD == "exit(0)")
    {

        exit(0); // You literally type a C code to exit, and the code verify it

    }
    else if (CMD == "Unchanged")
    {

        std::cout << "No command" << std::endl; // You are dumb if you did this by error ;-;

    }
    else if (CMD == "ASCII(4)")
    {

        ASCII(20); // A temporary watermark
        ASCII(4);

    }
    else if (CMD == "ASCII(5)")
    {

        ASCII(5);

    }
    else
    {

        std::cout << "Unknown command: " << CMD << std::endl;

    }

}

void update()
{

    cmds(1);
    std::string input;
    std::getline(std::cin, input);
    CMD = input;

	cmdCheck();

}

void boot(int arg)
{

    if (arg == 1) {
        system("cls");
        printf("Loading KernelModules from file /usr/share/KernelM/KernelMod/KernelMod.cpp");
        Display(2, ""); // CPP is very hard, but I think its better than C# for a kernel
        // fun fact: this module called "Display" was debugged while my dog sleeps below my bed
        // (she likes do that, i dont know why
        cmds(2);
        ASCII(2);
        printf("Loading initial functions");
        start();
        printf("Loading continuous functions at 60tps");

        using namespace std::chrono;
        const int target_fps = 60;
        const auto frame_duration = milliseconds(1000 / target_fps);

        while (true)
        {

            auto frame_start = high_resolution_clock::now();

            update();

            auto frame_end = high_resolution_clock::now();
            auto elapsed = duration_cast<milliseconds>(frame_end - frame_start);

            if (elapsed < frame_duration)
            {

                std::this_thread::sleep_for(frame_duration - elapsed);

            }

        }

    }
    else
    {

		printf("Invalid argument for boot function\n");

    }

}

int main()
{

	printf("Hello World!\n");
	printf("Loading Mod...\n");
	boot(1);

}