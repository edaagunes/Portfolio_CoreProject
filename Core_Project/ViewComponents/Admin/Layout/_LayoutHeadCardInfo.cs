using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Admin.Layout
{
	public class _LayoutHeadCardInfo:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
