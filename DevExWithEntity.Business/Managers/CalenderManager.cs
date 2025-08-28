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
    public class CalenderManager : ICalenderService
    {
        private readonly ICalenderDAL _calenderDAL;

        public CalenderManager(ICalenderDAL calenderDAL)
        {
            _calenderDAL = calenderDAL;
        }

        public void Add(Calender t)
        {
            _calenderDAL.Add(t);
        }

        public void Delete(Calender t)
        {
            _calenderDAL.Delete(t);
        }

        public Calender GetById(int Id)
        {
            return _calenderDAL.GetById(Id);
        }

        public List<Calender> ListAll()
        {
            return _calenderDAL.ListAll();
        }

        public List<Calender> List(Expression<Func<Calender, bool>> filter = null, Func<IQueryable<Calender>, IOrderedQueryable<Calender>> orderBy = null, int? take = null)
        {
            return _calenderDAL.List(filter, orderBy, take);
        }

        public void Update(Calender t)
        {
            _calenderDAL.Update(t);
        }
    }
}
