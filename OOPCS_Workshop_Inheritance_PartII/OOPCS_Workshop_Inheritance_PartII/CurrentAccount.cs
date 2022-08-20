using System;
namespace OOPCS_Workshop_Inheritance_PartII
{
    public class CurrentAccount : Account
    {

        public static double interestR = 0.25;

        public CurrentAccount(string accountNumber, string accountId, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountId = accountId;
            this.balance = balance;
        }


        public double CalculateInterest()
        {
            return (balance * (interestR / 100));
        }

        public double CreditInterest()
        {
            return balance += CalculateInterest();
        }

        public Boolean Withdraw(double withdrawAmount)
        {
            if (withdrawAmount > balance)
                return false;
            else
                return true;
        }



        public override string ToString()
        {
            return "(SavingsAccout) Account: " + "AccountNumber: " + this.accountNumber + "AccountId: " + this.accountId + "Balance: " + this.balance;
        }

    }
}

