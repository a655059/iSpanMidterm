using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjProject
{
    public partial class FlowBarProductTypeLastPage : UserControl
    {
        public FlowBarProductTypeLastPage()
        {
            InitializeComponent();
        }
        string _name = "";
        public string TypeName { get { return _name; } set { _name = value; } }
        public event EventHandler<ButtonClickedEventArgs2> ButtonClicked;
        protected virtual void OnButtonClicked(ButtonClickedEventArgs2 e)
        {
            this.ButtonClicked.Invoke(this, e);
        }
        private void FlowBarProductTypeLastPage_Load(object sender, EventArgs e)
        {
            button1.Text = _name;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.OnButtonClicked(new ButtonClickedEventArgs2((Button)sender));
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Orange;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }
    }
    public class ButtonClickedEventArgs2 : EventArgs
    {
        public Button Button { get; set; }

        public ButtonClickedEventArgs2(Button btn) => this.Button = btn;
    }
}

