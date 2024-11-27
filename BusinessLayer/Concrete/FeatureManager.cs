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
	public class FeatureManager : IFeatureService
	{
		IFeatureDal _featureDal;

		public FeatureManager(IFeatureDal featureDal)
		{
			_featureDal = featureDal;
		}

		public void TDelete(Feature entity)
		{
			_featureDal.Delete(entity);
		}

		public Feature TGetById(int id)
		{
			return _featureDal.GetById(id);
		}

		public List<Feature> TGetList()
		{
			return _featureDal.GetList();
		}

		public void TInsert(Feature entity)
		{
			_featureDal.Insert(entity);
		}

		public void TUpdate(Feature entity)
		{
			_featureDal.Update(entity);
		}
	}
}
