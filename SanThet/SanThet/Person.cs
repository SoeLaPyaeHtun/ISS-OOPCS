using System;
namespace SanThet
{
    public class Person
    {

        private string name;


        public Person(string name)
        {
            this.name = name;

        }

        public void Eat()
        {
            Console.WriteLine(this.name + " is eating...");
        }

        public void Sleep()
        {
            Console.WriteLine(this.name + " is sleeping ...");
        }

        public void Talk()
        {
            Console.WriteLine(this.name + " is talking....");
        }
    }
}
