using System.ComponentModel.DataAnnotations;

namespace DotNetCoreCamp.Models
{
    public class UserSignInViewModel
    {
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz")]
        public string username { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen şifre giriniz")]
        public string password { get; set; }
    }
}
