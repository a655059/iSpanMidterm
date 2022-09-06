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
    public partial class CtrlADDisplay : UserControl
    {
        public CtrlADDisplay()
        {
            InitializeComponent();
        }
        public int productID { get; set; }

        public Image itemPhoto
        {
            get
            {
                return pbItemPhoto.Image;
            }
            set
            {
                pbItemPhoto.Image = value;
            }
        }
    }
}
