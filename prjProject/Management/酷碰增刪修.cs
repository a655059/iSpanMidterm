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
    public partial class 酷碰增刪修 : Form
    {
        public 酷碰增刪修()
        {
            InitializeComponent();  
        }
        public int select { get; set; }

        iSpanProjectEntities DBiSpan = new iSpanProjectEntities();
        private void 修改_Click(object sender, EventArgs e)
        {
            var Q = DBiSpan.Coupons.Where(n => n.CouponID == select)
                .Select(n => n).FirstOrDefault();
            Q.CouponName=txtnm.Text;
            Q.StartDate = datest.Value;
            Q.ExpiredDate = dateed.Value;
            Q.Discount = float.Parse(txtds.Text);
            DBiSpan.SaveChanges();
            MessageBox.Show("修改成功");
        }

        private void 酷碰增刪修_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            txtnm.Text = DBiSpan.Coupons.Where(n => n.CouponID == select)
                            .Select(n => n.CouponName).FirstOrDefault();
            datest.Value = DBiSpan.Coupons.Where(n => n.CouponID == select)
                .Select(n => n.StartDate).FirstOrDefault();
            dateed.Value = DBiSpan.Coupons.Where(n => n.CouponID == select)
                .Select(n => n.StartDate).FirstOrDefault();
            txtds.Text = DBiSpan.Coupons.Where(n => n.CouponID == select)
                .Select(n => n.Discount).FirstOrDefault().ToString();
        }

        private void 新增_Click(object sender, EventArgs e)
        {
            Coupon coupon = new Coupon() {
            CouponName = txtnm.Text,
            StartDate = datest.Value,
            ExpiredDate = dateed.Value,
            Discount = float.Parse(txtds.Text)
        };
            DBiSpan.Coupons.Add(coupon);
            DBiSpan.SaveChanges();
            MessageBox.Show("新增成功");
        }

        private void 刪除_Click(object sender, EventArgs e)
        {
            var Q = DBiSpan.Coupons.Where(n => n.CouponID == select)
                .Select(n => n).FirstOrDefault();
            DBiSpan.Coupons.Remove(Q);
            DBiSpan.SaveChanges();
            MessageBox.Show("刪除成功");
        }
    }
}
