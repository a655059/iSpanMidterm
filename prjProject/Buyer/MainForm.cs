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
        public MainForm()
        {
            InitializeComponent();

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
        //AD CHECK
        int _ADid;
        FlowBarProductType _tempBigtype;
        FlowBarProductType _tempSmalltype;
        private bool _smallkey=false;
        private bool _isinSearch=false;

        private void MainForm_Load(object sender, EventArgs e)
        {
            //猜你喜歡
            gueseYouLike();
            //載入大類別
            LoadBigTypeList();
            //載入搜尋列
            searchbarReset();
            //ad載入
            ads(pbAD1, tbAD1, adtrigger1);
            ads(pbAD2, tbAD2, adtrigger2);
            //timer載入
            time_set();
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
            flowpanelTypeItem.Controls.Clear();
        }
        //點左側大類別按鈕
        private void BigType_Click(object sender, EventArgs e)
        {
            spContainerItem.Visible = false;
            flowpanelType.Controls.Clear();
            _isInType = true;
            FlowBarProductType _selected = (FlowBarProductType)sender;
            _tempBigtype = _selected;
            _selectedName = _selected.TypeName;
            tbSearch.Text = "從" + _selectedName + "分類中搜尋...";

            FlowBarProductTypeLastPage lp = new FlowBarProductTypeLastPage { TypeName = "回上一層" };
            lp.ButtonClicked += LastPage_Click;
            flowpanelType.Controls.Add(lp);

            SmalltypeShow(_selected);
            selectedItem(_selected);
        }
        //左側小類別按鈕 Show
        private void SmalltypeShow(FlowBarProductType f)
        {
            var q = dbContext.SmallTypes.Where(st => st.BigTypeID == f.TypeNum).OrderBy(st => st.SmallTypeID).Select(st => st);
            List<FlowBarProductType> listpt = new List<FlowBarProductType>();
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
        }
        //左側小類別按鈕 Click
        private void SmallType_Click(object sender, EventArgs e)
        {
            _smallkey = true;
            FlowBarProductType _selected = (FlowBarProductType)sender;
            _tempSmalltype = _selected;
            smalltypeColor(_selected);
            Application.DoEvents();
            selectedItem(_selected);
        }
        //小類別 功能 顏色調整
        private void smalltypeColor(FlowBarProductType f)
        {
            foreach (Control i in flowpanelType.Controls)
            {
                if (i is FlowBarProductType && i != f)
                {
                    ((FlowBarProductType)i).BackColor = Color.Black;
                    ((FlowBarProductType)i)._isclicked = false;
                }
            }
            f._isclicked = true;
            f.BackColor = Color.Red;
        }
        //小類別 功能 商品呈現
        private void selectedItem(object sender)
        {
            FlowBarProductType _selected = (FlowBarProductType)sender;
            flowpanelTypeItem.Controls.Clear();
            List<CtrlDisplayItem> list = new List<CtrlDisplayItem>();
            if (!_smallkey)
            {
                var q = dbContext.Products.Where(x => x.SmallType.BigTypeID == _selected.TypeNum && x.ProductStatusID == 0).OrderBy(x => x.SmallTypeID).Take(50).Select(x => x);
                if (!q.Any()) return;
                foreach(var item in CFunctions.GetProductsForShow(q))
                {
                    list.Add(item);
                }
            }
            else
            {
                var q = dbContext.Products.Where(x => x.SmallTypeID == _selected.TypeNum && x.ProductStatusID == 0).OrderBy(x => x.SmallTypeID).Select(x => x);
                if (!q.Any()) return;
                foreach (var item in CFunctions.GetProductsForShow(q))
                {
                    list.Add(item);
                }
            }
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
        //Smalltype 功能 回上一頁
        private void LastPage_Click(object sender, EventArgs e)
        {
            if (!_smallkey)
            {
                LoadBigTypeList();
                spContainerItem.Visible = true;
                gueseYouLike();
                searchbarReset();
            }
            else if (_smallkey&&!_isinSearch)
            {
                _smallkey = false;
                _tempSmalltype.BackColor = Color.Black;
                _tempSmalltype._isclicked = false;
                selectedItem(_tempBigtype);
            }
            else if(_smallkey && _isinSearch)
            {
                searchbarReset();
                _smallkey = false;
                SmalltypeShow(_tempBigtype);
                selectedItem(_tempBigtype);
            }
        }
        //Smalltype分頁 功能 清除
        private void _smallfloorreset()
        {
            
        }
        //Bigtype主頁 猜你喜歡
        private void gueseYouLike()
        {
            spContainerItem.Visible = true;
            flowpanelAD.Controls.Clear();
            Random find5 = new Random();

            var productquery = from q in dbContext.Products
                               where q.ProductStatusID == 0
                               select q.ProductID;
            int Counter = 5;
            if (productquery.Count() <= 0) return;
            else if (productquery.Count() < Counter) Counter = productquery.Count();
            int[] randomArray = new int[Counter];
            for (int i = 0; i < Counter; i++)
            {
                int index = find5.Next(productquery.Count());
                randomArray[i] = productquery.ToList()[index];
                for (int j = 0; j < i; j++)
                {
                    while (randomArray[j] == randomArray[i])
                    {
                        index = find5.Next(productquery.Count());
                        randomArray[i] = productquery.ToList()[index];
                        j = 0;
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
        //視窗按鈕
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
        //點選購物車
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
        //主頁面 會員登入
        private void linkLabelMemberCenter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (memberID == 0)
            {
                LoginForm form = new LoginForm();
                form.ShowDialog();
                memCheck(memberID);
                if (memberID == 0) return;
                member_center form2 = new member_center();
                form2.memberName = memberName;
                form2.memeberID = memberID;
                form2.ShowDialog();
            }
            else
            {
                member_center form = new member_center();
                form.memberName = memberName;
                form.memeberID = memberID;
                form.ShowDialog();
            }
        }
        //搜索功能
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbSearch.Text) && SearchSys(tbSearch.Text).Count != 0)
            {
                flowpanelType.Controls.Clear();
                FlowBarProductTypeLastPage lp = new FlowBarProductTypeLastPage { TypeName = "回上一層" };
                lp.ButtonClicked += LastPage_Click;
                flowpanelType.Controls.Add(lp);

                spContainerItem.Visible = false;
                flowpanelTypeItem.Controls.Clear();
                List<CtrlDisplayItem> list = SearchSys(tbSearch.Text);
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
            else
            {
                MessageBox.Show("查無此產品，請確認關鍵字");
                return;
            }
        }
        //搜尋鍵 focus&leave
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
            _isinSearch = true;
            if (_isInType)
            {
                //if (_smallkey) _smallfloorreset();
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
            _isinSearch = false;
            if (_isInType)
            {
                tbSearch.Text = "從" + _selectedName + "分類中搜尋...";
                tbSearch.ForeColor = Color.LightGray;
                textboxHasText = false;
            }
            else {
                _selectedName = "從全部商品中搜尋...";
                tbSearch.Text = _selectedName;
                tbSearch.ForeColor = Color.LightGray;
                textboxHasText = false;
                _isInType = false;
            }
        }
        //主頁面 賣家中心
        private void lblToSellerForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (memberID == 0)
            {
                LoginForm form = new LoginForm();
                form.ShowDialog();
                memCheck(memberID);
                if (memberID == 0) return;
                賣家中心 form2 = new 賣家中心();
                form2.memberID = memberID;
                form2.ShowDialog();
            }
            else
            {
                賣家中心 form = new 賣家中心();
                form.memberID = memberID;
                form.ShowDialog();
            }
        }

        //AD輪播timer
        private void time_set()
        {
            timer1.Interval = 5000;
            timer1.Enabled = true;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (spContainerItem.Visible == true)
            {
                gueseYouLike();
                ads(pbAD1, tbAD1,adtrigger1);
                ads(pbAD2, tbAD2, adtrigger2);
            }
        }
        //檢查會員
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
        //主頁面 優惠券領取
        private void EventAD1_Click(object sender, EventArgs e)
        {
            if (memberID == 0)
            {
                LoginForm form = new LoginForm();
                form.ShowDialog();
                memCheck(memberID);
                if (memberID == 0) return;
                Event_Coupon form2 = new Event_Coupon() {memberID=memberID };
                form2.ShowDialog();
            }
            else
            {
                Event_Coupon form = new Event_Coupon() { memberID = memberID };
                form.ShowDialog();
            }
        }
        //註冊頁面連結
        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 createAcc = new Form1();
            createAcc.ShowDialog();
        }
        //下排廣告輪播
        private void ads(PictureBox picturebox,TextBox textbox,Label l)
        {
            var adlist = dbContext.Products.Where(p => p.AdFee > 0 && p.ProductStatusID == 0).OrderBy(p=>p.ProductID).Select(p => p).ToList();

            if (adlist.Count() == 0) return;
            Random r = new Random();
            int idx = r.Next(adlist.Count());
            while (_ADid == idx)
                idx = r.Next(adlist.Count());
            _ADid = idx;
            int id = adlist[idx].ProductID;
            l.Text = id.ToString();
            textbox.Text = dbContext.Products.Where(p => p.ProductID == id).Select(p => p.Description).FirstOrDefault();
            var photo = dbContext.ProductPics.Where(p => p.ProductID == id).Select(p => p.picture).FirstOrDefault();
            if (photo != null)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(photo);
                picturebox.Image = Image.FromStream(ms);
            }
            else
                picturebox.Image = picturebox.ErrorImage;
        }
        private void clickAD(int pid)
        {
            SelectedProductForm selectp = new SelectedProductForm();
            selectp.productID = pid;
            selectp.ShowDialog();
        }
        private void pbAD1_Click(object sender, EventArgs e)
        {            
            clickAD(Convert.ToInt32(adtrigger1.Text));
        }
        private void pbAD2_Click(object sender, EventArgs e)
        {
            clickAD(Convert.ToInt32(adtrigger2.Text));
        }
    }
}
