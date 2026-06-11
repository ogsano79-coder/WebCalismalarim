using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace soru5.Pages
    {
        public class Index1Model : PageModel
        {
            [BindProperty]
            [Required(ErrorMessage = "1. sayýyý giriniz.")]
            public double? Sayi1 { get; set; }

            [BindProperty]
            [Required(ErrorMessage = "2. sayýyý giriniz.")]
            public double? Sayi2 { get; set; }

            [BindProperty]
            [Required(ErrorMessage = "3. sayýyý giriniz.")]
            public double? Sayi3 { get; set; }

            public string SonucMessage { get; set; } = string.Empty;

            public void OnGet()
            {
            }

            public void OnPost()
            {
                if (Sayi1.HasValue && Sayi2.HasValue && Sayi3.HasValue)
                {
                    // Math.Max fonksiyonu ile 3 sayýdan en büyüðünü buluyoruz
                    double enBuyuk = Math.Max(Sayi1.Value, Math.Max(Sayi2.Value, Sayi3.Value));

                    // Ýstenen formatta mesajý hazýrlýyoruz
                    SonucMessage = $"En büyük sayý: {enBuyuk}";
                }
            }
        }
    }