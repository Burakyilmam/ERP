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
    public class TabRepository : GenericRepository<Tab> , ITabDAL
    {
        private readonly DataContext _context;
        public TabRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
