using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Contact
{
	public class _ContactList:ViewComponent
	{
		private readonly IContactService _contactService;

		public _ContactList(IContactService contactService)
		{
			_contactService = contactService;
		}

		public IViewComponentResult Invoke()
		{
			var values =_contactService.TGetList();
			return View(values);
		}
	}
}
