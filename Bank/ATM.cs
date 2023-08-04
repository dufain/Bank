using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class ATM
    {
        private int Cash { get; set; } = 0;
        public Card? InsertedCard { get; set; }

        private IAccountManager AccountManager { get; set; }
        
        public ATM(IAccountManager accountManager) 
        {
            AccountManager = accountManager; 
        }

        public void InsertCard(Card card)
        {
            if (InsertedCard != null) throw new Exception("Card Already Present!");
            InsertedCard = card;
        }

        public void RemoveCard()
        {
            InsertedCard = null;
        }

        public void Withdraw(int amount)
        {
            if (InsertedCard == null) throw new Exception("No Card Inserted!");
            if (amount > Cash) throw new Exception("Not Enough Cash in the ATM!");
            

            
            bankAccount.Withdraw(amount);
            Cash -= amount;
        }

        public void Deposit(BankAccount bankAccount, int amount)
        {
            if (InsertedCard == null) throw new Exception("No Card Inserted!");
            bankAccount.Deposit(amount);
            Cash += amount;
        }
    }
}
