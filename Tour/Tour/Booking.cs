using System;
namespace Tour
{
    public class Booking : Tour
    {

        public Customer customer;
        public Trip trip;
        public int number;
        int aftDist;

        public Booking(int cost): base("", cost, 0) { }


        public override int Cost
        {
            get
            {
                if (5 < number)
                    aftDist = (5*Cost) * 95/100;
                return aftDist;
            }
        }
    }
}