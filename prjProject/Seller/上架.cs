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
        //public string account;
        public int product_id;
        iSpanProjectEntities isp = new iSpanProjectEntities();

        public 上架()
        {
            InitializeComponent();
        }

        public 上架(string acc)
        {
            InitializeComponent();
            //account = acc;
        }

        public int memberID { get; set; }


        private void cmb_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmb_region.Items.Clear();
            cmb_region.Visible = true;
            label5.Visible = true;

            var countryid = (from a in isp.CountryLists
                             where a.CountryName == cmb_country.Text
                             select a).ToList();
            int ctid = countryid[0].CountryID;
            var region = from a in isp.RegionLists
                         where a.CountryID == ctid
                         select a;

            foreach (var rgnion in region)
            {
                this.cmb_region.Items.Add(rgnion.RegionName);
            }

            
        }


        private void cmb_bigtype_SelectedIndexChanged(object sender, EventArgs e)//只有在選好之後才知道大項的內容
        {
            this.cmb_smtype.Items.Clear();
            //cmb_bigtype.Enabled = true;
            cmb_smtype.Visible = true;
            label3.Visible = true;

            //string bg_text = cmb_bigtype.Text;
            var bigid = (from a in isp.BigTypes                     //這邊記錄的大類只是為了要往後找小類  儲存的時候可以只存小類  透過小類的表對應到 大類來輸出值
                         where a.BigTypeName == cmb_bigtype.Text
                         select a).ToList();

            int bigtid = bigid[0].BigTypeID;
            var stype = from a in isp.SmallTypes
                        where a.BigTypeID == bigtid
                        select a;

            foreach (var stname in stype)
            {
                this.cmb_smtype.Items.Add(stname.SmallTypeName);
            }



        }
        private void 上架_Load(object sender, EventArgs e)
        {
            //----------------------------------------------------------------
            var bg = from a in isp.BigTypes
                     select a;

            foreach(var big in bg)
            {
                this.cmb_bigtype.Items.Add(big.BigTypeName);
            }
            cmb_smtype.Visible = false;
            label3.Visible = false;


            var ct = from a in isp.CountryLists
                     select a;

            foreach(var country in ct)
            {
                this.cmb_country.Items.Add(country.CountryName);
            }
            label5.Visible = false;
            cmb_region.Visible = false;
           // cmb_region.Enabled = false;

            var p = from c in isp.Shippers
                    select c;

            foreach (var sp in p)
            {
                this.cmb_shipper.Items.Add(sp.ShipperName);
            }
            //----------------------------------------------------------------
            var status = from a in isp.ProductStatus            //商品是否上架
                         select a;
            foreach (var sts in status)
            {
                this.cmb_productstatus.Items.Add(sts.ProductStatusName);
            }

            renew();


        }


        void renew()
        {

            var s = from d in isp.Products
                    where d.MemberID == this.memberID
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

            //pd.pr
            
            pd.MemberID = this.memberID;
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

            var productstatus = (from a in isp.ProductStatus
                                where a.ProductStatusName == cmb_productstatus.Text
                                select a).ToList();
            pd.ProductStatusID = productstatus[0].ProductStatusID;


            this.isp.Products.Add(pd);
            this.isp.SaveChanges();
            product_id = pd.ProductID;
            //-----------------------------------------------------------------------------------
            for(int i = 0;i < shiper.Count; i++)            //抓取多種貨運方式放入
            {
                ShipperToProduct sptopd = new ShipperToProduct();
                sptopd.ProductID = product_id;
                string shpname = shiper[i].shipper;
                var spid = (from a in isp.Shippers
                            where a.ShipperName == shpname
                            select a).ToList();

                int shpid = spid[0].ShipperID;
                sptopd.ShipperID = shpid;
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

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.picb_format.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] bytes = ms.GetBuffer();


            foreach (var pdtt in pddetail)
            {
                pdtt.Style = txt_style.Text;
                pdtt.Quantity = Convert.ToInt32(txt_quantity.Text);
                pdtt.UnitPrice = Convert.ToDecimal(txt_unitprice.Text);
                pdtt.Pic = bytes;
            }

            var c = from d in isp.ProductPics       //抓取id
                    where d.ProductID == pdid
                    select d;

            //----------------------------------------------------------------------------------------
            System.IO.MemoryStream ms1 = new System.IO.MemoryStream();
            this.picb_product.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] bytes1 = ms1.GetBuffer();
            foreach (var ppic in c)
            {
                ppic.picture = bytes1;
            }
            this.isp.SaveChanges();
            //----------------------------------------------------------------------------------------
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
                prds.ShipperID = shipid[0].ShipperID;
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
            //if (ms.Length > 0)
            //{
                this.picb_format.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bytes = ms.GetBuffer();

                if (bytes != null)
                {
                    pd_dtail.pic = bytes;
                }
            //}


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

            
            //-----------------------------------------------------------------------
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
            var shiptoprod = (from a in isp.ShipperToProducts
                             where a.ProductID == index
                             select a).ToList();

            int shipid = shiptoprod[0].ShipperID;
            var shipname = (from a in isp.Shippers
                           where a.ShipperID == shipid
                           select a).ToList();
            cmb_shipper.Text = shipname[0].ShipperName;
            //-----------------------------------------------------------------------
            var deta = (from a in isp.Products
                        where a.ProductID == index
                        select a).ToList();
            int smallid = deta[0].SmallTypeID;
            int regionid = deta[0].RegionID;

            int psd = deta[0].ProductStatusID;          //商品上架狀態.................................
            var pstatus = (from a in isp.ProductStatus
                          where a.ProductStatusID == psd
                          select a).ToList();


            foreach (var details in deta)
            {
                txt_pdname.Text = details.ProductName;
                txt_adfee.Text = details.AdFee.ToString();
                richTextBox_descript.Text = details.Description;
            }

            var small = (from a in isp.SmallTypes           //大小類
                         where a.SmallTypeID == smallid
                         select a).ToList();

            cmb_smtype.Text = small[0].SmallTypeName;
            int smid = small[0].BigTypeID;
            var big = (from a in isp.BigTypes
                      where a.BigTypeID == smid
                      select a).ToList();
            cmb_bigtype.Text = big[0].BigTypeName;

            var region = (from a in isp.RegionLists     // 縣市 區
                          where a.RegionID == regionid
                          select a).ToList();

            cmb_region.Text = region[0].RegionName;
            int? ctid = region[0].CountryID;
            var country = (from a in isp.CountryLists
                          where a.CountryID == ctid
                          select a).ToList();
            cmb_country.Text = country[0].CountryName;

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
            byte[] data1 = null;
            var detai = (from a in isp.ProductDetails
                         where a.ProductID == index
                         select a).ToList();

            txt_style.Text = detai[0].Style;
            txt_quantity.Text = detai[0].Quantity.ToString();
            txt_unitprice.Text = detai[0].UnitPrice.ToString();
            data1 = detai[0].Pic;

            MemoryStream stream_format = new MemoryStream(data1);
            picb_format.Image = Image.FromStream(stream_format);
            stream.Close();
        }

        private void cmb_smtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
