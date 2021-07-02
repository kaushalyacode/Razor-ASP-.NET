namespace RazorDemo.Pages.Custoemers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    public class IndexModel : PageModel
    {
        public List<String> Customers;
        public void OnGet()
        {
            this.Customers = new List<string>()
            {
                "kamal",
                "Amal",
                "Pabodha",
                "Dinesh"

            };
        }
    }
}