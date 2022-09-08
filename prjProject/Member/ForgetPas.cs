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
    public partial class ForgetPas : Form
    {
        iSpanProjectEntities dbContext = new iSpanProjectEntities();
        public ForgetPas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemberAccount acc = new MemberAccount();
            var q = (from i in dbContext.MemberAccounts
                    where i.Phone==txtphone.Text&&i.Email==txtmail.Text
                    select i).FirstOrDefault();
            if (!(q == null))
            {
                MessageBox.Show("您的密碼為:"+q.MemberPw);
                Close();
            }
            else 
            {
                MessageBox.Show("查無此帳號，請確認輸入資料是否正確");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Close();
        //}
    }
}
