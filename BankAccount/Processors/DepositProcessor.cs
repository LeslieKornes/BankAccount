using System;

namespace BankAccount
{
    class DepositProcessor
    {
        public static void GetDepositInfo(Client client)    //this method will run when the user chooses to make a deposit
        {
            var account = UserInteraction.PromptUserForAccount(client.Accounts);    //reusable method that obtains the user's desired account to deposit to
            decimal amount = UserInteraction.PromptUserForAmount();     //reusable method obtaining deposit amount
            int transactionId = account.Deposit(amount);    //obtains a transactionID and actually adds the money to the balance 

            TransactionLogger.LogTransactions(new TransactionInfo   //calling the LogTransactions method in the TransactionLogger
            {                                                            
                AccountNumber = client.ID,                     
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
