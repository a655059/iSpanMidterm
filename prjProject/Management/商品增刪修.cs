using prjProject.Entity;
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
        public int pid { get; set; } //為了讓上一張form資料連接這張form
        private void isLoad()
        {
            txtpdname.Text = DBiSpan.Products.Where(n => n.ProductID == pid)
                .Select(n => n.ProductName).FirstOrDefault();

            var SMall   = DBiSpan.Products.Where(n => n.ProductID == pid)
                .Select(n => n.SmallTypeID).FirstOrDefault();
            cbSmall.Text = DBiSpan.SmallTypes.Where(n => n.SmallTypeID == SMall)
                .Select(n => n.SmallTypeName).FirstOrDefault();

            var BIg = DBiSpan.SmallTypes.Select(n => n.BigTypeID).FirstOrDefault();
            cbBig.Text = DBiSpan.BigTypes.Where(n => n.BigTypeID == BIg)
                .Select(n => n.BigTypeName).FirstOrDefault();

            txtpdup.Text = DBiSpan.ProductDetails.Where(n => n.ProductID == pid)
                .Select(n => n.UnitPrice).FirstOrDefault().ToString();

            txtpdquty.Text = DBiSpan.ProductDetails.Where(n => n.ProductID == pid)
               .Select(n =>n.Quantity).FirstOrDefault().ToString();

            txtdesc.Text = DBiSpan.Products.Where(n => n.ProductID == pid)
                .Select(n => n.Description).FirstOrDefault();

            var Ship = DBiSpan.Products.Where(n => n.ProductID == pid)
                .Select(n =>n.ShipperID).FirstOrDefault();
            cbship.Text=DBiSpan.Shippers.Where(n=>n.ShipperID==Ship)
                .Select(n=>n.ShipperName).FirstOrDefault();

            txtstyle.Text = DBiSpan.ProductDetails.Where(n => n.ProductID == pid)
                .Select(n => n.Style).FirstOrDefault();

            var REgin= DBiSpan.Products.Where(n => n.ProductID == pid)
                .Select(n =>n.RegionID).FirstOrDefault();
            cbRegion.Text = DBiSpan.RegionLists.Where(n => n.RegionID == REgin)
                .Select(n => n.RegionName).FirstOrDefault();

            var Country=DBiSpan.RegionLists.Where(n => n.RegionID == REgin)
                .Select(n =>n.CountryID).FirstOrDefault();
            cbContry.Text = DBiSpan.CountryLists.Where(n => n.CountryID == Country)
                .Select(n => n.CountryName).FirstOrDefault();

            txtpdfee.Text= DBiSpan.Products.Where(n => n.ProductID == pid)
                .Select(n =>n.AdFee).FirstOrDefault().ToString();
        }
        private void 新增_Click(object sender, EventArgs e)
        {
       
                Product product = new Product()
                {
                    ProductName = txtpdname.Text,
                    AdFee = Convert.ToInt32(txtpdfee.Text),
                    ShipperID = DBiSpan.Shippers.Where(n => n.ShipperName == cbship.Text)
                    .Select(n => n.ShipperID).FirstOrDefault(),
                    MemberID = 1,
                    RegionID = DBiSpan.RegionLists.Where(n => n.RegionName == cbRegion.Text)
                    .Select(n => n.RegionID).FirstOrDefault(),
                    Description = txtdesc.Text,
                    SmallTypeID = DBiSpan.SmallTypes.Where(n => n.SmallTypeName == cbSmall.Text)
                    .Select(n => n.SmallTypeID).FirstOrDefault()
                };
                DBiSpan.Products.Add(product);
                DBiSpan.SaveChanges();

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] bytes = ms.GetBuffer();

                //todo#0 預設ID寫死
                ProductDetail productDetail = new ProductDetail()
                {
                    UnitPrice = Convert.ToInt32(txtpdup.Text),
                    Quantity = Convert.ToInt32(txtpdquty.Text),
                    Style = txtstyle.Text,
                    ProductID = DBiSpan.Products.Where(n => n.MemberID == 1)
                    .OrderByDescending(n => n.ProductID).Select(n => n.ProductID).FirstOrDefault(),
                    Pic = bytes
                };
                DBiSpan.ProductDetails.Add(productDetail);
            
            DBiSpan.SaveChanges();            
            MessageBox.Show("新增成功");
        }

        private void 新增照片_Click(object sender, EventArgs e)
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
            var Q = DBiSpan.Products.Where(n => n.ProductID == pid).Select(n => n).FirstOrDefault();
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

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            Byte[] bytes = ms.GetBuffer();
            
            var QQ = DBiSpan.ProductDetails.Where(n => n.ProductID == pid).Select(n => n).FirstOrDefault();
            QQ.UnitPrice = Convert.ToDecimal(txtpdup.Text);
                    QQ.Quantity = Convert.ToInt32(txtpdquty.Text);
            QQ.Style = txtstyle.Text;
            QQ.ProductID = DBiSpan.Products.Where(n => n.MemberID == 1)
            .OrderByDescending(n => n.ProductID).Select(n => n.ProductID).FirstOrDefault();
                    QQ.Pic = bytes;

            DBiSpan.SaveChanges();
            MessageBox.Show("修改成功");
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

        private void 刪除_Click(object sender, EventArgs e)
        {
            var PD = DBiSpan.ProductDetails.Where(n => n.ProductID == pid).Select(n => n).FirstOrDefault();
            DBiSpan.ProductDetails.Remove(PD);
            var P=DBiSpan.Products.Where(n => n.ProductID == pid).Select(n => n).FirstOrDefault();
            DBiSpan.Products.Remove(P);
            this.DBiSpan.SaveChanges();
            MessageBox.Show("刪除成功");
        }

        private void 商品增刪修_Leave(object sender, EventArgs e)
        {
            //產品介面.啟動表單();
        }
    }
}
