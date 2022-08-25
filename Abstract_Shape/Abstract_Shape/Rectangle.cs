using System;
namespace Abstract_Shape
{
    public class Rectangle: Shape
    {

        private int width;
        private int height;

        public Rectangle(string Color, int width, int height): base(Color)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }
    }
}

