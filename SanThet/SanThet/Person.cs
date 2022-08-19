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

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}

