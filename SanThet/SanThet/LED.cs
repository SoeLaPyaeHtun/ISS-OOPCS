using System;
namespace SanThet
{
    public class LED
    {

        private Boolean isOn;
        private string color;

        public LED(string color)
        {
            isOn = false;
            this.color = color;
        }

        public string getColor()
        {
            return color;
        }

        public Boolean isLedOn()
        {
            return isOn;
        }

        public void turnOn()
        {
            if (! isLedOn())
            {
                isOn = true;
            }
        }

        public void turnOff()
        {
            if (isLedOn())
            {
                isOn = false;
            }
        }
    }
}
