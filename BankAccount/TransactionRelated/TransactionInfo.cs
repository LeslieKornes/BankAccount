using System;

namespace BankAccount
{
    public class TransactionInfo        //this class was created to set and log the properties for every transaction
    {
        public double AccountNumber { get; set; }
        public DateTime TransactionDate { get; set; }
        public string UserFullName { get; set; }
        public decimal Balance { get; set; }
        public decimal TransactionAmount { get; set; }
        public string TransactionType { get; set; }
        public int TransactionId { get; set; }
        public string AccountType { get; set; }
    }
}
