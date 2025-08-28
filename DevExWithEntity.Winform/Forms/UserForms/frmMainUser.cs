using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExWithEntity.DataAccess.Context;
using DevExWithEntity.Entity;
using DevExWithEntity.Winform.Forms.GeneralForms;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExWithEntity.Winform.Forms.UserForms
{
    public partial class frmMainUser : Form
    {
        public frmMainUser(DataContext context)
        {
            InitializeComponent();
            InitEvents();
        }
        void InitEvents()
        {
            FormClosed += FrmMainUser_FormClosed;
            Load += FrmMainUser_Load;

            btnUser.ItemClick += btnKullanici_ItemClick;
            btnSession.ItemClick += btnSession_ItemClick;

            btnCalender.ItemClick += BtnCalender_ItemClick;
            btnCalculater.ItemClick += BtnCalculater_ItemClick;

            trMenu.RowCellClick += TrMenu_RowCellClick;
        }

        private void BtnCalculater_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("calc");
        }

        private void BtnCalender_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCalender calender = new frmCalender();
            calender.Show();
        }

        private void TrMenu_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Node.Nodes != null && e.Node.Nodes.Count == 0 && e.Clicks == 1)
            {
                if (trMenu.FocusedNode.Tag != null)
                {
                    General.OpenMenuNode(trMenu.FocusedNode);
                    CreateNewTab(trMenu.FocusedNode.Tag.ToString(), trMenu.FocusedNode.GetDisplayText(colMenu).ToString());
                    GetTabs();
                }
            }
            else
            {
                if (trMenu.FocusedNode.HasChildren)
                {
                    if (trMenu.FocusedNode.Expanded) { trMenu.FocusedNode.Collapse(); }
                    else { trMenu.FocusedNode.Expand(); }
                }
            }
        }

        private void btnSession_ItemClick(object sender, ItemClickEventArgs e)
        {
            General.FormOpen(new frmSessions());
        }

        private void FrmMainUser_Load(object sender, EventArgs e)
        {
            GetTabs();
            ButtonVisibilityControl();
        }

        public void ButtonVisibilityControl()
        {
            btnUser.Visibility = General.activeUser.IsAdmin ? BarItemVisibility.Always : BarItemVisibility.Never;
            btnSession.Visibility = General.activeUser.IsAdmin ? BarItemVisibility.Always : BarItemVisibility.Never;
            barLog.Visibility = General.activeUser.IsAdmin ? BarItemVisibility.Always : BarItemVisibility.Never;
        }

        private void FrmMainUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (General.activeSession != null)
            {
                General.activeSession.LogoutDate = DateTime.Now;
                General.activeSession.SessionDuration = General.activeSession.LogoutDate - General.activeSession.LoginDate;
                General.activeSession.ActiveForm = this.Name;
                General._session.Update(General.activeSession);
            }

            Application.Exit();
        }

        private void btnKullanici_ItemClick(object sender, ItemClickEventArgs e)
        {
            General.FormOpen(new frmUsers());
        }

        public void CreateNewTab(string FormNo, string FormName)
        {
            Tab tab = General._context.Tabs.FirstOrDefault(x => x.FormNo == FormNo && x.User.ID == General.activeUser.ID);

            if (tab != null)
            {
                tab.OpenDate = DateTime.Now;
                tab.OpenCount += 1;
                tab.TabName = FormName;
                General._tab.Update(tab);
            }
            else
            {
                tab = new Tab
                {
                    FormNo = FormNo,
                    TabName = FormName,
                    FirstOpenDate = DateTime.Now,
                    OpenDate = DateTime.Now,
                    OpenCount = 1,
                    User = General.activeUser
                };
                General._tab.Add(tab);
            }
        }

        public void GetTabs()
        {
            tileControlTab.Groups.Clear();

            var tabs = General._tab.List(filter: x => x.User.ID == General.activeUser.ID, orderBy: q => q.OrderByDescending(x => x.OpenDate), take: 10);
            TileBarGroup tileBarGroup = new TileBarGroup();
            tileControlTab.Groups.Add(tileBarGroup);

            Color[] tabColors = new Color[]
            {
                Color.FromArgb(52, 152, 219),    // mavi
                Color.FromArgb(231, 76, 60),     // kırmızı
                Color.FromArgb(46, 204, 113),    // yeşil
                Color.FromArgb(155, 89, 182),    // mor
                Color.FromArgb(241, 196, 15),    // sarı
                Color.FromArgb(230, 126, 34),    // turuncu
                Color.FromArgb(26, 188, 156),    // turkuaz
                Color.FromArgb(52, 73, 94),      // koyu gri/mavi
                Color.FromArgb(149, 165, 166),   // gri
                Color.FromArgb(192, 57, 43)      // koyu kırmızı
            };


            int counter = 0;
            foreach (var tile in tabs)
            {
                TreeListNode node = trMenu.GetNodeList().Where(x => x.Tag?.ToString() == tile.FormNo).FirstOrDefault();

                if (node == null)
                {
                    continue;
                }

                TileBarItem item = new TileBarItem();
                item.Tag = tile.FormNo;
                item.ItemSize = TileBarItemSize.Medium;

                if (node != null)
                {
                    item.Text = tile.TabName;
                }

                item.SuperTip = new SuperToolTip();
                item.SuperTip.Items.Add(new ToolTipTitleItem() { Text = tile.FormNo });
                item.SuperTip.Items.Add(new ToolTipItem() { Text = tile.TabName });
                item.TextAlignment = TileItemContentAlignment.MiddleCenter;

                int tabIndex = counter % tabColors.Length;
                item.AppearanceItem.Normal.BackColor = tabColors[tabIndex];
                item.AppearanceItem.Normal.ForeColor = Color.White;

                tileBarGroup.Items.Add(item);

                item.ItemClick += delegate
                {
                    CreateNewTab(tile.FormNo, tile.TabName);

                    if (node != null)
                    {
                        trMenu.BeginUpdate();
                        trMenu.CollapseAll();
                        trMenu.FocusedNode = node;
                        trMenu.EndUpdate();
                        General.OpenMenuNode(node);
                    }
                };

                counter++;
            }
        }
    }
}
