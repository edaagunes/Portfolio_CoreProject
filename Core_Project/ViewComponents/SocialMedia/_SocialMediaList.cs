using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.SocialMedia
{
	public class _SocialMediaList : ViewComponent
	{
		ISocialMediaService _socialMediaService;

		public _SocialMediaList(ISocialMediaService socialMediaService)
		{
			_socialMediaService = socialMediaService;
		}

		public IViewComponentResult Invoke()
		{
			var values=_socialMediaService.TGetList();
			return View(values);
		}
	}
}
