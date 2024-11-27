using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Service
{
	public class _ServiceList : ViewComponent
	{
		private readonly IServiceService _serviceService;

		public _ServiceList(IServiceService serviceService)
		{
			_serviceService = serviceService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _serviceService.TGetList();
			return View(values);
		}
	}
}
