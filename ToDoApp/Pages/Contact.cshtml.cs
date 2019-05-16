using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ToDoApp.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }
        public string TodayDate{ get; set; }
        public string EmailAdress { get; set; }

        public void OnGet()
        {
            Message = "Contact data:";
            TodayDate = DateTime.Today.ToString("d");
            EmailAdress = "lukasz@kapinski.pl";
        }

        public string GetDate()
        {
            return TodayDate;
        }
      
    }
}
