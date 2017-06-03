using BankAccount.TransactionRelated;
using System;

namespace BankAccount
{
    public class WithdrawalProcessor
    {
        public static void GetWithdrawalInfo(Client client)
        {
            var account = UserInteraction.PromptUserForAccount(client.Accounts);
            decimal amount = UserInteraction.PromptUserForAmount();
            var transactionId = account.Withdrawal(amount);

            TransactionLogger.LogTransactions(new TransactionInfo   //this will call the LogTransactions method and populate it with
            {                                                           //all the transaction specifics we will want when printing our 
                AccountNumber = client.Id,                      //details to the txt file later. It will run and update with 
                AccountType = account.Type,                                     //every withdrawal made 
                TransactionAmount = amount,
                TransactionDate = DateTime.Now,
                TransactionType = TransactionType.Withdrawal.ToString(),
                UserFullName = $"{client.FirstName} {client.LastName}",
                TransactionId = transactionId,
                Balance = account.Balance,
            });
        }
    }
}
