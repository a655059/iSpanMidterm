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
            myMemberShow();
            //var q1 = (from i in dbContext.MemberAccounts
            //          where i.MemberID == memberID
            //          select i).ToList();
            //int memid = q1[0].MemberID;

            //var q = from i in dbContext.Orders
            //        where i.MemberID == memid
            //        select i;
            //this.dataGridView1.DataSource = q.ToList();
//==============================================================
            //int nowId = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["OrderID"].Value.ToString());
            //var or = (from i in dbContext.Orders
            //          where i.MemberID == nowId
            //          select i).FirstOrDefault();
            //if (or == null) return;
            //this.txt_id.Text = or.OrderID.ToString();
            


        }
        void myMemberShow()
        {
            var q1 = (from i in dbContext.MemberAccounts
                      where i.MemberID == memberID
                      select i).ToList();
            int memid = q1[0].MemberID;

            var q = from i in dbContext.Orders
                    where i.MemberID == memid
                    //group i by i.OrderID into g
                    select new {訂單編號=i.OrderID,訂單成立時間=i.OrderDatetime,收件地址=i.RecieveAdr,訂單完成時間=i.FinishDate,優惠卷代碼=i.CouponID,訂單狀態=i.StatusID};
            this.dataGridView1.DataSource = q.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int nowId = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["訂單編號"].Value.ToString());
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
            this.txt_reAdd.Text = or.RecieveAdr.ToString();
            //this.txt_pdid.Text = or.ProductID.ToString();
            this.txt_finday.Text = or.FinishDate.ToString();
            this.txt_coupid.Text = or.Coupon.CouponName;
            this.txt_statid.Text = st[0].OrderStatusName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("請確認是否收到商品","訂單情況",MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                
                int nowId = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["訂單編號"].Value.ToString());
                var or = (from i in dbContext.Orders
                          where i.OrderID == nowId
                          select i).FirstOrDefault();
                or.StatusID = 6;
                this.dbContext.SaveChanges();
            }
            else if (result == DialogResult.Cancel)
            {
                return;
            }
        }

        private void btn_未結帳_Click(object sender, EventArgs e)
        {
            var q1 = (from i in dbContext.MemberAccounts
                      where i.MemberID == memberID
                      select i).ToList();
            int memid = q1[0].MemberID;
            var orst = from i in dbContext.Orders
                       where i.StatusID == 6&&i.MemberID==memid
                       select new { 訂單編號=i.OrderID,訂單狀態=i.OrderStatus.OrderStatusName,訂單成立時間=i.OrderDatetime,收貨地址=i.RecieveAdr,訂單完成時間=i.FinishDate,優惠券名稱=i.Coupon.CouponName};
            var list = orst.ToList();
            this.dataGridView1.DataSource =list;
            if (list.Count == 0) 
            {
                this.txt_id.Text = null;
                this.txt_datime.Text = null;
                this.txt_reAdd.Text = null;
                //this.txt_pdid.Text = or.ProductID.ToString();
                this.txt_finday.Text = null;
                this.txt_coupid.Text = null;
                this.txt_statid.Text = null;
            }
            else
            {
            this.txt_id.Text = list[0].訂單編號.ToString();
            this.txt_statid.Text = list[0].訂單狀態;
                this.txt_datime.Text = list[0].訂單成立時間.ToString();
                this.txt_reAdd.Text = list[0].收貨地址;
                this.txt_finday.Text = list[0].訂單完成時間.ToString();
                this.txt_coupid.Text = list[0].優惠券名稱;
            }

        }

        private void btn_已出貨_Click(object sender, EventArgs e)
        {
            var q1 = (from i in dbContext.MemberAccounts
                      where i.MemberID == memberID
                      select i).ToList();
            int memid = q1[0].MemberID;
            var orst = from i in dbContext.Orders
                       where i.StatusID == 3 && i.MemberID == memid
                       select new { 訂單編號 = i.OrderID, 訂單狀態 = i.OrderStatus.OrderStatusName, 訂單成立時間 = i.OrderDatetime, 收貨地址 = i.RecieveAdr, 訂單完成時間 = i.FinishDate, 優惠券名稱 = i.Coupon.CouponName };
            var list = orst.ToList();
            this.dataGridView1.DataSource = list;
            if (list.Count == 0)
            {
                this.txt_id.Text = null;
                this.txt_datime.Text = null;
                this.txt_reAdd.Text = null;
                //this.txt_pdid.Text = or.ProductID.ToString();
                this.txt_finday.Text = null;
                this.txt_coupid.Text = null;
                this.txt_statid.Text = null;
            }
            else
            {
            this.txt_id.Text = list[0].訂單編號.ToString();
            this.txt_statid.Text = list[0].訂單狀態;
                this.txt_datime.Text = list[0].訂單成立時間.ToString();
                this.txt_reAdd.Text = list[0].收貨地址;
                this.txt_finday.Text = list[0].訂單完成時間.ToString();
                this.txt_coupid.Text = list[0].優惠券名稱;

            }

        }

        private void btn_已到貨_Click(object sender, EventArgs e)
        {
            var q1 = (from i in dbContext.MemberAccounts
                      where i.MemberID == memberID
                      select i).ToList();
            int memid = q1[0].MemberID;
            var orst = from i in dbContext.Orders
                       where i.StatusID == 4 && i.MemberID == memid
                       select new { 訂單編號 = i.OrderID, 訂單狀態 = i.OrderStatus.OrderStatusName, 訂單成立時間 = i.OrderDatetime, 收貨地址 = i.RecieveAdr, 訂單完成時間 = i.FinishDate, 優惠券名稱 = i.Coupon.CouponName };
            var list = orst.ToList();
            this.dataGridView1.DataSource = list;
            if (list.Count == 0)
            {
                this.txt_id.Text = null;
                this.txt_datime.Text = null;
                this.txt_reAdd.Text = null;
                //this.txt_pdid.Text = or.ProductID.ToString();
                this.txt_finday.Text = null;
                this.txt_coupid.Text = null;
                this.txt_statid.Text = null;
            }
            else
            {
                this.txt_id.Text = list[0].訂單編號.ToString();
                this.txt_statid.Text = list[0].訂單狀態;
                this.txt_datime.Text = list[0].訂單成立時間.ToString();
                this.txt_reAdd.Text = list[0].收貨地址;
                this.txt_finday.Text = list[0].訂單完成時間.ToString();
                this.txt_coupid.Text = list[0].優惠券名稱;

            }
        }

        private void btn_退換貨_Click(object sender, EventArgs e)
        {
            var q1 = (from i in dbContext.MemberAccounts
                      where i.MemberID == memberID
                      select i).ToList();
            int memid = q1[0].MemberID;
            var orst = from i in dbContext.Orders
                       where i.StatusID == 8 && i.MemberID == memid
                       select new { 訂單編號 = i.OrderID, 訂單狀態 = i.OrderStatus.OrderStatusName, 訂單成立時間 = i.OrderDatetime, 收貨地址 = i.RecieveAdr, 訂單完成時間 = i.FinishDate, 優惠券名稱 = i.Coupon.CouponName };
            var list = orst.ToList();
            this.dataGridView1.DataSource = list;
            if (list.Count == 0)
            {
                this.txt_id.Text = null;
                this.txt_datime.Text = null;
                this.txt_reAdd.Text = null;
                //this.txt_pdid.Text = or.ProductID.ToString();
                this.txt_finday.Text = null;
                this.txt_coupid.Text = null;
                this.txt_statid.Text = null;
            }
            else
            {
                this.txt_id.Text = list[0].訂單編號.ToString();
                this.txt_statid.Text = list[0].訂單狀態;
                this.txt_datime.Text = list[0].訂單成立時間.ToString();
                this.txt_reAdd.Text = list[0].收貨地址;
                this.txt_finday.Text = list[0].訂單完成時間.ToString();
                this.txt_coupid.Text = list[0].優惠券名稱;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myMemberShow();
        }
    }
}
