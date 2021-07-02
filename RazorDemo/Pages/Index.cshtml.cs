namespace RazorDemo.Pages
{
    using System;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Logging;
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string demoMessege { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            this.demoMessege = $"first messege : hello world {DateTime.Now}";
        }
    }
}