using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops {

    class Program {

        static void Main(string[] args) {
            
            for (string s = ""; s.Length != 20;  s += "s") {
                Console.WriteLine(s);

            }

            string name = "Stephen";

            foreach (char letter in name) {
                Console.WriteLine(letter);

            }

            int total = 1;
            while (total != 5) {
                Console.WriteLine(total);
                total++;

            }

        }

    }

}
