using System;
using System.Collections.Generic;

namespace Tour
{
    public class Trip: Booking
    {
        public int maxSize;
        public Tour tour;
        public DateTime dt;
       
       
       
        int seatCount;


        public Trip(Tour tour, DateTime dt, int maxSize):base(0)
        {
            this.tour = tour;
            this.dt = dt;
            this.maxSize = maxSize;
        }



        public Trip(Tour tour):base(0)
        {
            this.tour.Name = tour.Name;
        }



        public void Book(Customer customer, int N)
        {
           
        }



        public void GetRevenue()
        {

        }
    }
}

