using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KernelM
{
    internal class External
    {

        public static void reset(string arg)
        {

            if (arg == "commands")
            {

                Program.cmd = "null";
                Program.ConsoleCommands();

            }

        }

    }
}
