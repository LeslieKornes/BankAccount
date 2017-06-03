namespace BankAccount
{
    public class Reserve : Account      
    {
        public Reserve(decimal balance, double clientId) : base(balance, clientId)
        {
            Type = "Reserve";
        }
    }
}
