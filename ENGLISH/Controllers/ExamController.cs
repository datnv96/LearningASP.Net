using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using ENGLISH.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ENGLISH.Controllers
{
    public class ExamController : Controller
    {
        private readonly TestContext _context;

        public ExamController(TestContext context)
        {
            _context = context;
        }


       [HttpGet]
       public async Task<IActionResult> Check(int ID, int Answer)
        {
            var test = await _context.Test
                .FirstOrDefaultAsync(m => m.Id == ID);

            if (test.RightAnswer == Answer)
            {
                ViewData["notification"] = "Right!";
            }
            else ViewData["notification"] = "Wrong!";

            return View(test);
        }
        public async Task<IActionResult> Index(int? Id)
        {
            if (Id == null)
            {
                var test = await _context.Test
                .FromSqlRaw("select * from dbo.Test").OrderBy(id => id.Id)
                .FirstOrDefaultAsync();

                if (test == null)
                {
                    return NotFound();
                }
                return View(test);
            }
            else
            {
                var testWithId = await _context.Test
                    .FirstOrDefaultAsync(id => id.Id == Id);
                if (testWithId == null)
                {
                    return NotFound();
                }
                return View(testWithId);
            }
        }
    }
}