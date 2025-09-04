
namespace DevExWithEntity.Winform.Forms.UserForms
{
    partial class frmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
            this.grdCustomer = new DevExpress.XtraGrid.GridControl();
            this.CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdvCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnFirst = new DevExpress.XtraBars.BarButtonItem();
            this.btnLast = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repoActive = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repoAdmin = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.barDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barExport = new DevExpress.XtraBars.BarButtonItem();
            this.barPhoneNumbers = new DevExpress.XtraBars.BarButtonItem();
            this.barEmails = new DevExpress.XtraBars.BarButtonItem();
            this.barAddress = new DevExpress.XtraBars.BarButtonItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuExport)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCustomer
            // 
            this.grdCustomer.DataSource = this.CustomerBindingSource;
            this.grdCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCustomer.Location = new System.Drawing.Point(0, 170);
            this.grdCustomer.MainView = this.grdvCustomer;
            this.grdCustomer.MenuManager = this.ribbonControl1;
            this.grdCustomer.Name = "grdCustomer";
            this.grdCustomer.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoActive,
            this.repositoryItemDateEdit1,
            this.repoAdmin});
            this.grdCustomer.Size = new System.Drawing.Size(999, 280);
            this.grdCustomer.TabIndex = 3;
            this.grdCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvCustomer});
            // 
            // CustomerBindingSource
            // 
            this.CustomerBindingSource.DataSource = typeof(DevExWithEntity.Entity.Customer);
            // 
            // grdvCustomer
            // 
            this.grdvCustomer.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grdvCustomer.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdvCustomer.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.grdvCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colSurname,
            this.colDateOfBirth,
            this.colCustomerCode,
            this.colCustomerType,
            this.colCompanyName,
            this.colTaxNumber,
            this.colCreateDate,
            this.colCreatedBy,
            this.colUpdateDate,
            this.colUpdatedBy,
            this.colNotes});
            this.grdvCustomer.GridControl = this.grdCustomer;
            this.grdvCustomer.Name = "grdvCustomer";
            this.grdvCustomer.OptionsSelection.MultiSelect = true;
            this.grdvCustomer.OptionsView.ColumnAutoWidth = false;
            this.grdvCustomer.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.grdvCustomer.OptionsView.ShowAutoFilterRow = true;
            this.grdvCustomer.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colSurname
            // 
            this.colSurname.Caption = "Surname";
            this.colSurname.FieldName = "Surname";
            this.colSurname.Name = "colSurname";
            this.colSurname.Visible = true;
            this.colSurname.VisibleIndex = 2;
            // 
            // colDateOfBirth
            // 
            this.colDateOfBirth.Caption = "Date Of The Birth";
            this.colDateOfBirth.FieldName = "DateOfBirth";
            this.colDateOfBirth.Name = "colDateOfBirth";
            this.colDateOfBirth.Visible = true;
            this.colDateOfBirth.VisibleIndex = 3;
            // 
            // colCustomerCode
            // 
            this.colCustomerCode.Caption = "Customer Code";
            this.colCustomerCode.FieldName = "CustomerCode";
            this.colCustomerCode.Name = "colCustomerCode";
            this.colCustomerCode.Visible = true;
            this.colCustomerCode.VisibleIndex = 4;
            // 
            // colCustomerType
            // 
            this.colCustomerType.Caption = "Customer Type";
            this.colCustomerType.FieldName = "CustomerType";
            this.colCustomerType.Name = "colCustomerType";
            this.colCustomerType.Visible = true;
            this.colCustomerType.VisibleIndex = 5;
            // 
            // colCompanyName
            // 
            this.colCompanyName.Caption = "Company Name";
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 6;
            // 
            // colTaxNumber
            // 
            this.colTaxNumber.Caption = "Tax Number";
            this.colTaxNumber.FieldName = "TaxNumber";
            this.colTaxNumber.Name = "colTaxNumber";
            this.colTaxNumber.Visible = true;
            this.colTaxNumber.VisibleIndex = 7;
            // 
            // colCreateDate
            // 
            this.colCreateDate.Caption = "Create Date";
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.OptionsColumn.ReadOnly = true;
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 8;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.Caption = "Created By";
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.OptionsColumn.ReadOnly = true;
            this.colCreatedBy.Visible = true;
            this.colCreatedBy.VisibleIndex = 9;
            // 
            // colUpdateDate
            // 
            this.colUpdateDate.Caption = "Update Date";
            this.colUpdateDate.FieldName = "UpdateDate";
            this.colUpdateDate.Name = "colUpdateDate";
            this.colUpdateDate.OptionsColumn.ReadOnly = true;
            this.colUpdateDate.Visible = true;
            this.colUpdateDate.VisibleIndex = 10;
            // 
            // colUpdatedBy
            // 
            this.colUpdatedBy.Caption = "Updated By";
            this.colUpdatedBy.FieldName = "UpdatedBy";
            this.colUpdatedBy.Name = "colUpdatedBy";
            this.colUpdatedBy.OptionsColumn.ReadOnly = true;
            this.colUpdatedBy.Visible = true;
            this.colUpdatedBy.VisibleIndex = 11;
            // 
            // colNotes
            // 
            this.colNotes.Caption = "Note";
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 12;
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
            this.btnRefresh,
            this.btnFirst,
            this.btnLast});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 29);
            this.ribbonControl1.MaxItemId = 9;
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
            // btnFirst
            // 
            this.btnFirst.Caption = "İlk Kayıt";
            this.btnFirst.Id = 7;
            this.btnFirst.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFirst.ImageOptions.SvgImage")));
            this.btnFirst.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnFirst.Name = "btnFirst";
            // 
            // btnLast
            // 
            this.btnLast.Caption = "Son Kayıt";
            this.btnLast.Id = 8;
            this.btnLast.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLast.ImageOptions.SvgImage")));
            this.btnLast.Name = "btnLast";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Müşteri İşlemleri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAdd);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUpdate);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Müşteri İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnFirst);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLast);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Tablo Kontrolleri";
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
            this.barExport,
            this.barPhoneNumbers,
            this.barEmails,
            this.barAddress});
            this.barManagerMain.MaxItemId = 11;
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
            // barPhoneNumbers
            // 
            this.barPhoneNumbers.Caption = "Telefon Numaralarım";
            this.barPhoneNumbers.Id = 8;
            this.barPhoneNumbers.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barPhoneNumbers.ImageOptions.SvgImage")));
            this.barPhoneNumbers.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.barPhoneNumbers.Name = "barPhoneNumbers";
            // 
            // barEmails
            // 
            this.barEmails.Caption = "Emaillerim";
            this.barEmails.Id = 9;
            this.barEmails.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barEmails.ImageOptions.SvgImage")));
            this.barEmails.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.barEmails.Name = "barEmails";
            // 
            // barAddress
            // 
            this.barAddress.Caption = "Adreslerim";
            this.barAddress.Id = 10;
            this.barAddress.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barAddress.ImageOptions.Image")));
            this.barAddress.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barAddress.ImageOptions.LargeImage")));
            this.barAddress.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.barAddress.Name = "barAddress";
            // 
            // popupMenuMain
            // 
            this.popupMenuMain.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barUpdate),
            new DevExpress.XtraBars.LinkPersistInfo(this.barDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.barAddress),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEmails),
            new DevExpress.XtraBars.LinkPersistInfo(this.barPhoneNumbers),
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barExportPDF),
            new DevExpress.XtraBars.LinkPersistInfo(this.barExportHTML),
            new DevExpress.XtraBars.LinkPersistInfo(this.barExportExcel)});
            this.popupMenuExport.Manager = this.barManagerExport;
            this.popupMenuExport.Name = "popupMenuExport";
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.grdCustomer);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmCustomers";
            this.Text = "frmCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuExport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvCustomer;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repoActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repoAdmin;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
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
        private System.Windows.Forms.BindingSource CustomerBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colDateOfBirth;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerType;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraBars.BarButtonItem btnFirst;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnLast;
        private DevExpress.XtraBars.BarButtonItem barPhoneNumbers;
        private DevExpress.XtraBars.BarButtonItem barEmails;
        private DevExpress.XtraBars.BarButtonItem barAddress;
    }
}