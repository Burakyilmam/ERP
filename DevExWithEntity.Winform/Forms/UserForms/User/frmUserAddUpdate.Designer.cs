
namespace DevExWithEntity.Winform.Forms.UserForms
{
    partial class frmUserAddUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAddUpdate));
            this.ImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnEye = new DevExpress.XtraEditors.SimpleButton();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.lblUsername = new DevExpress.XtraEditors.LabelControl();
            this.edActive = new DevExpress.XtraEditors.CheckEdit();
            this.edPassword = new DevExpress.XtraEditors.TextEdit();
            this.edUsername = new DevExpress.XtraEditors.TextEdit();
            this.pnlButton = new DevExpress.XtraEditors.PanelControl();
            this.btnAddUpdate = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButton)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageCollection
            // 
            this.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ImageCollection.ImageStream")));
            this.ImageCollection.Images.SetKeyName(0, "show_16x16.png");
            this.ImageCollection.Images.SetKeyName(1, "hide_16x16.png");
            this.ImageCollection.Images.SetKeyName(2, "additem_16x16.png");
            this.ImageCollection.Images.SetKeyName(3, "apply_16x16.png");
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnEye);
            this.panelControl1.Controls.Add(this.lblPassword);
            this.panelControl1.Controls.Add(this.lblUsername);
            this.panelControl1.Controls.Add(this.edActive);
            this.panelControl1.Controls.Add(this.edPassword);
            this.panelControl1.Controls.Add(this.edUsername);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(312, 101);
            this.panelControl1.TabIndex = 3;
            // 
            // btnEye
            // 
            this.btnEye.ImageOptions.ImageList = this.ImageCollection;
            this.btnEye.Location = new System.Drawing.Point(246, 72);
            this.btnEye.Name = "btnEye";
            this.btnEye.Size = new System.Drawing.Size(25, 20);
            this.btnEye.TabIndex = 10;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(14, 53);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(46, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(12, 8);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(48, 13);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Username";
            // 
            // edActive
            // 
            this.edActive.Location = new System.Drawing.Point(253, 27);
            this.edActive.Name = "edActive";
            this.edActive.Properties.Caption = "Active";
            this.edActive.Size = new System.Drawing.Size(50, 19);
            this.edActive.TabIndex = 7;
            // 
            // edPassword
            // 
            this.edPassword.Location = new System.Drawing.Point(14, 72);
            this.edPassword.Name = "edPassword";
            this.edPassword.Size = new System.Drawing.Size(230, 20);
            this.edPassword.TabIndex = 5;
            // 
            // edUsername
            // 
            this.edUsername.Location = new System.Drawing.Point(12, 27);
            this.edUsername.Name = "edUsername";
            this.edUsername.Size = new System.Drawing.Size(232, 20);
            this.edUsername.TabIndex = 6;
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnAddUpdate);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButton.Location = new System.Drawing.Point(0, 101);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(312, 39);
            this.pnlButton.TabIndex = 4;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.ImageOptions.ImageList = this.ImageCollection;
            this.btnAddUpdate.Location = new System.Drawing.Point(121, 6);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnAddUpdate.TabIndex = 3;
            // 
            // frmUserAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 140);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmUserAddUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserAddUpdate";
            ((System.ComponentModel.ISupportInitialize)(this.ImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButton)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.ImageCollection ImageCollection;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnEye;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.LabelControl lblUsername;
        private DevExpress.XtraEditors.CheckEdit edActive;
        private DevExpress.XtraEditors.TextEdit edPassword;
        private DevExpress.XtraEditors.TextEdit edUsername;
        private DevExpress.XtraEditors.PanelControl pnlButton;
        private DevExpress.XtraEditors.SimpleButton btnAddUpdate;
    }
}