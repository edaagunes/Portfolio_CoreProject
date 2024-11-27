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
	public class MessageManager : IMessageService
	{
		IMessageDal _messageDal;

		public MessageManager(IMessageDal messageDal)
		{
			_messageDal = messageDal;
		}

		public void TDelete(Message entity)
		{
			throw new NotImplementedException();
		}

		public Message TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Message> TGetList()
		{
			return _messageDal.GetList();
		}

		public void TInsert(Message entity)
		{
			_messageDal.Insert(entity);
		}

		public void TUpdate(Message entity)
		{
			throw new NotImplementedException();
		}
	}
}
