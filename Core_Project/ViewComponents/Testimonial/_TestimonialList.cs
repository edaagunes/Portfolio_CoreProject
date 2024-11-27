using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Testimonial
{
	public class _TestimonialList:ViewComponent
	{
		private readonly ITestimonialService _testimonialService;

		public _TestimonialList(ITestimonialService testimonialService)
		{
			_testimonialService = testimonialService;
		}

		public IViewComponentResult Invoke()
		{
			var values=_testimonialService.TGetList();
			return View(values);
		}
	}
}
