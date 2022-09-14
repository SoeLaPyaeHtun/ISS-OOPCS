using System;
namespace OldQuestion
{
    public class Faculty: Employee
    {
        private Boolean isTenure;
        public Faculty(string email,string name, int? age, double salary,Boolean isTenure) : base(email,name,age,salary)
        {
            IsTenure = isTenure;
        }

        public Boolean IsTenure { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Is Tenure: {IsTenure}";
        }
    }
}

