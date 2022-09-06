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
    public partial class 訂單管理 : Form
    {
        public 訂單管理()
        {
            InitializeComponent();
        }
        iSpanProjectEntities1 DBiSpan = new iSpanProjectEntities1();
        private void 訂單管理_Load(object sender, EventArgs e)
        {
            var Q = DBiSpan.Orders.Select(n => new{
            n.OrderID,
            n.MemberID,
            n.OrderDatetime,
            n.RecieveAdr,
            n.FinishDate,
            n.CouponID,
            n.StatusID
            }).ToList();
            dataGridView1.DataSource = Q;
            var QQ = DBiSpan.OrderDetails.Select(n => new{
               n.OrderDetailID,
               n.OrderID,
                n.ProductDetailID,
                n.ShipperID,
                n.Quantity,
                n.ShippingDate,
                n.RecieveDate,
                n.OutAdr,
                n.ShippingStatusID
            }).ToList();
            dataGridView2.DataSource = QQ;
        }
        
        private void 修改刪除_Click(object sender, EventArgs e)
        {
            var select = dataGridView1.CurrentRow.Cells["OrderID"].Value;

        }
    }
}
