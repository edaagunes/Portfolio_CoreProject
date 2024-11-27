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
	public class PortfolioManager : IPortfolioService
	{
		IPortfolioDal _portfolioDal;

		public PortfolioManager(IPortfolioDal portfolioDal)
		{
			_portfolioDal = portfolioDal;
		}

		public void TDelete(Portfolio entity)
		{
			throw new NotImplementedException();
		}

		public Portfolio TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Portfolio> TGetList()
		{
			return _portfolioDal.GetList();
		}

		public void TInsert(Portfolio entity)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Portfolio entity)
		{
			throw new NotImplementedException();
		}
	}
}
