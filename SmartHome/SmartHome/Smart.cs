using System;
namespace SmartHome
{
    public class Smart
    {


        public Smart()
        {
        }


        public virtual void Checker(int count)
        {
            if (count > 5)
                Console.WriteLine("Need Service");
            else
                Console.WriteLine("still Good");
        }

       
    }
}

