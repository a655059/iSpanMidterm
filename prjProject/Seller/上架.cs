using prjProject.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seller
{
    public partial class 上架 : Form
    {
        public string account;
        public int product_id;
        iSpanProjectEntities isp = new iSpanProjectEntities();

        public 上架()
        {
            InitializeComponent();
        }

        public 上架(string acc)
        {
            InitializeComponent();
            account = acc;
        }


        private void 上架_Load(object sender, EventArgs e)
        {

            //做好選單中的選項
            var m = from b in isp.SmallTypes
                    select b;

            foreach (var st in m)
            {
                this.cmb_smtype.Items.Add(st.SmallTypeName);
            }

            var q = from a in isp.RegionLists
                    select a;

            foreach (var pd in q)
            {
                this.cmb_region.Items.Add(pd.RegionName);
            }

            var p = from c in isp.Shippers
                    select c;

            foreach (var sp in p)
            {
                this.cmb_shipper.Items.Add(sp.ShipperName);
            }

            var status = from a in isp.ProductStatus
                         select a;
            foreach (var sts in status)
            {
                this.cmb_shipstatus.Items.Add(sts.ProductStatusName);
            }

            renew();


        }


        void renew()
        {

            var q = (from a in isp.MemberAccounts
                     where a.MemberAcc == account
                     select a).ToList();

            int memid = q[0].MemberID;
            var s = from d in isp.Products
                    where d.MemberID == memid
                    select d;

            dataGridView1.DataSource = s.ToList();  //抓特定賣家的販賣商品

        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            if (this.ofd_product.ShowDialog() == DialogResult.OK)
            {
                this.picb_product.Image = Image.FromFile(this.ofd_product.FileName);
            }
        }

      

        private void refresh_Click(object sender, EventArgs e)      //確定上架
        {

            Product pd = new Product();


            var q = (from p in isp.MemberAccounts           //找到對應的賣家帳號
                     where p.MemberAcc == account
                     select p).ToList();
            pd.MemberID = q[0].MemberID;

            pd.ProductName = txt_pdname.Text;
            pd.Description = richTextBox_descript.Text;
            pd.AdFee = Convert.ToDecimal(txt_adfee.Text);

            var s = (from t in isp.SmallTypes
                     where t.SmallTypeName == cmb_smtype.Text
                     select t).ToList();
            pd.SmallTypeID = s[0].SmallTypeID;


            var v = (from r in isp.RegionLists
                     where r.RegionName == cmb_region.Text
                     select r).ToList();
            pd.RegionID = v[0].RegionID;


            this.isp.Products.Add(pd);
            this.isp.SaveChanges();
            product_id = pd.ProductID;
            //-----------------------------------------------------------------------------------
            for(int i = 0;i < shiper.Count; i++)            //抓取多種貨運方式放入
            {
                ShipperToProduct sptopd = new ShipperToProduct();
                sptopd.ProductID = product_id;
                var spid = (from a in isp.Shippers
                           where a.ShipperName == shiper[i].shipper
                           select a).ToList();
                
                sptopd.ShipperID = spid[0].ShipperID;
                this.isp.ShipperToProducts.Add(sptopd);
            }

            for (int i = 0; i < pd_detail.Count; i++)           //抓取規格放入
            {
                ProductDetail prd = new ProductDetail();
                prd.ProductID = product_id;
                prd.Style = pd_detail[i].Style;
                prd.Quantity = pd_detail[i].Quantity;
                prd.UnitPrice = pd_detail[i].UnitPrice;
                prd.Pic = pd_detail[i].pic;
                this.isp.ProductDetails.Add(prd);
            }

            for (int i = 0; i < pd_pic.Count; i++)          //抓取圖片放入
            {
                ProductPic pdpic = new ProductPic();
                pdpic.ProductID = product_id;
                pdpic.picture = pd_pic[i].picture;
                this.isp.ProductPics.Add(pdpic);
            }

            this.isp.SaveChanges();

            shiper.Clear();
            pd_detail.Clear();
            pd_pic.Clear();
            renew();
        }

        private void dele_Click(object sender, EventArgs e)
        {

            int pdid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);

            var dee = (from a in isp.ShipperToProducts
                     where a.ProductID == pdid
                     select a).FirstOrDefault();

            var del = (from a in isp.ProductDetails
                       where a.ProductID == pdid
                       select a).FirstOrDefault();

            var delll = (from c in isp.ProductPics
                         where c.ProductID == pdid
                         select c
                        ).FirstOrDefault();

            isp.ShipperToProducts.Remove(dee);
            isp.ProductDetails.Remove(del);
            isp.ProductPics.Remove(delll);

            this.isp.SaveChanges();


            var de = (from b in isp.Products
                      where b.ProductID == pdid
                      select b).FirstOrDefault();

            isp.Products.Remove(de);

            this.isp.SaveChanges();

            renew();

        }

        private void alter_Click(object sender, EventArgs e)            //再產生對應新規格會卡住  要修改數量
        {
            //dataGridView1.CurrentRow.Cells[""]


            //修改 alter = new 修改(account);
            //alter.Show();
            int pdid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);


            //先修改  shiptoproduct    productdetails     productpics
            //-----------------------------------------------------------------------
            var shipstatus = from a in isp.ShipperToProducts    //同一商品對應到多種運送方式
                             where a.ProductID == pdid
                             select a;

            var shipid = (from a in isp.Shippers                //透過對應到的運送方式抓到
                         where a.ShipperName == cmb_shipper.Text
                         select a).ToList();

            foreach (var shipst in shipstatus)      //倒底要給使用者更改shippertoproductid嗎?
            {                                       //如果要個別改不同種的可能要再想一下
                shipst.ShipperID = shipid[0].ShipperID;
            }

            var pddetail = from b in isp.ProductDetails
                    where b.ProductID == pdid
                    select b;

            foreach (var pdtt in pddetail)
            {
                pdtt.Style = txt_style.Text;
                pdtt.Quantity = Convert.ToInt32(txt_quantity.Text);
                pdtt.UnitPrice = Convert.ToDecimal(txt_unitprice.Text);
            }

            var c = from d in isp.ProductPics
                    where d.ProductID == pdid
                    select d;


            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.picb_product.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] bytes = ms.GetBuffer();
            foreach (var ppic in c)
            {
                ppic.picture = bytes;
            }
            this.isp.SaveChanges();

            var j = (from s in isp.SmallTypes
                     where s.SmallTypeName == cmb_smtype.Text
                     select s).ToList();


            var i = (from t in isp.RegionLists
                     where t.RegionName == cmb_region.Text
                     select t).ToList();

            var g = from f in isp.Products
                    where f.ProductID == pdid
                    select f;


            foreach (var prds in g)
            {
                prds.ProductName = txt_pdname.Text;
                prds.Description = richTextBox_descript.Text;
                prds.AdFee = Convert.ToDecimal(txt_adfee.Text);
                prds.SmallTypeID = j[0].SmallTypeID;
                prds.RegionID = i[0].RegionID;
            }

            this.isp.SaveChanges();

            shiper.Clear();
            pd_detail.Clear();
            pd_pic.Clear();
            //-----------------------------------------------------------------------


            renew();
        }


        List<運貨方式> shiper = new List<運貨方式>();

        private void btn_shipper_new_Click(object sender, EventArgs e)
        {
            ship_method();
            show_shipstatus();
        }

        void ship_method()
        {
            運貨方式 pd_ship = new 運貨方式();
           
            pd_ship.shipper = cmb_shipper.Text;
            shiper.Add(pd_ship);
        }

        void show_shipstatus() {
            this.flowLayoutPanel3.Controls.Clear();
            for (int i = 0; i < shiper.Count(); i++)
            {
                Ucl商品狀態 ship_stat = new Ucl商品狀態();
                ship_stat.shippername = shiper[i].shipper;

                foreach (Control control in ship_stat.Controls)
                {
                    if (control.GetType() == typeof(Button))
                    {
                        Button button = (Button)control;
                        button.Click += Button_shipstatus_Click;
                    }
                }

                this.flowLayoutPanel3.Controls.Add(ship_stat);

                Application.DoEvents();
            }
        }

        private void Button_shipstatus_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int idx = this.flowLayoutPanel3.Controls.IndexOf(button.Parent);
            shiper.RemoveAt(idx);
            this.flowLayoutPanel3.Controls.Remove(button.Parent);

        }

        List<商品細項> pd_detail = new List<商品細項>();        //暫存的商品規格


        private void btn_newformat_Click(object sender, EventArgs e)
        {
            format();       //加入文字輸入到list中
            show_type();
        }

        void format()   //一個規格對應多
        {
            商品細項 pd_dtail = new 商品細項();

            pd_dtail.Style = txt_style.Text;
            pd_dtail.Quantity = Convert.ToInt32(txt_quantity.Text);
            pd_dtail.UnitPrice = Convert.ToDecimal(txt_unitprice.Text);


            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            if (ms.Length > 0)
            {
                this.picb_format.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bytes = ms.GetBuffer();

                if (bytes != null)
                {
                    pd_dtail.pic = bytes;
                }
            }


            pd_detail.Add(pd_dtail);
        }
        void show_type()        //新增規格
        {
            this.flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < pd_detail.Count; i++)
            {
                UserControl1 detail = new UserControl1();
                detail.style = pd_detail[i].Style;
                detail.quantity = pd_detail[i].Quantity;
                detail.unitprice = pd_detail[i].UnitPrice;
                if (pd_detail[i].pic != null)
                {
                    detail.picture = pd_detail[i].pic;
                }

                foreach (Control control in detail.Controls)
                {
                    if (control.GetType() == typeof(Button))
                    {
                        Button button = (Button)control;
                        button.Click += Button_Click;
                    }
                }
                this.flowLayoutPanel1.Controls.Add(detail);

                Application.DoEvents();
            }
        }



        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int idx = this.flowLayoutPanel1.Controls.IndexOf(button.Parent);
            pd_detail.RemoveAt(idx);
            this.flowLayoutPanel1.Controls.Remove(button.Parent);

        }



        //product圖
        #region
        List<商品圖> pd_pic = new List<商品圖>();               //暫存的商品圖


        private void btn_new_pic_Click(object sender, EventArgs e)
        {
            pic();
            btn_showpic();
        }
        void pic()
        {
            商品圖 pdpic = new 商品圖();

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.picb_product.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] bytes = ms.GetBuffer();

            pdpic.picture = bytes;

            pd_pic.Add(pdpic);
        }

        void btn_showpic()
        {
            this.flowLayoutPanel2.Controls.Clear();

            for (int i = 0; i < pd_pic.Count(); i++)
            {
                UserControl2 pict = new UserControl2();
                pict.picture = pd_pic[i].picture;

                this.flowLayoutPanel2.Controls.Add(pict);

                foreach (Control control in pict.Controls)
                {
                    if (control.GetType() == typeof(Button))
                    {
                        Button button = (Button)control;
                        button.Click += Button_pic_Click;
                    }
                }

                Application.DoEvents();
            }
        }

        private void Button_pic_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int idx = this.flowLayoutPanel2.Controls.IndexOf(button.Parent);
            pd_pic.RemoveAt(idx);
            this.flowLayoutPanel2.Controls.Remove(button.Parent);
        }


        #endregion

        private void picb_product_MouseUp(object sender, MouseEventArgs e)      //想做圖片可以托拉進去
        {
         
        }

        private void btn_open_formatpic_Click(object sender, EventArgs e)
        {
            if (this.ofd_product.ShowDialog() == DialogResult.OK)
            {
                this.picb_format.Image = Image.FromFile(this.ofd_product.FileName);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)      //產生對應的可修改選項
        {
            int index = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);

            var q = from a in isp.ProductDetails
                    where a.ProductID == index
                    select a;

            dataGridView2.DataSource = q.ToList();

            var viewpic = from a in isp.ProductPics
                          where a.ProductID == index
                          select a;
            dataGridView3.DataSource = viewpic.ToList();
            //-----------------------------------------------------------------------
            var deta = (from a in isp.Products
                        where a.ProductID == index
                        select a).ToList();
            int smallid = deta[0].SmallTypeID;
            int regionid = deta[0].RegionID;

            foreach (var details in deta)
            {
                txt_pdname.Text = details.ProductName;
                txt_adfee.Text = details.AdFee.ToString();
                richTextBox_descript.Text = details.Description;
            }
            var small = (from a in isp.SmallTypes
                         where a.SmallTypeID == smallid
                         select a).ToList();

            cmb_smtype.Text = small[0].SmallTypeName;

            var region = (from a in isp.RegionLists
                          where a.RegionID == regionid
                          select a).ToList();

            cmb_region.Text = region[0].RegionName;
            //---------------------------------------------------------------
            byte[] data = null;

            var pics = (from a in isp.ProductPics
                        where a.ProductID == index
                        select a).ToList();

            data = pics[0].picture;

            MemoryStream stream = new MemoryStream(data);
            picb_product.Image = Image.FromStream(stream);
            stream.Close();
            //---------------------------------------------------------------

            var detai = (from a in isp.ProductDetails
                         where a.ProductID == index
                         select a).ToList();

            txt_style.Text = detai[0].Style;
            txt_quantity.Text = detai[0].Quantity.ToString();
            txt_unitprice.Text = detai[0].UnitPrice.ToString();
            data = detai[0].Pic;

            MemoryStream stream_format = new MemoryStream(data);
            picb_format.Image = Image.FromStream(stream_format);
            stream.Close();
        }

        private void cmb_smtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
