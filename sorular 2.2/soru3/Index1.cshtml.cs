using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace soru3.Pages
{
    public class Index1Model : PageModel
    {
        [BindProperty]
        public int? Sayi { get; set; }

        public string SonucMessage { get; set; } = string.Empty;

        public void OnGet()
        {
            // Sayfa ilk yüklendiðinde çalýþýr
        }

        public void OnPost()
        {
            // Form gönderildiðinde (Post edildiðinde) çalýþýr
            if (Sayi.HasValue)
            {
                if (Sayi.Value % 2 == 0)
                {
                    SonucMessage = $"Girdiðiniz sayý ({Sayi.Value}) bir ÇÝFT sayýdýr.";
                }
                else
                {
                    SonucMessage = $"Girdiðiniz sayý ({Sayi.Value}) bir TEK sayýdýr.";
                }
            }
            else
            {
                SonucMessage = "Lütfen geçerli bir sayý giriniz.";
            }
        }
    }
}
