using DevExWithEntity.DataAccess.Context;
using DevExWithEntity.DataAccess.DALs;
using DevExWithEntity.Entity;
using System;
using System.Linq;

namespace DevExWithEntity.DataAccess.Repositories
{
    public class PhoneRepository : GenericRepository<Phone> , IPhoneDAL
    {
        public PhoneRepository(DataContext context) : base(context)
        {

        }
    }
}
