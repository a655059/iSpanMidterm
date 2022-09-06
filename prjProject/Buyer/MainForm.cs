using pgjMidtermProject;
using prjProject.Buyer;
using prjProject.Entity;
using prjProject.Models;
using Project_期中專案;
using seller;
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
        //調整圓角 沒啥用
        //        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //        private static extern IntPtr CreateRoundRectRgn
        //(
        //    int nLeftRect, // x-coordinate of upper-left corner
        //    int nTopRect, // y-coordinate of upper-left corner
        //    int nRightRect, // x-coordinate of lower-right corner
        //    int nBottomRect, // y-coordinate of lower-right corner
        //    int nWidthEllipse, // height of ellipse
        //    int nHeightEllipse // width of ellipse
        // );

        public MainForm()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            timer1.Interval = 5000;
            timer1.Enabled = true;
            timer1.Start();
        }
        public string memberName
        {
            get
            {
                return lblName.Text;
            }
            set
            {
                lblName.Text = value;
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
        //int _page;
        //搜索系統
        string _selectedName = "";
        bool textboxHasText = false;
        bool _isInType = false;
        private void MainForm_Load(object sender, EventArgs e)
        {
            gueseYouLike();
            //LoadAllItem();
            LoadBigTypeList();
            searchbarReset();
        }
        //private void LoadAllItem()
        //{

        //    spContainerItem.Visible = true;
        //    flowpanelItem.Controls.Clear();
        //    var q = dbContext.Products.Take(50).Select(i => i);
        //    List<CtrlDisplayItem> list = CFunctions.GetProductsForShow(q);
        //    foreach (CtrlDisplayItem i in list)
        //    {
        //        flowpanelItem.Controls.Add(i);
        //        i.Click += CtrlDisplayItem_Click;
        //        foreach (Control control in i.Controls)
        //        {
        //            control.Click += CtrlDisplayItem_Click;
        //        }
        //    }
        //    Application.DoEvents();
        //}
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
            flowpanelTypeItem.Controls.Clear();
        }
        //點左側大類別按鈕
        private void BigType_Click(object sender, EventArgs e)
        {
            spContainerItem.Visible = false;
            flowpanelType.Controls.Clear();

            FlowBarProductType _selected = (FlowBarProductType)sender;
            int bigtypenum = _selected.TypeNum;
            _selectedName = _selected.TypeName;
            tbSearch.Text = "從" + _selectedName + "分類中搜尋...";
            _isInType = true;

            //新增回上一層按鈕
            List<FlowBarProductType> listpt = new List<FlowBarProductType>();
            FlowBarProductTypeLastPage lp = new FlowBarProductTypeLastPage { TypeName = "回上一層" };
            lp.ButtonClicked += LastPage_Click;
            flowpanelType.Controls.Add(lp);
            //新增左側小類別按鈕
            var q = dbContext.SmallTypes.Where(st => st.BigTypeID == bigtypenum).OrderBy(st => st.SmallTypeID).Select(st => st);
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
            //商品區處理
            flowpanelTypeItem.Controls.Clear();
            var q2 = dbContext.Products.Where(x => x.SmallType.BigTypeID == _selected.TypeNum && x.ProductStatusID == 0).OrderBy(x => x.SmallTypeID).Take(50).Select(x => x);
            if (!q2.Any()) return;
            List<CtrlDisplayItem> list = CFunctions.GetProductsForShow(q2);
            foreach (CtrlDisplayItem j in list)
            {
                flowpanelTypeItem.Controls.Add(j);
                j.Click += CtrlDisplayItem_Click;
                foreach (Control control in j.Controls)
                {
                    control.Click += CtrlDisplayItem_Click;
                }
            }
            Application.DoEvents();
        }
        //點左側副類別按鈕
        private void SmallType_Click(object sender, EventArgs e)
        {
            FlowBarProductType _selected = (FlowBarProductType)sender;
            foreach (Control i in flowpanelType.Controls)
            {
                if (i is FlowBarProductType && i != _selected)
                {
                    ((FlowBarProductType)i).BackColor = Color.Black;
                    ((FlowBarProductType)i)._isclicked = false;
                }
            }
            _selected._isclicked = true;
            Application.DoEvents();
            //商品區處理
            flowpanelTypeItem.Controls.Clear();
            var q = dbContext.Products.Where(x => x.SmallTypeID == _selected.TypeNum && x.ProductStatusID == 0).OrderBy(x => x.SmallTypeID).Select(x => x);
            if (!q.Any()) return;
            List<CtrlDisplayItem> list = CFunctions.GetProductsForShow(q);
            foreach (CtrlDisplayItem j in list)
            {
                flowpanelTypeItem.Controls.Add(j);
                j.Click += CtrlDisplayItem_Click;
                foreach (Control control in j.Controls)
                {
                    control.Click += CtrlDisplayItem_Click;
                }
            }
        }
        private void LastPage_Click(object sender, EventArgs e)
        {
            LoadBigTypeList();
            spContainerItem.Visible = true;
            gueseYouLike();
            searchbarReset();
        }
        private void gueseYouLike()
        {
            spContainerItem.Visible = true;
            flowpanelAD.Controls.Clear();
            Random find5 = new Random();
            int[] randomArray = new int[5];
            var productquery = from q in dbContext.Products
                               where q.ProductStatusID == 0
                               select q.ProductID;
            int Couter = 5;
            if (productquery.Count() <= 0) return;
            else if (productquery.Count() < Couter) Couter = productquery.Count();

            for (int i = 0; i < Couter; i++)
            {
                int index = find5.Next(productquery.Count());
                randomArray[i] = productquery.ToList()[index];
                for (int j = 1; j < i; j++)
                {
                    while (randomArray[j] == randomArray[i])
                    {
                        j = 0;
                        randomArray[i] = productquery.ToList()[index];
                    }
                }
            }

            List<CtrlDisplayItem> list = new List<CtrlDisplayItem>();
            foreach (int idx in randomArray)
            {
                var pidx = from p in dbContext.Products
                           where p.ProductID == idx
                           select p;
                list.Add(CFunctions.GetProductsForShow(pidx)[0]);
            }
            foreach (CtrlDisplayItem j in list)
            {
                flowpanelAD.Controls.Add(j);
                j.Click += CtrlDisplayItem_Click;
                foreach (Control control in j.Controls)
                {
                    control.Click += CtrlDisplayItem_Click;
                }
            }

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
        //右上三個視窗按鈕
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
        //登入
        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm form = new LoginForm();
            form.ShowDialog();
            memCheck(memberID);
        }

        private void pbCart_Click(object sender, EventArgs e)
        {
            if (memberID == 0)
            {
                LoginForm form = new LoginForm();
                form.ShowDialog();
                memCheck(memberID);
                if (memberID == 0) return;
                CartForm form2 = new CartForm();
                form2.ShowDialog();
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
            if (memberID == 0)
            {
                LoginForm form = new LoginForm();
                form.ShowDialog();
                memCheck(memberID);
                if (memberID == 0) return;
                member_center form2 = new member_center();
                form2.ShowDialog();
            }
            else
            {
                member_center form = new member_center();
                form.ShowDialog();
            }
        }
        //搜索功能
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (_isInType)
            {
                if (!String.IsNullOrWhiteSpace(tbSearch.Text) && SearchSys(tbSearch.Text).Count != 0)
                {
                    flowpanelType.Controls.Clear();
                    FlowBarProductTypeLastPage lp = new FlowBarProductTypeLastPage { TypeName = "回上一層" };
                    lp.ButtonClicked += LastPage_Click;
                    flowpanelType.Controls.Add(lp);

                    spContainerItem.Visible = false;
                    flowpanelTypeItem.Controls.Clear();
                    foreach (CtrlDisplayItem j in SearchSys(tbSearch.Text))
                    {
                        flowpanelTypeItem.Controls.Add(j);
                        j.Click += CtrlDisplayItem_Click;
                        foreach (Control control in j.Controls)
                        {
                            control.Click += CtrlDisplayItem_Click;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("查無此產品，請確認關鍵字");
                    return;
                }
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(tbSearch.Text) && SearchSys(tbSearch.Text).Count != 0)
                {
                    flowpanelType.Controls.Clear();
                    FlowBarProductTypeLastPage lp = new FlowBarProductTypeLastPage { TypeName = "回上一層" };
                    lp.ButtonClicked += LastPage_Click;
                    flowpanelType.Controls.Add(lp);

                    spContainerItem.Visible = false;
                    flowpanelTypeItem.Controls.Clear();
                    foreach (CtrlDisplayItem j in SearchSys(tbSearch.Text))
                    {
                        flowpanelTypeItem.Controls.Add(j);
                        j.Click += CtrlDisplayItem_Click;
                        foreach (Control control in j.Controls)
                        {
                            control.Click += CtrlDisplayItem_Click;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("查無此產品，請確認關鍵字");
                    return;
                }
            }
        }
        //搜尋鍵
        private void tbSearch_Enter(object sender, EventArgs e)
        {
            if (textboxHasText == false)
                tbSearch.Text = "";

            tbSearch.ForeColor = Color.Black;
        }
        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                tbSearch.Text = _selectedName;
                tbSearch.ForeColor = Color.LightGray;
                textboxHasText = false;
            }
            else
                textboxHasText = true;
        }
        //關鍵字查詢
        private List<CtrlDisplayItem> SearchSys(string s)
        {
            if (_isInType)
            {
                var q = from p in dbContext.Products
                        where p.ProductName.ToUpper().Contains(s.ToUpper()) && p.SmallType.BigType.BigTypeName == _selectedName && p.ProductStatusID == 0
                        select p;
                List<CtrlDisplayItem> list = CFunctions.GetProductsForShow(q);
                return list;
            }
            else
            {
                var q = from p in dbContext.Products
                        where p.ProductName.ToUpper().Contains(s.ToUpper()) && p.ProductStatusID == 0
                        select p;
                List<CtrlDisplayItem> list = CFunctions.GetProductsForShow(q);
                return list;
            }
        }
        //重置搜尋
        private void searchbarReset()
        {
            tbSearch.Text = "從全部商品中搜尋...";
            _selectedName = "從全部商品中搜尋...";
            tbSearch.ForeColor = Color.LightGray;
            textboxHasText = false;
            _isInType = false;
        }
        //連結至賣家中心
        private void lblToSellerForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (memberID == 0)
            {
                LoginForm form = new LoginForm();
                form.ShowDialog();
                memCheck(memberID);
                if (memberID == 0) return;
                賣家中心 form2 = new 賣家中心();
                form2.ShowDialog();
            }
            else
            {
                賣家中心 form = new 賣家中心();
                form.memberID = memberID;
                form.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!_isInType)
            {
                gueseYouLike();
            }
        }
        private void memCheck(int i)
        {
            if (i == 0) return;
            else
            {
                lblName.Visible = true;
                linkLabelRegister.Visible = false;
                linkLabelLogin.Text = "歡迎";
                linkLabelLogin.LinkClicked -= linkLabelLogin_LinkClicked;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (memberID == 0)
            {
                LoginForm form = new LoginForm();
                form.ShowDialog();
                memCheck(memberID);
                if (memberID == 0) return;
                Event_Coupon form2 = new Event_Coupon();
                form2.ShowDialog();
            }
            else
            {
                Event_Coupon form = new Event_Coupon();
                form.ShowDialog();
            }
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 createAcc = new Form1();
            createAcc.ShowDialog();
        }
    }
}
