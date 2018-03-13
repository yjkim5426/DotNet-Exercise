using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace WebApplication_test.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            //Message = "Your application description page.";
            string directory = Environment.CurrentDirectory;
            Message = String.Format("Your directory is {0}.", directory);
        }
    }
}
