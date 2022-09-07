using prjProject.Entity;
using prjProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjProject.Seller
{
    public partial class 管理商品 : Form
    {
        //訂單
        //訂單細項
        
        iSpanProjectEntities isp = new iSpanProjectEntities();
        public 管理商品()
        {
            InitializeComponent();
        }

        public int memberID { get; set; }
       

        private void btn_outproduct_Click(object sender, EventArgs e)
        {
            int odid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["OrderID"].Value);

            var alter = isp.Orders.Where(x => x.OrderID == odid && x.StatusID <= 2);
           

            foreach (var at in alter)
            {
                at.StatusID = 4;
            }


            this.isp.SaveChanges();

            show();
        }
        
        private void 管理商品_Load(object sender, EventArgs e)
        {

            show();

        }

        void show()
        {
            var odd = isp.OrderDetails.Where(i => i.ProductDetail.Product.MemberID == this.memberID)/*.FirstOrDefault()*/;
            // 先抓到order中的內容
            var od = isp.OrderDetails.Where(i => i.ProductDetail.Product.MemberID == this.memberID && (i.Order.StatusID <= 2)).Select(i => new { i.Order.OrderID, i.Order.MemberID, i.Order.OrderDatetime, i.Order.RecieveAdr, i.Order.FinishDate, i.Order.CouponID,i.Order.StatusID });

            var od_on = isp.OrderDetails.Where(i => i.ProductDetail.Product.MemberID == this.memberID && (i.Order.StatusID > 2)).Select(i => new { i.Order.OrderID, i.Order.MemberID, i.Order.OrderDatetime, i.Order.RecieveAdr, i.Order.FinishDate, i.Order.CouponID, i.Order.StatusID });


            dataGridView1.DataSource = od.ToList();
            dataGridView2.DataSource = odd.ToList();
        }
    }
}
