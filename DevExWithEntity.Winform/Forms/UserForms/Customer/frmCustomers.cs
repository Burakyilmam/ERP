using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExWithEntity.Entity;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DevExWithEntity.Winform.Forms.UserForms
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
            InitEvents();
        }

        #region Event Tanımlama
        public void InitEvents()
        {
            this.Shown += FrmCustomers_Shown;

            grdvCustomer.InitNewRow += GrdvCustomer_InitNewRow;
            grdvCustomer.RowUpdated += GrdvCustomer_RowUpdated;
            grdvCustomer.MouseUp += GrdvCustomer_MouseUp;
            grdvCustomer.KeyDown += GrdvCustomer_KeyDown;

            btnAdd.ItemClick += BtnAdd_ItemClick;
            btnUpdate.ItemClick += BtnUpdate_ItemClick;
            btnDelete.ItemClick += BtnDelete_ItemClick;
            btnRefresh.ItemClick += BtnRefresh_ItemClick;
            btnFirst.ItemClick += BtnFirst_ItemClick;
            btnLast.ItemClick += BtnLast_ItemClick;

            barExport.ItemClick += BarExport_ItemClick;
            barPrint.ItemClick += BarPrint_ItemClick;
            barExportHTML.ItemClick += BarExportHTML_ItemClick;
            barExportPDF.ItemClick += BarExportPDF_ItemClick;
            barExportExcel.ItemClick += BarExportExcel_ItemClick;

            barUpdate.ItemClick += BarUpdate_ItemClick;
            barDelete.ItemClick += BarDelete_ItemClick;

            barAddress.ItemClick += BarAddress_ItemClick;
            barPhoneNumbers.ItemClick += BarPhoneNumbers_ItemClick;
            barEmails.ItemClick += BarEmails_ItemClick;
            //History eklenecek
        }

        #endregion

        #region Buton İşlemleri
        public void ButtonEnable()
        {
            btnDelete.Enabled = grdvCustomer.RowCount > 0 && General.activeUser.IsAdmin;
            btnUpdate.Enabled = grdvCustomer.RowCount > 0;
            btnFirst.Enabled = grdvCustomer.RowCount > 1;
            btnLast.Enabled = grdvCustomer.RowCount > 1;
        }
        #endregion

        #region Grid Üzerinde Ekleme ve Güncelleme İşlemleri
        private void GrdvCustomer_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            Customer customer = grdvCustomer.GetRow(e.RowHandle) as Customer;

            if (customer == null) { return; }

            if (customer.ID == 0)
            {
                customer.CreateDate = DateTime.Now;
                customer.CreatedBy = General.activeUser.Username;
            }
        }

        private void GrdvCustomer_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            Customer customer = e.Row as Customer;

            if (customer == null) { return; }

            if (customer.ID == 0)
            {
                General._customer.Add(customer);
            }
            else
            {
                customer.UpdateDate = DateTime.Now;
                customer.UpdatedBy = General.activeUser.Username;
                General._customer.Update(customer);
            }

            GetCustomers();
        }
        #endregion

        #region Klavye İşlemleri
        private void GrdvCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            Customer customer = grdvCustomer.GetRow(grdvCustomer.FocusedRowHandle) as Customer;

            if (customer == null) return;

            if (e.KeyCode == Keys.Enter)
            {
                UpdateCustomer();
            }
            else if (e.KeyCode == Keys.Delete && General.activeUser.IsAdmin)
            {
                if (Message.MessageQuestion("Seçili müşterileri silmek istediğinize emin misiniz ?", "Onay") == DialogResult.Yes)
                {
                    DeleteCustomer();
                }
            }
        }
        #endregion

        #region Fare İşlemleri
        private void GrdvCustomer_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                GridHitInfo hitInfo = grdvCustomer.CalcHitInfo(e.Location);
                if (hitInfo.InRow || hitInfo.InRowCell)
                {
                    popupMenuMain.ShowPopup(barManagerMain, grdCustomer.PointToScreen(e.Location));
                }
            }
        }
        #endregion

        #region Grid İçerisine Müşteri Getirme
        public void GetCustomers(bool first = false)
        {
            CustomerBindingSource.DataSource = General._customer.ListAll();
            grdCustomer.DataSource = CustomerBindingSource;
            grdCustomer.RefreshDataSource();
            grdvCustomer.RefreshData();
            ButtonEnable();

            if (!first)
            {
                General.GetLastRow(grdvCustomer);
            }
            else
            {
                General.GetFirstRow(grdvCustomer);
            }
        }

        private void FrmCustomers_Shown(object sender, EventArgs e)
        {
            GetCustomers();
            General.InitRowColor(grdvCustomer);
        }

        private void BtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetCustomers();
        }
        #endregion

        #region Müşteri Oluşturma İşlemleri
        public void AddCustomer()
        {
            //frmUserAddUpdate form = new frmUserAddUpdate(null);
            //
            //if (form.ShowDialog() == DialogResult.OK)
            //{
            //    General._customer.Add(form.user);
            //    GetCustomers();
            //    grdvCustomer.RefreshData();
            //    ButtonEnable();
            //}
        }

        private void BtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddCustomer();
        }
        #endregion

        #region Müşteri Güncelleme İşlemleri
        public void UpdateCustomer()
        {
            Customer selectedCustomer = grdvCustomer.GetFocusedRow() as Customer;

            // frmUserAddUpdate form = new frmUserAddUpdate(selectedCustomer);
            // 
            // if (form.ShowDialog() == DialogResult.OK)
            // {
            //     General._customer.Update(form.user);
            //     GetCustomers();
            // }
        }

        private void BtnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateCustomer();
        }

        private void BarUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateCustomer();
        }
        #endregion

        #region Müşteri Silme İşlemleri
        public void DeleteCustomer()
        {
            int[] selectedCustomers = grdvCustomer.GetSelectedRows();

            if (selectedCustomers == null) { return; }

            grdvCustomer.BeginUpdate();

            foreach (int selectedCustomer in selectedCustomers.OrderBy(x => x))
            {
                Customer deletedCustomer = grdvCustomer.GetRow(selectedCustomer) as Customer;

                if (deletedCustomer == null) { return; }

                General._customer.Delete(deletedCustomer);
            }

            grdvCustomer.EndUpdate();
            GetCustomers();
        }

        private void BtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Message.MessageQuestion("Seçili müşterileri silmek istediğinize emin misiniz ?") == DialogResult.Yes)
            {
                DeleteCustomer();
            }
        }

        private void BarDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Message.MessageQuestion("Seçili müşteriyi silmek istediğinize emin misiniz ?") == DialogResult.Yes)
            {
                DeleteCustomer();
            }
        }
        #endregion

        #region İlk ve Son Kayıt Getirme
        private void BtnLast_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetCustomers();
        }

        private void BtnFirst_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetCustomers(true);
        }
        #endregion

        #region Dönüştürme ve Yazdırma İşlemleri
        private void BarExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            popupMenuExport.ShowPopup(MousePosition);
        }

        private void BarPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grdvCustomer.ShowPrintPreview();
        }

        private void BarExportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            General.ExportToFile(grdvCustomer, "Excel Dosyaları| *.xls");
        }

        private void BarExportPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            General.ExportToFile(grdvCustomer, "PDF Dosyaları|*.pdf");
        }

        private void BarExportHTML_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            General.ExportToFile(grdvCustomer, "HTML Dosyaları|*.html");
        }
        #endregion

        #region  Müşteri Bilgilerini Getirme
        private void BarEmails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BarPhoneNumbers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BarAddress_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
