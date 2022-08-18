using System;
using System.Linq;

namespace ElasticArrayV2
{
    public class Tasks
    {
        
        private int validInput = 0;
        private int z = 0;
        private int i = 0;
        private int b = 0;

        int[] arrResult = new int[0];
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
            i++;
            Array.Resize(ref arrResult, i);
            Console.Write("Enter Interger to Add : ");
            int addedInt = Convert.ToInt32(Console.ReadLine());
            arrResult[i - 1] = addedInt;
            Console.WriteLine(">>>> interger added <<<< \n");
        }


        //Remove By Value Method
        private void RemoveByValue()
        {
            Console.Write("Which Value do you want to remove : ");
            int removeValue = Convert.ToInt32(Console.ReadLine());

            for (int y = 0; y < arrResult.Length; y++)
            {
                if (arrResult[y] == removeValue)
                {
                    Console.WriteLine($"{removeValue} at index {y} is removed");
                    arrResult = arrResult.Where((source, index) => index != y).ToArray();
                    b++;
                }
            }
            if (b == 0)
                Console.WriteLine($"Input Number {removeValue} Not Found in Array\n");

            b = 0;
            Console.WriteLine();
        }


        //Remove By Index Mehtod
        private void RemoveByIndex()
        {
            Console.Write("Which Index do you want to remove : ");
            int indexToRemove = Convert.ToInt32(Console.ReadLine());
            arrResult = arrResult.Where((source, index) => index != indexToRemove).ToArray();
        }


        //Find Interger Method
        private void FindInt()
        {
            Console.Write("Enter Interger to find : ");
            int find = Convert.ToInt32(Console.ReadLine());
            for (int a = 0; a < arrResult.Length; a++)
            {
                if (arrResult[a] == find)
                {
                    Console.WriteLine($"We Found {find} at index {a}");
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
            Console.WriteLine($"\n >>> total count : {arrResult.Length} <<<\n");
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


