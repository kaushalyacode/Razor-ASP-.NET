namespace Razor.Services
{
    using Razor.Models;
    using System.Collections.Generic;

    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomer(int id);

    }
}