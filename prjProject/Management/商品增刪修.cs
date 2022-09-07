using prjProject.Entity;
using prjProject.Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class 商品增刪修 : Form
    {
        public bool isproductupdate = false;
        public 商品增刪修()
        {
            InitializeComponent();
            var Big = DBiSpan.BigTypes.Select(n => n.BigTypeName).ToList();
            foreach (var b in Big)
            {
                cbBig.Items.Add(b);
            }
            var Small = DBiSpan.SmallTypes.Select(n => n.SmallTypeName).ToList();
            foreach (var s in Small)
            {
                cbSmall.Items.Add(s);
            }
            var Contry = DBiSpan.CountryLists.Select(n => n.CountryName).ToList();
            foreach (var c in Contry)
            {
                cbContry.Items.Add(c);
            }
            var Region = DBiSpan.RegionLists.Select(n => n.RegionName).ToList();
            foreach (var r in Region)
            {
                cbRegion.Items.Add(r);
            }
            var ship = DBiSpan.Shippers.Select(n => n.ShipperName).ToList();
            foreach (var i in ship)
            {
                cbship.Items.Add(i);
            }
        }

        iSpanProjectEntities DBiSpan = new iSpanProjectEntities();

        產品管理 產品介面 = new 產品管理();
        public int P_select { get; set; } //為了讓上一張form的product資料連接這張form的product
        public int PD_select { get; set; }//為了讓上一張form的productD資料連接這張form的productD
        public byte[] bytehead   //商品大頭貼二進位資料轉型
        {
            set
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(value);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }
        public byte[] bytepics   //商品大頭貼二進位資料轉型
        {
            set
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(value);
                pictureBox2.Image = Image.FromStream(ms);
            }
        }
        private void isLoad()
        {
            //===================================以下為product的資料帶入
            txtpdname.Text = DBiSpan.Products.Where(n => n.ProductID == P_select)
                .Select(n => n.ProductName).FirstOrDefault();

            var SMall = DBiSpan.Products.Where(n => n.ProductID == P_select)
                .Select(n => n.SmallTypeID).FirstOrDefault();
            cbSmall.Text = DBiSpan.SmallTypes.Where(n => n.SmallTypeID == SMall)
                .Select(n => n.SmallTypeName).FirstOrDefault();

            var BIg = DBiSpan.SmallTypes.Where(n => n.SmallTypeID == SMall)
                .Select(n => n.BigTypeID).FirstOrDefault();
            cbBig.Text = DBiSpan.BigTypes.Where(n => n.BigTypeID == BIg)
                .Select(n => n.BigTypeName).FirstOrDefault();           

            txtdesc.Text = DBiSpan.Products.Where(n => n.ProductID == P_select)
                .Select(n => n.Description).FirstOrDefault();

            var Ship = DBiSpan.Products.Where(n => n.ProductID == P_select)
                .Select(n => n.ShipperID).FirstOrDefault();
            cbship.Text = DBiSpan.Shippers.Where(n => n.ShipperID == Ship)
                .Select(n => n.ShipperName).FirstOrDefault();

            var REgin = DBiSpan.Products.Where(n => n.ProductID == P_select)
                .Select(n => n.RegionID).FirstOrDefault();
            cbRegion.Text = DBiSpan.RegionLists.Where(n => n.RegionID == REgin)
                .Select(n => n.RegionName).FirstOrDefault();

            var Country = DBiSpan.RegionLists.Where(n => n.RegionID == REgin)
                .Select(n => n.CountryID).FirstOrDefault();
            cbContry.Text = DBiSpan.CountryLists.Where(n => n.CountryID == Country)
                .Select(n => n.CountryName).FirstOrDefault();

            txtpdfee.Text = DBiSpan.Products.Where(n => n.ProductID == P_select)
                .Select(n => n.AdFee).FirstOrDefault().ToString();
            //===================================以下為detail的資料帶入
            txtstyle.Text = DBiSpan.ProductDetails.Where(n => n.ProductDetailID == PD_select)
               .Select(n => n.Style).FirstOrDefault();

            txtpdup.Text = DBiSpan.ProductDetails.Where(n => n.ProductDetailID == PD_select)
               .Select(n => n.UnitPrice).FirstOrDefault().ToString();

            txtpdquty.Text = DBiSpan.ProductDetails.Where(n => n.ProductDetailID == PD_select)
               .Select(n => n.Quantity).FirstOrDefault().ToString();
            
            var pic= DBiSpan.ProductDetails.Where(n => n.ProductDetailID == PD_select)
               .Select(n => n.Pic).FirstOrDefault();

            var pics=DBiSpan.ProductPics.Where(n => n.ProductID == P_select)
               .Select(n => n.picture).FirstOrDefault();

            if (pics != null)
            {
                bytepics = pics;
                if (pic != null)
                    bytehead = pic;
                else
                    return;
            }
            else
                return;
        }

        public int productID= 0;

        private void 新增_Click(object sender, EventArgs e)
        {          
                Product product = new Product()
                {
                    ProductName = txtpdname.Text,
                    AdFee = Convert.ToInt32(txtpdfee.Text),                   
                    MemberID = 1,
                    RegionID = DBiSpan.RegionLists.Where(n => n.RegionName == cbRegion.Text)
                    .Select(n => n.RegionID).FirstOrDefault(),
                    Description = txtdesc.Text,
                    SmallTypeID = DBiSpan.SmallTypes.Where(n => n.SmallTypeName == cbSmall.Text)
                    .Select(n => n.SmallTypeID).FirstOrDefault()
                };
                DBiSpan.Products.Add(product);


                DBiSpan.SaveChanges();

                productID=product.ProductID;  //新增出來的ID放進變數，要給其他表關聯用

                      
            for(int i =0;i<商品細項list.Count;i++)
            { 
                ProductDetail PD = new ProductDetail();

                PD.UnitPrice = 商品細項list[i].UnitPrice;
                PD.Quantity = 商品細項list[i].Quantity;
                PD.Style = 商品細項list[i].Style;
                PD.ProductID = productID;
                PD.Pic = 商品細項list[i].pic;
                
                DBiSpan.ProductDetails.Add(PD);
            }
                DBiSpan.SaveChanges();

            for (int i = 0; i < 照片區.Count; i++)
            {
                ProductPic productPic = new ProductPic();
                productPic.ProductID = productID;
                productPic.picture = 照片區[i].picture;
                DBiSpan.ProductPics.Add(productPic);
            }
            DBiSpan.SaveChanges();
            MessageBox.Show("新增成功");
            Close();
        }

        private void 瀏覽照片_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void cbContry_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRegion.Items.Clear();
            var CID = DBiSpan.CountryLists.Where(n => n.CountryName == cbContry.Text)
                .Select(n => n.CountryID).FirstOrDefault();
            var ReginName = DBiSpan.RegionLists.Where(n => n.CountryID == CID)
                .OrderBy(n => n.RegionID).Select(n => n.RegionName).ToList();
            foreach (var i in ReginName)
            {
                cbRegion.Items.Add(i);
            }
            cbRegion.Text = cbRegion.Items[0].ToString();
        }

        private void cbBig_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSmall.Items.Clear();
            var Big = DBiSpan.BigTypes.Where(n => n.BigTypeName == cbBig.Text)
                .Select(n => n.BigTypeID).FirstOrDefault(); //先找出選單選到哪個大類
            var Small = DBiSpan.SmallTypes.Where(n => n.BigTypeID == Big)
                .OrderBy(n => n.SmallTypeID).Select(n => n.SmallTypeName).ToList();
            //再從選到的大類裡的小類

            foreach (var i in Small)
            {
                cbSmall.Items.Add(i);
            }
            cbSmall.Text = cbSmall.Items[0].ToString();
        }

        private void 修改_Click(object sender, EventArgs e)
        {
            var Q = DBiSpan.Products.Where(n => n.ProductID == P_select).Select(n => n).FirstOrDefault();
            Q.ProductName = txtpdname.Text;
            Q.AdFee = Convert.ToDecimal(txtpdfee.Text);
            Q.ShipperID = DBiSpan.Shippers.Where(n => n.ShipperName == cbship.Text)
                    .Select(n => n.ShipperID).FirstOrDefault();
            Q.MemberID = 1;
            Q.RegionID = DBiSpan.RegionLists.Where(n => n.RegionName == cbRegion.Text)
                    .Select(n => n.RegionID).FirstOrDefault();
            Q.Description = txtdesc.Text;
            Q.SmallTypeID = DBiSpan.SmallTypes.Where(n => n.SmallTypeName == cbSmall.Text)
                    .Select(n => n.SmallTypeID).FirstOrDefault();

            productID = P_select;  //選到的ID放進變數，要給其他表關聯用


            for (int i = 0; i < 商品細項list.Count; i++)
            {
                ProductDetail PD = new ProductDetail();

                PD.UnitPrice = 商品細項list[i].UnitPrice;
                PD.Quantity = 商品細項list[i].Quantity;
                PD.Style = 商品細項list[i].Style;
                PD.ProductID = productID;
                PD.Pic = 商品細項list[i].pic;

                DBiSpan.ProductDetails.Add(PD);
            }
            DBiSpan.SaveChanges();

            for (int i = 0; i < 照片區.Count; i++)
            {
                ProductPic productPic = new ProductPic();
                productPic.ProductID = productID;
                productPic.picture = 照片區[i].picture;
                DBiSpan.ProductPics.Add(productPic);
            }
            DBiSpan.SaveChanges();
           MessageBox.Show("修改成功");
            Close();
        }

        private void 商品增刪修_Load(object sender, EventArgs e)
        {
            if (isproductupdate)
            { 
                isLoad();
                button1.Enabled = false;
                button2.Enabled = true;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = false;
            }

        }

        private void 刪除product_Click(object sender, EventArgs e)
        {
            var P=DBiSpan.Products.Where(n => n.ProductID == P_select)
                .Select(n => n).FirstOrDefault();
            P.ProductStatusID = 2;
            this.DBiSpan.SaveChanges();
            MessageBox.Show("刪除成功");
            Close();
        }
        private void 刪除productdetail_Click(object sender, EventArgs e)
        {
            var P = DBiSpan.ProductDetails.Where(n => n.ProductID == PD_select).Select(n => n).FirstOrDefault();
            DBiSpan.ProductDetails.Remove(P);
            this.DBiSpan.SaveChanges();
            MessageBox.Show("刪除成功");
            Close();
        }
        private void 商品增刪修_Leave(object sender, EventArgs e)
        {
            //產品介面.啟動表單();
        }

        //===========================================  照片庫區

        List<照片區> 照片區 = new List<照片區>(); // 照片暫存   建立一個類別
        private void picmore_Click(object sender, EventArgs e)
        {
            新增進照片類別();
            新增照片();
        }

         private void 照片庫瀏覽_Click(object sender, EventArgs e)
                {
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
                }

        void 新增進照片類別() 
        {
            照片區 照片 = new 照片區();

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] bytes = ms.GetBuffer();

            照片.picture = bytes;  
            照片區.Add(照片);
        }
        void 新增照片()
        {
            picPanel3.Controls.Clear();
            for(int i = 0; i < 照片區.Count(); i++)
            {
                照片控制項 照項 = new 照片控制項();
                照項.picture = 照片區[i].picture;
                picPanel3.Controls.Add(照項);

                foreach(Control control in 照項.Controls)
                {
                    if (control.GetType() == typeof(Button))
                    {
                        Button button = (Button)control;
                        button.Click += 刪除按鈕_Click;
                    }
                }
                Application.DoEvents();
            }
        }

        private void 刪除按鈕_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int idx = picPanel3.Controls.IndexOf(button.Parent);
            照片區.RemoveAt(idx);
            picPanel3.Controls.Remove(button.Parent);
        }
        //=====================================================
        //======================================規格區
        List<商品細項> 商品細項list = new List<商品細項>();

        private void 新增樣式_Click(object sender, EventArgs e)
        {
              新增進規格類別();
              新增規格();              
        }

        private void 新增規格()
        {
            tPanel2.Controls.Clear();
            for (int i = 0; i < 商品細項list.Count; i++)
            {
                細項控制項 系控 = new 細項控制項();
                系控.Quantity = 商品細項list[i].Quantity;
                系控.UnitPrice = 商品細項list[i].UnitPrice;
                系控.Style = 商品細項list[i].Style;
                if (商品細項list[i].pic != null)
                    系控.pic = 商品細項list[i].pic;
                tPanel2.Controls.Add(系控);

                foreach (Control control in 系控.Controls)
                {
                    if (control.GetType() == typeof(Button))
                    {
                        Button button = (Button)control;
                        button.Click += 刪除規格紐_click;
                    }
                }
            }
        }

        private void 新增進規格類別()
        {
            商品細項 細項 = new 商品細項();
            細項.Quantity = Convert.ToInt32(txtpdquty.Text);
            細項.UnitPrice = Convert.ToInt32(txtpdup.Text);
            細項.Style = txtstyle.Text;

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] bytes = ms.GetBuffer();

            if (bytes != null)
                細項.pic = bytes;

            商品細項list.Add(細項);
        }
        private void 刪除規格紐_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int idx = tPanel2.Controls.IndexOf(button.Parent);
            商品細項list.RemoveAt(idx);
            tPanel2.Controls.Remove(button.Parent);
        }
        //==========================================================
        //======================物流區
        List<物流> 物流list = new List<物流>();

        private void 增加送方式_Click(object sender, EventArgs e)
        {
            新增進物流類別();
            新增物流();
        }

        private void 新增物流()
        {
            Panel1.Controls.Clear();
            for (int i = 0; i < 物流list.Count; i++)
            {
                物流控制項 物項 = new 物流控制項();
                物項.ShipperName = 物流list[i].ShipperName;
                Panel1.Controls.Add(物項);

                foreach (Control control in 物項.Controls)// 抓出自訂控制項(UserContral)裡的控制項
                {
                    if (control.GetType() == typeof(Button))// 找出控制項裡的屬性=Button屬性
                    {                        
                        Button button = (Button)control; //將control轉型成Button，用Button接
                        button.Click += 刪除物流紐_Click; //找到控制項裡的Button設定事件
                    }
                }
            }
        }

        private void 刪除物流紐_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;  // 轉型成Button
            int idx = Panel1.Controls.IndexOf(button.Parent);
            // button.Parent 就是button上一層 在這就是指UserControl
            物流list.RemoveAt(idx);  //刪除選到的資料
            Panel1.Controls.Remove(button.Parent);//刪除選到的button物件
        }

        private void 新增進物流類別()
        {
            物流 物流 = new 物流();
            物流.ShipperName = cbship.Text;
            物流list.Add(物流);
        }

        
    }
}

        
    
