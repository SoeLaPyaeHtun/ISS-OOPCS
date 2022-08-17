using System;

namespace GenieLamp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            OnAndOff oAf = new OnAndOff(false);
            Color color = new Color();
            

        
           
            while (true)
            {
                Console.WriteLine("1. Turn On The Light");
                Console.WriteLine("2. Turn Off The Light");
                Console.WriteLine("3. What is the color of the light?");
                Console.WriteLine("4. Is The Lamp On?\n");


                Console.Write("Please Choose One: ");
              
                string choOne = Console.ReadLine();
                if (choOne == "1")
                {
                    if (oAf.on == 0)
                    {
                        oAf.TurnOn();
                        Console.WriteLine("\nThe Lamp is " + (oAf.isOnLed() ? "ON" : "OFF") + "\n");
                        oAf.isOn = true;
                    }
                    else
                    {
                        
                        Console.WriteLine("\nThe Light is Already On\n");
                    }
                }
                else if (choOne == "2")
                {
                    if (oAf.off == 0)
                    {
                      
                        oAf.TurnOff();
                        Console.WriteLine("\nThe Lamp is " + (oAf.isOnLed() ? "ON" : "OFF")+"\n");
                        oAf.isOn = false;
             
                       
                    }
                    else
                    {
                        Console.WriteLine("\nThe Light is Already Off\n");
                    }
                }
                else if(choOne == "4")
                {
                    Console.WriteLine("\nThe Lamp is " + (oAf.isOnLed() ? "ON" : "OFF") + "\n");
                }
                else if(choOne == "3")
                {
                    if((oAf.cCountOff > 0 && oAf.cCountOn > 0) || oAf.cCountOn > 0)
                    {
                        if (color.count == 0)
                        {
                            Console.WriteLine($"\nthe light color is {color.getColorRed()}\n");
                           
                            
                        }else if(color.count == 1)
                        {
                            Console.WriteLine($"\nthe light color is {color.getColorBlue()}\n");

                            
                        }else if(color.count == 2)
                        {
                            Console.WriteLine($"\nthe light color is {color.getColorGreen()}\n");
       
                        }
                        oAf.cCountOff = 0;
                        oAf.cCountOn = 0;
                    }
                }
            }


        }
    }
}
