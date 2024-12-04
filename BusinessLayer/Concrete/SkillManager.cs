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
	public class SkillManager : ISkillService
	{
		ISkillDal _skillDal;

		public SkillManager(ISkillDal skillDal)
		{
			_skillDal = skillDal;
		}

		public void TDelete(Skill entity)
		{
			_skillDal.Delete(entity);
		}

		public Skill TGetById(int id)
		{
			return _skillDal.GetById(id);
		}

		public List<Skill> TGetList()
		{
			return _skillDal.GetList();
		}

		public void TInsert(Skill entity)
		{
			_skillDal.Insert(entity);
		}

		public void TUpdate(Skill entity)
		{
			_skillDal.Update(entity);
		}
	}
}
