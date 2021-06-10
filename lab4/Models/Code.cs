using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace lab4.Models
{
    public class Code
    {
        [Required(ErrorMessage = "Заполните поле")]
        public string code { get; set; }
        [Compare("code", ErrorMessage = "Код не совпадает")]
        public string confirmCode { get; set; }

        public string GetCode(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
