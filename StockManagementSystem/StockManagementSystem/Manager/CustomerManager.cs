using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;
using StockManagementSystem.Repository;

namespace StockManagementSystem.Manager
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository=new CustomerRepository();

        public bool AddCustomer(Customer customer)
        {
            return _customerRepository.AddCustomer(customer);
        }

        public bool UpdateCustomer(Customer customer)
        {
            return _customerRepository.UpdateCustomer(customer);
        }

        public bool UniqueCode(Customer customer)
        {
            return _customerRepository.UniqueCode(customer);
        }

        public List<Customer> GetAllCustomer()
        {
            return _customerRepository.GetAllCustomer();
        }

        public List<Customer> GetAllCustomerForComboBox()
        {
            return _customerRepository.GetAllCustomerForComboBox();
        }

        public double GetCustomerLoyaltyPointById(int id)
        {
            return _customerRepository.GetCustomerLoyaltyPointById(id);
        }
        public string GetLastProductCode()
        {
            return _customerRepository.GetLastProductCode();
        }
    }
}
