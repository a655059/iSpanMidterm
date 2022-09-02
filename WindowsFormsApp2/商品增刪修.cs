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
    public partial class 商品增刪修 : Form
    {
        public 商品增刪修()
        {
            InitializeComponent();
           var Big =DBiSpan.BigTypes.Select(n => n.BigTypeName).ToList();
            foreach(var b in Big)
            {
                cbBig.Items.Add(b);
            }
            var Small = DBiSpan.SmallTypes.Select(n => n.SmallTypeName).ToList();
            foreach(var s in Small)
            {
                cbSmall.Items.Add(s);
            }
            var Contry = DBiSpan.CountryLists.Select(n => n.CountryName).ToList();
            foreach(var c in Contry)
            {
                cbContry.Items.Add(c);
            }
            var Region = DBiSpan.RegionLists.Select(n => n.RegionName).ToList();
            foreach(var r  in Region)
            {
                cbRegion.Items.Add(r);
            }
        }
        iSpanProjectEntities1 DBiSpan = new iSpanProjectEntities1();

        private void 新增_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                ProductName = txtpdname.Text,
                AdFee=Convert.ToInt32(txtpdfee.Text),
                
            };
            ProductDetail productDetail = new ProductDetail()
            {
                UnitPrice=Convert.ToInt32(txtpdup.Text),
                Quantity= Convert.ToInt32(txtpdquty.Text),
                
            };
        }

        private void 新增照片_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void cbContry_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRegion.Items.Clear();
            var CID = DBiSpan.CountryLists.Where(n => n.CountryName == cbContry.Text)
                .Select(n => n.CountryID).FirstOrDefault();
            var ReginName = DBiSpan.RegionLists.Where(n => n.CountryID == CID)
                .OrderBy(n=>n.RegionID).Select(n => n.RegionName).ToList();
            foreach(var i in ReginName)
            {
cbRegion.Items.Add(i);
            }
            cbRegion.Text = cbRegion.Items[0].ToString();


        }
    }
}
