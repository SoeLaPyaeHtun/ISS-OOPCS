using System;
namespace SmartHome
{
    public class Lamp : Smart, Ismart
    {

        public bool isOn = false;
        public int count = 0;
        public string name;


        public Lamp(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

       

        public void LampOn()
        {
            if (!isOn)
            {
                isOn = true;
                count++;
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine("Lamp is already On");
            }
        }

        public void LampOff()
        {
            if (isOn)
            {
                isOn = false;
            }
            else
            {
                isOn = false;
            }
        }


        public override void Checker(int count)
        {
            base.Checker(count);
        }




    }
}

