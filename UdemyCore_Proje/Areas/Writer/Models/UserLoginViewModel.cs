using System.ComponentModel.DataAnnotations;

namespace UdemyCore_Proje.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage ="Kullanıcı Adını Giriniz...!")]
        public string Username { get; set; }



        [Display(Name ="Şifre")]
        [Required(ErrorMessage ="Şifreyi Giriniz...!")]
        public string Password { get; set; }
    }
}
