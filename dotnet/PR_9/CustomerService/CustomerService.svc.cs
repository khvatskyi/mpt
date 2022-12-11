using System.Collections.Generic;

namespace CustomerService
{
    public class CustomerService : ICustomerService
    {
        public List<Customer> GetCustomerList()
        {
            return PopulateCustomerData();
        }

        private List<Customer> PopulateCustomerData()
        {
            List<Customer> customers = new List<Customer>();

            Customer customer1 = new Customer
            {
                CustomerId = 1,
                FirstName = "John",
                LastName = "Meaney",
                Address = "Chicago"
            };
            customers.Add(customer1);

            Customer customer2 = new Customer
            {
                CustomerId = 2,
                FirstName = "Peter",
                LastName = "Shaw",
                Address = "New York"
            };
            customers.Add(customer2);

            return customers;
        }
    }
}
