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

namespace prjProject.Management
{
    public partial class 申訴管理 : Form
    {
        public 申訴管理()
        {
            InitializeComponent();
        }
        iSpanProjectEntities DBiSpan = new iSpanProjectEntities();

        private void 申訴管理_Load(object sender, EventArgs e)
        {
            //var type=DBiSpan.ArgumentTypes.
        }
    }
}
