using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lab4.Models;

namespace lab4.Controllers
{
    public class ResetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ResetView(ResetInf model, string submit)
        {
            if (submit == "send" || submit == "have")
            {
                if (!ModelState.IsValid)
                    return View();

                Code modelCode = new Code();
                modelCode.code = modelCode.GetCode(5);
                return View("CodeView", modelCode);
            }
            return View();
        }
        public IActionResult Verify(Code model)
        {
            if (!TryValidateModel(model, nameof(model)))
            {
                return View("CodeView", model);
            }
            return View("DoneView");
        }
    }
}
