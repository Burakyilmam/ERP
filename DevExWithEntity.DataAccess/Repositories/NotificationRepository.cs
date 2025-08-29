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
    public class NotificationRepository : GenericRepository<Notification> , INotificationDAL
    {
        private readonly DataContext _context;
        public NotificationRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
