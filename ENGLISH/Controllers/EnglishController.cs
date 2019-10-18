using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ENGLISH.Controllers
{
    public class EnglishController : Controller
    {
        public string Wellcome(string name, int ID = 1)
        {
            return System.Text.Encodings.Web.HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}