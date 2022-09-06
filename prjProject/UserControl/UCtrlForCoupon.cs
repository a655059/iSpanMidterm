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
    public partial class UCtrlForCoupon : UserControl
    {
        public UCtrlForCoupon()
        {
            InitializeComponent();
        }
        public string CouponName
        {
            get { return lblCouponName.Text; }
            set { lblCouponName.Text = value; }
        }
        public string UseOrNot
        {
            get { return btnUseOrNot.Text; }
            set { btnUseOrNot.Text = value; }
        }
    }
}
