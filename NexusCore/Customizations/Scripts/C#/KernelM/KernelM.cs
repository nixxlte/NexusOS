using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KernelM
{

    // WAIT, the Program.cs is not the KernelM???
    // I explain, the Program.cs begans just a... Shell, that script has too many VISUAL and USER stuff,
    // This script will be the KernelM, from now, the commit that ill do 19/07/2025
    // AND for now the Program.cs will be the BootPoint for KernelM, but probably him can be closed and dont affect the real KernelM

    // Dude... why is Animal Crossing Wild World so good?
    // Maybe I'm just addicted to it :3

    internal class KernelM
    {

        public static void Boot()
        {

            Console.Write("Booting MainKernelM...\n");
            Kstart();

        }

        public static void LoadModules()
        {

            Modules.ASCII(2);
            Modules.Render(2);

        }

        public static void Kstart()
        {

            // im madding this part of the code using my phone as a monitor, is a bit weird but works
            // and don't has a big delay, so is fine :3
            Console.WriteLine("KernelM started successfully!");
            Console.Write("Started Kstart main function\n");

        }

        public static void TerminaRun() // It's just a cute name for "show this thing after the Terminal start"
        {

            Console.Write("Hello, World\n");
            Console.Write("Code written by Byt3z under a month\n");
            Console.Write("Licence: GNU GPLv3\n");
            Console.WriteLine(" ");

        }

        public static void Kupdate()
        {

            

        }

    }

}
