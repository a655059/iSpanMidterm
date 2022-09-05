using pgjMidtermProject;
using prjProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace prjProject
{
    public partial class MainForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect, // x-coordinate of upper-left corner
    int nTopRect, // y-coordinate of upper-left corner
    int nRightRect, // x-coordinate of lower-right corner
    int nBottomRect, // y-coordinate of lower-right corner
    int nWidthEllipse, // height of ellipse
    int nHeightEllipse // width of ellipse
 );

        public MainForm()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        public string memberName
        {
            get
            {
                return lblWelcome.Text;
            }
            set
            {
                lblWelcome.Text = value;
            }
        }
        public string ProductNumInCart
        {
            get
            {
                return lblProductNumInCart.Text;
            }
            set
            {
                lblProductNumInCart.Text = value;
            }
        }

        public int memberID { get; set; }
        iSpanProjectEntities dbContext = new iSpanProjectEntities();
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadAllItem();
            LoadBigTypeList();
        }
        private void LoadAllItem()
        {
            flowpanelItem.Controls.Clear();
            var q = dbContext.Products.Take(50).Select(i => i);
            List<CtrlDisplayItem> list = CFunctions.GetProductsForShow(q);
            foreach (CtrlDisplayItem i in list)
            {
                flowpanelItem.Controls.Add(i);
                i.Click += CtrlDisplayItem_Click;
                foreach (Control control in i.Controls)
                {
                    control.Click += CtrlDisplayItem_Click;
                }
            }
            Application.DoEvents();
        }
        private void LoadBigTypeList()
        {
            flowpanelType.Controls.Clear();
            List<FlowBarProductType> listpt = new List<FlowBarProductType>();
            var q = from bt in dbContext.BigTypes
                    orderby bt.BigTypeID
                    select bt;

            foreach (var item in q)
            {
                FlowBarProductType fbpt = new FlowBarProductType();
                fbpt.TypeName = item.BigTypeName;
                fbpt.TypeNum = item.BigTypeID;
                fbpt.ButtonClicked += BigType_Click;
                listpt.Add(fbpt);
            }
            foreach (var item in listpt)
            {
                flowpanelType.Controls.Add(item);
            }
            Application.DoEvents();
        }
        private void BigType_Click(object sender, EventArgs e)
        {
            FlowBarProductType _selected = (FlowBarProductType)sender;
            flowpanelType.Controls.Clear();
            int bigtypenum = _selected.TypeNum;
            List<FlowBarProductType> listpt = new List<FlowBarProductType>();
            FlowBarProductTypeLastPage lp = new FlowBarProductTypeLastPage { TypeName = "回上一層" };
            lp.ButtonClicked += LastPage_Click;
            flowpanelType.Controls.Add(lp);

            var q = from st in dbContext.SmallTypes
                    where st.BigTypeID == bigtypenum
                    orderby st.SmallTypeID
                    select st;

            foreach (var item in q)
            {
                FlowBarProductType lpp = new FlowBarProductType { TypeName = item.SmallTypeName, TypeNum = item.SmallTypeID };
                lpp.ButtonClicked += SmallType_Click;
                listpt.Add(lpp);
            }
            foreach (var item in listpt)
            {
                flowpanelType.Controls.Add(item);
            }
            Application.DoEvents();
            flowpanelItem.Controls.Clear();
            var q2 = dbContext.Products.Where(x => x.SmallType.BigTypeID == _selected.TypeNum).OrderBy(x => x.SmallTypeID).Select(x => x);
            if (!q2.Any()) return;
            List<CtrlDisplayItem> list = CFunctions.GetProductsForShow(q2);
            foreach (CtrlDisplayItem j in list.Take(100))
            {
                flowpanelItem.Controls.Add(j);
                j.Click += CtrlDisplayItem_Click;
                foreach (Control control in j.Controls)
                {
                    control.Click += CtrlDisplayItem_Click;
                }
            }
            Application.DoEvents();
        }
        private void SmallType_Click(object sender, EventArgs e)
        {
            FlowBarProductType _selected = (FlowBarProductType)sender;
            flowpanelItem.Controls.Clear();
            var q = dbContext.Products.Where(x => x.SmallTypeID == _selected.TypeNum).OrderBy(x => x.SmallTypeID).Select(x => x);
            if (!q.Any()) return;
            List<CtrlDisplayItem> list = CFunctions.GetProductsForShow(q);
            foreach (CtrlDisplayItem j in list)
            {
                flowpanelItem.Controls.Add(j);
                j.Click += CtrlDisplayItem_Click;
                foreach (Control control in j.Controls)
                {
                    control.Click += CtrlDisplayItem_Click;
                }
            }
            Application.DoEvents();
        }
        private void LastPage_Click(object sender, EventArgs e)
        {
            LoadBigTypeList();
            LoadAllItem();
        }

        private void CtrlDisplayItem_Click(object sender, EventArgs e)
        {
            int productID = -1;
            CFunctions.ClickItemAndShow(sender, out productID);
            SelectedProductForm form = new SelectedProductForm();
            form.productID = productID;
            form.memberID = memberID;
            form.ProductNumInCart = ProductNumInCart;
            form.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnWindowMaximized_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else this.WindowState = FormWindowState.Maximized;
        }

        private void btnWindowMinimized_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm form = new LoginForm();
            form.ShowDialog();
            if (memberID != 0) lblWelcome.Visible = true;
        }

        private void pbCart_Click(object sender, EventArgs e)
        {
            if (memberID == 0)
            {
                LoginForm form = new LoginForm();
                form.ShowDialog();
            }
            else
            {
                CartForm form = new CartForm();
                form.ShowDialog();
            }
        }

        private void linkLabelHouTai_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            主畫面 form = new 主畫面();
            form.ShowDialog();
        }

        private void linkLabelMemberCenter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
