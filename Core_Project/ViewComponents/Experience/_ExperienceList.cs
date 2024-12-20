﻿using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Experience
{
	public class _ExperienceList:ViewComponent
	{
		private readonly IExperienceService _experienceService;

		public _ExperienceList(IExperienceService experienceService)
		{
			_experienceService = experienceService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _experienceService.TGetList();
			return View(values);
		}
	}
}
