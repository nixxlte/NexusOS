using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KernelM
{
    internal class Modules
    {

        public static void init(string mod)
        {

            if (mod == "Display") 
            {
            
                Console.Write("Loading Display module... ");

            }
            else if (mod == "Render")
            {

                Console.Write("Loading Render module... ");

            }
            else
            {

                Console.Write("Loading UNKNOWN module... ");

            }

        }

        public static void close(string mod)
        {

            if (mod == "Display")
            {

                Console.WriteLine("Display module closed successfully!");

            }
            else if (mod == "Render")
            {

                Console.WriteLine("Render module closed successfully!");

            }
            else
            {

                Console.WriteLine("UNKNOWN module closed successfully!");

            }

        }

        public static void Display(int call)
        {

            if (call == 1) // Runs the module
            {

                Console.Write("> ");

            }
            else if (call == 2) // Initializes the module
            {

                init("Display");
                Console.WriteLine("Display module loaded successfully!\n");

            }
            else if (call == 3) // Stops the module
            {
               
                close("Display");

            }
            else if (call == 4)
            {

                Console.Write("> ");
                Program.cmd = Console.ReadLine();

            }

        }

        public static void Render(int call)
        { 
        
            if (call == 1)
            {

                Program.KernelUpdate();

            }
            else if (call == 2)
            {
                 
                init("Render");

            }
            else if (call == 3)
            {
                close("Render");
            }
            else
            {
                Console.WriteLine("Unknown render call!");
            }

        }

    }
}
