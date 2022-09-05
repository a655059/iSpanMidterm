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
    public partial class UCtrlComment : Form
    {
        public UCtrlComment()
        {
            InitializeComponent();
        }
        public Image memberPhoto
        {
            get { return pbMemberPhoto.Image; }
            set { pbMemberPhoto.Image = value; }
        }
        public string memberName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public string comment
        {
            get { return txtComment.Text; }
            set { txtComment.Text = value; }
        }
        //public object commentPhoto
        //{
        //    get { return flpCommentPhoto.Controls; }
        //    set { flpCommentPhoto.Controls = value; }
        //}
    }
}
