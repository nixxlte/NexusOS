using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KernelM {
    internal class Modules {

        public static void init(string mod) {
            if (mod == "Display")  {
                Console.Write("Loading Display module... \n");
            } else if (mod == "Render") {
                Console.Write("Loading Render module... \n");
            } else if (mod == "ASCII") {
                Console.Write("Loading ASCII module... \n");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
            } else {
                Console.Write("Loading UNKNOWN module... \n");
            }

        }

        public static void close(string mod) {
            if (mod == "Display") {
                Console.WriteLine("Display module closed successfully!");
            } else if (mod == "Render") {
                Console.WriteLine("Render module closed successfully!");
            } else {
                Console.WriteLine("UNKNOWN module closed successfully!");
            }
        }

        public static void Display(int call) {
            if (call == 1) { // Runs the module
                Console.Write("> ");
            } else if (call == 2) { // Initializes the module
                init("Display");
                Console.WriteLine("Display module loaded successfully!\n");
            } else if (call == 3) { // Stops the module
                close("Display");
            }
            else if (call == 4) {
                Console.Write("> ");
                Program.cmd = Console.ReadLine();
            }
        }

        public static void ASCII(int call) {
            if (call == 1) {
                External.logging("ASCII module called, but it don't has any call function");
            } else if (call == 2) {
                init("ASCII");
            } else if (call == 3) {
                close("ASCII");
            } else {
                Console.WriteLine("Unknown ASCII call!");
            }
        }

        public static void Render(int call) { 
            if (call == 1) {
                Program.Update();
            } else if (call == 2) {        
                init("Render");
            } else if (call == 3) {
                close("Render");
            } else {
                Console.WriteLine("Unknown render call!");
            }
        }
    }
}
