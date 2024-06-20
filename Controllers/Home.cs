//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using Pen.Data;
//using Pen.Models;

//namespace Pen.Controllers
//{
//    public class Home : Controller
//    {
//        private readonly PenContext _context;

//        public Home(PenContext context)
//        {
//            _context = context;
//        }

//        // GET: Pens
//        //public async Task<IActionResult> Index()
//        //{
//        //    return _context.Pens != null ?
//        //                View(await _context.Pens.ToListAsync()) :
//        //                Problem("Entity set 'PenContext.Pens'  is null.");
//        //}
//        public IActionResult Index()
//        {
//            return View();
//        }
//        public IActionResult Aboutus()
//        {
//            return View();
//        }
        
//        // GET: Pens/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null || _context.Pens == null)
//            {
//                return NotFound();
//            }

//            var pens = await _context.Pens
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (pens == null)
//            {
//                return NotFound();
//            }

//            return View(pens);
//        }

//        // GET: Pens/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: Pens/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("Id,Name,InkType,Year,Color,Material,Retractable,Price")] Pens pens)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(pens);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(pens);
//        }

//        // GET: Pens/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null || _context.Pens == null)
//            {
//                return NotFound();
//            }

//            var pens = await _context.Pens.FindAsync(id);
//            if (pens == null)
//            {
//                return NotFound();
//            }
//            return View(pens);
//        }

//        // POST: Pens/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,InkType,Year,Color,Material,Retractable,Price")] Pens pens)
//        {
//            if (id != pens.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(pens);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!PensExists(pens.Id))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            return View(pens);
//        }

//        // GET: Pens/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null || _context.Pens == null)
//            {
//                return NotFound();
//            }

//            var pens = await _context.Pens
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (pens == null)
//            {
//                return NotFound();
//            }

//            return View(pens);
//        }

//        // POST: Pens/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            if (_context.Pens == null)
//            {
//                return Problem("Entity set 'PenContext.Pens'  is null.");
//            }
//            var pens = await _context.Pens.FindAsync(id);
//            if (pens != null)
//            {
//                _context.Pens.Remove(pens);
//            }

//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool PensExists(int id)
//        {
//            return (_context.Pens?.Any(e => e.Id == id)).GetValueOrDefault();
//        }
//    }
//}
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Pen.Models;

namespace Pen.Controllers
{
    public class Home : Controller
    {
        private readonly ILogger<Home> _logger;

        public Home(ILogger<Home> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Aboutus()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

