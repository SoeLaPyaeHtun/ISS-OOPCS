using System;

namespace ExcPropagation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Main");
            Exc ex = new Exc();


            try
            {
                ex.M1();
            }
            catch(Exception e)
            {
                Console.WriteLine("Enter catch block of Main.");
                Console.WriteLine($"Exception from: {e.TargetSite}");
                Console.WriteLine("Exit catch block of Main.");
            }
            Console.WriteLine("Exit Main");
        }
    }
}

