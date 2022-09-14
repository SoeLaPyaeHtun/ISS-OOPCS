using System;
using System.Collections.Generic;

namespace Tour
{
    public class TravelAgency
    {

        private string name;
        public List<Customer> customers;
        private List<Tour> tours;
        private List<Trip> trips;

        public List<Customer> Customer { get; set; }


        public void Add(Customer customer)
        {
           
            customers.Add(customer);

        }
        //public void Add(Tour tour)
        //{
        //    tours.Add(tour);
        //}
        //public void Add(Trip trip)
        //{
        //    trips.Add(trip);
        //}




        //public Tour FindTour(string city)
        //{
        //    foreach(var i in tours)
        //    {
        //        if(i.Name == city)
        //        {
        //            break;
        //        }
           
        //    }
        //    return new Tour(city);
        //}





        //public Trip FindTrip(string city)
        //{
        //    foreach (var i in tours)
        //    {
        //        if (i.Name == city)
        //        {
        //            break;
        //        }

        //    }
        //    return new Trip(city);
        //}


        //public Customer FindCustomer(string name)
        //{
        //    return new Customer();
        //}
        
        public TravelAgency(string name)
        {
            this.name = name;
        }
    }
}

