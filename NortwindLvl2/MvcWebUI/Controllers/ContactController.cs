﻿using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Contact()
		{
			return View();
		}
	}
}
