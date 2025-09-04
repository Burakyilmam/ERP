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
    public class EmailRepository : GenericRepository<Email> , IEmailDAL
    {
        public EmailRepository(DataContext context) : base(context)
        {

        }
    }
}
