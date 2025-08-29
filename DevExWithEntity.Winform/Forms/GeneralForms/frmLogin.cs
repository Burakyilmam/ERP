using DevExpress.XtraEditors;
using DevExWithEntity.Business.Managers;
using DevExWithEntity.Business.Services;
using DevExWithEntity.DataAccess.Context;
using DevExWithEntity.DataAccess.DALs;
using DevExWithEntity.DataAccess.Repositories;
using DevExWithEntity.Entity;
using DevExWithEntity.Winform.Forms;
using DevExWithEntity.Winform.Forms.UserForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExWithEntity.Winform
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            InitEvents();

            General._context = new DataContext();
            General._user = new UserManager(new UserRepository(General._context));
            General._session = new SessionManager(new SessionRepository(General._context));
            General._tab = new TabManager(new TabRepository(General._context));
            General._calender = new CalenderManager(new CalenderRepository(General._context));
            General._notification = new NotificationManager(new NotificationRepository(General._context));

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            btnEye.ImageOptions.ImageIndex = 0;

            edPassword.Properties.UseSystemPasswordChar = true;
        }
        void InitEvents()
        {
            btnEye.Click += BtnEye_Click;
            btnLogin.Click += BtnLogin_Click;

            FormClosed += FrmLogin_FormClosed;
            Load += FrmLogin_Load;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            edUsername.Focus();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void UserDateControl()
        {
            List<User> userList = General._user.ListAll();
            foreach (User item in userList)
            {
                double days = (DateTime.Now - item.CreateDate).TotalDays;

                if (days > 365) General.CreateNotification("Yıllık Kullanıcı", $"{item.Username} adlı kullanıcı 1 yıldan fazladır kullanıcı", item);
                else if (days > 180) General.CreateNotification("6 Aylık Kullanıcı", $"{item.Username} adlı kullanıcı 6 aydan fazladır kullanıcı", item);
                else if (days > 30) General.CreateNotification("Aylık Kullanıcı", $"{item.Username} adlı kullanıcı 1 aydan fazladır kullanıcı", item);
                else if (days > 7) General.CreateNotification("Haftalık Kullanıcı", $"{item.Username} adlı kullanıcı 1 haftadan fazladır kullanıcı", item);
                else if (days > 1) General.CreateNotification("Günlük Kullanıcı", $"{item.Username} adlı kullanıcı 1 günden fazladır kullanıcı", item);
                else General.CreateNotification("Yeni Kullanıcı", $"{item.Username} adlı kullanıcı 1 günden az süredir kullanıcı", item);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = edUsername.EditValue?.ToString();
            string password = edPassword.EditValue?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                XtraMessageBox.Show("Kullanıcı adı ve parola boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user = General._user.GetUser(username, password, true);

            UserDateControl();

            if (user != null)
            {
                General.FailCount = 0;

                frmMainUser main = new frmMainUser();
                General.activeUser = user;

                frmNotificationAlert notification = new frmNotificationAlert();
                General.CreateNotification("Oturum Açıldı", $"{user.Username} adlı kullanıcı oturum açtı", user);
                General.CreateSession(user, this);


                main.Text = "Hoşgeldin " + user.Username;
                main.Show();
                this.Hide();

                notification.ShowAlert();
            }
            else
            {
                General.FailCount++;
                XtraMessageBox.Show("Kullanıcı adı veya parola yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEye_Click(object sender, EventArgs e)
        {
            if (edPassword.Properties.UseSystemPasswordChar == true)
            {
                edPassword.Properties.UseSystemPasswordChar = false;
                btnEye.ImageOptions.ImageIndex = 1;
            }
            else
            {
                edPassword.Properties.UseSystemPasswordChar = true;
                btnEye.ImageOptions.ImageIndex = 0;
            }
        }
    }
}
