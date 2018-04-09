using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Account
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        // public int AccountNumber { get; set; }
        // public DateTime OpenDate { get; set; }

        public Account()
        {
            Name = "";
            Amount = 0;
        }
    }

    
    // Constructors
    //public newAccount(DateTime openDate, string name)
    //{
    //    OpenDate = openDate;
    //    // calculate age
    //    Name = name;
    //    Console.WriteLine("A new account was constructed");
    //}
}
