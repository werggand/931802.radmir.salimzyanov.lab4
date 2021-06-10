using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace lab4.Models
{
    public class PrUserInf
    {
        [EmailAddress]
        [Required(ErrorMessage = "Заполните поле")]
        public string email { get; set; }
        [Required(ErrorMessage = "Заполните поле")]
        public string password { get; set; }
        [Compare("password", ErrorMessage = "Пароли не совпадают")]
        public string confirmPassword { get; set; }
    }
}
