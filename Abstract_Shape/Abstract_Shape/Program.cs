using System;

namespace Abstract_Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int width = rand.Next(5, 11);
            int height = rand.Next(6, 11);
            int radius = rand.Next(5, 11);

            string[] color = new string[] { "Blue", "Green", "Maroon" };

            Console.WriteLine($"Width: {width}, Height: {height}, radius: {radius}");

            Shape circle = new Circle(color[rand.Next(0, 2)], radius);
            Console.WriteLine("Color of Circle = " + circle.GetColor());
            Console.WriteLine("Area of Circle = " + circle.Area());




            Shape rectangle = new Rectangle(color[rand.Next(0, 2)], width, height);
            Console.WriteLine("Color of Rectangle = " + rectangle.GetColor());
            Console.WriteLine("Area of Rectangle = " + rectangle.Area());

        }
    }
}

