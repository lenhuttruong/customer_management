using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manage_customer.DAO
{
    class Slot
    {
        private string _Id;
        private string _Name;
        private DateTime _Date;
        private string _Service;
        private string _Product;
        private string _Staff;
        private string _Note;

        public Slot(string Id, string Name, DateTime Date, string Service, string Product, string Staff, string Note)
        {
            this.Id = Id;
            this.Name = Name;
            this.Date = Date;
            this.Service = Service;
            this.Product = Product;
            this.Staff = Staff;
            this.Note = Note;
        }

        public string Id { get => _Id; set => _Id = value; }
        public string Name { get => _Name; set => _Name = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public string Service { get => _Service; set => _Service = value; }
        public string Product { get => _Product; set => _Product = value; }
        public string Staff { get => _Staff; set => _Staff = value; }
        public string Note { get => _Note; set => _Note = value; }
    }
}
