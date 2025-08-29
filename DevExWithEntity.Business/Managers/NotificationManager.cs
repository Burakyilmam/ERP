using DevExWithEntity.Business.Services;
using DevExWithEntity.DataAccess.DALs;
using DevExWithEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevExWithEntity.Business.Managers
{
    public class NotificationManager : INotificationService
    {
        private readonly INotificationDAL _notificationDAL;

        public NotificationManager(INotificationDAL notificationDAL)
        {
            _notificationDAL = notificationDAL;
        }

        public void Add(Notification t)
        {
            _notificationDAL.Add(t);
        }

        public void Delete(Notification t)
        {
            _notificationDAL.Delete(t);
        }

        public Notification GetById(int Id)
        {
            return _notificationDAL.GetById(Id);
        }

        public List<Notification> List(Expression<Func<Notification, bool>> filter = null, Func<IQueryable<Notification>, IOrderedQueryable<Notification>> orderBy = null, int? take = null)
        {
            return _notificationDAL.List(filter, orderBy, take);
        }

        public List<Notification> ListAll()
        {
            return _notificationDAL.ListAll();
        }

        public void Update(Notification t)
        {
            _notificationDAL.Update(t);
        }
    }
}
