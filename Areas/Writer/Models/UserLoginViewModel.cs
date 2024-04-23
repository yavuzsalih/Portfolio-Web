using System.ComponentModel.DataAnnotations;

namespace İlkProjem.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage ="Kullanıcı Adı Giriniz....!")]
        public string userName { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifreyi Giriniz....!")]
        public string password { get; set; }
    }
}
