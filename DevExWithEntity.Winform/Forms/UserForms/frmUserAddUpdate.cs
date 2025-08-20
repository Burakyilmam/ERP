using DevExpress.XtraEditors;
using DevExWithEntity.Entity;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DevExWithEntity.Winform.Forms.UserForms
{
    public partial class frmUserAddUpdate : Form
    {
        public User user;
        public frmUserAddUpdate(User selectedUser)
        {
            InitializeComponent();
            InitEvents();

            btnEye.ImageOptions.ImageIndex = 0;
            edPassword.Properties.UseSystemPasswordChar = true;

            user = selectedUser;

            if (user == null)
            {
                btnAddUpdate.ImageOptions.ImageIndex = 2;
                btnAddUpdate.Text = "Ekle";
                this.Text = "Yeni Kayıt Formu";

                user = new User()
                {
                    CreateDate = DateTime.Now,
                    CreatedBy = General.activeUser.Username,
                    IsActive = true
                };
            }
            else
            {
                btnAddUpdate.ImageOptions.ImageIndex = 3;
                btnAddUpdate.Text = "Güncelle";
                this.Text = "Güncelleme Formu";

                edUsername.EditValue = user.Username;
                edPassword.EditValue = user.Password;
                edActive.Checked = user.IsActive;
            }
        }

        void InitEvents()
        {
            btnAddUpdate.Click += btnIslem_Click;
            btnEye.Click += BtnEye_Click;
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

        private void btnIslem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(edUsername.Text) || string.IsNullOrWhiteSpace(edPassword.Text))
            {
                XtraMessageBox.Show("Kullanıcı adı ve parola boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            user.Username = edUsername.EditValue.ToString();
            user.Password = edPassword.EditValue.ToString();
            user.IsActive = edActive.Checked;

            if (user.ID > 0)
            {
                user.UpdateDate = DateTime.Now;
                user.UpdatedBy = General.activeUser.Username;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

