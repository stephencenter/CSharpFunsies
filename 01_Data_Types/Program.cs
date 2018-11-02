using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Data_Types {

    class Program {

        static void Main(string[] args) {
            bool is_tall = true;
            int age = 23;

            byte low = 0;
            byte high = 255;

            float my_float = 123.32F;
            double my_double = 12000000000000.1234;
            decimal my_decimal = 19.939939939m;

            char my_character = 'a';
            string my_string = "Hello, world!";

            Console.WriteLine(my_string);

            Console.WriteLine("How old are you?");
            string input = Console.ReadLine();

            Console.WriteLine("So, you're " + input + " years old?");

        }

    }

}