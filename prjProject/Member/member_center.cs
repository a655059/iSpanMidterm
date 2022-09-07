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
        private void button1_Click(object sender, EventArgs e)
        {
            OverWriteCustDB ov1 = new OverWriteCustDB();
            ov1.memberID = this.memeberID;
            ov1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PdSearch pd = new PdSearch();
            pd.memberID = this.memeberID;
            pd.memberName = this.memberName;
            pd.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            memberCoupon cou = new memberCoupon();
            cou.memberID = this.memeberID;
            cou.memberName = this.memberName;
            cou.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            memberLike like = new memberLike();
            like.memberName = this.memberName;
            like.memberID = this.memeberID;
            like.ShowDialog();
        }
    }
}
