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
    public partial class 照片控制項 : UserControl
    {
        public 照片控制項()
        {
            InitializeComponent();
        }
        public byte[] picture
        {
            set
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(value);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }
    }
}
