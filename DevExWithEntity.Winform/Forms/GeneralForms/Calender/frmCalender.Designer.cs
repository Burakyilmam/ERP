
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
            this.toolTipCalender = new DevExpress.Utils.ToolTipController(this.components);
            this.barManagerCalender = new DevExpress.XtraBars.BarManager(this.components);
            this.popupMenuCalender = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barClear = new DevExpress.XtraBars.BarButtonItem();
            this.calenderControl = new DevExpress.XtraEditors.Controls.CalendarControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerCalender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuCalender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calenderControl.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManagerCalender
            // 
            this.barManagerCalender.DockingEnabled = false;
            this.barManagerCalender.Form = this;
            this.barManagerCalender.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barClear});
            this.barManagerCalender.MaxItemId = 1;
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
            // calenderControl
            // 
            this.calenderControl.AutoSize = false;
            this.calenderControl.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calenderControl.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.calenderControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calenderControl.DrawCellLines = true;
            this.calenderControl.Location = new System.Drawing.Point(0, 0);
            this.calenderControl.Name = "calenderControl";
            this.barManagerCalender.SetPopupContextMenu(this.calenderControl, this.popupMenuCalender);
            this.calenderControl.ShowWeekNumbers = true;
            this.calenderControl.Size = new System.Drawing.Size(450, 336);
            this.calenderControl.TabIndex = 5;
            this.calenderControl.ToolTipController = this.toolTipCalender;
            // 
            // frmCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 336);
            this.Controls.Add(this.calenderControl);
            this.Name = "frmCalender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCalender";
            ((System.ComponentModel.ISupportInitialize)(this.barManagerCalender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuCalender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calenderControl.CalendarTimeProperties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.ToolTipController toolTipCalender;
        private DevExpress.XtraBars.BarManager barManagerCalender;
        private DevExpress.XtraBars.PopupMenu popupMenuCalender;
        private DevExpress.XtraBars.BarButtonItem barClear;
        private DevExpress.XtraEditors.Controls.CalendarControl calenderControl;
    }
}