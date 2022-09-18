using System;

namespace OldQuestionTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                try
                {
                    Console.WriteLine("Please input an integer number:");
                    int input = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Your number is {input}.");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ouch! FormatException.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ouch! OverflowException.");
                }
            }
        }
    }
}

