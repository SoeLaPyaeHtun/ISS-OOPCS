using System;

namespace Triangle_Exception
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Triangle T1 = new Triangle(2, 3, 5);
                T1.Area();
                T1.Parameter();
            }catch(BadTriangleException ex)
            {
               Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

            try
            {
                Triangle T2 = new Triangle(7, 10, 5);
                T2.Area();
                T2.Parameter();
            }catch(BadTriangleException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}

