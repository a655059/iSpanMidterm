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
    public partial class 酷碰 : Form
    {
        public 酷碰()
        {
            InitializeComponent();
        }
        iSpanProjectEntities DBiSpan = new iSpanProjectEntities();
        private void 酷碰_Load(object sender, EventArgs e)
        {
            啟動帶入();
        }

        private void 啟動帶入()
        {
            var Q = DBiSpan.Coupons.Select(n => new
            {
                n.CouponID,
                n.CouponName,
                n.StartDate,
                n.ExpiredDate,
                n.Discount
            }).ToList();
            dataGridView1.DataSource = Q;
        }

        private void 增刪修_Click(object sender, EventArgs e)
        {
            酷碰增刪修 OO = new 酷碰增刪修();
            var select = dataGridView1.CurrentRow.Cells["CouponID"].Value;
            OO.select = Convert.ToInt32(select);
            OO.ShowDialog();
            啟動帶入();
        }
    }
}
