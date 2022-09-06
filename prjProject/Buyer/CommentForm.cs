using prjProject.Entity;
using prjProject.Models;
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

namespace prjProject
{
    public partial class CommentForm : Form
    {
        public CommentForm()
        {
            InitializeComponent();
        }
        public string ProductNumInCart
        {
            get { return lblProductNumInCart.Text; }
            set { lblProductNumInCart.Text = value; }
        }
        public string memberName
        {
            get { return lblWelcome.Text; }
            set { lblWelcome.Text = value; }
        }
        public string productName
        {
            get { return lblProductName.Text; }
            set { lblProductName.Text = value; }
        }
        public int memberID { get; set; }
        public int productID { get; set; }
        private int starCount = 0;

        iSpanProjectEntities dbContext = new iSpanProjectEntities();
        private void CommentForm_Load(object sender, EventArgs e)
        {
            memberID = CFunctions.GetMemberInfoFromHomePage();
            
            for (int i = 0; i < 5; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 30;
                pictureBox.Height = 30;
                pictureBox.Image = Image.FromFile("../../Images/star.png");
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                flpStar.Controls.Add(pictureBox);
                pictureBox.Click += Star_Click;
            }
        }

        private void Star_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            int index = flpStar.Controls.IndexOf(pictureBox);
            for (int i = 0; i <= index; i++)
            {
                PictureBox pb = (PictureBox)flpStar.Controls[i];
                pb.Image = Image.FromFile("../../Images/twinkleStar.png");
            }
            for (int i = index; i + 1 <= 4; i++)
            {
                PictureBox pb = (PictureBox)flpStar.Controls[i + 1];
                pb.Image = Image.FromFile("../../Images/star.png");
            }
            lblStar.Text = $"你給 {index + 1} 顆星";
            starCount = index + 1;
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in openFileDialog1.FileNames)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 30;
                    pictureBox.Height = 30;
                    pictureBox.Image = Image.FromFile(filePath);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    flpCommentPhoto.Controls.Add(pictureBox);
                    pictureBox.DoubleClick += CommentPhoto_DoubleClick;
                }
            }
        }

        private void CommentPhoto_DoubleClick(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            flpCommentPhoto.Controls.Remove(pictureBox);
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (memberID > 0)
            {
                if (txtWriteComment.Text == "")
                {
                    MessageBox.Show("請寫評論");
                    return;
                }
                else if (starCount == 0)
                {
                    MessageBox.Show("請用星星評分");
                    return;
                }
                else if (flpCommentPhoto.Controls.Count < 1)
                {
                    MessageBox.Show("請選擇圖片");
                    return;
                }
                else
                {
                    Comment comment = new Comment
                    {
                        ProductID = productID,
                        MemberID = memberID,
                        Comment1 = txtWriteComment.Text,
                        Star = Convert.ToByte(starCount),
                    };
                    dbContext.Comments.Add(comment);
                    dbContext.SaveChanges();
                    int commentID = dbContext.Comments.Where(i => i.MemberID == memberID && i.ProductID == productID).Select(i => i.CommentID).OrderByDescending(i => i).FirstOrDefault();
                    foreach (PictureBox pb in flpCommentPhoto.Controls)
                    {
                        MemoryStream ms = new MemoryStream();
                        pb.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] bytes = ms.GetBuffer();
                        CommentPic commentPic = new CommentPic
                        {
                            CommentID = commentID,
                            CommentPic1 = bytes,
                        };
                        dbContext.CommentPics.Add(commentPic);
                        dbContext.SaveChanges();
                    }
                }
            }
            else
            {
                LoginForm form = new LoginForm();
                form.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
