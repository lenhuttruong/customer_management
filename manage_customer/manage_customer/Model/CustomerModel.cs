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
        public List<Customer> getAllCustomer()
        {
            List<Customer> result = new List<Customer>();
            List<string> data = new List<string>();
            data = FileAccess.readData(customerPath);
            Customer customer;
            foreach (string line in data)
            {
                customer = new Customer(line);
                result.Add(customer);
            }
            return result;
        }
    }
}
