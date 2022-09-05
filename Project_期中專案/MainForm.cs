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
    public partial class MainForm : Form
    {
        public string account 
        {
            get { return label1.Text; }
            set { label1.Text = value; }

        }

        public MainForm()
        {
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //member_center m = new member_center();
            //m.MdiParent = this;
            //m.WindowState = FormWindowState.Maximized;
            //m.Show();
            member_center form = new member_center();
            form.account2 = account;
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            (new member_cre()).ShowDialog();

        }
    }
}
