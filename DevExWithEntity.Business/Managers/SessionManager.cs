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
    public class SessionManager : IGenericService<Session>, ISessionService
    {
        private readonly ISessionDAL _sessionDAL;

        public SessionManager(ISessionDAL sessionDAL)
        {
            _sessionDAL = sessionDAL;
        }

        public async Task AddAsync(Session t)
        {
            await _sessionDAL.AddAsync(t);
        }

        public async Task Delete(Session t)
        {
            await _sessionDAL.DeleteAsync(t);
        }

        public Task<Session> GetByIdAsync(int Id)
        {
            return _sessionDAL.GetByIdAsync(Id);
        }

        public Task<List<Session>> ListAllAsync()
        {
            return _sessionDAL.ListAllAsync();
        }

        public Task<List<Session>> ListAsync(Expression<Func<Session, bool>> filter = null, Func<IQueryable<Session>, IOrderedQueryable<Session>> orderBy = null, int? take = null)
        {
            return _sessionDAL.ListAsync(filter, orderBy, take);
        }

        public async Task Update(Session t)
        {
            await _sessionDAL.UpdateAsync(t);
        }


    }
}
