using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
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
        public User selectedUser;
        private bool passwordVisible;
        public frmUsers()
        {
            InitializeComponent();
            InitEvents();
            ButtonEnable();
        }

        void InitEvents()
        {
            Load += FrmUsers_Load;

            grdvUser.MouseUp += GrdvKullanicilar_MouseUp;
            grdvUser.FocusedRowChanged += GrdvUser_FocusedRowChanged;
            grdvUser.CustomDrawCell += GrdvUser_CustomDrawCell;
            grdvUser.RowUpdated += GrdvUser_RowUpdated;
            grdvUser.KeyDown += GrdvUser_KeyDown;

            btnAdd.ItemClick += btnAdd_ItemClick;
            btnUpdate.ItemClick += btnUpdate_ItemClick;
            btnDelete.ItemClick += BtnDelete_ItemClick;
            btnRefresh.ItemClick += BtnRefresh_ItemClick;

            barUpdate.ItemClick += BarUpdate_ItemClick;
            barDelete.ItemClick += BarDelete_ItemClick;
            barPassword.ItemClick += BarPassword_ItemClick;
            barExport.ItemClick += BarExport_ItemClick;
            barPrint.ItemClick += BarPrint_ItemClick;
            barExportHTML.ItemClick += BarExportHTML_ItemClick;
            barExportPDF.ItemClick += BarExportPDF_ItemClick;
            barExportExcel.ItemClick += BarExportExcel_ItemClick;
        }

        private async void BtnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            await GetUsers();
        }

        private async void GrdvUser_KeyDown(object sender, KeyEventArgs e)
        {
            User user = grdvUser.GetRow(grdvUser.FocusedRowHandle) as User;

            if (user == null) return;

            if (e.KeyCode == Keys.Enter)
            {
                await UpdateUser();
            }
            else if(e.KeyCode == Keys.Delete && General.activeUser.IsAdmin)
            {
                if (Message.MessageQuestion("Seçili kullanıcıları silmek istediğinize emin misiniz ?", "Onay") == DialogResult.Yes)
                {
                    await DeleteUser();
                    ButtonEnable();
                }
            }
        }

        private async void GrdvUser_RowUpdated(object sender, RowObjectEventArgs e)
        {
            User user = e.Row as User;

            if (user == null) return;

            try
            {
                if (user.ID == 0)
                {
                    user.CreateDate = DateTime.Now;
                    user.CreatedBy = General.activeUser.Username;
                    await General._user.AddAsync(user);
                }
                else
                {
                    if (Message.MessageQuestion("Seçili kullanıcı bilgileri güncellenecektir emin misiniz ?", "Onay") != DialogResult.Yes) return;

                    user.UpdateDate = DateTime.Now;
                    user.UpdatedBy = General.activeUser.Username;
                    await General._user.Update(user);
                }

                grdvUser.RefreshData();
            }
            catch (Exception ex)
            {
               Message.MessageError("İşlem sırasında hata oluştu: " + ex.Message, "Hata");
            }
        }

        public void InitRowColor()
        {
            grdvUser.Appearance.TopNewRow.BackColor = Color.LightGoldenrodYellow;
        }

        private void GrdvUser_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            ButtonEnable();
        }

        public async Task GetUsers()
        {
            userBindingSource.DataSource = await General._user.ListAllAsync();
            grdUser.DataSource = userBindingSource;
            grdUser.RefreshDataSource();
        }

        private async void FrmUsers_Load(object sender, EventArgs e)
        {
            await GetUsers();
            ButtonEnable();
            InitRowColor();
            barPassword.ImageOptions.ImageIndex = 0;
        }

        public User GetSelectedUser()
        {
            selectedUser = grdvUser.GetFocusedRow() as User;
            if (selectedUser != null)
            {
                return selectedUser;
            }
            else
            {
                return null;
            }
        }

        public void ButtonEnable()
        {
            btnUpdate.Enabled = grdvUser.RowCount > 0;
            btnDelete.Enabled = grdvUser.RowCount > 0;
        }

        public async Task AddUser()
        {
            frmUserAddUpdate form = new frmUserAddUpdate(null);
            if (form.ShowDialog() == DialogResult.OK)
            {
                await General._user.AddAsync(form.user);
                await GetUsers();
                grdvUser.RefreshData();
                ButtonEnable();
            }
        }

        private async void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            await AddUser();
        }

        public async Task UpdateUser()
        {
            selectedUser = GetSelectedUser();
            frmUserAddUpdate form = new frmUserAddUpdate(selectedUser);
            if (form.ShowDialog() == DialogResult.OK)
            {
                await General._user.Update(form.user);
                await GetUsers();
                grdvUser.RefreshData();
                ButtonEnable();
            }
        }

        private async void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            await UpdateUser();
        }

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

        public async Task DeleteUser()
        {
            int[] selectedUsers = grdvUser.GetSelectedRows();

            if (selectedUsers.Length == 0) return;

            grdvUser.BeginUpdate();

            foreach (int selected in selectedUsers.OrderByDescending(x => x))
            {
                User deleted = grdvUser.GetRow(selected) as User;

                if (deleted == null) continue;

                await General._user.Delete(deleted);
            }

            grdvUser.EndUpdate();

            await GetUsers();
            grdvUser.RefreshData();
        }


        private async void BtnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Message.MessageQuestion("Seçili kullanıcıları silmek istediğinize emin misiniz ?", "Onay") == DialogResult.Yes)
            {
                await DeleteUser();
                ButtonEnable();
            }
        }

        private async void BarDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Message.MessageQuestion("Seçili kullanıcıları silmek istediğinize emin misiniz ?", "Onay") == DialogResult.Yes)
            {
                await DeleteUser();
                ButtonEnable();
            }
        }

        private async void BarUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            await UpdateUser();
            ButtonEnable();
        }

        private void GrdvUser_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "Password" && !passwordVisible)
            {
                e.DisplayText = new string('*', e.DisplayText.Length);
            }
        }
        
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
        
            grdvUser.RefreshData();
        }

        private void BarExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            popupMenuExport.ShowPopup(MousePosition);
        }

        private void BarPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            grdvUser.ShowPrintPreview();
        }

        private void ExportToFile(string filter)
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
                        grdvUser.ExportToXls(fileName);
                    }
                    else if (filter == "PDF Dosyaları|*.pdf")
                    {
                        grdvUser.ExportToPdf(fileName);
                    }
                    else if (filter == "HTML Dosyaları|*.html")
                    {
                        grdvUser.ExportToHtml(fileName);

                    }
                }
            }
        }

        private void BarExportExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            ExportToFile("Excel Dosyaları|*.xls");
        }

        private void BarExportPDF_ItemClick(object sender, ItemClickEventArgs e)
        {
            ExportToFile("PDF Dosyaları|*.pdf");
        }

        private void BarExportHTML_ItemClick(object sender, ItemClickEventArgs e)
        {
            ExportToFile("HTML Dosyaları|*.html");
        }
    }
}

