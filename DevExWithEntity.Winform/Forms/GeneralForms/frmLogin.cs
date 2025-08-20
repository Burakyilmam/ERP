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

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            btnEye.ImageOptions.ImageIndex = 0;

            edPassword.Properties.UseSystemPasswordChar = true;
        }
        void InitEvents()
        {
            btnEye.Click += BtnEye_Click;
            btnLogin.Click += BtnLogin_ClickAsync;

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

        private async void BtnLogin_ClickAsync(object sender, EventArgs e)
        {
            string username = edUsername.EditValue?.ToString();
            string password = edPassword.EditValue?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                XtraMessageBox.Show("Kullanıcı adı ve parola boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user = General._user.GetUser(username, password, true);

            if (user != null)
            {
                General.FailCount = 0;

                frmMainUser main = new frmMainUser(General._context);
                General.activeUser = user;

                Session session = new Session()
                {
                    User = user,
                    ActiveForm = this.Name,
                    LoginDate = DateTime.Now,
                    MachineName = Environment.MachineName,
                    WindowsUsername = Environment.UserName,
                    FailedLoginAttempts = General.FailCount,
                    IPAddress = General.FindIP(),
                    SessionDuration = TimeSpan.Zero,
                    LastActivityDate = DateTime.Now,
                    DeviceInfo = $"{Environment.OSVersion} - {Environment.MachineName} - {Environment.UserName}",
                    GeoLocation = await General.GetGeoLocation()
                };

                await General._session.AddAsync(session);
                General.activeSession = session;

                main.Text = "Hoşgeldin " + user.Username;
                main.Show();
                this.Hide();
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
