namespace RazorDemo.Pages.Custoemers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Razor.Models;
    using Razor.Services;

    public class IndexModel : PageModel
    {
        public List<Customer> _customer;
        private readonly ICustomerRepository _customerRepository;
        public IndexModel(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public void OnGet()
        {
            _customer = (List<Customer>)_customerRepository.GetAllCustomers();
        }

    }
}