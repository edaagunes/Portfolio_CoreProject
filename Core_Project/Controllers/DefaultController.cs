using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_Project.Controllers
{
	public class DefaultController : Controller
	{
		private readonly IMessageService _messageService;

		public DefaultController(IMessageService messageService)
		{
			_messageService = messageService;
		}

		public IActionResult Index()
		{
			return View();
		}

		public PartialViewResult HeaderPartial()
		{
			return PartialView();
		}

		public PartialViewResult NavbarPartial()
		{
			return PartialView();
		}

		[HttpGet]
		public PartialViewResult SendMessagePartial()
		{
			return PartialView();
		}
		[HttpPost]
		public IActionResult SendMessagePartial(Message message)
		{
			message.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			message.Status = true;
			_messageService.TInsert(message);
			return RedirectToAction("Index","Default");
		}
	}
}
