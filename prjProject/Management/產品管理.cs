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
    public partial class 產品管理 : Form
    {
        public 產品管理()
        {
            InitializeComponent();                       
        }
        iSpanProjectEntities DBiSpan = new iSpanProjectEntities();

        
        private void 新增_Click(object sender, EventArgs e)
        {            
            商品增刪修 WW = new 商品增刪修();
            WW.Show();
        }

        private void 修改刪除_Click(object sender, EventArgs e)
        {
            var select = dataGridView1.CurrentRow.Cells["ProductID"].Value;

            商品增刪修 WW = new 商品增刪修();
            WW.pid = Convert.ToInt32(select);
            WW.isproductupdate = true;
            WW.ShowDialog();
        }

        private void 產品管理_Load(object sender, EventArgs e)
        {
            啟動表單();
        }

        public void 啟動表單()
        {
            var Q = DBiSpan.Products.Select(n =>
                        new
                        {
                            n.ProductID,
                            n.ProductName,
                            n.SmallTypeID,
                            n.MemberID,
                            n.RegionID,
                            n.AdFee,
                            n.Description,
                            n.ShipperID
                        }).ToList();
            dataGridView1.DataSource = Q;
            var W = DBiSpan.ProductDetails.Select(n => new
            {
                n.ProductDetailID,
                n.ProductID,
                n.Style,
                n.Quantity,
                n.UnitPrice,
                n.Pic
            }).ToList();
            dataGridView2.DataSource = W;
        }
    }
}
