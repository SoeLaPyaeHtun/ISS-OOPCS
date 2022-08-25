using System;

namespace SmartHome
{

    class Program
    {
        static void Main(string[] args)
        {
            Lamp lamp = new Lamp("Lamp");

            lamp.LampOn();
            lamp.LampOff();

            lamp.LampOn();
            lamp.LampOff();

            lamp.LampOn();
            lamp.LampOff();

            lamp.LampOn();
            lamp.LampOff();


            Console.WriteLine(lamp.GetName());
            lamp.Checker(lamp.count);


        }
    }
}

