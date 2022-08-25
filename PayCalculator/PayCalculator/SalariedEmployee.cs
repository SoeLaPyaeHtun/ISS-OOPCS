using System;
namespace PayCalculator
{
    public class SalariedEmployee : Employee
    {

        public double WeeklySalary
        {
            get;
            set;
        }

        public SalariedEmployee(String name, double wSalary): base(name)
        {
            WeeklySalary = wSalary;
        }

        public override double Earnings()
        {
            return WeeklySalary;
        }

    }
}

