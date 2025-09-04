using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList.Nodes;
using DevExWithEntity.Business.Services;
using DevExWithEntity.DataAccess.Context;
using DevExWithEntity.Entity;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace DevExWithEntity.Winform
{
    public static class General
    {
        public static User activeUser;
        public static Session activeSession;
        public static int FailCount;
        public static IUserService _user;
        public static ISessionService _session;
        public static ITabService _tab;
        public static ICalenderService _calender;
        public static INotificationService _notification;
        public static ICustomerService _customer;
        public static IEmailService _email;
        public static IPhoneService _phone;
        public static IAddressService _address;
        public static DataContext _context;
        public static string FindIP()
        {
            try
            {
                IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

                foreach (var item in host.AddressList)
                {
                    if (item.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return item.ToString();
                    }
                }

                return "Ağ kartı bulunmamaktadır";
            }
            catch (Exception ex)
            {
                return "Hata: " + ex.Message;
            }
        }

        public static void CreateNotification(string title, string content, User user, byte type = 0, string relatedForm = null, object relatedObject = null, byte priority = 0)
        {
            Notification notification = new Notification()
            {
                IsRead = false,
                Title = title,
                Content = content,
                NotificationType = type,
                RelatedForm = relatedForm,
                RelatedObject = relatedObject,
                User = user,
                CreatedAt = DateTime.Now,
                Priority = priority
            };

            General._notification.Add(notification);
        }

        public static void CreateSession(User user,Form form)
        {
            Session session = new Session()
            {
                User = user,
                ActiveForm = form.Name,
                LoginDate = DateTime.Now,
                MachineName = Environment.MachineName,
                WindowsUsername = Environment.UserName,
                FailedLoginAttempts = General.FailCount,
                IPAddress = FindIP(),
                SessionDuration = TimeSpan.Zero,
                LastActivityDate = DateTime.Now,
                DeviceInfo = $"{Environment.OSVersion} - {Environment.MachineName} - {Environment.UserName}",
                //GeoLocation = General.GetGeoLocation()
            };

            _session.Add(session);
            activeSession = session;
        }

        public static void OpenMenuNode(TreeListNode i)
        {
            if (i == null) return;
            if (i.Tag == null) return;

            if (i.Tag == "User") { FormOpen(new Forms.UserForms.frmUsers()); }
            if (i.Tag == "Customer") { FormOpen(new Forms.UserForms.frmCustomers()); }
        }

        public static Form FormOpen(Form i)
        {
            i.StartPosition = FormStartPosition.CenterScreen;

            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.GetType() == i.GetType() && !openForm.IsDisposed)
                {
                    openForm.BringToFront();
                    return openForm;
                }
            }

            i.Show();
            return i;
        }

        public static int GetWeekOfYear(DateTime date)
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            return culture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
        }

        public static void GetFirstRow(this GridView gv)
        {
            if (gv.RowCount > 0)
            {
                gv.FocusedRowHandle = 0;
                gv.SelectRow(0);
                gv.MakeRowVisible(0);
            }
        }

        public static void GetLastRow(this GridView gv)
        {
            if (gv.RowCount > 0)
            {
                gv.FocusedRowHandle = gv.RowCount - 1;
                gv.SelectRow(gv.FocusedRowHandle);
                gv.MakeRowVisible(gv.FocusedRowHandle);
            }
        }

        public static void InitRowColor(GridView gv)
        {
            gv.Appearance.TopNewRow.BackColor = Color.LightGoldenrodYellow;
        }

        public static void ExportToFile(GridView gv ,string filter)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = filter;
                saveDialog.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss");

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveDialog.FileName;

                    if (filter == "Excel Dosyaları| *.xls")
                    {
                        gv.ExportToXls(fileName);
                    }
                    else if (filter == "PDF Dosyaları|*.pdf")
                    {
                        gv.ExportToPdf(fileName);
                    }
                    else if (filter == "HTML Dosyaları|*.html")
                    {
                        gv.ExportToHtml(fileName);
                    }
                }
            }
        }

        //public static void TabOrder(Control parent)
        //{
        //    if (parent == null) return;

        //    for (int i = 0; i < parent.Controls.Count; i++)
        //    {
        //        Control ctrl = parent.Controls[i];

        //        if (ctrl.Visible && ctrl.TabStop)
        //        {
        //            ctrl.TabIndex = i;
        //        }

        //        if (ctrl.HasChildren) TabOrder(ctrl);
        //    }
        //}
    }
}
