using System;

namespace Exception_ExOne
{
    class Program
    {


        public static void isValid(int age)
        {
            if (age >= 18)
                Console.WriteLine("Access granted - You are old enough!");
            else
                throw new Ex("Your not valid");
        }




        static void Main(string[] args)
        {
           
                try
                {
                    Console.Write("Enter Your Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    isValid(age);
                }
            catch (Ex e)
                {
                    Console.WriteLine(e.Message);
                }

            
        }
    }
}

