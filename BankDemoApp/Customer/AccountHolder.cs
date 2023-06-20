using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankDemoApp.Customer
{
    public class Account
    {
        static int accountCount;
        static  Account()
        {
            accountCount = 1000;
        }

        public string SName { get; set; }
        public int IAccountNumber { get; set; }       
        public double AccountBalance { get; private set; }
        public AccountType accType { get; set; }

                
        //parametrized constructor
        public Account( string Name, int iType, double openingBal)
        {
            this.SName = Name;
            this.accType = (AccountType)iType-1;
            this.AccountBalance = AccountBalance + openingBal;
            IAccountNumber = accountCount++;
        }       

    }

    public enum AccountType
    {
        SavingsAccount, //0
        CurrentAccount, //1
        LoanAccount, //2
        NRIAccount, //3
    }

    public enum Week
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }



}
