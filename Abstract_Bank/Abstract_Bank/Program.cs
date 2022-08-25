using System;

namespace Abstract_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount One = new SavingAccount("N001", 500);
            BankAccount Two = new CheckingAccount("N002", 600);

            One.Withdraw(50);
            Console.WriteLine(One.GetBalance());
            Two.Deposite(400);
            Console.WriteLine(Two.GetBalance());
            Two.TransferToAccount(One, 100);
            Console.WriteLine(One.GetBalance());
            Console.WriteLine(Two.GetBalance());
        }
    }
}

