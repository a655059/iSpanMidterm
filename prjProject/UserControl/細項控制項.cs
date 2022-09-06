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
    public partial class 細項控制項 : UserControl
    {
        public 細項控制項()
        {
            InitializeComponent();
        }
        public string Style
        {
            //get { } 
            set { textBox1.Text = value; }
        }
        public int Quantity
        {
            //get { } 
            set { textBox2.Text = value.ToString(); }
        }
        public decimal UnitPrice
        {
            //get { } 
            set { textBox3.Text = value.ToString(); }
        }
        public byte[] pic
        {
            //get { } 
            set { 
                System.IO.MemoryStream ms = new System.IO.MemoryStream(value);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }
    }
}
