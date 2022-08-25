using System;

namespace SanThet
{
    public class Animal
    {
        public Animal()
        {

        }

        public virtual void Sound()
        {
            Console.WriteLine("");
        }
    }





    public class Cow : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Moo");
        }
    }


    public class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Oink");
        }
    }

    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Meow");
        }
    }

}
