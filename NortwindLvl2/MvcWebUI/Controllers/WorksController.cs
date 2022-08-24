using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
	public class WorksController : Controller
	{
		public IActionResult Works()
		{
			return View();
		}
	}
}
