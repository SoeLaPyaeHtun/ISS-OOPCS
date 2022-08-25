using System;
namespace Abstract_Shape
{
    public abstract class Shape
    {
        protected string Color;
        public Shape(String Color)
        {
            this.Color = Color;
        }


        public string GetColor()
        {
            return this.Color;
        }

        public abstract double Area();

    }
}

