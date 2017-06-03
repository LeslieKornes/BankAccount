using System;

namespace BankAccount.TransactionRelated
{
    public class TransactionInfo       
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
