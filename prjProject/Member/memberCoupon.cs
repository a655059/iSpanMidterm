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

            var officialCou = from i in dbindex.OfficialCoupons.AsEnumerable()
                              where i.MemberID == memberID
                              select new { id=i.CouponID,優惠券名稱=i.Coupon.CouponName,優惠券開始日期=i.Coupon.StartDate,優惠券結束日期=i.Coupon.ExpiredDate,優惠券內容=i.Coupon.Discount};
            if (!(officialCou == null))
            {
                this.dataGridView1.DataSource = officialCou.ToList();
                //int nowId = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["優惠券名稱"].Value.ToString());

                //var myCoupon = (from i in dbindex.Coupons
                //                where i.CouponID ==nowId
                //                select i).FirstOrDefault();
                //txt_couName.Text =myCoupon.CouponName;
                //txt_couStar.Text = myCoupon.StartDate.ToString();
                //txt_couEnd.Text = myCoupon.ExpiredDate.ToString();
                //txt_couDiscount.Text = myCoupon.Discount.ToString();

            }
            else
            {
                MessageBox.Show("抱歉,您還沒有任何優惠券");
                Close();
            }
                
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int nowId = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["id"].Value.ToString());

            //var officialCou = from i in dbindex.OfficialCoupons.AsEnumerable()
            //                  where i.MemberID == memberID
            //                  select new { 優惠券名稱 = i.Coupon.CouponName, 優惠券開始日期 = i.Coupon.StartDate, 優惠券結束日期 = i.Coupon.ExpiredDate, 優惠券內容 = i.Coupon.Discount };

            //int nowId = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["優惠券名稱"].Value.ToString());

            var myCoupon = (from i in dbindex.Coupons
                            where i.CouponID == nowId
                            select i).FirstOrDefault();
            txt_couName.Text = myCoupon.CouponName;
            txt_couStar.Text = myCoupon.StartDate.ToString();
            txt_couEnd.Text = myCoupon.ExpiredDate.ToString();
            txt_couDiscount.Text = myCoupon.Discount.ToString();

        }
    }
}
