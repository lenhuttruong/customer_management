using manage_customer.DAO;
using manage_customer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manage_customer.Controller
{
    class CustomerController
    {
        CustomerModel customerModel = new CustomerModel();
        public List<Customer>  getAllCustomer()
        {
            return customerModel.getAllCustomer();
        }

        public List<Customer> getBySearchString(string searchString)
        {
            return customerModel.getBySearchString(searchString);
        }

        public Boolean addCustomer(Customer customer)
        {
            return customerModel.addCustomer(customer);
        }

        public Boolean editCustomer(Customer customer)
        {
            return customerModel.editCustomer(customer);
        }

        public Boolean deleteCustomer(string id)
        {
            return customerModel.deleteCustomer(id);
        }

    }
}
