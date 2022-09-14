using System;
namespace OldQuestion
{
    public class Person
    {
        private string name;
        private string email;
        private int? age;

        public Person(string email, string name, int? age)
        {
            Email = email;
            Name = name;
            Age = age;
        }

        public Person(string email, string name)
        {
            Email = email;
            Name = name;
        }

        public string Email { set; get; }
        public string Name { set; get; }
        public int? Age { set; get; }


        public void Display()
        {
            Console.WriteLine($"Email: {Email}, Name: {Name}, Age: {Age}");
        }

        public override string ToString()
        {
            return $"Email: {Email}, Name: {Name}, Age: {Age}";
        }
    }
}

