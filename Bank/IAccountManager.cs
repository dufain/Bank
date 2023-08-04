namespace Bank
{
    public interface IAccountManager
    {
        void AddAccount(BankAccount bankAccount);
        void Deposit(BankAccount bankAccount, int amount);
        void RemoveAccount(BankAccount bankAccount);
        void Transfer(BankAccount fromBankAccount, BankAccount toBankAccount, int amount);
        void Withdraw(BankAccount bankAccount, int amount);
    }
}