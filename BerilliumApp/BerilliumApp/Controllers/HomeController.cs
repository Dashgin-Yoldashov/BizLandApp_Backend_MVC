using BerilliumApp.DAL;
using BerilliumApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BerilliumApp.Controllers
{
    public class HomeController : Controller
    {
		private readonly HomeDbContext db;

		public HomeController(HomeDbContext _db)
		{
			db = _db;
		}

		public async Task<IActionResult> Index()
        {
            HomeViewModel hvm = new HomeViewModel() {
                Corusels = await db.Corusels.ToListAsync(),
                Locations = await db.Locations.ToListAsync(),
                News = await db.News.OrderByDescending((n)=>n.Date).Take(3).ToListAsync(),
                Testimonials = await db.Testimonials.ToListAsync(),
                Sections = await db.Sections.ToListAsync(),
            };
            return View(hvm);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
