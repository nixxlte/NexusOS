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



}

void cmdCheck()
{
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