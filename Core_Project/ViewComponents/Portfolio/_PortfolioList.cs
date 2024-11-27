using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Portfolio
{
	public class _PortfolioList : ViewComponent
	{
		private readonly IPortfolioService _portfolioService;

		public _PortfolioList(IPortfolioService portfolioService)
		{
			_portfolioService = portfolioService;
		}

		public IViewComponentResult Invoke()
		{
			var values=_portfolioService.TGetList();
			return View(values);
		}
	}
}
