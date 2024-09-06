using BerilliumApp.DAL;
using BerilliumApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BerilliumApp.Areas.admin.Controllers
{
    [Area("admin")]
    public class CoruselController : Controller
    {
        private readonly HomeDbContext db;

        public CoruselController(HomeDbContext _db)
        {
            db = _db;
        }
        public async Task<IActionResult> Index()
        {
            List<Corusel> corusels = await db.Corusels.ToListAsync();

            return View(corusels);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Corusel corusel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            db.Corusels.Add(corusel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult>  Edit(int id)
        {
            var corusel = await db.Corusels.SingleOrDefaultAsync(x => x.Id == id);
            if (corusel == null)
            {
                return View();
            }
            return View(corusel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Corusel corusel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            db.Corusels.Update(corusel);
            await db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id)
        {
            var corusel = await db.Corusels.SingleOrDefaultAsync(x => x.Id == id);
            if (corusel == null)
            {
                return View();
            }
            db.Corusels.Remove(corusel);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
