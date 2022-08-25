using System;
namespace Abstract_Bank
{
	public class SavingAccount : BankAccount
    {

        protected double interest;
		public SavingAccount(string AccountNo, double Balance): base(AccountNo,Balance)
		{
            this.interest = 0.25;
		}


        public override double GetDailyInterest()
        {
            return (Balance * interest) / 365;
        }

        public override bool TransferToAccount(BankAccount ba, double amount)
        {
            return false;
        }
    }
}

