using System;
using System.Xml.Linq;

namespace Polymorphism
{
    public class Account
    {
        protected string accountNumber;
        protected string accountId;
        protected double balance;

        public Account(string number, string id, double bal)
        {
            accountNumber = number;
            accountId = id;
            balance = bal;
        }


        public string Num
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string Id
        {
            get { return accountId; }
            set { accountId = value;  }
        }

        public double Bal
        {
            get { return balance;  }
            set { balance = value;  }
        }


        public void deposite(double amount)
        {
            balance += amount;
        }


        public virtual double CalculateInterest()
        {
            return 0;
        }

        public virtual bool Withdraw(double amount)
        {
            balance -= amount;
            return true;
        }

        public override string ToString()
        {
            return " AccountNumber:" +
                   accountNumber + " AccountId:" + accountId + " Balance:" + balance;
        }




    }
}

