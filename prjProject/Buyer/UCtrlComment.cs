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
        public int star
        {
            set
            {
                for (int i = 0; i <= value; i++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 10;
                    pictureBox.Height = 10;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Image = Image.FromFile("../../Images/twinkleStar.png");
                    panel1.Controls.Add(pictureBox);
                }
                for (int i = value; i + 1 <= 4; i++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 10;
                    pictureBox.Height = 10;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Image = Image.FromFile("../../Images/star.png");
                    panel1.Controls.Add(pictureBox);
                }
            }
        }
    }
}
