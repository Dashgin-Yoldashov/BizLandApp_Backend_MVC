using Microsoft.AspNetCore.Mvc;

namespace BerilliumApp.Areas.admin.Controllers
{
	public class HomeController : Controller
	{
		[Area("admin")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
