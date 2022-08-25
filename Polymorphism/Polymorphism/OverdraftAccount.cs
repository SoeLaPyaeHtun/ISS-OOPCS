using System;
namespace Polymorphism
{
    public class OverdraftAccount : Account
    {
        public static double interestR = 0.25;
        public static double interestRNe = 6;


        public OverdraftAccount(string Number, string Id, double balance) : base(Number, Id, balance) { }



        public override double CalculateInterest()
        {

            if (0 < balance)
                return (balance * (interestR / 100));
            else
                return (balance * (interestRNe / 100));
        }



        public double CreditInterest()
        {

            return balance += CalculateInterest();
        }



        public override Boolean Withdraw(double amount)
        {
            if (amount < balance)
                return base.Withdraw(amount);
            else
                return false;
        }



        public override string ToString()
        {

            return "(OverDraftAccout) Account: " + base.ToString();
        }
    }
}

