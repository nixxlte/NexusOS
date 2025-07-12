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