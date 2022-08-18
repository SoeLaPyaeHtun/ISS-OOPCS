using System;
namespace SanThet
{
    public class GetAndSet
    {

        private string name;  // field
        public string Name    // property
        {
            get { return name; }
            set { name = value; }
        }


        public GetAndSet()
        {
        }
    }
}
