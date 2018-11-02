using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Practice {

    class Program {

        static void Main(string[] args) {
            string response = "n";

            while (response != "y") {
                Console.WriteLine("What's your name?");
                string name = Console.ReadLine();
                Console.WriteLine($"Hello {name}!");

                Console.WriteLine("Do you want to keep your name? | Y/N");
                response = Console.ReadLine();

            }

        }

    }

}
