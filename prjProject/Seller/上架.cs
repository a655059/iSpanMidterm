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
        public bool flag_mainpic = false;
        public bool flag_formatpic = false;

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

            var countryid = isp.RegionLists.Where(a => a.CountryList.CountryName == cmb_country.Text).ToList();
           
            foreach (var rgnion in countryid)
            {
                this.cmb_region.Items.Add(rgnion.RegionName);
            }

            
        }


        private void cmb_bigtype_SelectedIndexChanged(object sender, EventArgs e)//只有在選好之後才知道大項的內容
        {
            this.cmb_smtype.Items.Clear();
            cmb_smtype.Visible = true;
            label3.Visible = true;

            var stype = isp.SmallTypes.Where(a => a.BigType.BigTypeName == cmb_bigtype.Text).ToList();

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
            var s = isp.Products.Where(a => a.MemberID == this.memberID && a.ProductStatusID != 2);
            dataGridView1.DataSource = s.ToList();  //抓特定賣家的販賣商品

        }

      

        private void btn_product_Click(object sender, EventArgs e)
        {
            if (this.ofd_product.ShowDialog() == DialogResult.OK)
            {
                this.picb_product.Image = Image.FromFile(this.ofd_product.FileName);
            }
            flag_mainpic = true;
        }

        bool okay()
        {
            decimal decy,unitp;
            int quanty;

            bool a = decimal.TryParse(txt_adfee.Text, out decy);
            bool b = int.TryParse(txt_quantity.Text, out quanty);
            bool c = decimal.TryParse(txt_unitprice.Text, out unitp);
            bool str = string.IsNullOrEmpty(cmb_shipper.Text) || string.IsNullOrEmpty(cmb_productstatus.Text)
                || string.IsNullOrEmpty(cmb_bigtype.Text) || string.IsNullOrEmpty(cmb_smtype.Text)
                || string.IsNullOrEmpty(cmb_country.Text) || string.IsNullOrEmpty(cmb_region.Text)
                || string.IsNullOrEmpty(richTextBox_descript.Text) || string.IsNullOrEmpty(txt_style.Text);

            if (a && b && c && !str) return true;
            else return false;
            
        }
      

        private void refresh_Click(object sender, EventArgs e)      //確定上架
        {


            if (okay())
            {
                Product pd = new Product();

                pd.MemberID = this.memberID;
                pd.ProductName = txt_pdname.Text;
                pd.Description = richTextBox_descript.Text;
                pd.AdFee = Convert.ToDecimal(txt_adfee.Text);


                var s = isp.SmallTypes.Where(a => a.SmallTypeName == cmb_smtype.Text).ToList();
                pd.SmallTypeID = s[0].SmallTypeID;

                var v = isp.RegionLists.Where(a => a.RegionName == cmb_region.Text).ToList();
                pd.RegionID = v[0].RegionID;

                var productstatus = isp.ProductStatus.Where(a => a.ProductStatusName == cmb_productstatus.Text).ToList();
                pd.ProductStatusID = productstatus[0].ProductStatusID;


                this.isp.Products.Add(pd);
                this.isp.SaveChanges();
                product_id = pd.ProductID;
                //-----------------------------------------------------------------------------------
                for (int i = 0; i < shiper.Count; i++)            //抓取多種貨運方式放入
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
                clear();
                renew();
            }

            else
            {
                DialogResult result = MessageBox.Show("請正確輸入!!", "Warning",
                    MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }


        void clear() {

            picb_product.Image = null;
            picb_format.Image = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;

            txt_pdname.Text = ""; 
            txt_adfee.Text = "";
            txt_style.Text = "";
            txt_quantity.Text = "";
            txt_unitprice.Text = "";
            cmb_shipper.Text = "";
            cmb_productstatus.Text = "";
            cmb_bigtype.Text = "";
            cmb_smtype.Text = "";
            cmb_country.Text = "";
            cmb_region.Text = "";

            richTextBox_descript.Text = "";

            this.flowLayoutPanel1.Controls.Clear();
            this.flowLayoutPanel2.Controls.Clear();
            this.flowLayoutPanel3.Controls.Clear();
        }


        private void dele_Click(object sender, EventArgs e)
        {

            int pdid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);

            var delete = isp.Products.Where(i => i.ProductID == pdid).ToList();

            delete[0].ProductStatusID = 2;

            this.isp.SaveChanges();
            
            clear();
           
            renew();

        }
        int selectedProductID = -1;
        int selectedProductDetailID = -1;
        private void alter_Click(object sender, EventArgs e)            //再產生對應新規格會卡住  要修改數量
        {
            selectedProductID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);
            selectedProductDetailID = Convert.ToInt32(dataGridView2.CurrentRow.Cells["ProductDetailID"].Value);
            var product = isp.Products.Where(i => i.ProductID == selectedProductDetailID).Select(i => i).FirstOrDefault();
            var productDetail = isp.ProductDetails.Where(i => i.ProductDetailID == selectedProductDetailID).Select(i => i).FirstOrDefault();
            var smallTypeID = isp.SmallTypes.Where(i => i.SmallTypeName == cmb_smtype.Text).Select(i => i.SmallTypeID).FirstOrDefault();
            var countryID = isp.CountryLists.Where(i => i.CountryName == cmb_country.Text).Select(i => i.CountryID).FirstOrDefault();
            var regionID = isp.RegionLists.Where(i => i.RegionName == cmb_region.Text && i.CountryID == countryID).Select(i => i.RegionID).FirstOrDefault();
            var productStatusID = isp.ProductStatus.Where(i => i.ProductStatusName == cmb_productstatus.Text).Select(i => i.ProductStatusID).FirstOrDefault();
            MemoryStream ms = new MemoryStream();
            picb_format.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] bytes = ms.GetBuffer();
            product.ProductName = txt_pdname.Text;
            product.SmallTypeID = smallTypeID;
            product.RegionID = regionID;
            product.AdFee = Convert.ToDecimal(txt_adfee.Text);
            product.Description = richTextBox_descript.Text;
            product.ProductStatusID = productStatusID;
            isp.SaveChanges();
            productDetail.ProductID = selectedProductID;
            productDetail.Style = txt_style.Text;
            productDetail.Quantity = Convert.ToInt32(txt_quantity.Text);
            productDetail.UnitPrice = Convert.ToDecimal(txt_unitprice.Text);
            productDetail.Pic = bytes;
            isp.SaveChanges();

            //if (okay())
            //{
            //    int pdid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);


            //    //先修改  shiptoproduct    productdetails     productpics
            //    //-----------------------------------------------------------------------
            //    var shipstatus = from a in isp.ShipperToProducts    //同一商品對應到多種運送方式
            //                     where a.ProductID == pdid
            //                     select a;

            //    var shipid = (from a in isp.Shippers                //透過對應到的運送方式抓到
            //                  where a.ShipperName == cmb_shipper.Text
            //                  select a).ToList();

            //    //var shipid = isp.ShipperToProducts.Where(a => a.ProductID == pdid).Select(a => a.ShipperID).ToList();

            //    foreach (var shipst in shipstatus)      //倒底要給使用者更改shippertoproductid嗎?
            //    {                                       //如果要個別改不同種的可能要再想一下
            //        shipst.ShipperID = shipid[0].ShipperID;
            //    }


            //    var pddetail = isp.ProductDetails.Where(a => a.ProductID == pdid);
            //    if (flag_formatpic)
            //    {
            //        System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //        this.picb_format.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //        byte[] bytes = ms.GetBuffer();

            //        foreach (var pdtt in pddetail)
            //        {
            //            pdtt.Pic = bytes;
            //        }
            //    }

            //    foreach (var pdtt in pddetail)
            //    {
            //        pdtt.Style = txt_style.Text;
            //        pdtt.Quantity = Convert.ToInt32(txt_quantity.Text);
            //        pdtt.UnitPrice = Convert.ToDecimal(txt_unitprice.Text);
            //    }

            //    var c = from d in isp.ProductPics       //抓取id
            //            where d.ProductID == pdid
            //            select d;

            //    //----------------------------------------------------------------------------------------
            //    if (flag_mainpic)
            //    {
            //        System.IO.MemoryStream ms1 = new System.IO.MemoryStream();
            //        this.picb_product.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
            //        byte[] bytes1 = ms1.GetBuffer();
            //        foreach (var ppic in c)
            //        {
            //            ppic.picture = bytes1;
            //        }
            //        flag_mainpic = false;
            //    }
            //    else
            //    {
            //        DialogResult result = MessageBox.Show("請正確輸入!!", "Warning",
            //            MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            //    }

            //    this.isp.SaveChanges();
            //    //----------------------------------------------------------------------------------------
            //    var j = (from s in isp.SmallTypes
            //             where s.SmallTypeName == cmb_smtype.Text
            //             select s).ToList();


            //    var i = (from t in isp.RegionLists
            //             where t.RegionName == cmb_region.Text
            //             select t).ToList();

            //    var g = from f in isp.Products
            //            where f.ProductID == pdid
            //            select f;


            //    foreach (var prds in g)
            //    {
            //        prds.ProductName = txt_pdname.Text;
            //        prds.Description = richTextBox_descript.Text;
            //        prds.AdFee = Convert.ToDecimal(txt_adfee.Text);
            //        prds.SmallTypeID = j[0].SmallTypeID;
            //        prds.RegionID = i[0].RegionID;
            //        //prds.ShipperID = shipid[0].ShipperID;
            //    }

            //    this.isp.SaveChanges();

            //    shiper.Clear();
            //    pd_detail.Clear();
            //    pd_pic.Clear();
            //    //-----------------------------------------------------------------------

            //    clear();

            //    renew();
            //}
            //else
            //{
            //    DialogResult result = MessageBox.Show("請正確輸入!!", "Warning",
            //        MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            //}

            int pdid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);


            var shiptopd = isp.ShipperToProducts.Where(a => a.Product.ProductID == pdid).ToList();
            var new_sp_id = isp.Shippers.Where(a => a.ShipperName == cmb_shipper.Text).ToList();
            shiptopd[0].ShipperID = new_sp_id[0].ShipperID;


            var pddetail = isp.ProductDetails.Where(a => a.ProductID == pdid);
            if (flag_formatpic)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                this.picb_format.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bytes = ms.GetBuffer();

                foreach (var pdtt in pddetail)
                {
                    pdtt.Pic = bytes;
                }
            }

            foreach (var pdtt in pddetail)
            {
                pdtt.Style = txt_style.Text;
                pdtt.Quantity = Convert.ToInt32(txt_quantity.Text);
                pdtt.UnitPrice = Convert.ToDecimal(txt_unitprice.Text);
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
            flag_mainpic = false;


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

            //var g = isp.Products.Where(a => a.ProductID == pdid && a.ProductStatu.ProductStatusName == cmb_productstatus.Text).ToList();


            //foreach (var prds in g)
            //{
            //    prds.ProductName = txt_pdname.Text;
            //    prds.Description = richTextBox_descript.Text;
            //    prds.AdFee = Convert.ToDecimal(txt_adfee.Text);
            //    prds.SmallTypeID = j[0].SmallTypeID;
            //    prds.RegionID = i[0].RegionID;
            //    //prds.ShipperID = shipid[0].ShipperID;
            //    prds.ProductStatusID = g[0].ProductStatusID;
            //}

            this.isp.SaveChanges();

            shiper.Clear();
            pd_detail.Clear();
            pd_pic.Clear();
            //-----------------------------------------------------------------------

            clear();

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

            if(flag_formatpic == true)
            {
                MemoryStream ms = new MemoryStream();
                this.picb_format.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bytes = ms.GetBuffer();
                pd_dtail.pic = bytes;
            }
            
            pd_detail.Add(pd_dtail);
            flag_formatpic = false;
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
            if(flag_mainpic == true)
            {
                pic();
                btn_showpic();
            }
            else
            {
                DialogResult result = MessageBox.Show("請正確輸入!!", "Warning",
                    MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
            flag_mainpic = false;
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

      

        private void btn_open_formatpic_Click(object sender, EventArgs e)
        {
            if (this.ofd_product.ShowDialog() == DialogResult.OK)
            {
                this.picb_format.Image = Image.FromFile(this.ofd_product.FileName);
            }
            flag_formatpic = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)      //產生對應的可修改選項
        {
            //clear();

            //-----------------------------------------------------------------------
            int index = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);

            var q = isp.ProductDetails.Where(a => a.ProductID == index);
            dataGridView2.DataSource = q.ToList();
            var viewpic = isp.ProductPics.Where(a => a.ProductID == index);
            dataGridView3.DataSource = viewpic.ToList();
            //-----------------------------------------------------------------------
           

            var shipname = isp.ShipperToProducts.Where(a => a.ProductID == index).Select(a => a.Shipper.ShipperName).FirstOrDefault();
            cmb_shipper.Text = shipname;
            //-----------------------------------------------------------------------
            var pname = isp.Products.Where(a => a.ProductID == index).ToList();

            cmb_productstatus.Text = pname[0].ProductStatu.ProductStatusName;
            cmb_smtype.Text = pname[0].SmallType.SmallTypeName;
            cmb_bigtype.Text = pname[0].SmallType.BigType.BigTypeName;

            cmb_region.Text = pname[0].RegionList.RegionName;
            cmb_country.Text = pname[0].RegionList.CountryList.CountryName;

            txt_pdname.Text = pname[0].ProductName;
            txt_adfee.Text = pname[0].AdFee.ToString();
            richTextBox_descript.Text = pname[0].Description;

            //---------------------------------------------------------------
            byte[] data = null;

            var pics = (from a in isp.ProductPics
                        where a.ProductID == index
                        select a).ToList();

            if(pics.Count() > 0)
            {
                data = pics[0].picture;
                MemoryStream stream = new MemoryStream(data);
                picb_product.Image = Image.FromStream(stream);
                stream.Close();
            }
           


            //---------------------------------------------------------------
            var detai = isp.ProductDetails.Where(a => a.ProductID == index).ToList();

           byte[] data1 = null;
            txt_style.Text = detai[0].Style;
            txt_quantity.Text = detai[0].Quantity.ToString();
            txt_unitprice.Text = detai[0].UnitPrice.ToString();
            data1 = detai[0].Pic;

            if(data1 != null)
            {
                MemoryStream stream_format = new MemoryStream(data1);
                picb_format.Image = Image.FromStream(stream_format);
                stream_format.Close();
            }

            else
            {
                picb_format.Image = Image.FromFile("../../Images/cross.png");
            }


        }

        private void cmb_smtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_MouseUp(object sender, MouseEventArgs e)
        {
            int index = Convert.ToInt32(dataGridView2.CurrentRow.Cells["ProductDetailID"].Value);
            var q = isp.ProductDetails.Where(i => i.ProductDetailID == index).Select(i => i).FirstOrDefault();
            try
            {
                MemoryStream ms = new MemoryStream(q.Pic);
                picb_format.Image = Image.FromStream(ms);
            }
            catch(Exception ex)
            {
                picb_format.Image = Image.FromFile("../../Images/cross.png");
            }
            txt_style.Text = q.Style;
            txt_quantity.Text = q.Quantity.ToString("0");
            txt_unitprice.Text = q.UnitPrice.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
