using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPageMovie.Pages.Admin
{
    public class Form : PageModel
    {
        private readonly ILogger<Form> _logger;

        public Form(ILogger<Form> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}