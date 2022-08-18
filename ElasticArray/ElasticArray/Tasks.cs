using System;
using System.Collections;
namespace ElasticArray
{
    public class Tasks
    {
        private ArrayList arrResult = new ArrayList();
        private int removeIndex = 0;
        private int inputOne = 0;
        private int validInput = 0;
        private int removeValue = 0;
        private int findInt = 0;
        private int z = 0;
       
        
        ValidInput valid = new ValidInput();

        public Tasks()
        {
        }

        public void ShowMenu()
        {

            while (true)
            {
                Console.Write("What Would I like To Do?\n\n" +
                    "1. Add Interger\n2. Remove Interger Of Value X\n" +
                    "3. Remove Interger at Position X\n4. Find Interger\n" +
                    "5. How Many Element Right Now?\n6. Show Content\n\n Please Choose One: ");

                string input = Console.ReadLine();
                validInput = valid.Valid(input);
                Console.WriteLine();

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

                    try
                    {

                        if (validInput == 1)
                        {
                            SetValue();
                        }
                        else if (validInput == 2)
                        {
                            RemoveByValue();
                        }
                        else if (validInput == 3)
                        {
                            RemoveByIndex();
                        }
                        else if (validInput == 4)
                        {
                            FindInt();
                        }
                        else if (validInput == 5)
                        {
                            PrintTotalCount();
                        }
                        else
                        {
                            PirntAllOfElement();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("\n>>> Please provide number input only<<<\n");
                    }
                }

            }
        }


        //Interger Added Method
        private void SetValue()
        {
            Console.Write("Enter Interger to Add : ");
            inputOne = Convert.ToInt32(Console.ReadLine());
            arrResult.Add(inputOne);
            Console.WriteLine(">>>> interger added <<<< \n");
        }


        //Remove By Value Method
        private void RemoveByValue()
        {
            Console.Write("Which Value do you want to remove : ");
            removeValue = Convert.ToInt32(Console.ReadLine());

            for (int y = 0; y < arrResult.Count; y++)
            {
                arrResult.Remove(removeValue);
            }
        }


        //Remove By Index Mehtod
        private void RemoveByIndex()
        {
            Console.Write("Which Index do you want to remove : ");
            removeIndex = Convert.ToInt32(Console.ReadLine());
            arrResult.RemoveAt(removeIndex);
        }


        //Find Interger Method
        private void FindInt()
        {
            Console.Write("Enter Interger to find : ");
            findInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int a = 0; a < arrResult.Count; a++)
            {
                if (Convert.ToInt32(arrResult[a]) == findInt)
                {
                    Console.WriteLine($"We Found {findInt} at index {a}");
                    z++;
                }
            }

            if (z == 0)
                Console.WriteLine("Not Found in Array\n");

            z = 0;
            Console.WriteLine();
        }


        //Print Total Count Method
        private void PrintTotalCount()
        {
            Console.WriteLine($"\n >>> total count : {arrResult.Count} <<<\n");
        }


        //Print All of Element Method
        private void PirntAllOfElement()
        {
            foreach (var x in arrResult)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine("\n");
        }
    }
}
