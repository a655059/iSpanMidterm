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
            dataGridView1.DataSource = Q;
            var W = DBiSpan.ProductDetails.Select(n => n).ToList();
            dataGridView2.DataSource = W;
        }
        iSpanProjectEntities1 DBiSpan = new iSpanProjectEntities1();

        private void button1_Click(object sender, EventArgs e)
        {
            //商品增刪修 update = new 商品增刪修();
            //string select = dataGridView1.SelectedRows.ToString();
            //var Q = DBiSpan.Products.Where(n => n.ProductName == select).Select(n => n);
            商品增刪修 WW = new 商品增刪修();
            WW.Show();
        }
    }
}
