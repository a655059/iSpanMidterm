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
    public partial class 產品管理 : Form
    {
        public 產品管理()
        {
            InitializeComponent();
            var Q = DBiSpan.Products.Select(n => n).ToList();
            //new
            //{
            //    ID = n.ProductID,
            //    Name = n.ProductName,
            //    Holder = n.MemberID,

            //}
            dataGridView1.DataSource = Q;
            var W = DBiSpan.ProductDetails.Select(n => n).ToList();
            dataGridView2.DataSource = W;
        }
        iSpanProjectEntities1 DBiSpan = new iSpanProjectEntities1();

        private void button1_Click(object sender, EventArgs e)
        {            
            商品增刪修 WW = new 商品增刪修();
            WW.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var select = dataGridView1.CurrentRow.Cells["ProductID"].Value;

            商品增刪修 WW = new 商品增刪修();
            WW.pid = Convert.ToInt32(select);
            WW.isproductupdate = true;
            WW.Show();
        }
    }
}
