using DevExWithEntity.Entity;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DevExWithEntity.Winform.Forms.UserForms
{
    public partial class frmSessionAddUpdate : Form
    {
        public Session session;
        public frmSessionAddUpdate(Session _session)
        {
            InitializeComponent();

            session = _session;

            if (session == null)
            {
                //btnAddUpdate.ImageOptions.ImageIndex = 2;
                //btnAddUpdate.Text = "Ekle";
                this.Text = "Yeni Kayıt Formu";

                session = new Session()
                {
                    LoginDate = DateTime.Now,
                    User = General.activeUser,
                    IPAddress = General.FindIP(),
                    MachineName = Environment.MachineName,
                    WindowsUsername = Environment.UserName,
                    ActiveForm = this.Name,

                };
            }
            else
            {
                //btnAddUpdate.ImageOptions.ImageIndex = 3;
                //btnAddUpdate.Text = "Güncelle";
                this.Text = "Güncelleme Formu";
                //edUsername.EditValue = session.Username;
            }
        }
    }
}
