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
                resetCount();
            else
                this.count = count;
        }
        private void resetCount()
        {
            this.count = 0;
        }
    }
}
