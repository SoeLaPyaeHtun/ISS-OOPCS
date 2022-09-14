using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Tour
{
    public class Tour
    {
        private string name;
        private int cost;
        private int duration;
        private List<int> placeofinterest;
      

        public virtual int Cost { get; set; }
        public virtual int Duration { get; set; }
        public string Name { get; set; }


        public Tour(string name)
        {
            Name = name;
        }

        public Tour(string name, int cost, int duration)
        {
            Name = name;
            Cost = cost;
            Duration = duration;
        }

     

        public override string ToString()
        {
            return "Tour: " + name + "; Cost: " + cost;
        }
    }
}

