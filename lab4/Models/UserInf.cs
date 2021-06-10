using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace lab4.Models
{
    public class UserInf
    {
        [Required(ErrorMessage = "Заполните поле")]
        [StringLength(55, MinimumLength = 1, ErrorMessage = "Введите больше одной буквы")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Заполните поле")]
        [StringLength(55, MinimumLength = 1, ErrorMessage = "Введите больше одной буквы")]
        public string SecondName { get; set; }
        [Required(ErrorMessage = "Заполните поле")]
        [Range(1, 31, ErrorMessage = "Несуществующая дата")]
        public int Day { get; set; }
        [Required(ErrorMessage = "Заполните поле")]
        public string Month { get; set; }
        [Required(ErrorMessage = "Заполните поле")]
        [Range(1900, 2020, ErrorMessage = "Несуществующий год")]
        public string Year { get; set; }
        [Required(ErrorMessage = "Заполните поле")]
        public string Gender { get; set; }

        public List<SelectListItem> Mounts { get; } = new List<SelectListItem>
        {
                    new SelectListItem { Value ="January", Text ="January" },
                    new SelectListItem { Value ="February", Text ="February" },
                    new SelectListItem { Value ="March", Text ="March" },
                    new SelectListItem { Value ="April", Text ="April" },
                    new SelectListItem { Value ="May", Text ="May" },
                    new SelectListItem { Value ="June", Text ="June" },
                    new SelectListItem { Value ="July", Text ="July" },
                    new SelectListItem { Value ="August", Text ="August" },
                    new SelectListItem { Value ="September", Text ="September" },
                    new SelectListItem { Value ="October", Text ="October" },
                    new SelectListItem { Value ="November", Text ="November" },
                    new SelectListItem { Value ="December", Text ="December" }
        };
        public List<SelectListItem> Days { get; } = new List<SelectListItem>();
        public List<SelectListItem> Years { get; } = new List<SelectListItem>();
        public List<string> Genders { get; } = new List<string>();
        public UserInf()
        {
            for (int i = 1; i <= 31; i++)
            {
                this.Days.Add(new SelectListItem { Value = i.ToString(), Text = i.ToString() });
            }
            for (int i = 2020; i >= 1900; i--)
            {
                this.Years.Add(new SelectListItem { Value = i.ToString(), Text = i.ToString() });
            }
            Genders.Add("Male");
            Genders.Add("Female");
        }
    }
}
