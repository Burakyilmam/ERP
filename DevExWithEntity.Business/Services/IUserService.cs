using DevExWithEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExWithEntity.Business.Services
{
    public interface IUserService : IGenericService<User>
    {
        bool UserExist(string Username, string Password, bool IsActive);
        User GetUser(string username, string password, bool isActive);
    }
}
