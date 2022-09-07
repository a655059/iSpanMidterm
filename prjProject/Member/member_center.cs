using prjProject.Entity;
using prjProject.Member;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_期中專案
{
    public partial class member_center : Form
    {

        iSpanProjectEntities dbContext = new iSpanProjectEntities();
        byte[] bytes;
        //public string txt{set{ label2.Text = value; } }
        public string memberName
        {
            get { return lab_showname.Text; }
            set { lab_showname.Text = value; }
        }
        public int memeberID { get; set; }
        public member_center()
        {
            InitializeComponent();
            //var pic = from i in dbContext.MemberAccounts
            //          where i.MemberID == this.memeberID
            //          select i;
            //var piclist = pic.ToList();
            //if (piclist[0].MemPic == null) return;
            //else
            //{
            //    System.IO.MemoryStream ms = new System.IO.MemoryStream(piclist[0].MemPic);
            //    this.pictureBox1.Image = Image.FromStream(ms);
            //    bytes = piclist[0].MemPic;
            //}
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            OverWriteCustDB ov1 = new OverWriteCustDB();
            ov1.memberID = this.memeberID;
            ov1.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PdSearch pd = new PdSearch();
            pd.memberID = this.memeberID;
            pd.memberName = this.memberName;
            pd.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var q = dbContext.OfficialCoupons.Where(m => m.MemberID == memeberID).Select(p => p);
            if (q.Any())
            {
                memberCoupon cou = new memberCoupon();
                cou.memberID = this.memeberID;
                cou.memberName = this.memberName;
                cou.ShowDialog();
            }
            else
            {
                MessageBox.Show("你還沒有任何優惠券！");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            var q = dbContext.Likes.Where(m => m.MemberID == memeberID).Select(p => p);
            if (q.Any())
            {
                memberLike like = new memberLike();
                like.memberName = this.memberName;
                like.memberID = this.memeberID;
                like.ShowDialog();
            }
            else
            {
                MessageBox.Show("你還沒有點讚過任何商品！");
            }
        }
        private void pbClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void member_center_Load(object sender, EventArgs e)
        {
            var q = dbContext.MemberAccounts.Where(m => m.MemberID == memeberID).Select(m => m.MemPic);
            if (q.Any()) {
                var acpic = q.FirstOrDefault();
                System.IO.MemoryStream ms = new System.IO.MemoryStream(acpic);
                pictureBox1.Image= Image.FromStream(ms);
            }
        }
    }
}
