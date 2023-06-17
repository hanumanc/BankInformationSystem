using BankDemoApp.Customer;
using BankDemoApp.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BankDemoApp
{
    public  class Program
    {
     
        static void Main(string[] args)
        {

            bool exit = false;
            BankOperations.LoadData();
            while (!exit)
            {
                BankOperations.DisplayMenu();

                // Accept user input
                Console.Write("Enter your choice: ");
                string userInput = Console.ReadLine();

                // Process user input
                switch (userInput)
                {
                    case "1":
                        // Console.WriteLine("You chose option 1.");
                        BankOperations.CreateAccount();
                        break;
                    case "2":
                        BankOperations.SaveData();
                        break;
                    case "3":
                        BankOperations.SubMenu();
                        break;
                    case "4":
                        Console.Clear();
                        break;
                    case "5":
                        BankOperations.PrintAccountInformation();

                        break;
                    case "6":
                        BankOperations.PrintAllAccounts();

                        break;
                    case "7":
                        Console.WriteLine("Exiting the program...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
    public class BankOperations
    {
        static List<AccountHolder> lAccounts = new List<AccountHolder>();

        public static void LoadData()
        {
            lAccounts= IOAction.LoadDataFromFile();
        }
        public static void SaveData()
        {
            IOAction.SaveAccountsFile(lAccounts);
        }
        public static void CreateAccount()
        {
            string name = null;
            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine();

            var account = new AccountHolder(name);
            lAccounts.Add(account);

        }

        public static void PrintAccountInformation()
        {
            //Only print the selected account 
            Console.WriteLine(" ");
            Console.WriteLine("\t\t\t  --------- Bank Information System --------");
            Console.WriteLine("\t\t\t  ------------------------------------------");
            Console.WriteLine(" ");

            int accountNumber = 0;
            Console.Write("Enter Account #: ");
            accountNumber = Convert.ToInt32(Console.ReadLine());

            var filteredAccount = lAccounts.Where(i => i.IAccountNumber == accountNumber).Single();

            Console.WriteLine(" ");
            Console.WriteLine("Account # : " + filteredAccount.IAccountNumber);
            Console.WriteLine("Account Name : " + filteredAccount.SName);
        }

        public static void PrintAllAccounts()
        {
            Console.WriteLine(" ");
            Console.WriteLine("\t\t\t  --------- Bank Information System --------");
            Console.WriteLine("\t\t\t  ------------------------------------------");
            Console.WriteLine(" ");

            foreach (var item in lAccounts)
            {
                Console.WriteLine("Account # : " + item.IAccountNumber);
                Console.WriteLine("Account Name : " + item.SName);
                Console.WriteLine(" ");

            }
        }

        public static void DisplayMenu()
        {
            Console.WriteLine(" ");
            Console.WriteLine("\t\t\t  --------- Bank Information System --------");
            Console.WriteLine("\t\t\t  ------------------------------------------");
            Console.WriteLine(" ");

            Console.WriteLine("Main Menu");
            Console.WriteLine("---------");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Save Data");
            Console.WriteLine("3. Sub Menu");
            Console.WriteLine("4. Clear Console");
            Console.WriteLine("5. Print Account Data");
            Console.WriteLine("6. Print All Accounts");
            Console.WriteLine("7. Exit");
        }

        public static void SubMenu()
        {
            bool exitSubMenu = false;

            while (!exitSubMenu)
            {
                Console.WriteLine(" ");
                Console.WriteLine("\t\t\t  --------- Bank Information System --------");
                Console.WriteLine("\t\t\t  ------------------------------------------");
                Console.WriteLine(" ");

                Console.WriteLine();
                Console.WriteLine("Sub Menu");
                Console.WriteLine("--------");
                Console.WriteLine("1. Sub Option 1");
                Console.WriteLine("2. Sub Option 2");
                Console.WriteLine("3. Back to Main Menu");

                Console.Write("Enter your choice: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("You chose sub option 1.");
                        break;
                    case "2":
                        Console.WriteLine("You chose sub option 2.");
                        break;
                    case "3":
                        Console.WriteLine("Going back to the main menu...");
                        exitSubMenu = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}

      
    

