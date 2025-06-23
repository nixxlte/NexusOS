using System;

// This file executes tasks in background while the OS is running.
// Like the name suggests, it was to be more than 1 file, but it was simplified to just one file.
// I think I need to sleep, I made: Dependencies1.sh, PathX/Main.py, and now this.
// I made these 3 files in the same day, in the same night, now... at 00:30 AM

// Code by Byt3z :3

public int Running = 0; // This var lets you close the while loop, closing the terminal and BG processes

public class Class1
{

    public static void subprocess()
    {

        Console.WriteLine("Subprocess started");
        Console.Clear();

        Console.WriteLine("Running processes");

    }

    public static void Main(string[] args)
    {

        Console.WriteLine("Hello, World!");
        Console.WriteLine("OS Started");

        Console.Clear();

        Console.WriteLine("Waiting for any commands...");

        Running = 1; // Set the running variable to 1, so the while loop can start

        while (Running == 1)
        {

            Console.Write("> ");
            string input = Console.ReadLine();
            if (input == null)
                continue;

            if (input.Trim().Equals("sub", StringComparison.OrdinalIgnoreCase))
            {

                Console.WriteLine("Initializing Subprocess...");
                subprocess();

            }
            else if (input.Trim().Equals("exit", StringComparison.OrdinalIgnoreCase))
            {

                Console.WriteLine("Exiting Terminal");
                Running = 0; // Set the running variable to 0, so the while loop can stop, and close the shell
                continue;
                // This thing is not working, I need to fix it later
                // But you can close the shell just... closing the windows, I think you aren't dumb

            }
            else
            {

                Console.WriteLine($"Unknown command: {input}");

            }
        }

    }

}

// Byt3z of next day: I had to rewrite all this CRAP cause I can't start the file without a visual studio solution
// I must have been drunk on coffee yesterday not to have noticed this
// Wait... I don't drink coffee, ok, nevermind