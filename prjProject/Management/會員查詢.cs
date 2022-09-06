using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class 會員查詢 : Form
    {
        public 會員查詢()
        {
            InitializeComponent();
        }
        iSpanProjectEntities1 DBiSpan = new iSpanProjectEntities1();
        public string acc { get; set; }
        
        private void btnselect_Click(object sender, EventArgs e)
        {
            var Q = DBiSpan.MemberAccounts.Where(n=>n.Phone==txtselect.Text).Select(n => n.Phone).FirstOrDefault();
            
            if (Q.Any())
            {
                var O = DBiSpan.MemberAccounts.Where(n=>n.Phone==Q)
                    .Select(n => n.MemberAcc).FirstOrDefault();
                acc = O;
                Close();
            }               
            else
                MessageBox.Show("查無此人");
        }
    }
}
