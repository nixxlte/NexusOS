#include <iostream>
#include "Modules.h"

// I think CPP is harder than C# but I need to use it to make my Kernel integrated with linux's kernel

const std::string logPrefix = "auto log: ";

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

void ASCII(int arg) {

	if (arg == 1) 
	{
	
		printf("sorry, but ASCII module doesn't have any function\n");

	}
	else if (arg == 2) 
	{

		printf("ASCII module from file '/usr/share/KernelM/KernelMod/Modules.h' loaded sucessfully\n");

	}
	else if (arg == 3) 
	{

		printf("ASCII module from file '/usr/share/KernelM/KernelMod/Modules.h' closed sucessfully\n");

	}
	else if (arg == 4)
	{

		std::cout << "_______________________________" << std::endl;

	}
	else if (arg == 5)
	{

		std::cout << "|";

	}
	else if (arg == 20)
	{

		std::cout << "ASCII beta 2 :: for testing purposes only" << std::endl;

	}
	else 
	{

		print("unknown argument for ASCII module\n");

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

int log(const std::string& arg)
{


	if (arg.empty())
	{

		std::cout << logPrefix << "no argument provided\n";

	}
	else if (arg == "exit")
	{

		std::cout << logPrefix << "fatal error, system exiting\n";

	}
	else if (arg == "compilation")
	{

		std::cout << logPrefix << "compilation error, maybe Byt3z's error for this build, sorry\n";

	}
	else if (arg == "debug")
	{

		std::cout << logPrefix << "debugging code, reason: code request\n";
		
	}

	return 0; // return 0 to indicate success, or any other value to indicate an error

}