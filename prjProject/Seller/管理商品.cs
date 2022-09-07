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
        List<int> prodid = new List<int>();
        List<int> prodetail = new List<int>();
        List<int> orddetail = new List<int>();
        
        List<訂單> ordd = new List<訂單>();
        List<訂單細項> orddt = new List<訂單細項>();

        private void btn_outproduct_Click(object sender, EventArgs e)
        {
            
            //var product = from a in isp.Products
            //              where a.MemberID == this.memberID
            //              select a;

            //var productDetailID = isp.ProductDetails.Where(i => i.Product.MemberID == memberID).Select(i => i.ProductDetailID).ToList();

            //var q10 = isp.OrderDetails.Where(i => i.ProductDetail.Product.MemberID == memberID).Select(i => i.OrderID).FirstOrDefault();

            var q10 = isp.OrderDetails.Where(i => i.ProductDetail.Product.MemberID == memberID);

            dataGridView1.DataSource = q10.ToList();

            MessageBox.Show("" + q10);
            
            //int oid = q10;
            //var a = isp.Orders.Where()
            //MessageBox.Show(""+ q10);
          
        }
    }
}
