
namespace DevExWithEntity.Winform
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.ImageCollectionEye = new DevExpress.Utils.ImageCollection(this.components);
            this.pnlEdits = new DevExpress.XtraEditors.PanelControl();
            this.btnEye = new DevExpress.XtraEditors.SimpleButton();
            this.edUsername = new DevExpress.XtraEditors.TextEdit();
            this.edPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.lblUsername = new DevExpress.XtraEditors.LabelControl();
            this.pnlButton = new DevExpress.XtraEditors.PanelControl();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCollectionEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdits)).BeginInit();
            this.pnlEdits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButton)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageCollectionEye
            // 
            this.ImageCollectionEye.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ImageCollectionEye.ImageStream")));
            this.ImageCollectionEye.Images.SetKeyName(0, "show_16x16.png");
            this.ImageCollectionEye.Images.SetKeyName(1, "hide_16x16.png");
            // 
            // pnlEdits
            // 
            this.pnlEdits.Controls.Add(this.btnEye);
            this.pnlEdits.Controls.Add(this.edUsername);
            this.pnlEdits.Controls.Add(this.edPassword);
            this.pnlEdits.Controls.Add(this.lblPassword);
            this.pnlEdits.Controls.Add(this.lblUsername);
            this.pnlEdits.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdits.Location = new System.Drawing.Point(0, 0);
            this.pnlEdits.Name = "pnlEdits";
            this.pnlEdits.Size = new System.Drawing.Size(316, 98);
            this.pnlEdits.TabIndex = 3;
            // 
            // btnEye
            // 
            this.btnEye.ImageOptions.ImageList = this.ImageCollectionEye;
            this.btnEye.Location = new System.Drawing.Point(282, 68);
            this.btnEye.Name = "btnEye";
            this.btnEye.Size = new System.Drawing.Size(25, 20);
            this.btnEye.TabIndex = 7;
            // 
            // edUsername
            // 
            this.edUsername.Location = new System.Drawing.Point(15, 23);
            this.edUsername.Name = "edUsername";
            this.edUsername.Size = new System.Drawing.Size(260, 20);
            this.edUsername.TabIndex = 5;
            // 
            // edPassword
            // 
            this.edPassword.Location = new System.Drawing.Point(15, 68);
            this.edPassword.Name = "edPassword";
            this.edPassword.Size = new System.Drawing.Size(260, 20);
            this.edPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(15, 49);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(46, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(15, 4);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(48, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnLogin);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButton.Location = new System.Drawing.Point(0, 98);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(316, 35);
            this.pnlButton.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLogin.ImageOptions.ImageToTextIndent = 7;
            this.btnLogin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLogin.ImageOptions.SvgImage")));
            this.btnLogin.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnLogin.Location = new System.Drawing.Point(121, 6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 133);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.pnlEdits);
            this.Name = "frmLogin";
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.ImageCollectionEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdits)).EndInit();
            this.pnlEdits.ResumeLayout(false);
            this.pnlEdits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButton)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.ImageCollection ImageCollectionEye;
        private DevExpress.XtraEditors.PanelControl pnlEdits;
        private DevExpress.XtraEditors.SimpleButton btnEye;
        private DevExpress.XtraEditors.TextEdit edUsername;
        private DevExpress.XtraEditors.TextEdit edPassword;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.LabelControl lblUsername;
        private DevExpress.XtraEditors.PanelControl pnlButton;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
    }
}

