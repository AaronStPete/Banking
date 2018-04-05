using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Loading Usertable into application
            var usertable = new Dictionary<string, string>();
            const string USER_PATH = "../../../usertable.csv";
            using (var reader = new StreamReader(USER_PATH))
            {
                while (reader.Peek() < -1)
                {
                    var Line = reader.ReadLine().Split(',');
                    usertable.Add(Line[0], Line[1]);
                }
            }

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
                        ///TODO: save to usertable
                        ///
                        using (var writer = new StreamWriter(USER_PATH))
                        {
                            usertable.Add(user.Name, user.Password);
                            foreach (var Person in usertable)
                            {
                                writer.WriteLine($"{user.Name},{user.Password}");
                            }
                        }

                        completedLogin = true;
                    }
                }
            }
        }
    }
}
