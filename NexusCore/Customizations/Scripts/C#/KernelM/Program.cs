using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

// This is not a "kernel", is just a kernel-like structure for organizing code.
// I call this a "kernel mod", like the name "KernelM" suggests.
// I probably will spend some time in this code... cause is a... kernel, kernels are fun, right?
// Linus Torvalds don't make the Linux in just a day, he spent years on it.
// I probably will spend just... 11 months, cause i'm using the Linux kernel as a base.
// d'you want a coffee to watch me code this?
// I'm madding this code while fix an Galaxy J5 :D

namespace KernelM
{

    // Code by Byt3z :3

    internal class Program
    {

        public static string cmd = ""; // This is just a variable to store the command, I will use it later
        public static string process = ""; // This is just a variable to store the current process, I will use it later
        public static string ocmd = ""; // This is just a variable to store the old command, I will use it later

        public static void Main(string[] args) // I cant count how many times I wrote "cublic" by error
        {
            Console.WriteLine("Finishing boot NexuOS...\n");
            System.Threading.Thread.Sleep(1000); // Wait for 1 second (1000 milliseconds), I did this cause
                                                 // Startup() clears the console, so you can't see the message
            Startup();
        }
        
        public static void Startup()
        {

            cmd = "null"; // Initialize the command variable to null, so it can be read later
            Console.Clear(); // Theres what I said, clears the console
            Console.WriteLine("Hello, World\n");
            Console.WriteLine("Booting up KernelMod...\n");
            Console.WriteLine("Call function KernelStart() from file /mnt/KernelMod/Program.cs\n");
            KernelStart(); // Call the KernelStart function, this is the main function of the kernel mod
            Console.WriteLine("Call function Start() from Display() on file /mnt/KernelMod/Modules.cs\n");
            Modules.Display(2); // Call the Display function from the Modules class, this is just a test to see if the modules work
            process = process + "Display\n"; // Add the Display process to the current process, cause... its running, no?
            Console.WriteLine("Call function KernelUpdate() from file /mnt/KernelMod/Program.cs at 60tps\n");
            Console.Clear(); // Clears the console again, cause we don't need to see the startup message anymore
            //Modules.Render(2); // Call the Render function from the Modules class
            process = process + "Render\n"; // Add the Render process to the current process, cause... its running, no? i don't will justificate this every time
            while (true) // Runs the KernelUpdate function at 60 ticks per second
            {

                KernelUpdate();
                System.Threading.Thread.Sleep(16); // Sleep for 16 milliseconds, this is 60 ticks per second

            }

        }

        public static void KernelStart()
        {

            Console.WriteLine("KernelMod started successfully!\n");
            Console.Clear(); // Clears the console again, just... cause yes :D

        }

        public static void KernelUpdate()
        {

            // Console.WriteLine("KernelMod is running..."); // This is just a SUCESSFULLY test,
            // the kernel mod is running properly

            // This will verify the command you will enter, and show a "> " prompt
            Modules.Display(4); // Print "> " and read the command from the console
            ConsoleCommands(); // Call the verification of the entered command

        }

        public static void KernelProcess()
        {

            // This is just a function to show the current kernel process, it can be executed by running "kprocess"
            Console.Write("\n");
            Console.Write("Current running process on kernel: \n");
            Console.WriteLine(process + "\n"); // Yes... just 2 lines of code, its not too much, but it works :D

        }

        public static void ConsoleCommands()
        {

            if (cmd == null)
            {

                ocmd = cmd; // Save the old command to the ocmd variable
                Console.Write("\n");
                Console.Write("You entered an empty command, please enter a valid command.\n");
                External.reset("commands"); // Reset the command to null, so it can be read again

            }
            else if (cmd == "help")
            {

                ocmd = cmd;

                Console.Write("\n");
                Console.Write("Avaiable commands:\n");

                Console.Write("help - Show this help message\n");
                Console.Write("kprocess - Show the current kernel process\n");
                Console.Write("clr - Clears the console");
                External.reset("commands");

            }
            else if (cmd == "kprocess")
            {

                ocmd = cmd;
                Console.Write("Booting KernelProcess...\n");
                Console.Clear(); // Clears the console, cause we don't need to see the command prompt anymore
                KernelProcess(); // Call the KernelProcess function, this will show the current kernel processes
                External.reset("commands");

            }
            else if (cmd == "clr")
            {

                ocmd = cmd;
                Console.Clear(); // Clears the console, this is just a command to clear the console...
                External.reset("commands"); // Reset the command to null, so it can be read again

            }
            else if (cmd == "Console.Var.Read(cmd)")
            {

                Console.Write(ocmd + " \n"); // Yes... this is the code to read the variable
                ocmd = cmd;
                External.reset("commands");

            }
            else if (cmd == "exit")
            {

                ocmd = cmd;
                Console.Write("If you exit the kernel mod, the kernel will stop and the system will shut down.\n");
                Console.Write("so the command is 'shutdown -s', like in the windows\n");
                External.reset("Commands"); // This thing mades shell enter in a trance, and send infinite commands
                // And im too lazy to fix it

            }
            else if (cmd == "shutdown -s")
            {

                ocmd = cmd;
                Console.Write("Shutting down the system...\n");
                System.Threading.Thread.Sleep(1000); // Wait for 1 second (1000 milliseconds)
                Console.Clear(); // Clears the console, cause we don't need to see the command prompt anymore
                Environment.Exit(0); // Exits the program, this will stop the kernel mod and shut down the system

            }
            else
            {

                ocmd = cmd;
                Console.Write("\n");
                Console.Write("Unknown command: " + cmd + "\n");
                Console.Write("Type 'help' to see the available commands.\n");
                External.reset("commands"); // Reset the command to null, so it can be read again

            }

        }

    }

}
