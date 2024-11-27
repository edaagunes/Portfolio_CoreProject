using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Feature
{
	public class _FeatureList : ViewComponent
	{
		private readonly IFeatureService _featureService;

		public _FeatureList(IFeatureService featureService)
		{
			_featureService = featureService;
		}

		public IViewComponentResult Invoke()
		{
			var values=_featureService.TGetList();
			return View(values);
		}
	}
}
