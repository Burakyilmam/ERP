using DevExWithEntity.Business.Services;
using DevExWithEntity.DataAccess.DALs;
using DevExWithEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DevExWithEntity.Business.Managers
{
    public class UserManager : IGenericService<User> , IUserService
    {
        private readonly IUserDAL _userDAL;

        public UserManager(IUserDAL userDAL)
        {
            _userDAL = userDAL;
        }

        public async Task AddAsync(User t)
        {
            await _userDAL.AddAsync(t);
        }

        public async Task Delete(User t)
        {
           await _userDAL.DeleteAsync(t);
        }

        public Task<User> GetByIdAsync(int Id)
        {
           return _userDAL.GetByIdAsync(Id);
        }

        public User GetUser(string username, string password, bool isActive)
        {
            return _userDAL.GetUser(username, password, isActive);
        }

        public Task<List<User>> ListAllAsync()
        {
            return _userDAL.ListAllAsync();
        }

        public Task<List<User>> ListAsync(Expression<Func<User, bool>> filter = null, Func<IQueryable<User>, IOrderedQueryable<User>> orderBy = null, int? take = null)
        {
            return _userDAL.ListAsync(filter, orderBy, take);
        }

        public async Task Update(User t)
        {
            await _userDAL.UpdateAsync(t);
        }

        public bool UserExist(string Username, string Password, bool IsActive)
        {
            return _userDAL.UserExist(Username, Password, IsActive);
        }
    }
}
