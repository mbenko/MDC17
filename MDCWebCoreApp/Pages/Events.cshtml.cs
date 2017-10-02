using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MDCWebCoreApp.Pages
{
    public class EventsModel : PageModel
    {

        public string Greeting { get; set; }
        public void OnGet()
        {
            Greeting = "Welcome to my Site - " + DateTime.UtcNow.ToLongDateString();
        }
    }
}