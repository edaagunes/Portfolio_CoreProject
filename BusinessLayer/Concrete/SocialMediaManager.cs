using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class SocialMediaManager : ISocialMediaService
	{
		ISocialMediaDal _socialMediaDal;

		public SocialMediaManager(ISocialMediaDal socialMediaDal)
		{
			_socialMediaDal = socialMediaDal;
		}

		public void TDelete(SocialMedia entity)
		{
			throw new NotImplementedException();
		}

		public SocialMedia TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<SocialMedia> TGetList()
		{
			return _socialMediaDal.GetList();	
		}

		public void TInsert(SocialMedia entity)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(SocialMedia entity)
		{
			throw new NotImplementedException();
		}
	}
}
