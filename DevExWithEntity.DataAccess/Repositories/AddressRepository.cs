using DevExWithEntity.DataAccess.Context;
using DevExWithEntity.DataAccess.DALs;
using DevExWithEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExWithEntity.DataAccess.Repositories
{
    public class AddressRepository : GenericRepository<Address> , IAddressDAL
    {
        public AddressRepository(DataContext context) : base(context)
        {

        }
    }
}
