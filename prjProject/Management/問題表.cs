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

namespace WindowsFormsApp2
{
    public partial class 問題表 : Form
    {
        public 問題表()
        {
            InitializeComponent();
        }
        iSpanProjectEntities DBiSpan = new iSpanProjectEntities();
        public int select { get; set; }

        private void 問題表_Load(object sender, EventArgs e)
        {
            var Q = DBiSpan.FAQTypes.Select(n => n.FAQTypeName).ToList();
            foreach(var i in Q)
            {
                comboBox1.Items.Add(i);
            }
            load();
        }

        private void 新增_Click(object sender, EventArgs e)
        {
            var FAQTypeID = DBiSpan.FAQTypes.Where(n => n.FAQTypeName == comboBox1.Text)
                .Select(n => n.FAQTypeID).FirstOrDefault();
            FAQ faq = new FAQ()
            {
                Answer = txtqs.Text,
                Question = txtas.Text,
                FAQTypeID=FAQTypeID
            };
            DBiSpan.FAQs.Add(faq);
            DBiSpan.SaveChanges();
            MessageBox.Show("新增成功");
        }

        private void 修改刪除_Click(object sender, EventArgs e)
        {
            var FAQTypeID = DBiSpan.FAQTypes.Where(n => n.FAQTypeName == comboBox1.Text)
                .Select(n => n.FAQTypeID).FirstOrDefault();

            var Q = DBiSpan.FAQs.Where(n => n.FAQID == select)
                .Select(n => n).FirstOrDefault();
            Q.Answer = txtqs.Text;
            Q.Question = txtas.Text;
            Q.FAQTypeID = FAQTypeID;
            DBiSpan.SaveChanges();
            MessageBox.Show("修改成功");
        }

        private void load()
        {
            txtqs.Text = DBiSpan.FAQs.Where(n => n.FAQID == select)
                            .Select(n => n.Question).FirstOrDefault();
            txtas.Text = DBiSpan.FAQs.Where(n => n.FAQID == select)
                .Select(n => n.Answer).FirstOrDefault();

            var Q = DBiSpan.FAQs.Where(n => n.FAQID == select)
                .Select(n => n.FAQTypeID).FirstOrDefault();
            comboBox1.Text = DBiSpan.FAQTypes.Where(n => n.FAQTypeID == Q)
                .Select(n => n.FAQTypeName).FirstOrDefault();
        }

        private void 刪除_Click(object sender, EventArgs e)
        {
            var Q = DBiSpan.FAQs.Where(n => n.FAQID == select).Select(n => n).FirstOrDefault();
            DBiSpan.FAQs.Remove(Q);
            DBiSpan.SaveChanges();
            MessageBox.Show("刪除成功");
        }
    }
}
