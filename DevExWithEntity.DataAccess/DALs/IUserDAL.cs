using DevExWithEntity.Entity;
using System;
using System.Linq;

namespace DevExWithEntity.DataAccess.DALs
{
    public interface IUserDAL : IGenericDAL<User>
    {
        bool UserExist(string Username , string Password , bool IsActive);
        User GetUser(string username, string password, bool isActive);
    }
}
