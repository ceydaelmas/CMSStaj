using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
	public class ResumeController : Controller
	{
		public IActionResult Resume()
		{
			return View();
		}
	}
}
