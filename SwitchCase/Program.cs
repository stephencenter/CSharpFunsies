using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase {

    class Program {

        static void Main(string[] args) {
            Console.WriteLine("How are you feeling on a scale of 1-5?");
            string feeling = Console.ReadLine();
            int input = int.Parse(feeling);

            switch (input) {
                case 1:
                    Console.WriteLine("That's bad.");
                    break;

                case 2:
                    Console.WriteLine("That's not good.");
                    break;

                case 3:
                    Console.WriteLine("That's okay.");
                    break;

                case 4:
                    Console.WriteLine("That's good.");
                    break;

                case 5:
                    Console.WriteLine("That's great!");
                    break;

                default:
                    Console.WriteLine("Keep your stupid comments in your pocket.");
                    break;

            }

            if (input == 1) {
                Console.WriteLine("That's bad.");

            }

            else if (input == 2) {
                Console.WriteLine("That's not good.");

            }

            else if (input == 3) {
                Console.WriteLine("That's okay.");

            }

            else if (input == 4) {
                Console.WriteLine("That's good.");

            }

            else if (input == 5) {
                Console.WriteLine("That's great!");

            }

            else {
                Console.WriteLine("Keep your stupid comments in your pocket.");

            }
            

        }

    }

}
