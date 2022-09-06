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

namespace prjProject.Member
{
    public partial class memberCoupon : Form
    {
        public string memberName { get; set; }
        public int memberID { get; set; }
        iSpanProjectEntities dbindex = new iSpanProjectEntities();

        public memberCoupon()
        {
            InitializeComponent();
        }

        private void memberCoupon_Load(object sender, EventArgs e)
        {
            var q = (from i in dbindex.MemberAccounts
                     where i.MemberID == memberID
                     select i).FirstOrDefault();

        }
    }
}
