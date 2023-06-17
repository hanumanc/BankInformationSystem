using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankDemoApp.Customer
{
    public class AccountHolder
    {
        static int accountCount;
        static  AccountHolder()
        {
            accountCount = 1000;
        }

        public string SName { get; set; }
        public int IAccountNumber { get; set; }       
        public double AccountBalance { get; private set; }

        //parametrized constructor
        public AccountHolder( string Name)
        {
            this.SName = Name;
            IAccountNumber = accountCount++;
        }


       

    }
}
