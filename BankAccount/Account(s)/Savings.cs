namespace BankAccount
{
    public class Savings : Account  
    {
        public Savings(decimal balance, double clientId) : base(balance, clientId)
        {
            Type = "Savings";
        }
    }
}
