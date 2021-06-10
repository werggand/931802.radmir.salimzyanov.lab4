using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lab4.Models;

namespace lab4.Controllers
{
    public class ToolController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CheckBox()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckBox(bool isSelected)
        {
            ViewBag.Title = "CheckBox";
            ViewBag.Type = "isSelected: ";
            ViewBag.Message = isSelected ? "true" : "false";

            return View("Result");
        }
        [HttpGet]
        public IActionResult DropDown()
        {
            return View(Month.Instance);
        }
        [HttpPost]
        public IActionResult DropDown(bool selected)
        {
            ViewBag.Title = "DropDown";
            ViewBag.Type = "Months: ";
            ViewBag.Message = Request.Form["months"];

            return View("Result");
        }
        [HttpGet]
        public IActionResult ListBox()
        {
            return View(Month.Instance);
        }
        [HttpPost]
        public IActionResult ListBox(bool selected)
        {
            ViewBag.Title = "ListBox";
            ViewBag.Type = "Months: ";
            ViewBag.Message = Request.Form["months"];

            return View("Result");
        }
        [HttpGet]
        public IActionResult Radio()
        {
            return View(Month.Instance);
        }
        [HttpPost]
        public IActionResult Radio(bool selected)
        {
            ViewBag.Title = "Radio";
            ViewBag.Type = "Months: ";
            ViewBag.Message = Request.Form["months"];

            return View("Result");
        }
        [HttpGet]
        public IActionResult TextArea()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TextArea(string text)
        {
            ViewBag.Title = "TextArea";
            ViewBag.Type = "Text: ";
            ViewBag.Message = text;

            return View("Result");
        }
        [HttpGet]
        public IActionResult TextBox()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TextBox(string text)
        {
            ViewBag.Title = "TextBox";
            ViewBag.Type = "Text: ";
            ViewBag.Message = text;

            return View("Result");
        }
    }
}

