
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace soru1.Pages
{
    public class Index1Model : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Lütfen birinci sayýyý giriniz.")]
        public double? Sayi1 { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Lütfen ikinci sayýyý giriniz.")]
        public double? Sayi2 { get; set; }

        // Sonuçlarý ekranda göstermek için deðiþkenler
        public double? Toplam { get; set; }
        public double? Carpim { get; set; }
        public bool IsPost { get; set; } = false;

        public void OnGet()
        {
            // Sayfa ilk yüklendiðinde çalýþýr
        }

        public void OnPost()
        {
            IsPost = true;

            if (Sayi1.HasValue && Sayi2.HasValue)
            {
                // Toplama ve Çarpma iþlemlerini yapýyoruz
                Toplam = Sayi1.Value + Sayi2.Value;
                Carpim = Sayi1.Value * Sayi2.Value;
            }
        }
    }
}