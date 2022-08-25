using System;
namespace PayCalculator
{
    public class Employee
    {


        public string Name
        {
            get;
            set;
        }

        public Employee(string name)
        {
            Name = name;
        }

        public virtual double Earnings()
        {
            return 0;
        }
    }
}

