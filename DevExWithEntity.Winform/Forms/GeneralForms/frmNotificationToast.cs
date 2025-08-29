using DevExpress.XtraBars.ToastNotifications;
using DevExWithEntity.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExWithEntity.Winform.Forms.UserForms
{
    public partial class frmNotificationToast : Form
    {
        public frmNotificationToast()
        {
            InitializeComponent();
            InitEvents();
        }
        void InitEvents()
        {
          
        }

        public void ShowToast()
        {
            var notifications = General._notification.List(filter: x => x.UserID == General.activeUser.ID && x.IsRead == false, orderBy: q => q.OrderBy(n => n.CreatedAt));
            if (notifications != null)
            {
                foreach (Notification notification in notifications)
                {
                    ToastNotification toast = new ToastNotification();
                    toast.ID = Guid.NewGuid().ToString();
                    toast.Header = notification.Title;
                    toast.Body = notification.Content;
                    toast.Duration = ToastNotificationDuration.Default;

                    notification.IsRead = true;

                    toastNotificationsManager.ShowNotification(toast);
                }
            }

        }
    }
}
