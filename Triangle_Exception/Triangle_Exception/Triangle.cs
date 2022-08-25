using System;
namespace Triangle_Exception
{
    public class Triangle
    {

        private double side1, side2, side3;

        public Triangle(double side1, double side2, double side3)
        {

            if (IsValidTriangle(side1, side2, side3))
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }
            else
            {
                throw new BadTriangleException("Invalid Sides");
            }
        }


        //BadTriangleException ex = new BadTriangleException("Invalid sides");
        
        //public double SideOne { get; set; }
        //public double SideTwo { get; set; }
        //public double SideThree { get; set; }

        private static bool IsValidTriangle(double side1, double side2, double side3)
        {

            if(side1 > 0 && side2 > 0 && side3 > 0 &&
                 side1 + side2 > side3 &&
                 side1 + side3 > side2 &&
                 side2 + side3 > side1)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public void Parameter()
        {
          
           Console.WriteLine($"Parameter of Triangle is {side1 + side2 + side3}");
        
        }

        public void Area()
        {
           
            double semiperimeter = (side1 + side2 + side3) / 2;
            double Area = Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
            Console.WriteLine($"Area of Triangle is {Area}");
          
        }

    }
}

