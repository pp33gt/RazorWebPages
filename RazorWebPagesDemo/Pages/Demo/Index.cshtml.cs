using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorWebPagesDemo.Pages.Demo
{
    public class IndexModel : PageModel
    {
        public string Title { get; private set; }

        private ILogging _Logging = null;

        public IndexModel(ILogging logging)
        {
            _Logging = logging;
        }


        public void OnGet()
        {
            this.Title = "RazorDemoModel";

            _Logging.Log("In RazorDemoModel");
        }
    }
}