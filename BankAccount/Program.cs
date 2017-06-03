using System;
using System.Collections.Generic;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client("Josie", "Detwiller"); 
            client.Accounts = CreateAccounts(client.ID);    

            string userInput = string.Empty;  
            UserInteraction.GreetUser(client);
            
            do                                  
            {
                userInput = UserInteraction.PromptUser(client); 
                if (userInput == ((int)UserInput.Deposit).ToString()) 
                {
                    DepositProcessor.GetDepositInfo(client);    
                }
                else if (userInput == ((int)UserInput.Withdrawal).ToString())
                {
                    WithdrawalProcessor.GetWithdrawalInfo(client);  
                }
                else if (userInput == ((int)UserInput.Exit).ToString())
                {
                    UserInteraction.SayGoodbye();  
                }
                else
                {
                    Console.WriteLine("Please enter a valid selection");    
                }
            } while (userInput != ((int)UserInput.Exit).ToString());   
        }

        public enum UserInput  
        {
            Deposit = 1, 
            Withdrawal,
            Exit,
        }

        private static List<Account> CreateAccounts(double clientId)    //this is just a helper method to assign the accounts to the client
        {                                                               //not all clients will have the same types of accounts
            return new List<Account>                                    
            {
            new Checking(50000, clientId),  //declaring the balance in these accounts for this client
            new Savings(75000, clientId),   //don't need to name the accounts bc they're disposable variables at this point
            new Reserve(500, clientId),     //we only want the accounts for this instance of a Client
            };
        }
    }
}
