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
    public partial class FlowBarProductType : UserControl
    {
        public FlowBarProductType()
        {
            InitializeComponent();            
        }
        string _name = "";
        int _typeNum;
        public int TypeNum { get { return _typeNum; } set { _typeNum = value; } }
        public string TypeName { get { return _name; } set { _name = value; } }
        public event EventHandler<ButtonClickedEventArgs> ButtonClicked;

        private void button1_Click(object sender, EventArgs e)
        {
            this.OnButtonClicked(new ButtonClickedEventArgs((Button)sender));
        }
        protected virtual void OnButtonClicked(ButtonClickedEventArgs e)
        {
            this.ButtonClicked?.Invoke(this, e);
        }

        private void FlowBarProductType_Load(object sender, EventArgs e)
        {
            button1.Text = _name;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
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
    public class ButtonClickedEventArgs : EventArgs
    {
        public Button Button { get; set; }

        public ButtonClickedEventArgs(Button btn) => this.Button = btn;
    }

}

