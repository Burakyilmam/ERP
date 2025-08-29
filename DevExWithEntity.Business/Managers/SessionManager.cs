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
    public class SessionManager :  ISessionService
    {
        private readonly ISessionDAL _sessionDAL;

        public SessionManager(ISessionDAL sessionDAL)
        {
            _sessionDAL = sessionDAL;
        }

        public void Add(Session t)
        {
            _sessionDAL.Add(t);
        }

        public void Delete(Session t)
        {
            _sessionDAL.Delete(t);
        }

        public Session GetById(int Id)
        {
            return _sessionDAL.GetById(Id);
        }

        public List<Session> ListAll()
        {
            return _sessionDAL.ListAll();
        }

        public List<Session> List(Expression<Func<Session, bool>> filter = null, Func<IQueryable<Session>, IOrderedQueryable<Session>> orderBy = null, int? take = null)
        {
            return _sessionDAL.List(filter, orderBy, take);
        }

        public void Update(Session t)
        {
            _sessionDAL.Update(t);
        }


    }
}
