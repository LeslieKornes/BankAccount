using System;
using System.Collections.Generic;

namespace BankAccount
{
    public class UserInteraction
    {
        internal static void GreetUser(Client client)
        {
            Console.WriteLine($"Hello, {client.FirstName} {client.LastName}");
            Console.WriteLine($"UserID: {client.ID}");
        }

        internal static decimal PromptUserForAmount()   //prompting user for desired amount of transaction(will work for dep or wd)
        {
            Console.WriteLine("\nWhat is the amount of your transaction?\n");   
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            return amount;
        }

        internal static string PromptUser(Client client)
        {
            Console.WriteLine("\nCurrent Balances:");
            client.Accounts.ForEach(account =>
            {
               Console.WriteLine($"{account.Type}: {account.Balance}");
            });
            Console.WriteLine($"\n\nWhat would you like to do, {client.FirstName}?");
            Console.WriteLine("\nPress 1 to make a DEPOSIT");
            Console.WriteLine("Press 2 to make a WITHDRAWAL");
            Console.WriteLine("Press 3 to  EXIT\n");

            return Console.ReadKey().KeyChar.ToString();    //this will execute after only one key is entered

            
        }

        internal static void SayGoodbye()
        {
            Console.WriteLine("\nThank you for banking with us today");
        }

        internal static Account PromptUserForAccount(List<Account> accounts) 
        {
            Console.WriteLine("\n\nPlease select an account:\n"); 
            int accountIndex = 1;
            accounts.ForEach(account =>
            {
                Console.WriteLine($"For {account.Type}, enter {accountIndex}");
                accountIndex++;
            });
            try
            {
                int selectedAccount = Convert.ToInt16(Console.ReadLine());

                return accounts[selectedAccount - 1];       //returning the account at the index - 1, because the index increments after each loop

            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter a 1, 2 or 3 to select your account type.");
                throw;
            }
            
        }
    }
}
