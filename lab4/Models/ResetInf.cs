using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace lab4.Models
{
    public class ResetInf
    {
        [EmailAddress]
        [Required(ErrorMessage = "Заполните поле")]
        public string email { get; set; }
    }
}
