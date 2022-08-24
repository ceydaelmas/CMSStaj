using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
	public class NewsDetailController : Controller
	{
		public IActionResult NewsDetail()
		{
			return View();
		}
	}
}
