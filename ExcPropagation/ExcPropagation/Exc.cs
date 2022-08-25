using System;
namespace ExcPropagation
{
    public class Exc
    {
        public Exc()
        {
        }

        public void M1()
        {
            try
            {
                Console.WriteLine("Exit Try Block M1");
                M2();
                Console.WriteLine("Exit Try Block M1");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Enter catch block of M1.");
                Console.WriteLine($"Exceptiom from {e.TargetSite}");
                Console.WriteLine("Exit Catch Block M1");
            }

            Console.WriteLine("Exit M1");
        }



        public void M2()
        {
            Console.WriteLine("Enter M2");
            int y = 0;
            int x = 10 / y ;
            Console.WriteLine("Exit M2");
        }
    }
}

