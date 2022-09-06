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

namespace Project_期中專案
{
    public partial class member_center : Form
    {

        iSpanProjectEntities dbContext = new iSpanProjectEntities();

        //public string txt{set{ label2.Text = value; } }
        public string memberName
        {
            get { return lab_showname.Text; }
            set { lab_showname.Text = value; }
        }
        public int memeberID { get; set; }
        public member_center()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OverWriteCustDB ov1 = new OverWriteCustDB();
            ov1.memberID = this.memeberID;
            ov1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PdSearch pd = new PdSearch();
            pd.memberID = this.memeberID;
            pd.memberName = this.memberName;
            pd.ShowDialog();
        }
    }
}
