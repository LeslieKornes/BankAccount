namespace BankAccount
{
    public class Checking : Account   
    {
        public Checking(decimal balance, double clientId) : base(balance, clientId)
        {
            Type = "Checking";
        }
    }
}
