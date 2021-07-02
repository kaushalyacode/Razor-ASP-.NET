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
            this.customers = new List<Customer>()
            {
                        new Customer
                        { 
                          FirstName = "KAUSHALYA",
                          LastName  = "HARSHANATH",
                          Id        =  1,
                          imagePath ="image1.png"
                        },
                        new Customer
                        {
                          FirstName = "KAUSHALYA2",
                          LastName  = "HARSHANATH2",
                          Id        =  2,
                          imagePath ="image1.png"
                        },
                        new Customer
                        {
                          FirstName = "KAUSHALYA3",
                          LastName  = "HARSHANATH3",
                          Id        =  3,
                          imagePath ="image1.png"
                        }
            };
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return this.customers;
        }
        public Customer GetCustomer(int id)
        {
            return new Customer { 
                FirstName="moke first name",
                LastName ="moke lastname",
                Id=1
            };
        }
    }
}