using BankAccount.TransactionRelated;
using System;

namespace BankAccount.Processors
{
    class DepositProcessor
    {
        public static void GetDepositInfo(Client client)    
        {
            var account = UserInteraction.PromptUserForAccount(client.Accounts);    
            decimal amount = UserInteraction.PromptUserForAmount();     
            int transactionId = account.Deposit(amount);    

            TransactionLogger.LogTransactions(new TransactionInfo   
            {                                                            
                AccountNumber = client.Id,                     
                AccountType = account.Type,                                     
                TransactionAmount = amount,
                TransactionDate = DateTime.Now,
                TransactionType = TransactionType.Deposit.ToString(),
                UserFullName = $"{client.FirstName} {client.LastName}",
                TransactionId = transactionId,
                Balance = account.Balance,
            });
        }
    }
}
