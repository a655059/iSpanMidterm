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
    public partial class member_cre : Form
    {
        bool isClosed = true;
        iSpanProjectEntities2 dbContext = new iSpanProjectEntities2();
        public member_cre()
        {
            InitializeComponent();
        }

        private void btn_Sigin_Click(object sender, EventArgs e)
        {
            MemberAccount list = new MemberAccount();

            //member_center center = (member_center)this.Owner;

            var account1 = txtAccount.Text;
            

            var q = from i in dbContext.MemberAccounts
                    where i.MemberAcc == account1
                    select i;
            if (q.Any())
            {
                //foreach (Form form in Application.OpenForms)
                //{
                //    if (form.GetType() == typeof(Frm_main))
                //    {
                //        ((Frm_main)form).account = account_txt.Text;
                //    }

                //}
                if (txtPassord.Text == q.First().MemberPw)
                {
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.GetType() == typeof(MainForm))
                        {
                            ((MainForm)form).account = account1;
                        }
                    }
                    MessageBox.Show("登入成功!");
                    isClosed = false;
                    Close();
                    return;
                }
                else MessageBox.Show("密碼有錯");
            }
            else MessageBox.Show("帳號有錯");

        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            isClosed = false;
            Application.Exit();
        }

        private void member_cre_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = isClosed;
        }

        private void btn_creat_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ForgetPas().ShowDialog();
        }
    }
}
