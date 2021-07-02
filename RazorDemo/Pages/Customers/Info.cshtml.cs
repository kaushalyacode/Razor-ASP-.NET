using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor.Models;
using Razor.Services;

namespace Razor.Demo.Pages.Customers
{
    public class InfoModel : PageModel
    {
        private readonly ICustomerRepository _customerRepository;
        public Customer customer { get; private set;}
        public InfoModel(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public void OnGet(int Id)
        {
           customer =
                _customerRepository.GetCustomer(Id);
        }
    }
}
