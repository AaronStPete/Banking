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
        public Account Accounts { get; set; }
    }
}
