using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.About
{
	public class _AboutList : ViewComponent
	{
		private readonly IAboutService _aboutService;

		public _AboutList(IAboutService aboutService)
		{
			_aboutService = aboutService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _aboutService.TGetList();
			return View(values);
		}
	}
}
