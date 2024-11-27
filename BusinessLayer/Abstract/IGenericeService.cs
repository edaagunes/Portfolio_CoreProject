﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IGenericeService<T>
	{
		void TInsert(T entity);
		void TDelete(T entity);
		void TUpdate(T entity);
		List<T> TGetList();
		T TGetById(int id);
	}
}