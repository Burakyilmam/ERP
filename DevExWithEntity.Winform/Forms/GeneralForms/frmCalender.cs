using DevExpress.XtraEditors.Calendar;
using DevExWithEntity.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DevExWithEntity.Winform.Forms.GeneralForms
{
    public partial class frmCalender : Form
    {
        private string ustYazi = "";
        private string altYazi = "";
        private Point mousePos;
        private bool isHover = false;


        private List<DateTime> specialDays = new List<DateTime>
        {
            new DateTime(DateTime.Now.Year, 1, 1),   // Yılbaşı
            new DateTime(DateTime.Now.Year, 4, 23),  // Ulusal Egemenlik ve Çocuk Bayramı
            new DateTime(DateTime.Now.Year, 5, 1),   // Emek ve Dayanışma Günü
            new DateTime(DateTime.Now.Year, 5, 19),  // Atatürk’ü Anma, Gençlik ve Spor Bayramı
            new DateTime(DateTime.Now.Year, 7, 15),  // Demokrasi Bayramı
            new DateTime(DateTime.Now.Year, 8, 30),  // Zafer Bayramı
            new DateTime(DateTime.Now.Year, 10, 29)  // Cumhuriyet Bayramı
            // Dini Bayramlar API ile getirilecek
        };

        public frmCalender()
        {
            InitializeComponent();
            InitEvents();
        }

        void InitEvents()
        {
            calenderControl.MouseDoubleClick += calenderControl_MouseDoubleClick;
            calenderControl.MouseMove += calenderControl_MouseMove;
            calenderControl.MouseUp += CalenderControl_MouseUp;
            calenderControl.CustomDrawDayNumberCell += CalenderControl_CustomDrawDayNumberCell;

            barClear.ItemClick += BarClear_ItemClick;
        }

        private void BarClear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CalendarHitInfo hitInfo = calenderControl.GetHitInfo(calenderControl.PointToClient(Cursor.Position));

            if (hitInfo.HitTest != CalendarHitInfoType.MonthNumber) return;

            DateTime hoveredDate = hitInfo.HitDate.Date;

            var calender = General._context.Calenders.FirstOrDefault(x => x.CurrentDate == hoveredDate && x.UserID == General.activeUser.ID);

            if (calender != null)
            {
                General._calender.Delete(calender);

                calenderControl.Invalidate();
            }
        }

        private void CalenderControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                popupMenuCalender.ShowPopup(Control.MousePosition);
            }
        }

        private void CalenderControl_CustomDrawDayNumberCell(object sender, CustomDrawDayNumberCellEventArgs e)
        {
            if (e.View.ToString() != "MonthInfo") return;

            e.Handled = true;
            DateTime currentDate = e.Date;
            Rectangle rDay = e.Bounds;
            string dayText = currentDate.Day.ToString();

            Font dayFont = new Font("Segoe UI", 10, FontStyle.Regular);
            Font noteFont = new Font("Segoe UI", 7, FontStyle.Regular);

            Brush normalForeColor = new SolidBrush(Color.Black);
            SolidBrush normalBackColor = new SolidBrush(Color.White);

            Brush specialForeColor = new SolidBrush(Color.DarkOrange);
            SolidBrush specialBackColor = new SolidBrush(Color.White);

            Brush weekendForeColor = new SolidBrush(Color.Red);
            SolidBrush weekendBackColor = new SolidBrush(Color.White);

            Brush todayForeColor = new SolidBrush(Color.SteelBlue);
            SolidBrush todayBackColor = new SolidBrush(Color.White);

            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            isHover = rDay.Contains(mousePos);

            Brush backBrush;
            Brush foreBrush;

            if (isHover)
            {
                if (currentDate.Date == DateTime.Now.Date)
                {
                    backBrush = todayBackColor;
                    foreBrush = todayForeColor;
                }
                else if (specialDays.Any(d => d.Date == currentDate.Date))
                {
                    backBrush = specialForeColor;
                    foreBrush = specialBackColor;
                }
                else if (currentDate.Date.DayOfWeek == DayOfWeek.Sunday || currentDate.Date.DayOfWeek == DayOfWeek.Saturday)
                {
                    backBrush = weekendForeColor;
                    foreBrush = weekendBackColor;
                }
                else
                {
                    backBrush = normalForeColor;
                    foreBrush = normalBackColor;
                }
            }
            else
            {
                if (currentDate.Date == DateTime.Now.Date)
                {
                    backBrush = todayForeColor;
                    foreBrush = todayBackColor;
                }
                else if (specialDays.Any(d => d.Date == currentDate.Date))
                {
                    backBrush = specialBackColor;
                    foreBrush = specialForeColor;
                }

                else if (currentDate.Date.DayOfWeek == DayOfWeek.Sunday || currentDate.Date.DayOfWeek == DayOfWeek.Saturday)
                {
                    backBrush = weekendBackColor;
                    foreBrush = weekendForeColor;
                }
                else
                {
                    backBrush = normalBackColor;
                    foreBrush = normalForeColor;
                }
            }

            e.Graphics.FillRectangle(backBrush, rDay);
            e.Graphics.DrawString(dayText, dayFont, foreBrush, rDay, sf);

            Calender calender = General._context.Calenders.FirstOrDefault(x => x.CurrentDate == currentDate && x.UserID == General.activeUser.ID);

            if (calender != null && !string.IsNullOrEmpty(calender.Title))
            {
                string[] lines = calender.Title.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

                string ustYazi = lines[0];
                string altYazi = lines.Length > 1 ? lines[1] : "";

                if (lines.Length > 2 || altYazi.Length > 15)
                {
                    altYazi += "...";
                }

                Rectangle rTopTitle = rDay;
                Rectangle rBottomTitle = rDay;

                int formHeight = this.Height;
                int formWidth = this.Width;

                if (formHeight < 617)
                {
                    rTopTitle.Y -= 12;
                    rBottomTitle.Y += 12;
                }
                else if (formHeight > 616 || formWidth > 663)
                {
                    rTopTitle.Y -= 8;
                    rBottomTitle.Y += 8;
                }

                e.Graphics.DrawString(ustYazi, noteFont, foreBrush, rTopTitle, sf);

                if (!string.IsNullOrEmpty(altYazi))
                {
                    e.Graphics.DrawString(altYazi, noteFont, foreBrush, rBottomTitle, sf);
                }
            }
        }

        private void calenderControl_MouseMove(object sender, MouseEventArgs e)
        {
            mousePos = e.Location;
            calenderControl.Invalidate();
            CalendarHitInfo hitInfo = calenderControl.GetHitInfo(e.Location);

            if (hitInfo.HitTest == CalendarHitInfoType.MonthNumber)
            {
                DateTime currentDate = hitInfo.HitDate.Date;

                string title = General._context.Calenders.Where(x => x.CurrentDate == currentDate && x.UserID == General.activeUser.ID).Select(x => x.Title).FirstOrDefault();

                if (!string.IsNullOrEmpty(title))
                {
                    toolTipCalender.ShowHint(title, calenderControl.PointToScreen(e.Location));
                }
                else
                {
                    toolTipCalender.HideHint();
                }
            }
        }

        private void calenderControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CalendarHitInfo hitInfo = calenderControl.GetHitInfo(e.Location);
            DateTime date = hitInfo.HitDate.Date;


            Calender calender = General._context.Calenders.FirstOrDefault(x => x.CurrentDate == date && x.UserID == General.activeUser.ID);

            if (hitInfo.HitTest == CalendarHitInfoType.MonthNumber)
            {
                frmNote note = new frmNote(calenderControl.DateTime, calender);
                note.Text = calenderControl.DateTime.ToString("dd.MM.yyyy");
                note.StartPosition = FormStartPosition.CenterScreen;
                note.Show();

                if (note.DialogResult == DialogResult.OK)
                {
                    calenderControl.Invalidate();
                }
            }
        }
    }
}
