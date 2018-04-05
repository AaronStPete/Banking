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
                Console.ReadLine().ToLower();

                /// prompt for password
                Console.WriteLine("Please enter your password");
                Console.ReadLine();

            }
            else if (input == "new")
            {
                var completedLogin = false;
                while (completedLogin == false)
                {
                    /// generate user

                    /// prompt for name
                    Console.WriteLine("Please enter the name you will login with.");
                    /// store name
                    var nameInput = Console.ReadLine().ToLower();

                    /// prompt for password
                    Console.WriteLine("Please enter the password you will login with.");
                    /// store password
                    var passInput = Console.ReadLine();

                    var user = new User(nameInput, passInput);

                    Console.WriteLine($"{user.Name} and {user.Password} are correct? (yes) or (no)");
                    var confirmation = Console.ReadLine().ToLower();

                    if (confirmation == "yes" || confirmation == "y")
                    {
                        ///save to usertable
                        completedLogin = true;
                    }
                }
            }
        }
    }
}
