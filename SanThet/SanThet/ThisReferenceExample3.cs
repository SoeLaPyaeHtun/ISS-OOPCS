using System;
using static System.Collections.Specialized.BitVector32;

namespace SanThet
{
    public class ThisReferenceExample3
    {
        private int number1;
        private int number2;

        public ThisReferenceExample3()
            : this(-1, -1)
        {}

        public ThisReferenceExample3(int number1)
            : this(number1, -1)
        {}

        public ThisReferenceExample3(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }

        public void print()
        {
            Console.WriteLine("Number 1 is " + number1 + "\nnumber 2 is " + number2);
        }
    }
    
}

