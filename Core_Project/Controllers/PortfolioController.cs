using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
	public class PortfolioController : Controller
	{
		private readonly IPortfolioService _portfolioService;

		public PortfolioController(IPortfolioService portfolioService)
		{
			_portfolioService = portfolioService;
		}

		public IActionResult Index()
		{
			var values = _portfolioService.TGetList();
			return View(values);
		}

		[HttpGet]
		public IActionResult AddPortfolio()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddPortfolio(Portfolio portfolio)
		{
			PortfolioValidator validationRules = new PortfolioValidator();
			ValidationResult validationResult = validationRules.Validate(portfolio);

			if (validationResult.IsValid)
			{
				_portfolioService.TInsert(portfolio);
				return RedirectToAction("Index");
			}
			else
			{
				foreach (var item in validationResult.Errors)
				{
						ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}			
			}
			return View();
		}
		public IActionResult DeletePortfolio(int id)
		{
			var values = _portfolioService.TGetById(id);
			_portfolioService.TDelete(values);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdatePortfolio(int id)
		{
			var values = _portfolioService.TGetById(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdatePortfolio(Portfolio portfolio)
		{
			_portfolioService.TUpdate(portfolio);
			return RedirectToAction("Index");
		}
	}
}
