using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BikeForLife.Web.Pages.Errors
{
    public class IndexModel : PageModel
    {
        public string ErrorMessage { get; set; }
        public void OnGet(string errorCode)
        {
            switch (errorCode)
            {
                case "404":
                    ErrorMessage = "Den søgte side kunne ikke findes.";
                    break;
                default:
                    ErrorMessage = $"Der opstod en ukendt fejl. Fejlkoden var {errorCode}.";
                    break;
            }
        }
    }
}