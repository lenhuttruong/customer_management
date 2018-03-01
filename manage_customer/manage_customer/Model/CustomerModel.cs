using manage_customer.DAO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manage_customer.Model
{
    class CustomerModel
    {
        private static string customerPath = Directory.GetCurrentDirectory() + "\\customer.dat";
        public List<Customer> getAllCustomer()
        {
            List<Customer> result = new List<Customer>();
            List<string> data = new List<string>();
            try
            {
                data = FileAccess.readData(customerPath);
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Can not get customers !");
            }
            
            Customer customer;
            foreach (string line in data)
            {
                customer = new Customer(line);
                result.Add(customer);
            }
            return result;
        }

        public List<Customer> getBySearchString(string searchString)
        {
            List<Customer> result = new List<Customer>();
            List<string> data = new List<string>();
            try
            {
                data = FileAccess.findData(customerPath, searchString);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Can not find customer !");
            }

            Customer customer;
            foreach (string line in data)
            {
                customer = new Customer(line);
                result.Add(customer);
            }
            return result;
        }

        public Boolean addCustomer(Customer customer)
        {
            string str = customer.convertToString();
            try
            {
                FileAccess.insertData(customerPath, str);
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Can not add customer !");
                return false;
            }
            return true;
        }

        public Boolean editCustomer(Customer customer)
        {
            string str = customer.convertToString();
            try
            {
                FileAccess.editData(customerPath, customer.Id, str);
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Can not edit customer !");
                return false;
            }
            return true;
        }

        public Boolean deleteCustomer(string id)
        {
            try
            {
                FileAccess.deleteData(customerPath, id);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Can not delete customer !");
                return false;
            }
            return true;
        }
    }
}
