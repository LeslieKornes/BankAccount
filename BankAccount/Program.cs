using BankAccount.Processors;
using System;
using System.Collections.Generic;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client("Josie", "Detwiller"); 
            client.Accounts = CreateAccounts(client.Id);    

            string userInput;  
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

        private static List<Account> CreateAccounts(double clientId)    
        {                                                               
            return new List<Account>                                    
            {
            new Checking(50000, clientId),  
            new Savings(75000, clientId),  
            new Reserve(500, clientId),     
            };
        }
    }
}
