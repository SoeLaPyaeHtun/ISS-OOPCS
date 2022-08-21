using System;

namespace SanThet
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 1, 4, 6, 8 };


            foreach (var p in arr)
            {
                Console.Write(p + " ");
            }
            Console.WriteLine();



            //int temp = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            temp = arr[j];
            //            arr[j] = arr[i];
            //            arr[i] = temp;
            //        }
            //    }
            //}



            foreach (var a in arr)
            {
                Console.Write(a + " ");
            }

        }

    }



}
