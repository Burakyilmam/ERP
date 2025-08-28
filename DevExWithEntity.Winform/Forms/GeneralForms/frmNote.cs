using DevExWithEntity.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExWithEntity.Winform.Forms.GeneralForms
{
    public partial class frmNote : Form
    {
        public Calender _calender;
        public frmNote(DateTime date, Calender calender = null)
        {
            InitializeComponent();
            InitEvents();

            _calender = calender;

            if (_calender != null)
            {
                edTitle.EditValue = _calender.Title;
                edNote.EditValue = _calender.Note;
            }
            else
            {
                _calender = new Calender()
                {
                    User = General.activeUser,
                    CurrentDate = date,
                };

                General._calender.Add(_calender);
            }
        }
        void InitEvents()
        {
            btnNote.Click += BtnNote_Click;
        }

        private void BtnNote_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(edTitle.EditValue.ToString()))
            {
                MessageBox.Show("Başlık alanı boş bırakılamaz");
                edTitle.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(edNote.EditValue.ToString()))
            {
                MessageBox.Show("Not alanı boş bırakılamaz");
                edNote.Focus();
                return;
            }

            if (edTitle.EditValue.ToString().Length > 50)
            {
                MessageBox.Show("Başlık 50 karakterden fazla olmamalı");
                edTitle.Focus();
                return;
            }

            _calender.Title = edTitle.EditValue.ToString();
            _calender.Note = edNote.EditValue.ToString();

            General._calender.Update(_calender);

            this.Hide();
        }
    }
}
