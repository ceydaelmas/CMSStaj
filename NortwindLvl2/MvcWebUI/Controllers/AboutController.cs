using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
	public class AboutController : Controller
	{

		public IActionResult About()
		{
			return View();
		}
	}
}
