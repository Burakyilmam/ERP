
namespace DevExWithEntity.Winform.Forms.UserForms
{
    partial class frmSessions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSessions));
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.barDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barExport = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManagerExport = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barExportHTML = new DevExpress.XtraBars.BarButtonItem();
            this.barExportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barExportPDF = new DevExpress.XtraBars.BarButtonItem();
            this.barPrint = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuExport = new DevExpress.XtraBars.PopupMenu(this.components);
            this.grdSession = new DevExpress.XtraGrid.GridControl();
            this.grdvSession = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWindowsUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMachineName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActiveForm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeviceInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeoLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoginDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastActivityDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogoutDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIPAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFailedLoginAttempts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSessionDuration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoActive = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repoAdmin = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataSource = typeof(DevExWithEntity.Entity.Session);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnAdd,
            this.btnUpdate,
            this.btnDelete,
            this.barButtonItem1,
            this.btnRefresh});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 29);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(999, 141);
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Ekle";
            this.btnAdd.Id = 1;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Name = "btnAdd";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Güncelle";
            this.btnUpdate.Id = 2;
            this.btnUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdate.ImageOptions.SvgImage")));
            this.btnUpdate.Name = "btnUpdate";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Sil";
            this.btnDelete.Id = 3;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Name = "btnDelete";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Yenile";
            this.btnRefresh.Id = 6;
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            this.btnRefresh.Name = "btnRefresh";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Oturum İşlemleri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAdd);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUpdate);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Oturum İşlemleri";
            // 
            // barManagerMain
            // 
            this.barManagerMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManagerMain.DockControls.Add(this.barDockControlTop);
            this.barManagerMain.DockControls.Add(this.barDockControlBottom);
            this.barManagerMain.DockControls.Add(this.barDockControlLeft);
            this.barManagerMain.DockControls.Add(this.barDockControlRight);
            this.barManagerMain.Form = this;
            this.barManagerMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barUpdate,
            this.barDelete,
            this.barExport});
            this.barManagerMain.MaxItemId = 8;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerMain;
            this.barDockControlTop.Size = new System.Drawing.Size(999, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManagerMain;
            this.barDockControlBottom.Size = new System.Drawing.Size(999, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Manager = this.barManagerMain;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 421);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(999, 29);
            this.barDockControlRight.Manager = this.barManagerMain;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 421);
            // 
            // barUpdate
            // 
            this.barUpdate.Caption = "Güncelle";
            this.barUpdate.Id = 0;
            this.barUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barUpdate.ImageOptions.SvgImage")));
            this.barUpdate.Name = "barUpdate";
            // 
            // barDelete
            // 
            this.barDelete.Caption = "Sil";
            this.barDelete.Id = 1;
            this.barDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barDelete.ImageOptions.SvgImage")));
            this.barDelete.Name = "barDelete";
            // 
            // barExport
            // 
            this.barExport.ActAsDropDown = true;
            this.barExport.Caption = "Dışarıya Aktar";
            this.barExport.Id = 3;
            this.barExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barExport.ImageOptions.Image")));
            this.barExport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barExport.ImageOptions.LargeImage")));
            this.barExport.Name = "barExport";
            // 
            // popupMenuMain
            // 
            this.popupMenuMain.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barUpdate),
            new DevExpress.XtraBars.LinkPersistInfo(this.barDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.barExport)});
            this.popupMenuMain.Manager = this.barManagerMain;
            this.popupMenuMain.Name = "popupMenuMain";
            // 
            // barManagerExport
            // 
            this.barManagerExport.DockControls.Add(this.barDockControl1);
            this.barManagerExport.DockControls.Add(this.barDockControl2);
            this.barManagerExport.DockControls.Add(this.barDockControl3);
            this.barManagerExport.DockControls.Add(this.barDockControl4);
            this.barManagerExport.Form = this;
            this.barManagerExport.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barExportHTML,
            this.barExportExcel,
            this.barExportPDF,
            this.barPrint});
            this.barManagerExport.MaxItemId = 9;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManagerExport;
            this.barDockControl1.Size = new System.Drawing.Size(999, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 450);
            this.barDockControl2.Manager = this.barManagerExport;
            this.barDockControl2.Size = new System.Drawing.Size(999, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManagerExport;
            this.barDockControl3.Size = new System.Drawing.Size(0, 450);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(999, 0);
            this.barDockControl4.Manager = this.barManagerExport;
            this.barDockControl4.Size = new System.Drawing.Size(0, 450);
            // 
            // barExportHTML
            // 
            this.barExportHTML.Caption = "HTML Dönüştür";
            this.barExportHTML.Id = 4;
            this.barExportHTML.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barExportHTML.ImageOptions.Image")));
            this.barExportHTML.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barExportHTML.ImageOptions.LargeImage")));
            this.barExportHTML.Name = "barExportHTML";
            // 
            // barExportExcel
            // 
            this.barExportExcel.Caption = "Excel Dönüştür";
            this.barExportExcel.Id = 5;
            this.barExportExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barExportExcel.ImageOptions.Image")));
            this.barExportExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barExportExcel.ImageOptions.LargeImage")));
            this.barExportExcel.Name = "barExportExcel";
            // 
            // barExportPDF
            // 
            this.barExportPDF.Caption = "PDF Dönüştür";
            this.barExportPDF.Id = 6;
            this.barExportPDF.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barExportPDF.ImageOptions.Image")));
            this.barExportPDF.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barExportPDF.ImageOptions.LargeImage")));
            this.barExportPDF.Name = "barExportPDF";
            // 
            // barPrint
            // 
            this.barPrint.Caption = "Yazdır";
            this.barPrint.Id = 7;
            this.barPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barPrint.ImageOptions.Image")));
            this.barPrint.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barPrint.ImageOptions.LargeImage")));
            this.barPrint.Name = "barPrint";
            // 
            // popupMenuExport
            // 
            this.popupMenuExport.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.barExportExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.barExportPDF),
            new DevExpress.XtraBars.LinkPersistInfo(this.barExportHTML),
            new DevExpress.XtraBars.LinkPersistInfo(this.barPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.barExportPDF),
            new DevExpress.XtraBars.LinkPersistInfo(this.barExportHTML),
            new DevExpress.XtraBars.LinkPersistInfo(this.barExportExcel)});
            this.popupMenuExport.Manager = this.barManagerExport;
            this.popupMenuExport.Name = "popupMenuExport";
            // 
            // grdSession
            // 
            this.grdSession.DataSource = this.sessionBindingSource;
            this.grdSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSession.Location = new System.Drawing.Point(0, 170);
            this.grdSession.MainView = this.grdvSession;
            this.grdSession.MenuManager = this.ribbonControl1;
            this.grdSession.Name = "grdSession";
            this.grdSession.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoActive,
            this.repositoryItemDateEdit1,
            this.repoAdmin});
            this.grdSession.Size = new System.Drawing.Size(999, 280);
            this.grdSession.TabIndex = 13;
            this.grdSession.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvSession});
            // 
            // grdvSession
            // 
            this.grdvSession.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grdvSession.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdvSession.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.grdvSession.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colUser,
            this.colWindowsUsername,
            this.colMachineName,
            this.colActiveForm,
            this.colDeviceInfo,
            this.colGeoLocation,
            this.colLoginDate,
            this.colLastActivityDate,
            this.colLogoutDate,
            this.colIPAddress,
            this.colFailedLoginAttempts,
            this.colSessionDuration});
            this.grdvSession.GridControl = this.grdSession;
            this.grdvSession.Name = "grdvSession";
            this.grdvSession.OptionsDetail.EnableMasterViewMode = false;
            this.grdvSession.OptionsSelection.MultiSelect = true;
            this.grdvSession.OptionsView.ColumnAutoWidth = false;
            this.grdvSession.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.grdvSession.OptionsView.ShowAutoFilterRow = true;
            this.grdvSession.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colUser
            // 
            this.colUser.Caption = "Kullanıcı Adı";
            this.colUser.FieldName = "User.Username";
            this.colUser.Name = "colUser";
            this.colUser.Visible = true;
            this.colUser.VisibleIndex = 1;
            // 
            // colWindowsUsername
            // 
            this.colWindowsUsername.Caption = "Windows Kullanıcı Adı";
            this.colWindowsUsername.FieldName = "WindowsUsername";
            this.colWindowsUsername.Name = "colWindowsUsername";
            this.colWindowsUsername.Visible = true;
            this.colWindowsUsername.VisibleIndex = 2;
            // 
            // colMachineName
            // 
            this.colMachineName.Caption = "Bilgisayar Adı";
            this.colMachineName.FieldName = "MachineName";
            this.colMachineName.Name = "colMachineName";
            this.colMachineName.Visible = true;
            this.colMachineName.VisibleIndex = 3;
            // 
            // colActiveForm
            // 
            this.colActiveForm.Caption = "Aktif Form";
            this.colActiveForm.FieldName = "ActiveForm";
            this.colActiveForm.Name = "colActiveForm";
            this.colActiveForm.Visible = true;
            this.colActiveForm.VisibleIndex = 4;
            // 
            // colDeviceInfo
            // 
            this.colDeviceInfo.Caption = "Cihaz Bilgileri";
            this.colDeviceInfo.FieldName = "DeviceInfo";
            this.colDeviceInfo.Name = "colDeviceInfo";
            this.colDeviceInfo.Visible = true;
            this.colDeviceInfo.VisibleIndex = 5;
            // 
            // colGeoLocation
            // 
            this.colGeoLocation.Caption = "Konum";
            this.colGeoLocation.FieldName = "GeoLocation";
            this.colGeoLocation.Name = "colGeoLocation";
            this.colGeoLocation.Visible = true;
            this.colGeoLocation.VisibleIndex = 6;
            // 
            // colLoginDate
            // 
            this.colLoginDate.Caption = "Giriş Tarihi";
            this.colLoginDate.FieldName = "LoginDate";
            this.colLoginDate.Name = "colLoginDate";
            this.colLoginDate.Visible = true;
            this.colLoginDate.VisibleIndex = 7;
            // 
            // colLastActivityDate
            // 
            this.colLastActivityDate.Caption = "Son Aktiflik";
            this.colLastActivityDate.FieldName = "LastActivityDate";
            this.colLastActivityDate.Name = "colLastActivityDate";
            this.colLastActivityDate.Visible = true;
            this.colLastActivityDate.VisibleIndex = 8;
            // 
            // colLogoutDate
            // 
            this.colLogoutDate.Caption = "Çıkış Tarihi";
            this.colLogoutDate.FieldName = "LogoutDate";
            this.colLogoutDate.Name = "colLogoutDate";
            this.colLogoutDate.Visible = true;
            this.colLogoutDate.VisibleIndex = 9;
            // 
            // colIPAddress
            // 
            this.colIPAddress.Caption = "IP Adresi";
            this.colIPAddress.FieldName = "IPAddress";
            this.colIPAddress.Name = "colIPAddress";
            this.colIPAddress.Visible = true;
            this.colIPAddress.VisibleIndex = 10;
            // 
            // colFailedLoginAttempts
            // 
            this.colFailedLoginAttempts.Caption = "Hatalı Giriş";
            this.colFailedLoginAttempts.FieldName = "FailedLoginAttempts";
            this.colFailedLoginAttempts.Name = "colFailedLoginAttempts";
            this.colFailedLoginAttempts.Visible = true;
            this.colFailedLoginAttempts.VisibleIndex = 11;
            // 
            // colSessionDuration
            // 
            this.colSessionDuration.Caption = "Oturum Süresi";
            this.colSessionDuration.FieldName = "SessionDuration";
            this.colSessionDuration.Name = "colSessionDuration";
            this.colSessionDuration.Visible = true;
            this.colSessionDuration.VisibleIndex = 12;
            // 
            // repoActive
            // 
            this.repoActive.AutoHeight = false;
            this.repoActive.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoActive.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repoActive.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Aktif", true, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Pasif", false, 3)});
            this.repoActive.Name = "repoActive";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // repoAdmin
            // 
            this.repoAdmin.AutoHeight = false;
            this.repoAdmin.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoAdmin.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repoAdmin.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Yönetici", true, 4),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Kullanıcı", false, 5)});
            this.repoAdmin.Name = "repoAdmin";
            // 
            // frmSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.grdSession);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmSessions";
            this.Text = "Oturumlar";
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl grdSession;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvSession;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
        private DevExpress.XtraGrid.Columns.GridColumn colWindowsUsername;
        private DevExpress.XtraGrid.Columns.GridColumn colMachineName;
        private DevExpress.XtraGrid.Columns.GridColumn colActiveForm;
        private DevExpress.XtraGrid.Columns.GridColumn colDeviceInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colGeoLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colLoginDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLastActivityDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLogoutDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIPAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colFailedLoginAttempts;
        private DevExpress.XtraGrid.Columns.GridColumn colSessionDuration;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repoActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repoAdmin;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManagerExport;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barExportHTML;
        private DevExpress.XtraBars.BarButtonItem barExportExcel;
        private DevExpress.XtraBars.BarButtonItem barExportPDF;
        private DevExpress.XtraBars.BarButtonItem barPrint;
        private DevExpress.XtraBars.BarButtonItem barUpdate;
        private DevExpress.XtraBars.BarButtonItem barDelete;
        private DevExpress.XtraBars.BarButtonItem barExport;
        private DevExpress.XtraBars.PopupMenu popupMenuMain;
        private DevExpress.XtraBars.PopupMenu popupMenuExport;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
    }
}