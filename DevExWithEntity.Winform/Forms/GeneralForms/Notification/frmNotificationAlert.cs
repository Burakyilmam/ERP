using DevExpress.XtraBars.Alerter;
using DevExWithEntity.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExWithEntity.Winform.Forms.UserForms
{
    public partial class frmNotificationAlert : Form
    {
        public frmNotificationAlert()
        {
            InitializeComponent();
            InitEvents();
        }

        void InitEvents()
        {
            alertControl.AlertClick += AlertControl_AlertClick;
        }

        private void AlertControl_AlertClick(object sender, AlertClickEventArgs e)
        {
            if (e.Info.Tag is Notification notification)
            {
                notification.IsRead = true;
                General._notification.Update(notification);
                e.AlertForm.Close();
            }
        }

        public void ShowAlert(User activeUser)
        {
            Expression<Func<Notification, bool>> filter;

            if (activeUser.IsAdmin)
            {
                filter = x => !x.IsRead;
            }
            else
            {
                filter = x => !x.IsRead && x.UserID == activeUser.ID && x.Title.ToLower().Contains("onay");
            }

            var notifications = General._notification.List(filter: filter, orderBy: q => q.OrderBy(n => n.CreatedAt));

            foreach (var notification in notifications)
            {
                AlertInfo info = new AlertInfo(notification.Title, notification.Content);
                info.Tag = notification;
                alertControl.Show(this, info);
            }
        }
    }
}
