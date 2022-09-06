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
    public partial class 常見問題 : Form
    {
        public 常見問題()
        {
            InitializeComponent();
        }

        private void 增刪修按鈕_Click(object sender, EventArgs e)
        {
            問題表 問題表 = new 問題表();
            var Q = dataGridView1.CurrentRow.Cells["FAQID"].Value;
            問題表.select = Convert.ToInt32(Q);
            問題表.Show();
        }
        iSpanProjectEntities1 DBiSpan = new iSpanProjectEntities1();
        private void 常見問題_Load(object sender, EventArgs e)
        {
            var Q = DBiSpan.FAQs.Select(n => new {
                n.FAQID,
                n.Question,
                n.Answer,
                n.FAQTypeID
            }).ToList();
            dataGridView1.DataSource = Q;

            var QQ = DBiSpan.FAQTypes.Select(n => new { 
            n.FAQTypeID,
            n.FAQTypeName
            }).ToList();
            dataGridView2.DataSource = QQ;
        }
    }
}
