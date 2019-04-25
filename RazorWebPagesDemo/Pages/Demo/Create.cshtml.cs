using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorWebPagesDemo.Pages.Demo
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public string Movie { get; set; }

        public IActionResult OnGet()
        {
            this.Movie = "star wars";
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var aoa = this.Movie;
            return RedirectToPage("./Index");
        }
    }
}