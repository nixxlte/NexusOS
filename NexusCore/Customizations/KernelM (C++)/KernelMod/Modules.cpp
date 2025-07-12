#include <iostream>
#include "Modules.h"

// I think CPP is harder than C# but I need to use it to make my Kernel integrated with linux's kernel

void Display(int arga, const std::string& argb)
{

	if (arga == 1)
	{

		printf(argb, "\n"); // prints the arg and auto breaks the line

	}
	else if (arga == 2)
	{

		printf("Display module from file '/usr/share/KernelM/KernelMod/Modules.h' loaded sucessfully\n");

	}
	else if (arga == 3)
	{

		printf("Display module from file '/usr/share/KernelM/KernelMod/Modules.h' closed sucessfully\n");

	}

}

void logging(const std::string& arg)
{

	printf("LOG: ", arg "\n");

}

void Linux(int arg)
{

	if (arg == 1)
	{

		logging("this module hasn't a code function"); // I hope you already know :p

	}
	else if (arg == 2)
	{

		printf("Linux Kernel has already loaded.");

	}

}

void cmds(int arg)
{

	if (arg == 1)
	{

		printf("> ");

	}
	else if (arg == 2)
	{

		printf("CMDS module from file '/usr/share/KernelM/KernelMod/Modules.h' loaded sucessfully\n");

	}
	else if (arg == 3)
	{

		printf("CMDS module from file '/usr/share/KernelM/KernelMod/Modules.h' closed sucessfully\n");

	}
	else
	{

		logging("invalid command selected");

	}

}