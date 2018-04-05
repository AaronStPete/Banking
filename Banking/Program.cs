using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Banking.");
            Console.WriteLine("Would you like to (login) or create a (new) account?");
            string input = Console.ReadLine();

            if (input == "login")
            {
                /// prompt for name
                Console.WriteLine("Please login with your name:");
                Console.ReadLine();

                /// prompt for password
                Console.WriteLine("Please enter your password");
                Console.ReadLine();

            }
            else if (input == "new")
            {
                /// generate user

                /// prompt for name
                Console.WriteLine("");
                /// store name
                Console.ReadLine();


                /// prompt for password
                Console.WriteLine("");
                /// store password
                Console.ReadLine();

            }
        }
    }
}
