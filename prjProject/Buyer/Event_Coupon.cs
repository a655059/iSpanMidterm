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

namespace prjProject.Buyer
{
    public partial class Event_Coupon : Form
    {
        public Event_Coupon()
        {
            InitializeComponent();
        }
        iSpanProjectEntities dbContext = new iSpanProjectEntities();
        public int memberID { get; set; }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var check =dbContext.OfficialCoupons.Where(m=>m.MemberID == memberID && m.CouponID == 1).Select(m=>m);
            if (check.Any())
            { 
                MessageBox.Show("你已領取過此券！");
                return;
            }

            OfficialCoupon o = new OfficialCoupon
            {
                MemberID = memberID,
                CouponID = 1,
                ExpireN_A = false,
            };
            MessageBox.Show("領取成功！開始蝦拚到爆吧！");
            //dbContext.OfficialCoupons.Add(o);
            //dbContext.SaveChanges();
        }
    }
}
