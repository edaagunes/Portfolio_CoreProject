using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
	public class ExperienceController : Controller
	{
		private readonly IExperienceService _experienceService;

		public ExperienceController(IExperienceService experienceService)
		{
			_experienceService = experienceService;
		}

		public IActionResult Index()
		{
			ViewBag.pageName = "Deneyimler";
			ViewBag.pageSubName = "Deneyim Listesi";
			var values = _experienceService.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddExperience()
		{
			ViewBag.pageName = "Deneyimler";
			ViewBag.pageSubName = "Deneyim Ekleme";
			return View();
		}
		[HttpPost]
		public IActionResult AddExperience(Experience experience)
		{
			_experienceService.TInsert(experience);
			return RedirectToAction("Index");
		}

		public IActionResult DeleteExperience(int id)
		{
			var values=_experienceService.TGetById(id);
			_experienceService.TDelete(values);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult UpdateExperience(int id)
		{
			ViewBag.pageName = "Deneyimler";
			ViewBag.pageSubName = "Deneyim Güncelleme";
			var values = _experienceService.TGetById(id);
			return View(values);
		}

		[HttpPost]
		public IActionResult UpdateExperience(Experience experience)
		{
			_experienceService.TUpdate(experience);
			return RedirectToAction("Index");
		}
	}
}
