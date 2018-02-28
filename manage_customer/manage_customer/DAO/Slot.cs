using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manage_customer.DAO
{
    class Slot
    {
        private string _Id;
        private string _Name;
        private string _Date;
        private string _Service;
        private string _Product;
        private string _Staff;
        private string _Note;

        public Slot()
        {
        }

        public Slot(string Id, string Name, string Date, string Service, string Product, string Staff, string Note)
        {
            this.Id = Id;
            this.Name = Name;
            this.Date = Date;
            this.Service = Service;
            this.Product = Product;
            this.Staff = Staff;
            this.Note = Note;
        }

        public Slot(string str)
        {
            string[] listString = str.Split('\t');
            if (listString.Length == 7)
            {
                this.Id = listString[0];
                this.Name = listString[1];
                this.Date = listString[2];
                this.Service = listString[3];
                this.Product = listString[4];
                this.Staff = listString[5];
                this.Note = listString[6];
            }
        }

        public string convertToString()
        {
            return String.Concat(this.Id, "\t", this.Name, "\t", this.Date, "\t", this.Service, this.Product, "\t", this.Staff, "\t", this.Note);
        }

        public string Id { get => _Id; set => _Id = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Date { get => _Date; set => _Date = value; }
        public string Service { get => _Service; set => _Service = value; }
        public string Product { get => _Product; set => _Product = value; }
        public string Staff { get => _Staff; set => _Staff = value; }
        public string Note { get => _Note; set => _Note = value; }
    }
}
