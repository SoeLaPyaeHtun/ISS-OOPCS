using System;
using System.Xml.Linq;

namespace OOPC_Workshop_Inheritance_PartI
{
    public class Account
    {

            /**
             * TODO: create attributes
             * This class has 3 attributes:
             * acctNumber : string, private
             * acctHolderId : string, private
             * balance: double, private
             */

            private string acctNumber;
            private string acctHolderId;
            private double balance;

            public Account()
            {
            }

            /**
             * TODO: create constructor
             * This contructor receives 3 values
             * and initializes the 3 attributes accordingly
             */


            public Account(string acctNumber, string acctHolderId, double balance)
            {
                this.acctNumber = acctNumber;
                this.acctHolderId = acctHolderId;
                this.balance = balance;
            }

            public virtual string GetNum()
        {
            return this.acctNumber;
        }

            public virtual string GetId()
        {
            return this.acctHolderId;
        }
            public virtual double GetBalanc()
        {
            return this.balance;
        }


        public virtual void Display()
        {
            Console.WriteLine("acctNumber: {0}; acctHolderId: {1}; balance{2} ", this.acctNumber, this.acctHolderId, this.balance);
        }

        /**
         * TODO: create properties
         * These properties expose the private attributes
         *
         * Note: acctNumber should be read-only, i.e. can not be
         * set from outside
         */






        /**
         * TODO: implement method Deposit
         * This method increases the account balance 
         * by the given amount
         */
        public double Deposite(double deposite)
            {
            this.balance += deposite;
                return  this.balance;
            }



            /**
             * TODO: implement method Withdraw
             * This method decreases the account balance
             * by the given amount. Balance must NOT be negative.
             * It makes sure that there is enough balance to
             * widthdraw
             */

            public void widthdraw(double widthdrawAmount)
            {

                if (this.balance <= 0.0)
                {
                    Console.WriteLine("There is no balance..");
                }
                else if (this.balance < widthdrawAmount)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    this.balance -=  widthdrawAmount;
                    Console.WriteLine(this.balance);
                }


            }


            public void TransferTo(double transfer)
        {
            if(this.balance < transfer)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                this.balance -= transfer;
                Console.WriteLine(this.balance);
            }
        }
        /**
         * TODO: implement method TransferTo
         * This method transfers a given amount to another given 
         * account. It makes sure that this sender has enough
         * balance before transfering
         */




        class Dplay : Account
        {
            public override void Display()
            {
                Console.WriteLine("acctNumber: {0}; acctHolderId: {1}; balance{2} ", this.acctNumber, this.acctHolderId, this.balance);
            }

        }


        /**
         * TODO: override method ToString
         * This method returns the values of the attributes
         * of the current object in a more readable format
         * For example: 
         * Account: accountNumber=S0000111, accountHolder=S1111111A, balance=2000
         */








    }

}