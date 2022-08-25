using System;

namespace SanThet
{

    class Program
    {
        //public static void MakeManySound(Animal myAni, int times)
        //{
        //    for(int i =0; i < times; i++)
        //    {
        //        myAni.Sound();
        //    }
        //}

        public Animal CreateAnimal(string Type)
        {
            switch (Type)
            {
                case "cat":
                    return new Cat();

                case "dog":
                    return new Dog();

                case "cow":
                    return new Cow();


                default:
                    return null;
            }
        }


        static void Main(string[] args)
        {



            Animal myAni = new CreateAnimal("cat");

            //int[] arr = { 2, 5, 1, 4, 6, 8 };


            //foreach (var p in arr)
            //{
            //    Console.Write(p + " ");
            //}
            //Console.WriteLine();


            //selection sort
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



            //bubble sort
            //int temp = 0;
            //for (int p = 0; p < arr.Length - 1; p++)
            //{
            //    for (int i = 0; i < arr.Length - 1; i++)
            //    {
            //        if (arr[i] > arr[i + 1])
            //        {
            //            temp = arr[i + 1];
            //            arr[i + 1] = arr[i];
            //            arr[i] = temp;
            //        }
            //    }
            //}



            //foreach (var a in arr)
            //{
            //    Console.Write(a + " ");
            //}

        }

    }



}
