using prjProject.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjProject.Buyer
{
    public partial class CommentPhotoForm : Form
    {
        public CommentPhotoForm()
        {
            InitializeComponent();
        }
        public int commentID { get; set; }
        iSpanProjectEntities dbContext = new iSpanProjectEntities();
        private void CommentPhotoForm_Load(object sender, EventArgs e)
        {
            var commentPhotos = dbContext.CommentPics.Where(i => i.CommentID == commentID).Select(i => i.CommentPic1);
            foreach (var p in commentPhotos)
            {
                MemoryStream ms = new MemoryStream(p);
                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 600;
                pictureBox.Height = 600;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromStream(ms);
                flowLayoutPanel1.Controls.Add(pictureBox);
            }
        }
    }
}
