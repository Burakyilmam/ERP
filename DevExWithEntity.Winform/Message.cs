using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExWithEntity.Winform
{
    public static class Message
    {
        public static DialogResult MessageQuestion(string message, string title = "Soru")
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Caption = title;
            args.Text = message;
            args.Buttons = new DialogResult[] { DialogResult.Yes, DialogResult.No };
            return XtraMessageBox.Show(args);
        }

        public static DialogResult MessageError(string message, string title = "Hata")
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Caption = title;
            args.Text = message;
            args.Buttons = new DialogResult[] { DialogResult.OK };
            return XtraMessageBox.Show(args);
        }

        public static DialogResult MessageWarning(string message, string title = "Uyarı", int delay = 5000)
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Caption = title;
            args.Text = message;
            args.Buttons = new DialogResult[] { DialogResult.OK };
            args.AutoCloseOptions.Delay = delay;
            args.AutoCloseOptions.ShowTimerOnDefaultButton = true;
            return XtraMessageBox.Show(args);
        }

        public static DialogResult MessageSuccess(string message, string title = "Başarılı", int delay = 5000)
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Caption = title;
            args.Text = message;
            args.Buttons = new DialogResult[] { DialogResult.OK };
            args.AutoCloseOptions.Delay = delay;
            args.AutoCloseOptions.ShowTimerOnDefaultButton = true;
            return XtraMessageBox.Show(args);
        }
    }
}
