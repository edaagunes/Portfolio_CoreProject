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
	public class ContactManager : IContactService
	{
		IContactDal _contactDal;

		public ContactManager(IContactDal contactDal)
		{
			_contactDal = contactDal;
		}

		public void TDelete(Contact entity)
		{
			throw new NotImplementedException();
		}

		public Contact TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Contact> TGetList()
		{
			return _contactDal.GetList();
		}

		public void TInsert(Contact entity)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Contact entity)
		{
			throw new NotImplementedException();
		}
	}
}
