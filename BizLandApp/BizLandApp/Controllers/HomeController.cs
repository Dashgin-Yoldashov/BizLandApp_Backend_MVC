using BizLandApp.DAL;
using BizLandApp.Models;
using BizLandApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BizLandApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;

        public HomeController(AppDbContext _db)
        {
            db = _db;
        }

        public async Task<IActionResult> Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                abouts = await db.abouts.ToListAsync(),
                aboutlists = await db.aboutlists.ToListAsync(),
                categories = await db.categories.ToListAsync(),
                clients = await db.clients.ToListAsync(),
                counters = await db.counters.ToListAsync(),
                homeHeroes = await db.homeHeroes.ToListAsync(),
                products = await db.products.ToListAsync(),
                services = await db.services.ToListAsync(),
                testimonials = await db.testimonials.ToListAsync(),
                teams = await db.teams.ToListAsync(),
                pricings = await db.pricings.ToListAsync(),
                faqs = await db.faqs.ToListAsync(),
                skills = await db.skills.ToListAsync(),
                contacts = await db.contacts.ToListAsync(),
                contacthead = await db.contactheads.ToListAsync(),
                sectionHeaders = await db.sectionHeaders.ToListAsync(),

            };
            return View(homeViewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
