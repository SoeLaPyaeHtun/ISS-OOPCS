using System;
using System.Collections.Generic;

namespace OldQuestion
{
    public class PersonelRecords
    {
        public PersonelRecords()
        {
        }

        List<Person> record = new List<Person>();
       
        public void Add(Person obj)
        {
            record.Add(obj);
        }

        public void Display()
        {
            foreach (Person i in record)
            {
                Console.WriteLine(i);
            }
        }
    }
}

