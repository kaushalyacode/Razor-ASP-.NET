using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorDemo.Pages.Custoemers
{
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
