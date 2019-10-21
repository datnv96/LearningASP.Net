using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var test = await _context.Test
                .FirstOrDefaultAsync(m => m.Id == id);
            if (test == null)
            {
                return NotFound();
            }

            return View(test);
        }
    }
}