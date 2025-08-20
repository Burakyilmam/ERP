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
    public class TabManager : ITabService
    {
        private readonly ITabDAL _tabDAL;

        public TabManager(ITabDAL tabDAL)
        {
            _tabDAL = tabDAL;
        }

        public async Task AddAsync(Tab t)
        {
            await _tabDAL.AddAsync(t);
        }

        public async Task Delete(Tab t)
        {
            await _tabDAL.DeleteAsync(t);
        }

        public async Task<Tab> GetByIdAsync(int Id)
        {
            return  await _tabDAL.GetByIdAsync(Id);
        }

        public async Task<List<Tab>> ListAllAsync()
        {
            return await _tabDAL.ListAllAsync();
        }

        public Task<List<Tab>> ListAsync(Expression<Func<Tab, bool>> filter = null, Func<IQueryable<Tab>, IOrderedQueryable<Tab>> orderBy = null, int? take = null)
        {
            return _tabDAL.ListAsync(filter, orderBy, take);
        }

        public async Task Update(Tab t)
        {
            await _tabDAL.UpdateAsync(t);
        }
    }
}
