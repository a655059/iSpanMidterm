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
    public partial class 主畫面 : Form
    {
        public 主畫面()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            帳號管理 帳號 = new 帳號管理();
            產品管理 產品 = new 產品管理();
            訂單管理 訂單 = new 訂單管理();
            集運管理 集運 = new 集運管理();

            if (comboBox1.SelectedItem == "帳號管理")
            {
            panel1.Controls.Clear();
            帳號.TopLevel = false;
            panel1.Controls.Add(帳號);
            帳號.Show();
            }
            else if(comboBox1.SelectedItem == "產品管理")
            {
                panel1.Controls.Clear();
                產品.TopLevel = false;
                panel1.Controls.Add(產品);
                產品.Show();
            }
            else if (comboBox1.SelectedItem == "訂單管理")
            {
                panel1.Controls.Clear();
                訂單.TopLevel = false;
                panel1.Controls.Add(訂單);
                訂單.Show();
            }
            else if (comboBox1.SelectedItem == "集運管理")
            {
                panel1.Controls.Clear();
                集運.TopLevel = false;
                panel1.Controls.Add(集運);
                集運.Show();
            }
            else
                panel1.Controls.Clear();
        }
    }
}
