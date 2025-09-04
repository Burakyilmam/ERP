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
    public class CustomerRepository : GenericRepository<Customer> , ICustomerDAL
    {
        public CustomerRepository(DataContext context) : base(context)
        {

        }
    }
}
