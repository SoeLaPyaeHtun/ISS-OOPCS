using System;
namespace Abstract_Bank
{
    public class CheckingAccount: BankAccount
    {
        public CheckingAccount(string AccountNo, double Balance): base(AccountNo, Balance) { }

        public override double GetDailyInterest()
        {
            return 0;
        }


        public override bool TransferToAccount(BankAccount ba, double amount)
        {
            if (Withdraw(amount))
            {
                ba.Deposite(amount);
                return true;
            }
                return false;
            
        }

    }
}

