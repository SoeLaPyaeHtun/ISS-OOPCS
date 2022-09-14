using System;
namespace Tour
{
    public class Customer
    {

        private string name;
        private string address;
        private string id;


        public string Name { get; set; }
        public string Address { get; set; }
        public string Id { get; set; }



        public Customer(string name, string address, string id)
        {
            this.name = name;
            this.address = address;
            this.id = id;
        }
    }
}

