﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class ExperienceManager : IExperienceService
	{
		IExperienceDal _experienceDal;

		public ExperienceManager(IExperienceDal experienceDal)
		{
			_experienceDal = experienceDal;
		}

		public void TDelete(Experience entity)
		{
			throw new NotImplementedException();
		}

		public Experience TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Experience> TGetList()
		{
			return _experienceDal.GetList();
		}

		public void TInsert(Experience entity)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Experience entity)
		{
			throw new NotImplementedException();
		}
	}
}