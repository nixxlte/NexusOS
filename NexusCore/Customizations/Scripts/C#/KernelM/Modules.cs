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

        }

        public static void close(string mod)
        {
            if (mod == "Display")
            {
                Console.WriteLine("Display module closed successfully!");
            }
        }

        public static void Display(int call)
        {

            if (call == 1) // Runs the module
            {

                Console.WriteLine("> ");

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

        }

    }
}
