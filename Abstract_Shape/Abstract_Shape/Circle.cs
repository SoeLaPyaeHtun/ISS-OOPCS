using System;
namespace Abstract_Shape
{
    public class Circle: Shape
    {
        private int radius;

        public Circle(string Color, int radius): base(Color)
        {
            this.radius = radius;
        }


        public override double Area()
        {
            return Math.Round(Math.PI * radius * radius, 2);
        }
    }
}

