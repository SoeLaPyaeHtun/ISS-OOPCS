﻿using System;

namespace OOPCS_Workshop_Inheritance_PartII
{
    class Program
    {
        static void Main(string[] args)
        {

            bool canWithraw;
            SavingsAccount savingAccount = new SavingsAccount("S0000111", "S1111111A",2000);
            Console.WriteLine(savingAccount.ToString());
            Console.WriteLine("Interest: {0}", savingAccount.CalculateInterest());
            savingAccount.CreditInterest();
            Console.WriteLine(savingAccount.ToString());

            canWithraw = savingAccount.Withdraw(3000);
            if (canWithraw)
            {
                Console.WriteLine("Withraw 3000 ok");
            }
            else
            {
                Console.WriteLine("Withraw 3000 fails");
            }

            Console.WriteLine();


            //Test Current Accounts

           CurrentAccount currentAccount = new CurrentAccount("S0000333", "S3333333B", 2000);
            Console.WriteLine(currentAccount.ToString());
            Console.WriteLine("Interest: {0}", currentAccount.CalculateInterest());
            currentAccount.CreditInterest();
            Console.WriteLine(currentAccount.ToString());
            canWithraw = currentAccount.Withdraw(3000);
            if (canWithraw)
            {
                Console.WriteLine("Withraw 3000 ok");
            }
            else
            {
                Console.WriteLine("Withraw 3000 fails");
            }
            Console.WriteLine();




            // Test Overdraft Accounts

            OverdraftAccount overdraftAccount1 = new OverdraftAccount("S0000222", "S2222222B", 2000);
            Console.WriteLine(overdraftAccount1.ToString());
            Console.WriteLine("Interest: {0}", overdraftAccount1.CalculateInterest());
            overdraftAccount1.CreditInterest();
            Console.WriteLine(overdraftAccount1.ToString());
            canWithraw = overdraftAccount1.Withdraw(3000);
            if (canWithraw)
            {
                Console.WriteLine("Withraw 3000 ok");
            }
            else
            {
                Console.WriteLine("Withraw 3000 fails");
            }
            Console.WriteLine(overdraftAccount1.ToString());
            Console.WriteLine();

            OverdraftAccount overdraftAccount2 = new OverdraftAccount("S0000222", "S2222222B", -2000);
            Console.WriteLine(overdraftAccount2.ToString());
            Console.WriteLine("Interest: {0}", overdraftAccount2.CalculateInterest());
            overdraftAccount2.CreditInterest();
            Console.WriteLine(overdraftAccount2.ToString());
            Console.WriteLine();
        }
    
    }
}

