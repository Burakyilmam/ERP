using DevExWithEntity.DataAccess.Context;
using DevExWithEntity.DataAccess.DALs;
using DevExWithEntity.Entity;
using System;
using System.Linq;

namespace DevExWithEntity.DataAccess.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserDAL
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public bool UserExist(string Username, string Password, bool IsActive)
        {
            return _context.Users.Any(x => x.Username == Username && x.Password == Password && x.IsActive == IsActive);
        }

        public User GetUser(string Username, string Password, bool IsActive)
        {
            return _context.Users.FirstOrDefault(x => x.Username == Username && x.Password == Password && x.IsActive == IsActive);
        }
    }
}
