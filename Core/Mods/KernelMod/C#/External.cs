using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KernelM
{
    internal class External {
        public static void reset(string arg) {
            if (arg == "commands") {
                Program.cmd = "null";
                Program.Update();
            }
        }

        public static void logging(string arg) {
            if (arg != "REBOOTING") {
                Console.Write("LOG: " + arg + "\n");
            } else if (arg == "REBOOTING") {
                Console.Write("REBOOTING: kernel panic");
            } else if (arg == "") {
                Console.Write("LOG: unknown");
            }
        }
    }
}
