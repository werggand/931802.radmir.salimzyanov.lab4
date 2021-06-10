using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lab4.Models;
using System.ComponentModel.DataAnnotations;

namespace lab4.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AuthView()
        {
            User model = new User();
            model.UserInfModel = new UserInf();
            ViewBag.Private = "none";
            return View(model);
        }
        [HttpPost]
        public IActionResult AuthView(User model, string action)
        {
            List<ValidationResult> validResults = new List<ValidationResult>();
            if (action == "signUp")
            {
                Validator.TryValidateObject(model.UserInfModel, new ValidationContext(model.UserInfModel), validResults, true);
                if (validResults.Count() == 0)
                {
                    ViewBag.Public = "none";
                    ModelState.Clear();
                    return View(model);
                }
                else
                {
                    ViewBag.Private = "none";
                    return View(model);
                }
            }
            else
            {
                validResults.Clear();
                Validator.TryValidateObject(model.PrUserInfModel, new ValidationContext(model.PrUserInfModel), validResults, true);
                if (validResults.Count() == 0)
                    return View("AuthCompleteView", model);
                else
                {
                    ViewBag.Public = "none";
                    return View(model);
                }
            }
        }

        public IActionResult AuthCompleteView()
        {
            return View();
        }
    }
}
