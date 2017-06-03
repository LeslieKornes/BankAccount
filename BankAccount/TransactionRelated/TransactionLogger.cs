using System;
using System.IO;

namespace BankAccount
{
    public static class TransactionLogger
    {
        const string FilePath = "..\\Debug/Transaction_Log_FILETYPE.txt";  
        const string FileTypePlaceholder = "FILETYPE";

        public static void LogTransactions(TransactionInfo logInfo) 
        {                                                              
            var path = FilePath.Replace(FileTypePlaceholder, logInfo.AccountType);   
            StreamWriter logFile = new StreamWriter(path, true);  
            logFile.WriteLine($"Account Holder: {logInfo.UserFullName}\n");
            logFile.WriteLine($"Account Number: {logInfo.AccountNumber}");
            logFile.WriteLine($"Account Type: {logInfo.AccountType}");
            logFile.WriteLine($"Transaction ID: {logInfo.TransactionId}");
            logFile.WriteLine($"Transaction Type: {logInfo.TransactionType}");
            var transactionSymbol = logInfo.TransactionType == TransactionType.Deposit.ToString() ? "+" : "-";  
            var beginningBalance = transactionSymbol == "+" ? (logInfo.Balance - logInfo.TransactionAmount) : (logInfo.Balance + logInfo.TransactionAmount);   
            logFile.WriteLine($"Beginning Account Balance: {beginningBalance:C}");
            logFile.WriteLine($"Transaction Amount: {transactionSymbol}{logInfo.TransactionAmount:C}");    
            logFile.WriteLine($"Ending Account Balance: {logInfo.Balance:C}");
            logFile.WriteLine($"Transaction Date: {logInfo.TransactionDate}");
            logFile.WriteLine("\n\n\n");
            logFile.Close();
        }
    }
}
