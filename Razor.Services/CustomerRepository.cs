namespace Razor.Services
{
    using Razor.Models;
    using System.Collections.Generic;
    public class CustomerRepository :
                                     ICustomerRepository
    {
        private List<Customer> customers;
        public CustomerRepository()
        {
            customers = new List<Customer>()
            {
                        new Customer
                        { 
                          FirstName = "KAUSHALYA",
                          LastName  = "HARSHANATH",
                          Id        =  1
                        },
                        new Customer
                        {
                          FirstName = "KAUSHALYA2",
                          LastName  = "HARSHANATH2",
                          Id        =  2
                        },
                        new Customer
                        {
                          FirstName = "KAUSHALYA3",
                          LastName  = "HARSHANATH3",
                          Id        =  3
                        }
            };
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return this.customers;
        }
    }
}