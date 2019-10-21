using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ENGLISH.Controllers
{
    public class EnglishController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Wellcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}