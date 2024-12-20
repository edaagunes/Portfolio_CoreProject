﻿using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Skill
{
	public class _SkillList : ViewComponent
	{
		private readonly ISkillService _skillService;

		public _SkillList(ISkillService skillService)
		{
			_skillService = skillService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _skillService.TGetList();
			return View(values);
		}
	}
}
