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
    public partial class PdSearch : Form
    {
        iSpanProjectEntities dbContext = new iSpanProjectEntities();
        public string account{get;set;}


        public PdSearch()
        {
            InitializeComponent();

        }

        private void PdSearch_Load(object sender, EventArgs e)
        {
            mem_Name.Text = account;
            var q1 = (from i in dbContext.MemberAccounts
                      where i.MemberAcc == account
                      select i).ToList();
            int memid = q1[0].MemberID;

            var q = from i in dbContext.Orders
                    where i.MemberID == memid
                    select i;
            this.dataGridView1.DataSource = q.ToList();
//==============================================================
            int nowId = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["OrderID"].Value.ToString());
            var or = (from i in dbContext.Orders
                      where i.MemberID == nowId
                      select i).FirstOrDefault();
            if (or == null) return;
            this.txt_id.Text = or.OrderID.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
