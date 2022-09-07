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

namespace prjProject.Member
{
    public partial class memberCoupon : Form
    {
        public string memberName { get; set; }
        public int memberID { get; set; }
        iSpanProjectEntities dbindex = new iSpanProjectEntities();

        public memberCoupon()
        {
            InitializeComponent();
        }

        private void memberCoupon_Load(object sender, EventArgs e)
        {

            var officialCou = (from i in dbindex.OfficialCoupons
                              where i.MemberID == memberID
                              select i).FirstOrDefault();
            //var myCoupon = (from i in dbindex.Coupons
            //               where i.CouponID == officialCou.CouponID
            //               select i).ToList();
            if (!(officialCou == null))
            {
                var myCoupon = (from i in dbindex.Coupons
                                where i.CouponID == officialCou.CouponID
                                select i).ToList();
                txt_couName.Text = myCoupon[0].CouponName;
                txt_couStar.Text = myCoupon[0].StartDate.ToString();
                txt_couEnd.Text = myCoupon[0].ExpiredDate.ToString();
                txt_couDiscount.Text = myCoupon[0].Discount.ToString();

            }
            else
            {
                MessageBox.Show("抱歉,您還沒有任何優惠券");
                Close();
            }
                
        }
    }
}
