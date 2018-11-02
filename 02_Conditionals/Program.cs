using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Conditionals {

    class Program {

        static void Main(string[] args) {
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            int real_age = int.Parse(age);

            // Pt 1
            if (real_age < 18) {
                Console.WriteLine("Hey there, kid.");

            }

            else {
                Console.WriteLine("Hey there, peer.");
    
            }

            // Pt 2
            if (real_age == 18) {
                Console.WriteLine("You're 18!");

            }

            else {
                Console.WriteLine("You're not 18!");

            }

            // Pt 3
            if (real_age < 13) {
                Console.WriteLine("You qualify for our children's discount.");

            }

            else if (real_age >= 65) {
                Console.WriteLine("You qualify for our senior discount.");
                

            }

            else {
                Console.WriteLine("You do not qualilfy for an age-related discount.");

            }

            // Pt 4
            if (real_age > 80 || real_age < 8) {
                Console.WriteLine("I'm sorry, people your age cannot ride this rollercoaster.");

            }

            else {
                Console.WriteLine("Feel free to ride our rollercoaster!");
            }
        }

    }

}
