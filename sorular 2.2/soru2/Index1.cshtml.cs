using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace soru2.Pages
{
    public class Index1Model : PageModel
    {
        [BindProperty]
        public double Kenar { get; set; }

        public double Alan { get; set; }

        public double Cevre { get; set; }

        public bool Hesaplandi { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Alan = Kenar * Kenar;
            Cevre = 4 * Kenar;
            Hesaplandi = true;
        }
    }
}