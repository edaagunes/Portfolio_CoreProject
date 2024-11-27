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
	public class ServiceManager : IServiceService
	{
		IServiceDal _serviceDal;

		public ServiceManager(IServiceDal serviceDal)
		{
			_serviceDal = serviceDal;
		}

		public void TDelete(Service entity)
		{
			throw new NotImplementedException();
		}

		public Service TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Service> TGetList()
		{
			return _serviceDal.GetList();
		}

		public void TInsert(Service entity)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Service entity)
		{
			throw new NotImplementedException();
		}
	}
}
