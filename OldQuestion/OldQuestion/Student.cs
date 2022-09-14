using System;
namespace OldQuestion
{
    public class Student : Person
    {
        private string major;

        public Student(string email, string name, int? age, string major): base(email, name, age)
        {
            Major = major;
        }

        public string Major { get; set; }


        public override string ToString()
        {
            return base.ToString() + $"Major: {Major}";
        }
    }
}

