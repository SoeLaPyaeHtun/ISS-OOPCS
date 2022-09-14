using System;
namespace OldQuestion
{
    public class Employee : Person
    {
        private double salary;

        public Employee(string email, string name, int? age, double salary):base(email,name,age)
        {
            Salary = salary;
        }

        public double Salary { get; set; }



        public override string ToString()
        {
       
             return base.ToString() + $"Salary: {Salary}";
        }
    }
}

