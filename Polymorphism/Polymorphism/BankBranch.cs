using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public class BankBranch
    {

        private List<Account> BankAccount;

        public BankBranch(string name)
        {
            Name = name;
            BankAccount = new List<Account>();
        }


        public string Name { get; set; }

        public void AddAccount(Account account)
        {
            BankAccount.Add(account);
        }

        public void PrintCustomers()
        {
            foreach (Account account in BankAccount)
            {
                Console.WriteLine(account.Id);
            }
        }

        public double TotalDeposits()
        {
            double totalDeposite = 0;
            foreach (Account account in BankAccount)
            {
               
                    totalDeposite += account.Bal;

            }
            return totalDeposite;
        }

        public double TotalInterestPaid()
        {
            double totalInterestPaid = 0;
            foreach (Account account in BankAccount)
            {
                if (account.Bal > 0)
                    totalInterestPaid += account.CalculateInterest();

            }
            return totalInterestPaid;
        }


        public double TotalInterestEarned()
        {
            double totalInterestEarned = 0;
            foreach (Account account in BankAccount)
            {
                if (account.Bal < 0)
                    totalInterestEarned += account.CalculateInterest();

            }
            return totalInterestEarned;
        }


        public void PrintAccounts()
        {
            foreach(Account account in BankAccount)
            {
                Console.WriteLine(account);

            }
        }


      

    }
}

