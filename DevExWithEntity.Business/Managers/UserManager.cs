using DevExWithEntity.Business.Services;
using DevExWithEntity.DataAccess.DALs;
using DevExWithEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DevExWithEntity.Business.Managers
{
    public class UserManager :  IUserService
    {
        private readonly IUserDAL _userDAL;

        public UserManager(IUserDAL userDAL)
        {
            _userDAL = userDAL;
        }

        public void Add(User t)
        {
            _userDAL.Add(t);
        }

        public void Delete(User t)
        {
            _userDAL.Delete(t);
        }

        public User GetById(int Id)
        {
            return _userDAL.GetById(Id);
        }

        public User GetUser(string username, string password, bool isActive)
        {
            return _userDAL.GetUser(username, password, isActive);
        }

        public List<User> ListAll()
        {
            return _userDAL.ListAll();
        }

        public List<User> List(Expression<Func<User, bool>> filter = null, Func<IQueryable<User>, IOrderedQueryable<User>> orderBy = null, int? take = null)
        {
            return _userDAL.List(filter, orderBy, take);
        }

        public void Update(User t)
        {
            _userDAL.Update(t);
        }

        public bool UserExist(string Username, string Password, bool IsActive)
        {
            return _userDAL.UserExist(Username, Password, IsActive);
        }
    }
}
