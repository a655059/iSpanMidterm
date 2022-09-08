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

namespace prjProject.Buyer
{
    public partial class frm_FAQ : Form
    {
        iSpanProjectEntities dbContext = new iSpanProjectEntities();
        public frm_FAQ()
        {
            InitializeComponent();
        }

        private void FAQ_Load(object sender, EventArgs e)
        {
            Refresh_Form();
        }
        void Refresh_Form()
        {
            var q = from t in dbContext.FAQTypes select t.FAQTypeName;
            lst_Type.DataSource = q.ToList();
            Change_on_lstIndex(lst_Type.SelectedItem.ToString());
        }

        private void lst_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Change_on_lstIndex(lst_Type.SelectedItem.ToString());
        }

        void Change_on_lstIndex(string selitem)
        {
            txt_FAQ.Text = "";
            var q = from t in dbContext.FAQs.AsEnumerable() where selitem == t.FAQType.FAQTypeName select t;
            var FAQlst = q.ToList();
            foreach(var FAQitem in q)
            {
                txt_FAQ.Text += FAQitem.Question + "\r\n";
                txt_FAQ.Text += FAQitem.Answer + "\r\n\r\n";
            }
            foreach (var FAQitem in q)
            {
                txt_FAQ.Select(txt_FAQ.Text.IndexOf(FAQitem.Question), FAQitem.Question.Length);
                txt_FAQ.SelectionFont = new Font("微軟正黑體", 24, FontStyle.Bold);
            }
            
        }

    }
}
