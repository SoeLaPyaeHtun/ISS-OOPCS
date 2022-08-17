using System;
using System.Collections;

namespace ElasticArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int validInput = 0;
            Tasks tasks = new Tasks();
            ValidInput valid = new ValidInput();


            while (true)
            {
                Console.Write("What Would I like To Do?\n\n" +
                    "1. Add Interger\n2. Remove Interger Of Value X\n" +
                    "3. Remove Interger at Position X\n4. Find Interger\n" +
                    "5. How Many Element Right Now?\n6. Show Content\n\n Please Choose One: ");
                string input = Console.ReadLine();
                validInput = valid.Valid(input);


                if (validInput == 0)

                {
                    Console.WriteLine(">>> Invalid Input <<<");
                }
                else if (validInput == 10)
                {
                    Console.WriteLine(">>> Please provide number input <<<");
                }
                else
                {
                    if (validInput == 1)
                    {

                        tasks.SetValue();

                    }
                    else if (validInput == 2)
                    {
                        tasks.RemoveByValue();
                    }
                    else if (validInput == 3)
                    {

                        tasks.RemoveByIndex();
                    }
                    else if (validInput == 4)
                    {

                        tasks.FindInt();
                    }
                    else if (validInput == 5)
                    {
                        tasks.PrintTotalCount();
                    }
                    else
                    {
                        tasks.PirntAllOfElement();
                    }
                }
            }  
        }
    }
}
