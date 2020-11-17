using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloRezerPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloRezerPage.Page
{
    public class _ViewImportsModel : PageModel
    {
        [BindProperty]
        public AppMessage Heading { get; set; }

        public string SubHeadinh { get; set; }
        public void OnGet()
        {
            this.Heading = new AppMessage();
            this.Heading.Message = "Hello World Razor Page!";
        }

        public void OnPost()
        {
            this.SubHeadinh = "Message Changed";
        }
    }
}
