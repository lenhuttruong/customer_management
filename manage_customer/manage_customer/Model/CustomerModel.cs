using manage_customer.DAO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manage_customer.Model
{
    class CustomerModel
    {
        private static string customerPath = Directory.GetCurrentDirectory();
        public Customer[] getAllCustomer()
        {
            List<string> data = new List<string>();
            data = FileAccess.readData(customerPath);
            return null;
        }
    }
}
