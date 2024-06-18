using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DewanAssessment.mvc.Views.Shared
{
    public class _offCanvas : PageModel
    {
        private readonly ILogger<_offCanvas> _logger;

        public _offCanvas(ILogger<_offCanvas> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}