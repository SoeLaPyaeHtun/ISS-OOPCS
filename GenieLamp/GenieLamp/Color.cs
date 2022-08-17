using System;
namespace GenieLamp
{
    public class Color
    {
        public int count = 0;
        public string color;
        public Color()
        {
           
        }

        public string getColorRed()
        {
            color = "Red";
            count = 1;
            return color;
        }
        public string getColorBlue()
        {
            color = "Blue";
            count = 2;
            return color;
        }
        public string getColorGreen()
        {
            color = "Green";
            count = 0;
            return color;
        }
    }
}
