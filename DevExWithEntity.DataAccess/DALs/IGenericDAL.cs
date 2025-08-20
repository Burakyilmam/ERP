using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevExWithEntity.DataAccess.DALs
{
    public interface IGenericDAL<T> where T : class
    {
        Task<List<T>> ListAllAsync();
        Task<T> GetByIdAsync(int Id);
        Task AddAsync(T t);
        Task DeleteAsync(T t);
        Task UpdateAsync(T t);
        Task<List<T>> ListAsync(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, int? take = null);
    }
}
