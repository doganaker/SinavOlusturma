using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SinavOlusturma.Models.VM
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Kullanıcı Adınızı Giriniz!")]
        [Display(Name ="Kullanıcı Adı")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Şifrenizi Giriniz!")]
        [Display(Name ="Şifre")]
        public string Password { get; set; }
    }
}
