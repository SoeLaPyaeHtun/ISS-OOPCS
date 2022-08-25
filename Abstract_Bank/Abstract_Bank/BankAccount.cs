using System;
namespace Abstract_Bank
{
    public abstract class BankAccount
    {
        protected string AccountNo;
        protected double Balance;

        public BankAccount(string AccountNo, double Balance)
        {
            this.AccountNo = AccountNo;
            this.Balance = Balance;
        }

        public double GetBalance()
        {
            return Balance;
        }


        public void Deposite(double Amount)
        {
            if (Amount > 0)
                Balance += Amount;
        }

        public Boolean Withdraw(double amount)
        {
            if (amount <= 0 || amount > Balance)
                return false;
            else
                Balance -= amount;
                return true;
        }


        public abstract double GetDailyInterest();
        public abstract Boolean TransferToAccount(BankAccount ba, double amount);
    }
}

