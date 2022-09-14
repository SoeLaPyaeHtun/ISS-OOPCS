using System;

namespace OldQuestion
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person("elise@example.com", "Elise", 1998);
            Person p2 = new Person("kyle@example.com", "Kyle", 2003);
            Person p3 = new Person("keaton@example.com", "Keaton");
            Employee e1 = new Employee("cormac@example.com", "Cormac", 2002, 3000);
            Employee e2 = new Employee("asher@example.com", "Asher", 1995, 2500);
            Faculty f1 = new Faculty("amalia@example.com", "Amalia", 2001, 4000, true);
            Faculty f2 = new Faculty("ellie@example.com", "Ellie", 2001, 3500, false);
            Student s1 = new Student("dennis@example.com", "Dennis", 1999, "Computing");


            PersonelRecords personelRecords = new PersonelRecords();
            personelRecords.Add(p1);
            personelRecords.Add(e1);
            personelRecords.Add(f1);
            personelRecords.Add(s1);
            personelRecords.Add(p3);
            personelRecords.Display();

        }
    }
}

