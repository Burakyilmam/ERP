
namespace DevExWithEntity.Winform.Forms.UserForms
{
    partial class frmMainUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainUser));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barUser = new DevExpress.XtraBars.BarButtonItem();
            this.barProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.barCategory = new DevExpress.XtraBars.BarButtonItem();
            this.barEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.barSession = new DevExpress.XtraBars.BarButtonItem();
            this.barLog = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.trMenu = new DevExpress.XtraTreeList.TreeList();
            this.colMenu = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tileControlTab = new DevExpress.XtraEditors.TileControl();
            this.imageCollectionMenu = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barUser,
            this.barProduct,
            this.barCustomer,
            this.barCategory,
            this.barEmployee,
            this.barSession,
            this.barLog});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1006, 141);
            // 
            // barUser
            // 
            this.barUser.Caption = "Kullanıcılar";
            this.barUser.Hint = "Kullanıcılar";
            this.barUser.Id = 1;
            this.barUser.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barUser.ImageOptions.SvgImage")));
            this.barUser.Name = "barUser";
            this.barUser.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // barProduct
            // 
            this.barProduct.Caption = "Ürünler";
            this.barProduct.Hint = "Ürünler";
            this.barProduct.Id = 2;
            this.barProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barProduct.ImageOptions.SvgImage")));
            this.barProduct.Name = "barProduct";
            // 
            // barCustomer
            // 
            this.barCustomer.Caption = "Müşteriler";
            this.barCustomer.Hint = "Müşteriler";
            this.barCustomer.Id = 3;
            this.barCustomer.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barCustomer.ImageOptions.SvgImage")));
            this.barCustomer.Name = "barCustomer";
            // 
            // barCategory
            // 
            this.barCategory.Caption = "Kategoriler";
            this.barCategory.Hint = "Kategoriler";
            this.barCategory.Id = 4;
            this.barCategory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barCategory.ImageOptions.SvgImage")));
            this.barCategory.Name = "barCategory";
            // 
            // barEmployee
            // 
            this.barEmployee.Caption = "Personeller";
            this.barEmployee.Hint = "Personeller";
            this.barEmployee.Id = 5;
            this.barEmployee.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barEmployee.ImageOptions.SvgImage")));
            this.barEmployee.Name = "barEmployee";
            // 
            // barSession
            // 
            this.barSession.Caption = "Oturumlar";
            this.barSession.Id = 6;
            this.barSession.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSession.ImageOptions.Image")));
            this.barSession.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSession.ImageOptions.LargeImage")));
            this.barSession.Name = "barSession";
            // 
            // barLog
            // 
            this.barLog.Caption = "Loglar";
            this.barLog.Id = 7;
            this.barLog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barLog.ImageOptions.Image")));
            this.barLog.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLog.ImageOptions.LargeImage")));
            this.barLog.Name = "barLog";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barUser);
            this.ribbonPageGroup1.ItemLinks.Add(this.barCustomer);
            this.ribbonPageGroup1.ItemLinks.Add(this.barEmployee);
            this.ribbonPageGroup1.ItemLinks.Add(this.barProduct);
            this.ribbonPageGroup1.ItemLinks.Add(this.barCategory);
            this.ribbonPageGroup1.ItemLinks.Add(this.barSession);
            this.ribbonPageGroup1.ItemLinks.Add(this.barLog);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 141);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.trMenu);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1006, 529);
            this.splitContainerControl1.SplitterPosition = 244;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // trMenu
            // 
            this.trMenu.Caption = "Menüler";
            this.trMenu.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colMenu});
            this.trMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trMenu.Location = new System.Drawing.Point(0, 0);
            this.trMenu.Name = "trMenu";
            this.trMenu.BeginUnboundLoad();
            this.trMenu.AppendNode(new object[] {
            "Kullanıcı"}, -1);
            this.trMenu.AppendNode(new object[] {
            "Kullanıcı İşlemleri"}, 0, 2, 2, -1, "User");
            this.trMenu.AppendNode(new object[] {
            "Müşteri"}, -1);
            this.trMenu.AppendNode(new object[] {
            "Müşteri İşlemleri"}, 2, 2, 2, -1, "Customer");
            this.trMenu.EndUnboundLoad();
            this.trMenu.OptionsBehavior.Editable = false;
            this.trMenu.OptionsFind.AlwaysVisible = true;
            this.trMenu.SelectImageList = this.imageCollectionMenu;
            this.trMenu.Size = new System.Drawing.Size(244, 529);
            this.trMenu.TabIndex = 0;
            // 
            // colMenu
            // 
            this.colMenu.Caption = "Menüler";
            this.colMenu.FieldName = "Menü";
            this.colMenu.Name = "colMenu";
            this.colMenu.Visible = true;
            this.colMenu.VisibleIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tileControlTab);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(757, 109);
            this.panelControl1.TabIndex = 0;
            // 
            // tileControlTab
            // 
            this.tileControlTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControlTab.Location = new System.Drawing.Point(2, 2);
            this.tileControlTab.Name = "tileControlTab";
            this.tileControlTab.Size = new System.Drawing.Size(753, 105);
            this.tileControlTab.TabIndex = 0;
            this.tileControlTab.Text = "tileControl1";
            // 
            // imageCollectionMenu
            // 
            this.imageCollectionMenu.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionMenu.ImageStream")));
            this.imageCollectionMenu.Images.SetKeyName(0, "open_16x16.png");
            this.imageCollectionMenu.Images.SetKeyName(1, "open2_16x16.png");
            this.imageCollectionMenu.Images.SetKeyName(2, "window_16x16.png");
            // 
            // frmMainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 670);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmMainUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainUser";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTreeList.TreeList trMenu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TileControl tileControlTab;
        private DevExpress.XtraBars.BarButtonItem barUser;
        private DevExpress.XtraBars.BarButtonItem barProduct;
        private DevExpress.XtraBars.BarButtonItem barCustomer;
        private DevExpress.XtraBars.BarButtonItem barCategory;
        private DevExpress.XtraBars.BarButtonItem barEmployee;
        private DevExpress.XtraBars.BarButtonItem barSession;
        private DevExpress.XtraBars.BarButtonItem barLog;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMenu;
        private DevExpress.Utils.ImageCollection imageCollectionMenu;
    }
}