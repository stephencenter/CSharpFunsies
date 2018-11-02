using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance {

    class Program {
        static Dictionary<string, Dictionary<string, int>> user_list = new Dictionary<string, Dictionary<string, int>>();

        static void Main(string[] args) {
            while (true) {
                Console.WriteLine("-----------");
                Console.WriteLine("Welcome to Komodo Car Insurance!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[R]egister");
                Console.WriteLine("[U]pdate Information");
                Console.WriteLine("[C]alculate Premium");
                Console.WriteLine("[E]xit");
                Console.WriteLine("-----------");

                while (true) {
                    Console.WriteLine("Pick an option by typing the letter in brackets");
                    string chosen = Console.ReadLine().ToLower();

                    if (chosen.StartsWith("r")) {
                        Register();
                        break;

                    }

                    if (chosen.StartsWith("u")) {
                        Update();
                        break;

                    }

                    if (chosen.StartsWith("c")) {
                        CalculatePremium();
                        break;

                    }

                    if (chosen.StartsWith("e")) {
                        System.Environment.Exit(1);

                    }
       
                }

            }

        }

        static void Register() {
            string name;

            Console.WriteLine("-----------");
            Console.WriteLine("Okay, let's you registered!");
            Console.WriteLine();

            while (true) {
                Console.WriteLine("What is your name?");
                 name = Console.ReadLine();

                if (user_list.ContainsKey(name)) {
                    Console.WriteLine("A user with that name is already registered, please use a different one!");

                }

                else {
                    user_list.Add(name, new Dictionary<string, int>());
                    Console.WriteLine();
                    break;

                }

            }
            
            Console.WriteLine("How old is your car?");
            int age = int.Parse(Console.ReadLine());
            user_list[name].Add("age", age);
            Console.WriteLine();

            Console.WriteLine("How many miles does your car have?.");
            int miles = int.Parse(Console.ReadLine());
            user_list[name].Add("miles", miles);
            Console.WriteLine();

            Console.WriteLine("How many accidents have you had in the last year?");
            int accidents = int.Parse(Console.ReadLine());
            user_list[name].Add("accidents", accidents);
            Console.WriteLine();

            Console.WriteLine($"Thank you {name}, you are now registered!");
            Console.ReadLine();

        }

        static void Update() {
            Console.WriteLine("-----------");
            Console.WriteLine("List of registered users: ");
            user_list.ToList().ForEach(x => Console.WriteLine(" " + x.Key));
            Console.WriteLine();

            string name;

            while (true) {
                Console.WriteLine("Type in a name or type \"b\" to go back.");
                name = Console.ReadLine();

                if (name.ToLower().StartsWith("b")) {
                    return;

                }

                else if (user_list.ContainsKey(name)) {
                    break;

                }

                else {
                    Console.WriteLine("That name does not match a registered user.");

                }

            }

            Console.WriteLine("-----------");
            Console.WriteLine("List of variables: ");
            user_list[name].ToList().ForEach(x => Console.WriteLine(" " + x.Key));
            Console.WriteLine();

            string variable;

            while (true) {
                Console.WriteLine("Type in the variable you want to modify or type \"b\" to go back.");
                variable = Console.ReadLine();

                if (name.ToLower().StartsWith("b")) {
                    return;

                }

                else if (user_list[name].ContainsKey(variable)) {
                    break;

                }

                else {
                    Console.WriteLine("That does not match a variable name.");

                }

            }

            Console.WriteLine("-----------");
            Console.WriteLine($"Modifying {variable}");
            Console.WriteLine("Current Value:");
            Console.WriteLine(user_list[name][variable]);
            Console.WriteLine("New Value:");
            user_list[name][variable] = int.Parse(Console.ReadLine());

            Console.WriteLine($"The value of {variable} has been updated!");
            Console.ReadLine();

        }

        static void CalculatePremium() {
            Console.WriteLine("-----------");
            Console.WriteLine("We offer three insurance rates based on the age of your car.");
            Console.WriteLine();
            Console.WriteLine("Age of Car | Rate");
            Console.WriteLine("-----------|-----------");
            Console.WriteLine("<5 Years   | $75/Month");
            Console.WriteLine("5-15 Years | $100/Month");
            Console.WriteLine(">15 Years  | $150/Month");
            Console.WriteLine();
            Console.WriteLine("There's an additional $25 fee if your car has over 50,000 miles.");
            Console.WriteLine("There's an additional $50 fee if your car has over 100,000 miles.");
            Console.WriteLine("There's an additional $25 fee if you've had an accident in the last year.");
            Console.WriteLine("-----------");

            Console.WriteLine("List of registered users: ");
            user_list.ToList().ForEach(x => Console.WriteLine(" " + x.Key));
            Console.WriteLine("-----------");

            string name;
            int charge;


            while (true) {
                Console.WriteLine("Type in a name or type \"b\" to go back.");
                name = Console.ReadLine();
                
                if (name.ToLower().StartsWith("b")) {
                    return;

                }

                else if (user_list.ContainsKey(name)) {
                    break;

                }

                else {
                    Console.WriteLine("That name does not match a registered user.");

                }

            }


            // Calculate age premium
            if (user_list[name]["age"] < 5) {
                charge = 75;

            }

            else if (user_list[name]["age"] > 15) {
                charge = 150;

            }

            else {
                charge = 100;

            }

            // Calculate miles premium
            if (user_list[name]["miles"] > 100000) {
                charge += 50;

            }

            else if (user_list[name]["miles"] > 50000) {
                charge += 25;

            }

            // Calculate accidents premium
            if (user_list[name]["accidents"] > 0) {
                charge += 25;

            }

            Console.WriteLine();
            Console.WriteLine($"Thanks {name}, your premium is ${charge}.");
            Console.ReadLine();


        }

    }

}
