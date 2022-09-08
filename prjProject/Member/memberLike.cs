using pgjMidtermProject;
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

namespace prjProject.Member
{
    public partial class memberLike : Form
    {
        public string memberName { get; set; }
        public int memberID { get; set; }
        iSpanProjectEntities dbindex = new iSpanProjectEntities();

        public memberLike()
        {
            InitializeComponent();

        }

        private void memberLike_Load(object sender, EventArgs e)
        {
            //CtrlDisplayItem _selected = (CtrlDisplayItem)sender;
            //foreach (Control i in Likepanel.Controls)
            //{
            //    if (i is CtrlDisplayItem && i != _selected)
            //    {
            //        ((CtrlDisplayItem)i).BackColor = Color.Black;
            //        ((CtrlDisplayItem)i)._isclicked = false;
            //    }
            //}
            //_selected._isclicked = true;
            //Application.DoEvents();
            this.Likepanel.Controls.Clear();

            try 
            {
            //int id = memberID[0].ProductID;
            //var productPic = from i in dbindex.Products
            //                 where i.ProductID == memberID[0].ProductID
            //                 select i;

            //我改好這邊了by沈
            var productpic = dbindex.Products.Where(x => x.MemberID == memberID).Select(x => x);
            if (!productpic.Any()) 
            {
                return;
            };
            List<CtrlDisplayItem> list = CFunctions.GetProductsForShow(productpic);
            foreach (CtrlDisplayItem j in list)
            {
                Likepanel.Controls.Add(j);
                j.Click += CtrlDisplayItem_Click;
                foreach (Control control in j.Controls)
                {
                    control.Click += CtrlDisplayItem_Click;
                }
            }
            }
            catch(Exception)
            {
                MessageBox.Show("抱歉您還沒有任何按讚商品");
                Close();
            }
           


        }
        private void CtrlDisplayItem_Click(object sender, EventArgs e)
        {
            int productID = -1;
            CFunctions.ClickItemAndShow(sender, out productID);
            SelectedProductForm form = new SelectedProductForm();
            form.productID = productID;
            form.memberID = memberID;
            //form.ProductNumInCart = ProductNumInCart;
            form.ShowDialog();
        }
    }
}
