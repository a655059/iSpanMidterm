using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjProject.Management
{
    public partial class 物流控制項 : UserControl
    {
        public 物流控制項()
        {
            InitializeComponent();
        }
        public string ShipperName
        {
            set
            {
                textBox1.Text = value;
            }
        }

    }
}
