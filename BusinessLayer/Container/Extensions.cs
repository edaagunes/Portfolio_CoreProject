using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
	public static class Extensions
	{
		public static void ContainerDependencies(this IServiceCollection services)
		{
			services.AddScoped<IFeatureService,FeatureManager>();
			services.AddScoped<IFeatureDal,EfFeatureDal>();

			services.AddScoped<IPortfolioService, PortfolioManager>();
			services.AddScoped<IPortfolioDal, EfPortfolioDal>();

			services.AddScoped<IAboutService, AboutManager>();
			services.AddScoped<IAboutDal, EfAboutDal>();

			services.AddScoped<IServiceService, ServiceManager>();
			services.AddScoped<IServiceDal, EfServiceDal>();

			services.AddScoped<ISkillService, SkillManager>();
			services.AddScoped<ISkillDal, EfSkillDal>();

			services.AddScoped<IContactService, ContactManager>();
			services.AddScoped<IContactDal, EfContactDal>();

			services.AddScoped<IMessageService, MessageManager>();
			services.AddScoped<IMessageDal, EfMessageDal>();

			services.AddScoped<IExperienceService, ExperienceManager>();
			services.AddScoped<IExperienceDal, EfExperienceDal>();

			services.AddScoped<ISocialMediaService, SocialMediaManager>();
			services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();

			services.AddScoped<ITestimonialService, TestimonialManager>();
			services.AddScoped<ITestimonialDal, EfTestimonialDal>();


		}
	}
}
