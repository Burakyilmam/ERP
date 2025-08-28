using DevExWithEntity.Business.Services;
using DevExWithEntity.DataAccess.DALs;
using DevExWithEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DevExWithEntity.Business.Managers
{
    public class TabManager : ITabService
    {
        private readonly ITabDAL _tabDAL;

        public TabManager(ITabDAL tabDAL)
        {
            _tabDAL = tabDAL;
        }

        public void Add(Tab t)
        {
            _tabDAL.Add(t);
        }

        public void Delete(Tab t)
        {
            _tabDAL.Delete(t);
        }

        public Tab GetById(int Id)
        {
            return _tabDAL.GetById(Id);
        }

        public List<Tab> ListAll()
        {
            return _tabDAL.ListAll();
        }

        public List<Tab> List(Expression<Func<Tab, bool>> filter = null, Func<IQueryable<Tab>, IOrderedQueryable<Tab>> orderBy = null, int? take = null)
        {
            return _tabDAL.List(filter, orderBy, take);
        }

        public void Update(Tab t)
        {
            _tabDAL.Update(t);
        }
    }
}
