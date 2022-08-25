using System;
namespace PayCalculator
{
    public class PayCalculator
    {

        private SalariedEmployee[] salariedEmployees;
        private HourlyEmployee[] hourlyEmployees;

        public PayCalculator(SalariedEmployee[] salariedEmployees, HourlyEmployee[] hourlyEmployees)
        {
            this.salariedEmployees = salariedEmployees;
            this.hourlyEmployees = hourlyEmployees;
        }


        public double CalculatePay()
        {
            double total = 0;

            foreach(SalariedEmployee se in salariedEmployees)
            {
                total += se.Earnings();
            }

            foreach(HourlyEmployee he in hourlyEmployees)
            {
                total += he.Earnings();
            }


            return total;
        }
    }
}

