using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjProject
{
    public partial class UCtrlShowItemsInCart : UserControl
    {
        public UCtrlShowItemsInCart()
        {
            InitializeComponent();
           
        }
        public int orderDetailID { get; set; }
        public int productDetailID { get; set; }
        public bool IsChecked
        {
            get { return checkBox.Checked; }
            set { checkBox.Checked = value; }
        }
        public Image productPhoto
        {
            get { return pictureBox.Image; }
            set { pictureBox.Image = value; }
        }
        public string productName
        {
            get { return lblProductName.Text; }
            set { lblProductName.Text = value; }
        }

        public string productPrice
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }

        public int productCount
        {
            get { return Convert.ToInt32(nudCount.Value); }
            set { nudCount.Value = value; }
        }
        public int nudCountMinValue
        {
            get { return Convert.ToInt32(nudCount.Minimum); }
            set { nudCount.Maximum = value; }
        }
        public string productSumPrice
        {
            get { return lblSum.Text; }
            set { lblSum.Text = value; }
        }
        public object shipperName
        {
            get
            {
                return cbbShipperName.Text;
            }
            set
            {
                cbbShipperName.DataSource = value;
            }
        }
        public string buyerAddress
        {
            get { return txtBuyerAddress.Text; }
            set { txtBuyerAddress.Text = value; }
        }
        public string buyerPhone
        {
            get { return txtBuyerPhone.Text; }
            set { txtBuyerPhone.Text = value; }
        }
        public int oldQty { get; set; }
    }
}
