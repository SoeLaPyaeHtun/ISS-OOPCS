using System;

namespace SanThet
{
    class Program
    {
        static void Main(string[] args)
        {

            GetAndSet santhet = new GetAndSet();

            Console.WriteLine(santhet.N);

            santhet.N = 10;

            Console.WriteLine(santhet.N);


        }
    }
}
