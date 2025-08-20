
namespace DevExWithEntity.Winform.Forms.UserForms
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
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
            this.ImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.barUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.barDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barPassword = new DevExpress.XtraBars.BarButtonItem();
            this.barExport = new DevExpress.XtraBars.BarButtonItem();
            this.barManagerExport = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barExportHTML = new DevExpress.XtraBars.BarButtonItem();
            this.barExportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barExportPDF = new DevExpress.XtraBars.BarButtonItem();
            this.barPrint = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMenuExport = new DevExpress.XtraBars.PopupMenu(this.components);
            this.grdvUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoActive = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colUpdateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoAdmin = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.grdUser = new DevExpress.XtraGrid.GridControl();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(869, 141);
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
            this.ribbonPage1.Text = "Kullanıcı İşlemleri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAdd);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUpdate);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Kullanıcı İşlemleri";
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
            this.barManagerMain.Images = this.ImageCollection;
            this.barManagerMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barUpdate,
            this.barDelete,
            this.barPassword,
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
            this.barDockControlTop.Size = new System.Drawing.Size(869, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 507);
            this.barDockControlBottom.Manager = this.barManagerMain;
            this.barDockControlBottom.Size = new System.Drawing.Size(869, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Manager = this.barManagerMain;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 478);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(869, 29);
            this.barDockControlRight.Manager = this.barManagerMain;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 478);
            // 
            // ImageCollection
            // 
            this.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ImageCollection.ImageStream")));
            this.ImageCollection.Images.SetKeyName(0, "show_16x16.png");
            this.ImageCollection.Images.SetKeyName(1, "hide_16x16.png");
            this.ImageCollection.Images.SetKeyName(2, "iconsetsigns3_16x16.png");
            this.ImageCollection.Images.SetKeyName(3, "iconsetredtoblack4_16x16.png");
            this.ImageCollection.Images.SetKeyName(4, "bocustomer_16x16.png");
            this.ImageCollection.Images.SetKeyName(5, "boperson_16x16.png");
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
            // barPassword
            // 
            this.barPassword.Caption = "Parolayı Göster";
            this.barPassword.Id = 2;
            this.barPassword.Name = "barPassword";
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
            // barManagerExport
            // 
            this.barManagerExport.DockControls.Add(this.barDockControl1);
            this.barManagerExport.DockControls.Add(this.barDockControl2);
            this.barManagerExport.DockControls.Add(this.barDockControl3);
            this.barManagerExport.DockControls.Add(this.barDockControl4);
            this.barManagerExport.Form = this;
            this.barManagerExport.Images = this.ImageCollection;
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
            this.barDockControl1.Size = new System.Drawing.Size(869, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 507);
            this.barDockControl2.Manager = this.barManagerExport;
            this.barDockControl2.Size = new System.Drawing.Size(869, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManagerExport;
            this.barDockControl3.Size = new System.Drawing.Size(0, 507);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(869, 0);
            this.barDockControl4.Manager = this.barManagerExport;
            this.barDockControl4.Size = new System.Drawing.Size(0, 507);
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
            // popupMenuMain
            // 
            this.popupMenuMain.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barUpdate),
            new DevExpress.XtraBars.LinkPersistInfo(this.barDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.barPassword),
            new DevExpress.XtraBars.LinkPersistInfo(this.barExport)});
            this.popupMenuMain.Manager = this.barManagerMain;
            this.popupMenuMain.Name = "popupMenuMain";
            // 
            // popupMenuExport
            // 
            this.popupMenuExport.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.barExportPDF),
            new DevExpress.XtraBars.LinkPersistInfo(this.barExportHTML),
            new DevExpress.XtraBars.LinkPersistInfo(this.barExportExcel)});
            this.popupMenuExport.Manager = this.barManagerExport;
            this.popupMenuExport.Name = "popupMenuExport";
            // 
            // grdvUser
            // 
            this.grdvUser.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grdvUser.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdvUser.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.grdvUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUsername,
            this.colPassword,
            this.colCreateDate,
            this.colCreatedBy,
            this.colIsActive,
            this.colUpdateDate,
            this.colUpdatedBy,
            this.colIsAdmin});
            this.grdvUser.GridControl = this.grdUser;
            this.grdvUser.Name = "grdvUser";
            this.grdvUser.OptionsDetail.EnableMasterViewMode = false;
            this.grdvUser.OptionsSelection.MultiSelect = true;
            this.grdvUser.OptionsView.ColumnAutoWidth = false;
            this.grdvUser.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.grdvUser.OptionsView.ShowAutoFilterRow = true;
            this.grdvUser.OptionsView.ShowGroupPanel = false;
            // 
            // colUsername
            // 
            this.colUsername.Caption = "Kullanıcı Adı";
            this.colUsername.FieldName = "Username";
            this.colUsername.Name = "colUsername";
            this.colUsername.Visible = true;
            this.colUsername.VisibleIndex = 2;
            this.colUsername.Width = 119;
            // 
            // colPassword
            // 
            this.colPassword.Caption = "Parola";
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 3;
            this.colPassword.Width = 116;
            // 
            // colCreateDate
            // 
            this.colCreateDate.Caption = "Oluşturulma Tarihi";
            this.colCreateDate.ColumnEdit = this.repositoryItemDateEdit1;
            this.colCreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.OptionsColumn.AllowEdit = false;
            this.colCreateDate.OptionsColumn.ReadOnly = true;
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 4;
            this.colCreateDate.Width = 118;
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
            // colCreatedBy
            // 
            this.colCreatedBy.Caption = "Oluşturan Kullanıcı";
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.OptionsColumn.AllowEdit = false;
            this.colCreatedBy.OptionsColumn.ReadOnly = true;
            this.colCreatedBy.Visible = true;
            this.colCreatedBy.VisibleIndex = 5;
            this.colCreatedBy.Width = 146;
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "Aktif";
            this.colIsActive.ColumnEdit = this.repoActive;
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 1;
            this.colIsActive.Width = 45;
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
            this.repoActive.SmallImages = this.ImageCollection;
            // 
            // colUpdateDate
            // 
            this.colUpdateDate.Caption = "Güncellenme Tarihi";
            this.colUpdateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colUpdateDate.FieldName = "UpdateDate";
            this.colUpdateDate.Name = "colUpdateDate";
            this.colUpdateDate.OptionsColumn.AllowEdit = false;
            this.colUpdateDate.OptionsColumn.ReadOnly = true;
            this.colUpdateDate.Visible = true;
            this.colUpdateDate.VisibleIndex = 6;
            this.colUpdateDate.Width = 108;
            // 
            // colUpdatedBy
            // 
            this.colUpdatedBy.Caption = "Güncelleyen Kullanıcı";
            this.colUpdatedBy.FieldName = "UpdatedBy";
            this.colUpdatedBy.Name = "colUpdatedBy";
            this.colUpdatedBy.OptionsColumn.AllowEdit = false;
            this.colUpdatedBy.OptionsColumn.ReadOnly = true;
            this.colUpdatedBy.Visible = true;
            this.colUpdatedBy.VisibleIndex = 7;
            this.colUpdatedBy.Width = 138;
            // 
            // colIsAdmin
            // 
            this.colIsAdmin.Caption = "Yetki";
            this.colIsAdmin.ColumnEdit = this.repoAdmin;
            this.colIsAdmin.FieldName = "IsAdmin";
            this.colIsAdmin.Name = "colIsAdmin";
            this.colIsAdmin.Visible = true;
            this.colIsAdmin.VisibleIndex = 0;
            this.colIsAdmin.Width = 57;
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
            this.repoAdmin.SmallImages = this.ImageCollection;
            // 
            // grdUser
            // 
            this.grdUser.DataSource = this.userBindingSource;
            this.grdUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdUser.Location = new System.Drawing.Point(0, 170);
            this.grdUser.MainView = this.grdvUser;
            this.grdUser.MenuManager = this.ribbonControl1;
            this.grdUser.Name = "grdUser";
            this.grdUser.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoActive,
            this.repositoryItemDateEdit1,
            this.repoAdmin});
            this.grdUser.Size = new System.Drawing.Size(869, 337);
            this.grdUser.TabIndex = 1;
            this.grdUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvUser});
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(DevExWithEntity.Entity.User);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 507);
            this.Controls.Add(this.grdUser);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcılar";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barUpdate;
        private DevExpress.XtraBars.BarButtonItem barDelete;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraBars.BarButtonItem barPassword;
        private DevExpress.Utils.ImageCollection ImageCollection;
        private DevExpress.XtraBars.BarButtonItem barExport;
        private DevExpress.XtraBars.PopupMenu popupMenuMain;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarManager barManagerExport;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barExportHTML;
        private DevExpress.XtraBars.BarButtonItem barExportExcel;
        private DevExpress.XtraBars.BarButtonItem barExportPDF;
        private DevExpress.XtraBars.BarButtonItem barPrint;
        private DevExpress.XtraBars.PopupMenu popupMenuExport;
        private DevExpress.XtraGrid.GridControl grdUser;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvUser;
        private DevExpress.XtraGrid.Columns.GridColumn colUsername;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdatedBy;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repoActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsAdmin;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repoAdmin;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
    }
}