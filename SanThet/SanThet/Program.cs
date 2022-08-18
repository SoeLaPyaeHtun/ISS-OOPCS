using System;

namespace SanThet
{
    class Program
    {
        static void Main(string[] args)
        {

            GetAndSet myObj = new GetAndSet();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);


        }
    }
}
