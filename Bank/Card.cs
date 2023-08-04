namespace Bank
{
    public class Card
    {
        public int CardNumber { get; private set; }
        public int PIN { get; private set; }
        public BankAccount LinkedAccount { get; set; }

        public Card(BankAccount linkedAccount, int pin) 
        {
            CardNumber = Utils.GenerateRandomNumber(16);
            PIN = pin;
            LinkedAccount = linkedAccount;
        }
    }
}
