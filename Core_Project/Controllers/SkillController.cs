using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
	public class SkillController : Controller
	{
		private readonly ISkillService _skillService;

		public SkillController(ISkillService skillService)
		{
			_skillService = skillService;
		}

		public IActionResult Index()
		{
			ViewBag.pageName = "Yetenekler";
			ViewBag.pageSubName = "Yetenek Listesi";

			var value = _skillService.TGetList();
			return View(value);
		}

		[HttpGet]
		public IActionResult AddSkill()
		{
			ViewBag.pageName = "Yetenekler";
			ViewBag.pageSubName = "Yetenek Ekleme";

			return View();
		}
		[HttpPost]
		public IActionResult AddSkill(Skill skill)
		{
			_skillService.TInsert(skill);
			return RedirectToAction("Index");
		}

		public IActionResult DeleteSkill(int id)
		{
			var values = _skillService.TGetById(id);
			_skillService.TDelete(values);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateSkill(int id)
		{
			ViewBag.pageName = "Yetenekler";
			ViewBag.pageSubName = "Yetenek Güncelleme";

			var values = _skillService.TGetById(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateSkill(Skill skill)
		{
			_skillService.TUpdate(skill);
			return RedirectToAction("Index");
		}
	}
}
