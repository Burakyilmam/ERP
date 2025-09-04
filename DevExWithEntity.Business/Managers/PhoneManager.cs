using DevExWithEntity.Business.Services;
using DevExWithEntity.DataAccess.DALs;
using DevExWithEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevExWithEntity.Business.Managers
{
    public class PhoneManager : IPhoneService
    {
        private readonly IPhoneDAL _phoneDAL;

        public PhoneManager(IPhoneDAL phoneDAL)
        {
            _phoneDAL = phoneDAL;
        }

        public void Add(Phone t)
        {
            _phoneDAL.Add(t);
        }

        public void Delete(Phone t)
        {
            _phoneDAL.Delete(t);
        }

        public Phone GetById(int Id)
        {
            return _phoneDAL.GetById(Id);
        }

        public List<Phone> List(Expression<Func<Phone, bool>> filter = null, Func<IQueryable<Phone>, IOrderedQueryable<Phone>> orderBy = null, int? take = null)
        {
            return _phoneDAL.List(filter, orderBy, take);
        }

        public List<Phone> ListAll()
        {
            return _phoneDAL.ListAll();
        }

        public void Update(Phone t)
        {
            _phoneDAL.Update(t);
        }
    }
}
