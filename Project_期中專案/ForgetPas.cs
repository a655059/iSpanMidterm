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
    public partial class ForgetPas : Form
    {
        iSpanProjectEntities2 dbContext = new iSpanProjectEntities2();
        public ForgetPas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemberAccount acc = new MemberAccount();
            var q = (from i in dbContext.MemberAccounts
                    where i.MemberAcc==txtAcc.Text
                    select i).FirstOrDefault();
            if (!(q == null))
            {
                MessageBox.Show("您的密碼為:"+q.MemberPw);
            }
            else
                MessageBox.Show("查無此帳號");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
