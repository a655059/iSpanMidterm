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
using prjProject.Seller;
using System.IO;

namespace seller
{
    public partial class 賣家中心 : Form
    {
      
        public 賣家中心()
        {
            InitializeComponent();
        }

      
        public int memberID { get; set; }

        iSpanProjectEntities isp = new iSpanProjectEntities();
        List<int> prod = new List<int>();
        int page = 0;


        private void btn_prev_Click(object sender, EventArgs e)
        {
            page--;
            shift();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            page++;
            shift();
        }


        private void 賣家中心_Load(object sender, EventArgs e)
        {


            var acount = isp.MemberAccounts.Where(x => x.MemberID == this.memberID).Select(x => x.MemberAcc).FirstOrDefault();
            var acct = isp.MemberAccounts.Where(x => x.MemberID == this.memberID).ToList();
            byte[] data = null;


            label2.Text = acount;
            label4.Text = acount;
            if(acct[0].MemPic != null)
            {
                data = acct[0].MemPic;
                MemoryStream stream = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(stream);
                stream.Close();
            }

            else
            {
                pictureBox1.Image = Image.FromFile("../../Images/cross.png");
            }
            var q = isp.Products.OrderBy(a => a.ProductID).Where(a => a.MemberID == this.memberID);
            lbl_sel_count.Text = q.Count().ToString();
            page++;
            shift();
        }

        void shift() {
            var q = isp.Products.OrderBy(a => a.ProductID).Where(a => a.MemberID == this.memberID);
            if (q.Count() > 0)           //代表賣家有商品 可以顯示
            {
                foreach (var pid in q.Skip((page-1)*2).Take(2))       //抓取特定賣家的id存入list中使用
                {
                    prod.Add(pid.ProductID);
                }

                show();
                prod.Clear();

            }
        }

        void show() {
            this.flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < prod.Count(); i++)          //根據list中的proid內容把值放入usercontrol顯示
            {
                UserControl_賣家總覽 seller = new UserControl_賣家總覽();
                int produ = prod[i];

               
                var main_picture = isp.ProductPics.Where(a => a.ProductID == produ).ToList();
                if (main_picture.Count() > 0)
                {
                    seller.picture = main_picture[0].picture;
                }

                var descript = isp.Products.Where(a => a.ProductID == produ).ToList();
                seller.desciption = descript[0].ProductName;
                
                this.flowLayoutPanel1.Controls.Add(seller);

                Application.DoEvents();
            }
        }

        private void lklb_upload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            上架 sel = new 上架();
            sel.memberID = this.memberID;
            sel.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            管理商品 manage = new 管理商品();
            manage.memberID = this.memberID;
            manage.Show();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {

        }
    }
}
