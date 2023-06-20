using BankDemoApp.Customer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BankDemoApp.FileIO
{
    public class IOAction
    {
        static string filePath;
         static IOAction()
        {
            filePath = @"C:\temp\accounts.json";
        }
      
        public static void SaveAccountsFile(List<Account> accounts)
        {
            try
            {
                string json = JsonConvert.SerializeObject(accounts, Newtonsoft.Json.Formatting.Indented);

                // If the file doesn't exist, create it. If it exists, overwrite it.
                File.WriteAllText(filePath, json);
                Console.WriteLine("JSON file created/updated!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occured: "+ex.Message);
            }
            
        }

        public static List<Account> LoadDataFromFile()
        {
            var accounts = new List<Account>();
            try
            {
                if (File.Exists(filePath))
                {
                    // If file exists, load data from file
                    string jsonFromFile = File.ReadAllText(filePath);
                    accounts = JsonConvert.DeserializeObject<List<Account>>(jsonFromFile);
                    Console.WriteLine("Data loaded from file!");
                }
            } catch (Exception ex)
            {
                Console.WriteLine("Exception Occured: " + ex.Message);
            }

            return accounts;
        }
    }
}
