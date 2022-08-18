using System;
namespace SanThet
{
    public class Count
    {
        private int count;
        public Count(int count)
        {
            this.count = count;
        }


        public int getCount()
        {
            return count;
        }

        public void setCount(int count)
        {
            if (count == 0)
                Reset();
            else
                this.count = count;
        }

        public void Reset()
        {
            this.count = 0; 
        }
    }
}
