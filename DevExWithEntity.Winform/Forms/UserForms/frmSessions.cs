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
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExWithEntity.Winform.Forms.UserForms
{
    public partial class frmSessions : Form
    {
        public Session selectedSession;
        public frmSessions()
        {
            InitializeComponent();
            InitEvents();
            ButtonEnable();
        }

        void InitEvents()
        {
            Load += FrmSessions_Load;

            grdvSession.MouseUp += GrdvSession_MouseUp;
            grdvSession.KeyDown += GrdvSession_KeyDown;
            grdvSession.RowUpdated += GrdvSession_RowUpdated;
            grdvSession.RowStyle += GrdvSession_RowStyle;

            btnAdd.ItemClick += btnAdd_ItemClick;
            btnUpdate.ItemClick += btnUpdate_ItemClick;
            btnDelete.ItemClick += BtnDelete_ItemClick;
            btnRefresh.ItemClick += BtnRefresh_ItemClick;

            barUpdate.ItemClick += BarUpdate_ItemClick;
            barDelete.ItemClick += BarDelete_ItemClick;
            barExport.ItemClick += BarExport_ItemClick;
            barPrint.ItemClick += BarPrint_ItemClick;
            barExportExcel.ItemClick += BarExportExcel_ItemClick;
            barExportPDF.ItemClick += BarExportPDF_ItemClick;
            barExportHTML.ItemClick += BarExportHTML_ItemClick;
        }

        private void FrmSessions_Load(object sender, EventArgs e)
        {
            GetSessions();
            ButtonEnable();
            InitRowColor();
        }

        #region Listeleme ve Veri Getirme İşlemleri

        public void GetSessions()
        {
            sessionBindingSource.DataSource = General._session.ListAll();
            grdSession.DataSource = sessionBindingSource;
            grdvSession.RefreshData();
        }

        public Session GetSelectedSession()
        {
            selectedSession = grdvSession.GetFocusedRow() as Session;
            if (selectedSession != null)
            {
                return selectedSession;
            }
            else
            {
                return null;
            }
        }

        private void BtnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GetSessions();
        }

        #endregion

        #region Klavye ve Fare İşlemleri

        private void GrdvSession_KeyDown(object sender, KeyEventArgs e)
        {
            Session session = grdvSession.GetRow(grdvSession.FocusedRowHandle) as Session;

            if (session == null) return;

            if (e.KeyCode == Keys.Enter)
            {
                UpdateSession();
            }
            else if (e.KeyCode == Keys.Delete && General.activeUser.IsAdmin)
            {
                if (Message.MessageQuestion("Seçili oturumları silmek istediğinize emin misiniz ?", "Onay") == DialogResult.Yes)
                {
                    DeleteSession();
                    ButtonEnable();
                }
            }
        }

        private void GrdvSession_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                GridHitInfo hitInfo = grdvSession.CalcHitInfo(e.Location);
                if (hitInfo.InRow || hitInfo.InRowCell)
                {
                    popupMenuMain.ShowPopup(barManagerMain, grdSession.PointToScreen(e.Location));
                }
            }
        }

        #endregion

        #region Grid Üzerinden Ekleme ve Güncelleme İşlemleri

        private void GrdvSession_RowUpdated(object sender, RowObjectEventArgs e)
        {
            Session session = e.Row as Session;

            if (session == null) return;

            try
            {
                if (session.ID == 0)
                {
                    session.LoginDate = DateTime.Now;
                    session.User = General.activeUser;
                    General._session.Add(session);
                }
                else
                {
                    if (Message.MessageQuestion("Seçili oturum bilgileri güncellenecektir emin misiniz ?", "Onay") != DialogResult.Yes) return;

                    session.LastActivityDate = DateTime.Now;
                    session.User = General.activeUser;
                    General._session.Update(session);
                }

                grdvSession.RefreshData();
            }
            catch (Exception ex)
            {
                Message.MessageError("İşlem sırasında hata oluştu: " + ex.Message, "Hata");
            }
        }

        #endregion

        #region Buton İşlemleri

        public void ButtonEnable()
        {
            btnUpdate.Enabled = grdvSession.RowCount > 0;
            btnDelete.Enabled = grdvSession.RowCount > 0;
        }

        #endregion

        #region Renklendirme İşlemleri

        public void InitRowColor()
        {
            grdvSession.Appearance.TopNewRow.BackColor = Color.LightGoldenrodYellow;
        }

        private void GrdvSession_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                selectedSession = grdvSession.GetRow(e.RowHandle) as Session;
                if (selectedSession != null)
                {
                    if (selectedSession.LogoutDate == null)
                    {
                        e.Appearance.BackColor = Color.DarkOrange;
                        e.Appearance.ForeColor = Color.White;
                        e.Appearance.FontStyleDelta = FontStyle.Bold;
                    }
                    if (selectedSession.ID == General.activeSession.ID)
                    {
                        e.Appearance.BackColor = Color.SteelBlue;
                        e.Appearance.ForeColor = Color.White;
                        e.Appearance.FontStyleDelta = FontStyle.Bold;
                    }
                }
            }
        }


        #endregion

        #region Ekleme İşlemleri

        public void AddSession()
        {
            frmSessionAddUpdate form = new frmSessionAddUpdate(null);
            if (form.ShowDialog() == DialogResult.OK)
            {
                General._session.Add(form.session);
                GetSessions();
                ButtonEnable();
            }
        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddSession();
        }

        #endregion

        #region Güncelleme İşlemleri

        public void UpdateSession()
        {
            selectedSession = GetSelectedSession();
            frmSessionAddUpdate form = new frmSessionAddUpdate(selectedSession);
            if (form.ShowDialog() == DialogResult.OK)
            {
                General._session.Update(form.session);
                GetSessions();
                ButtonEnable();
            }
        }

        private void btnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            UpdateSession();
        }

        private void BarUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            UpdateSession();
            ButtonEnable();
        }

        #endregion

        #region Silme İşlemleri

        public void DeleteSession()
        {
            int[] selectedSessions = grdvSession.GetSelectedRows();

            if (selectedSessions.Length == 0) return;

            grdvSession.BeginUpdate();

            foreach (int selected in selectedSessions.OrderByDescending(x => x))
            {
                Session deleted = grdvSession.GetRow(selected) as Session;

                if (deleted == null) continue;

                General._session.Delete(deleted);
            }

            grdvSession.EndUpdate();
            GetSessions();
        }

        private void BarDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Message.MessageQuestion("Seçili oturumları silmek istediğinize emin misiniz ?", "Onay") == DialogResult.Yes)
            {
                DeleteSession();
                ButtonEnable();
            }
        }

        private void BtnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Message.MessageQuestion("Seçili oturumları silmek istediğinize emin misiniz ?", "Onay") == DialogResult.Yes)
            {
                DeleteSession();
                ButtonEnable();
            }
        }

        #endregion

        #region Dışa Aktarma ve Yazdırma İşlemleri

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
                        grdvSession.ExportToXls(fileName);
                    }
                    else if (filter == "PDF Dosyaları|*.pdf")
                    {
                        grdvSession.ExportToPdf(fileName);
                    }
                    else if (filter == "HTML Dosyaları|*.html")
                    {
                        grdvSession.ExportToHtml(fileName);

                    }
                }
            }
        }

        private void BarExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            popupMenuExport.ShowPopup(MousePosition);
        }

        private void BarPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            grdvSession.ShowPrintPreview();
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

        #endregion
    }
}
