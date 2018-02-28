using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manage_customer.DAO
{
    class Customer
    {
        private string _Id;
        private string _Name;
        private string _Phone;
        private string _Address;

        public Customer()
        {
        }

        public Customer(string Id, string Name, string Phone, string Address)
        {
            this.Id = Id;
            this.Name = Name;
            this.Phone = Phone;
            this.Address = Address;
        }

        public Customer(string str)
        {
            string[] listString = str.Split('\t');
            if(listString.Length == 4)
            {
                this.Id = listString[0];
                this.Name = listString[1];
                this.Phone = listString[2];
                this.Address = listString[3];
            }
        }

        public string convertToString()
        {
            return String.Concat(this.Id, "\t", this.Name, "\t", this.Phone, "\t", this.Address);
        }

        public string Id { get => _Id; set => _Id = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Phone { get => _Phone; set => _Phone = value; }
        public string Address { get => _Address; set => _Address = value; }
    }
}
