using System;


namespace ElasticArrayV2
{
    public class Tasks
    {
        
        private int validInput = 0;
        private int z = 0;
        private int i = 0;
        private int b = 0;

        private int m = 0;
       

        private int temp = 0;
       

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

            for(int u =0; u < arrResult.Length; u++)
            {
                if (arrResult[u] == removeValue)
                {
                    m++;
                }
            }
            for (int j = 0; j < m; j++)
            {
                for (int a = 0; a < arrResult.Length - 1; a++)
                {
                    if (arrResult[a] == removeValue)
                    {
                        temp = arrResult[a];
                        arrResult[a] = arrResult[a + 1];
                        arrResult[a + 1] = temp;
                        b++;
                    }

                }
            }
            Array.Resize(ref arrResult, arrResult.Length - m);
                

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
            int temp2 = arrResult[indexToRemove];
            if (indexToRemove >= arrResult.Length)
                Console.WriteLine($"Array has only {arrResult.Length} elements, So Max index number is {arrResult.Length - 1}");
            else
                for (int y = 0; y < arrResult.Length -1 ; y++)
                {
                    if (arrResult[y] == temp2) { 
                        temp = arrResult[y];
                        arrResult[y] = arrResult[y + 1];
                        arrResult[y + 1] = temp;
                        
                    }
                }
            Array.Resize(ref arrResult, arrResult.Length - 1);
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


