using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public Account Checking { get; set; }
        public Account Savings { get; set; }

        public User (string name, string password, Account Checking, Account Savings)
        {
            this.Name = name;
            this.Password = password;
            this.Checking = Checking;
            this.Savings = Savings;
            
        }

        public User (string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }
    }
}