using System;

namespace OOPC_Workshop_Inheritance_PartI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test class Account by creating an Account object
            // and call methods to make sure your code at 
            // class Account work
            Account account1 = new Account("S0000111", "S1111111A", 2000);

            account1.Display();
            Console.WriteLine();



            // TODO. Create object
            // 1. Create a new Account object account1
            // - accNumber: S0000111
            // - acctHolderId: S1111111A
            // - balance: 2000
            // 2. Call Console.WriteLine(account1)
            // Make sure that the account information 
            // is displayed correctly

            account1.Deposite(200);
            account1.Display();
            Console.WriteLine();

            // TODO: Deposit
            // Deposit 200 to the acccount.
            // Display the account information again and 
            // manually verify the new balance




            account1.Display();
            account1.widthdraw(500);
            // TODO: Widthdraw
            // Withdraw 200 from the account.
            // Display the account information again and
            // manually verify the new balance




            account1.widthdraw(4000);
            // TODO: Widthdraw
            // Withdraw 4000 from the account.
            // Make sure that the withdrawing is unsuccessful.



            account1.Display();

           
        }
    }
}

