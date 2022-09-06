using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seller
{
    public partial class Ucl商品狀態 : UserControl
    {
        public Ucl商品狀態()
        {
            InitializeComponent();
        }

        public string shippername {
            //get { }
            set
            {
                this.lbl_商品運送狀態.Text = value;
                /*his.textBox1.Text = value;*/
            }
        }
    }
}
