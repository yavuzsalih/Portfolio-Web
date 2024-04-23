using Microsoft.Build.Framework;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace İlkProjem.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen adınızı giriniz!!")]
        public string? Name { get; set; }


        [Required(ErrorMessage = "Lütfen soyadınızı giriniz!!")]
        public string? SurName { get; set; }


        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz!!")]
        public string? UserName { get; set; }


        [Required(ErrorMessage = "Lütfen şifreyi giriniz!!")]
        public string? Password { get; set; }


        [Required(ErrorMessage = "Lütfen şifreyi tekrar girin!!")]
        [Compare("Password", ErrorMessage = "Şifreler uyumlu değil!!")]
        public string? ConfirmPassword { get; set; }


        [Required(ErrorMessage ="Lütfen mail giriniz!!")]
        
        public string? Mail { get; set; }


        [Required(ErrorMessage = "Lütfen Resim URL giriniz!!")]
        public string? ImageUrl { get; set; }

    }
}
