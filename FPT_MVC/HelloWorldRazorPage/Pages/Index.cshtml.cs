using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HelloWorldRazorPage.Models;

namespace HelloWorldRazorPage.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public AppMessage Heading { get; set; }

        public string SubHeading { get; set; }
        public void OnGet()
        {
            this.Heading = new AppMessage();
            this.Heading.Title2 = "Hello World Razor Page!";
        }

        public void OnPost()
        {
            this.SubHeading = "Message Changed";
        }
    }
}
