namespace Bank
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }

        public BankAccount(string name, int balance) 
        {
            AccountNumber = Utils.GenerateRandomNumber(6);
            Balance = balance;
            Name = name;
        }

        public void Withdraw(int amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                throw new Exception("Insufficient Funds!");
            }
        }

        public void Deposit(int amount)
        {
            Balance += amount;
        }
    }
}
