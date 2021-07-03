namespace Razor.Demo.Pages.Customers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Razor.Models;
    using Razor.Services;

    public class InfoModel : PageModel
    {
        private readonly ICustomerRepository _customerRepository;
        public Customer customer { get; private set; }
        public InfoModel(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        [BindProperty(SupportsGet = true)]
        public int id { get; set; }
        public IActionResult OnGet(int Id)
        {
            customer =
                 _customerRepository.GetCustomer(Id);
            if (id.Equals(0))
            {
                return RedirectToPage("/NotFound");
            }
            else
            {
                return Page();
            }
        }
    }
}