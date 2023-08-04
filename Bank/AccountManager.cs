namespace Bank
{
    public class AccountManager : IAccountManager
    {
        private List<BankAccount> _accounts = new List<BankAccount>();

        public AccountManager()
        {
            var masterAccount = new BankAccount("Master Account", 999999999);
        }

        public void AddAccount(BankAccount bankAccount)
        {
            _accounts.Add(bankAccount);
        }

        public List<BankAccount> GetAllAccounts()
        {
            return _accounts;
        }

        public BankAccount? GetAccountByNumber(int acctNum)
        {
            foreach (BankAccount bankAccount in _accounts)
            {
                if (bankAccount.AccountNumber == acctNum) return bankAccount;
            }

            return null;
        }

        public void RemoveAccount(BankAccount bankAccount)
        {
            _accounts.Remove(bankAccount);
        }

        public void Withdraw(BankAccount bankAccount, int amount)
        {
            bankAccount.Withdraw(amount);
        }

        public void Deposit(BankAccount bankAccount, int amount)
        {
            bankAccount.Deposit(amount);
        }

        public void Transfer(BankAccount fromBankAccount, BankAccount toBankAccount, int amount)
        {
            if (fromBankAccount.Balance < amount)
            {
                throw new Exception("Insufficient Funds!");
            }

            fromBankAccount.Withdraw(amount);
            toBankAccount.Deposit(amount);
        }
    }
}
