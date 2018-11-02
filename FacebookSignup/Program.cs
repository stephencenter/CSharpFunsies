using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookSignup {

    class Program {

        static void Main(string[] args) {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is your email address?");
            string email = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is your physical address?");
            string address = Console.ReadLine();
            Console.WriteLine();


            Console.WriteLine("What is your Driver's License number?");
            string dln = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is your Social Security Number?");
            string ssn = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is your credit card number, including experation date and security code?");
            string credit_card = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("DLN: " + dln);
            Console.WriteLine("SSN: " + ssn);
            Console.WriteLine("Credit Card: " + credit_card);
            Console.WriteLine();
            Console.WriteLine("Assassins have been dispatched to your house,");
            Console.WriteLine("you will be replaced by a replicant within 10 minutes.");
            Console.WriteLine("Thank you for joining Facebook!");
            Console.ReadLine();

        }

    }

}
