using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExWithEntity.Business.Managers;
using DevExWithEntity.Business.Services;
using DevExWithEntity.DataAccess.Context;
using DevExWithEntity.DataAccess.Repositories;
using DevExWithEntity.Entity;
using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExWithEntity.Winform.Forms.UserForms
{
    public partial class frmUsers : Form
    {
        private bool passwordVisible;
        public frmUsers()
        {
            InitializeComponent();
            InitEvents();
            ButtonEnable();
        }

        void InitEvents()
        {
            this.Shown += FrmUsers_Shown;

            grdvUser.MouseUp += GrdvKullanicilar_MouseUp;
            grdvUser.FocusedRowChanged += GrdvUser_FocusedRowChanged;
            grdvUser.CustomDrawCell += GrdvUser_CustomDrawCell;
            grdvUser.RowUpdated += GrdvUser_RowUpdated;
            grdvUser.InitNewRow += GrdvUser_InitNewRow;
            grdvUser.KeyDown += GrdvUser_KeyDown;

            btnAdd.ItemClick += btnAdd_ItemClick;
            btnUpdate.ItemClick += btnUpdate_ItemClick;
            btnDelete.ItemClick += BtnDelete_ItemClick;
            btnRefresh.ItemClick += BtnRefresh_ItemClick;

            btnFirst.ItemClick += BtnFirst_ItemClick;
            btnLast.ItemClick += BtnLast_ItemClick;

            barUpdate.ItemClick += BarUpdate_ItemClick;
            barDelete.ItemClick += BarDelete_ItemClick;

            barPassword.ItemClick += BarPassword_ItemClick;

            barExport.ItemClick += BarExport_ItemClick;
            barPrint.ItemClick += BarPrint_ItemClick;
            barExportHTML.ItemClick += BarExportHTML_ItemClick;
            barExportPDF.ItemClick += BarExportPDF_ItemClick;
            barExportExcel.ItemClick += BarExportExcel_ItemClick;
        }

        #region Buton İşlemleri
        public void ButtonEnable()
        {
            btnUpdate.Enabled = grdvUser.RowCount > 0;
            btnDelete.Enabled = grdvUser.RowCount > 0 && General.activeUser.IsAdmin;
            btnFirst.Enabled = grdvUser.RowCount > 1;
            btnLast.Enabled = grdvUser.RowCount > 1;
        }
        #endregion

        #region  Grid Üzerinde Ekleme ve Güncelleme İşlemleri
        private void GrdvUser_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            User user = grdvUser.GetRow(e.RowHandle) as User;

            if (user == null) { return; }

            if (user.ID == 0)
            {
                user.CreateDate = DateTime.Now;
                user.CreatedBy = General.activeUser.Username;
            }
        }

        private void GrdvUser_RowUpdated(object sender, RowObjectEventArgs e)
        {
            User user = e.Row as User;

            if (user == null) return;

            if (user.ID == 0)
            {
                General._user.Add(user);
            }
            else
            {
                if (Message.MessageQuestion("Seçili kullanıcı bilgileri güncellenecektir emin misiniz ?", "Onay") != DialogResult.Yes) return;
                user.UpdateDate = DateTime.Now;
                user.UpdatedBy = General.activeUser.Username;
                General._user.Update(user);
            }

            grdvUser.RefreshData();

        }
        #endregion

        #region Klavye İşlemleri
        private void GrdvUser_KeyDown(object sender, KeyEventArgs e)
        {
            User user = grdvUser.GetRow(grdvUser.FocusedRowHandle) as User;

            if (user == null) return;

            if (e.KeyCode == Keys.Enter)
            {
                UpdateUser();
            }
            else if (e.KeyCode == Keys.Delete && General.activeUser.IsAdmin)
            {
                if (Message.MessageQuestion("Seçili kullanıcıları silmek istediğinize emin misiniz ?", "Onay") == DialogResult.Yes)
                {
                    DeleteUser();
                }
            }
        }
        #endregion

        #region Fare İşlemleri
        private void GrdvKullanicilar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                GridHitInfo hitInfo = grdvUser.CalcHitInfo(e.Location);
                if (hitInfo.InRow || hitInfo.InRowCell)
                {
                    popupMenuMain.ShowPopup(barManagerMain, grdUser.PointToScreen(e.Location));
                }
            }
        }
        #endregion

        #region Grid İçerisine Müşteri Getirme
        public void GetUsers(bool first = false)
        {
            userBindingSource.DataSource = General._user.ListAll();
            grdUser.DataSource = userBindingSource;
            grdUser.RefreshDataSource();
            grdvUser.RefreshData();
            ButtonEnable();

            if (!first)
            {
                General.GetLastRow(grdvUser);
            }
            else
            {
                General.GetFirstRow(grdvUser);
            }
        }

        private void FrmUsers_Shown(object sender, EventArgs e)
        {
            GetUsers();
            General.InitRowColor(grdvUser);
            barPassword.ImageOptions.ImageIndex = 0;
        }

        private void BtnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetUsers();
        }
        #endregion

        #region Grid Eventleri
        private void GrdvUser_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            ButtonEnable();
        }
        #endregion

        #region Kullanıcı Oluşturma İşlemleri
        public void AddUser()
        {
            frmUserAddUpdate form = new frmUserAddUpdate(null);

            if (form.ShowDialog() == DialogResult.OK)
            {
                General._user.Add(form.user);
                GetUsers();
            }
        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddUser();
        }
        #endregion

        #region Kullanıcı Güncelleme İşlemleri
        public void UpdateUser()
        {
            User selectedUser = grdvUser.GetFocusedRow() as User;

            if (selectedUser == null) { return; }

            frmUserAddUpdate form = new frmUserAddUpdate(selectedUser);

            if (form.ShowDialog() == DialogResult.OK)
            {
                General._user.Update(form.user);
                GetUsers();
            }
        }

        private void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            UpdateUser();
        }

        private void BarUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            UpdateUser();
        }
        #endregion

        #region Kullanıcı Silme İşlemleri
        public void DeleteUser()
        {
            int[] selectedUsers = grdvUser.GetSelectedRows();

            if (selectedUsers.Length == 0) return;

            grdvUser.BeginUpdate();

            foreach (int selectedUser in selectedUsers.OrderByDescending(x => x))
            {
                User deletedUser = grdvUser.GetRow(selectedUser) as User;

                if (deletedUser == null) continue;

                General._user.Delete(deletedUser);
            }

            grdvUser.EndUpdate();
        }

        private void BtnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Message.MessageQuestion("Seçili kullanıcıları silmek istediğinize emin misiniz ?", "Onay") == DialogResult.Yes)
            {
                DeleteUser();
                GetUsers();
            }
        }

        private void BarDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Message.MessageQuestion("Seçili kullanıcıları silmek istediğinize emin misiniz ?", "Onay") == DialogResult.Yes)
            {
                DeleteUser();
                GetUsers();
            }
        }
        #endregion

        #region Grid Kullanıcı Şifre Gizleme
        private void GrdvUser_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "Password" && !passwordVisible)
            {
                e.DisplayText = new string('*', e.DisplayText.Length);
            }
        }
        #endregion

        #region Parola İşlemleri
        private void BarPassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            passwordVisible = !passwordVisible;

            if (passwordVisible)
            {
                barPassword.Caption = "Parolayı Gizle";
                barPassword.ImageOptions.ImageIndex = 1;
            }
            else
            {
                barPassword.Caption = "Parolayı Göster";
                barPassword.ImageOptions.ImageIndex = 0;
            }

            GetUsers();
        }
        #endregion

        #region Dönüştürme ve Yazdırma İşlemleri
        private void BarExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            popupMenuExport.ShowPopup(MousePosition);
        }

        private void BarPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            grdvUser.ShowPrintPreview();
        }

        private void BarExportExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            General.ExportToFile(grdvUser, "Excel Dosyaları|*.xls");
        }

        private void BarExportPDF_ItemClick(object sender, ItemClickEventArgs e)
        {
            General.ExportToFile(grdvUser, "PDF Dosyaları|*.pdf");
        }

        private void BarExportHTML_ItemClick(object sender, ItemClickEventArgs e)
        {
            General.ExportToFile(grdvUser, "HTML Dosyaları|*.html");
        }
        #endregion

        #region İlk ve Son Kayıt Getirme
        private void BtnLast_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetUsers();
        }

        private void BtnFirst_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetUsers(true);
        }
        #endregion
    }
}

