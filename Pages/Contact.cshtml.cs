using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webapp.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }
        public string Hello { get; set; }

        public void OnGet()
        {
            Message = "Your Nssse Page.";
            Hello = "Interesting";
        }
    }
}
