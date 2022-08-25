using System;
namespace PayCalculator
{
    public class HourlyEmployee: Employee
    {

        public double WagePerHour
        {
            get; set;
        }

        public double Hours
        {
            get; set;
        }

        public HourlyEmployee(string name, double wphour, double hour) : base(name)
        {
            WagePerHour = wphour;
            Hours = hour;
        }

        public override double Earnings()
        {
            return WagePerHour * Hours;
        }
    }


  
}

