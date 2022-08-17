using System;
namespace GenieLamp
{
    public class OnAndOff
    {

        public int on = 0;
        public int off = 0;
        public Boolean isOn;
        public int cCountOn = 0;
        public int cCountOff = 0;

        public OnAndOff(Boolean isOn)
        {
            this.isOn = isOn;
        }

        public Boolean isOnLed()
        {
            return isOn;
        }

        public Boolean TurnOn()
        {
            
            if (!isOnLed())
                isOn = true;
                on++;
                off = 0;
                cCountOn++;
            return isOn;
        }

        public Boolean TurnOff()
        {
            
            if (isOnLed())
                isOn = false;
                on = 0;
                off++;
                cCountOff++;
            return isOn;
        }
    }
}
