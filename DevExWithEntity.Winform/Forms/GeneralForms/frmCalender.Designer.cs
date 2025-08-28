
namespace DevExWithEntity.Winform.Forms.GeneralForms
{
    partial class frmCalender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalender));
            this.calenderControl = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.toolTipCalender = new DevExpress.Utils.ToolTipController(this.components);
            this.barManagerCalender = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.popupMenuCalender = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barClear = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.calenderControl.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerCalender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuCalender)).BeginInit();
            this.SuspendLayout();
            // 
            // calenderControl
            // 
            this.calenderControl.AutoSize = false;
            this.calenderControl.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calenderControl.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.calenderControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calenderControl.DrawCellLines = true;
            this.calenderControl.Location = new System.Drawing.Point(0, 49);
            this.calenderControl.Name = "calenderControl";
            this.barManagerCalender.SetPopupContextMenu(this.calenderControl, this.popupMenuCalender);
            this.calenderControl.ShowWeekNumbers = true;
            this.calenderControl.Size = new System.Drawing.Size(450, 264);
            this.calenderControl.TabIndex = 0;
            this.calenderControl.ToolTipController = this.toolTipCalender;
            // 
            // barManagerCalender
            // 
            this.barManagerCalender.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManagerCalender.DockControls.Add(this.barDockControlTop);
            this.barManagerCalender.DockControls.Add(this.barDockControlBottom);
            this.barManagerCalender.DockControls.Add(this.barDockControlLeft);
            this.barManagerCalender.DockControls.Add(this.barDockControlRight);
            this.barManagerCalender.Form = this;
            this.barManagerCalender.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barClear});
            this.barManagerCalender.MainMenu = this.bar2;
            this.barManagerCalender.MaxItemId = 1;
            this.barManagerCalender.StatusBar = this.bar3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerCalender;
            this.barDockControlTop.Size = new System.Drawing.Size(450, 49);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 313);
            this.barDockControlBottom.Manager = this.barManagerCalender;
            this.barDockControlBottom.Size = new System.Drawing.Size(450, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 49);
            this.barDockControlLeft.Manager = this.barManagerCalender;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 264);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(450, 49);
            this.barDockControlRight.Manager = this.barManagerCalender;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 264);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // popupMenuCalender
            // 
            this.popupMenuCalender.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barClear)});
            this.popupMenuCalender.Manager = this.barManagerCalender;
            this.popupMenuCalender.Name = "popupMenuCalender";
            // 
            // barClear
            // 
            this.barClear.Caption = "Temizle";
            this.barClear.Id = 0;
            this.barClear.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barClear.ImageOptions.SvgImage")));
            this.barClear.Name = "barClear";
            // 
            // frmCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 336);
            this.Controls.Add(this.calenderControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCalender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCalender";
            ((System.ComponentModel.ISupportInitialize)(this.calenderControl.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerCalender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuCalender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Controls.CalendarControl calenderControl;
        private DevExpress.Utils.ToolTipController toolTipCalender;
        private DevExpress.XtraBars.BarManager barManagerCalender;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupMenu popupMenuCalender;
        private DevExpress.XtraBars.BarButtonItem barClear;
    }
}