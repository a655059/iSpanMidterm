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
        public string memberName{get;set;}
        public int memberID { get; set; }
        

        public PdSearch()
        {
            InitializeComponent();

        }

        private void PdSearch_Load(object sender, EventArgs e)
        {
            mem_Name.Text = memberName;
           
            var q1 = (from i in dbContext.MemberAccounts
                      where i.MemberID == memberID
                      select i).ToList();
            int memid = q1[0].MemberID;

            var q = from i in dbContext.Orders
                    where i.MemberID == memid
                    select i;
            this.dataGridView1.DataSource = q.ToList();
//==============================================================
            //int nowId = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["OrderID"].Value.ToString());
            //var or = (from i in dbContext.Orders
            //          where i.MemberID == nowId
            //          select i).FirstOrDefault();
            //if (or == null) return;
            //this.txt_id.Text = or.OrderID.ToString();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int nowId = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["OrderID"].Value.ToString());
            var or = (from i in dbContext.Orders
                      where i.OrderID == nowId
                      select i).FirstOrDefault();
            var st = (from i in dbContext.OrderStatuses
                     where i.OrderStatusID == or.StatusID
                     select i).ToList();

            //MessageBox.Show(or.OrderID.ToString());
            if (or == null) return;
            this.txt_id.Text = or.OrderID.ToString();
            this.txt_datime.Text = or.OrderDatetime.ToString();
            this.txt_retime.Text = or.RecieveAdr.ToString();
            this.txt_pdid.Text = or.ProductID.ToString();
            this.txt_finday.Text = or.FinishDate.ToString();
            this.txt_coupid.Text = or.CouponID.ToString();
            this.txt_statid.Text = st[0].OrderStatusName;
        }
    }
}
