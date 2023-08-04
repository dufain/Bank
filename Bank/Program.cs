using Bank;

AccountManager accountManager = new AccountManager();
accountManager.CreateAccount();
ATM atm = new ATM(accountManager);

atm.