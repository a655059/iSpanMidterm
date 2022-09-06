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
    public partial class UCtrlComment : UserControl
    {
        public UCtrlComment()
        {
            InitializeComponent();
        }
        public bool HasCommentPhoto
        {
            set
            {
                linkLabelCommentPhoto.Visible = value;
            }
        }
        public int commentID { get; set; }
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
                    pictureBox.Width = 30;
                    pictureBox.Height = 30;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Image = Image.FromFile("../../Images/twinkleStar.png");
                    flpStar.Controls.Add(pictureBox);
                }
                for (int i = value; i + 1 <= 4; i++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 30;
                    pictureBox.Height = 30;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Image = Image.FromFile("../../Images/star.png");
                    flpStar.Controls.Add(pictureBox);
                }
            }
        }

        
    }
}
