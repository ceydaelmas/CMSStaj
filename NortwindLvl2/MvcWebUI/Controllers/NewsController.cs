using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
	public class NewsController : Controller
	{
		public IActionResult News()
		{
			return View();
		}
	}
}
