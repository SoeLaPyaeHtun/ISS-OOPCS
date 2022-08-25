using System;
namespace Abstract_Shape
{
    public class Triangle: Shape
    {
        private int width;
        private int height;

        public Triangle(string Color, int width, int height):base(Color)
        {
            this.width = width;
            this.height = height;
        }


        public override double Area()
        {
            return 0.5 * width * height;
        }
    }
}

