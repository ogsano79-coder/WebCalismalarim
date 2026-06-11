using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace soru4.Pages
{
    public class Index1Model: PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Lütfen yaþýnýzý giriniz.")]
        public int? Yas { get; set; }

        public string SonucMessage { get; set; } = string.Empty;

        public void OnGet()
        {
            // Sayfa ilk açýldýðýnda boþ kalacak
        }

        public void OnPost()
        {
            // Form gönderildiðinde çalýþacak kontrol bloðu
            if (Yas.HasValue)
            {
                if (Yas.Value < 18)
                {
                    SonucMessage = "Reþit Deðilsiniz";
                }
                else
                {
                    SonucMessage = "Reþitsiniz";
                }
            }
        }
    }
}