using System;
using System.Collections;
namespace ElasticArray
{
    public class Tasks
    {
        public ArrayList arrResult = new ArrayList();
        public int removeIndex = 0;
        public int inputOne = 0;
        public int validInput = 0;
        public int removeValue = 0;
        public int findInt = 0;
        public int z = 0;

        public Tasks()
        {
        }

        public void SetValue()
        {
            Console.Write("Enter Interger to Add : ");
            inputOne = Convert.ToInt32(Console.ReadLine());
            arrResult.Add(inputOne);
            Console.WriteLine(">>>> interger added <<<< \n");
        }

        public void RemoveByValue()
        {
            Console.Write("Which Value do you want to remove : ");
            removeValue = Convert.ToInt32(Console.ReadLine());

            for (int y = 0; y < arrResult.Count; y++)
            {
                arrResult.Remove(removeValue);
            }
        }

        public void RemoveByIndex()
        {
            Console.Write("Which Index do you want to remove : ");
            removeIndex = Convert.ToInt32(Console.ReadLine());
            arrResult.RemoveAt(removeIndex);
        }

        public void FindInt()
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
                Console.WriteLine($"Not Found in Array\n");

            z = 0;
        }

        public void PrintTotalCount()
        {
            Console.WriteLine($"\n >>> total count : {arrResult.Count} <<<\n");
        }

        public void PirntAllOfElement()
        {
            foreach (var x in arrResult)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine("\n");
        }
    }
}
