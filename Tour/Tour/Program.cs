using System;

namespace Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            TravelAgency t = new TravelAgency("Tan Ah Huat Travel Far");


            t.Add(new Customer("Tan Lian Hwee", "Clementi Road", "C10010"));
            //t.Add(new Customer("Lim Teck Gee", "Kent Ridge Road", "C10020"));
            //t.Add(new Customer("Koh Ghim Moh", "Dover Road", "C10030"));
            //t.Add(new Customer("Liat Kim Ho", "West Coast Road", "C10040"));

            Customer a = new Customer("Tan Lian Hwee", "Clementi Road", "C10010");
        }
    }
}

