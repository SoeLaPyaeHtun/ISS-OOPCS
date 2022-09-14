using System;
namespace Tour
{
    public class TourGuide
    {

        private string name;
        private string address;
        private int salary;


        public string Name { get; set; }
        public string Address { get; set; }
        public string Salary { get; set; }

        public TourGuide(string name, string address, int salary)
        {
            this.name = name;
            this.address = address;
            this.salary = salary;
        }
    }
}

