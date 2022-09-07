using prjProject.Buyer;
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
        //public string ProductNumInCart
        //{
        //    get { return lblProductNumInCart.Text; }
        //    set { lblProductNumInCart.Text = value; }
        //}
        public string memberCenter
        {
            get { return linkLabelLogin.Text; }
            set { linkLabelLogin.Text = value; }
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
        public bool IsLogin
        {
            set
            {
                var q = dbContext.OrderDetails.Where(i => i.ProductDetail.Product.ProductID == productID && i.Order.MemberID == memberID && i.Order.StatusID == 6).Select(i => i).ToList();
                if (q.Count > 0)
                {
                    txtWriteComment.Enabled = value;
                    flpStar.Enabled = value;
                    btnChoosePhoto.Enabled = value;
                }
                else
                {
                    txtWriteComment.Enabled = false;
                    flpStar.Enabled = false;
                    btnChoosePhoto.Enabled = false;
                }   
            }
        }
        public int memberID { get; set; }
        public int productID { get; set; }
        private int starCount = 0;

        iSpanProjectEntities dbContext = new iSpanProjectEntities();
        private void CommentForm_Load(object sender, EventArgs e)
        {
            memberID = CFunctions.GetMemberInfoFromHomePage();
            if (memberID > 0)
            {
                CFunctions.SendMemberInfoToEachForm(memberID);
                IsLogin = true;
            }
            else
            {
                IsLogin = false;
            }
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
            List<UCtrlComment> list = CFunctions.GetComments(productID);
            foreach (UCtrlComment uCtrl in list)
            {
                flowLayoutPanel1.Controls.Add(uCtrl);
                foreach (Control control in uCtrl.Controls)
                {
                    if (control.GetType() == typeof(LinkLabel))
                    {
                        LinkLabel linkLabel = (LinkLabel)control;
                        linkLabel.Click += ShowCommentPhoto_Click;
                    }
                }
            }
            foreach (Control control in panel1.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    Button button = (Button)control;
                    if (button.Text == "給評價" || button.Text == "選擇照片")
                    {
                        continue;
                    }
                    button.Click += CommentFilter_Click;
                }
            }
            decimal averageStar = CFunctions.GetAverageStarScore(productID);
            if (averageStar > 0)
            {
                lblAverageStar.Text = averageStar.ToString("0.0");
                int starScore = Convert.ToInt32(Math.Round(averageStar, MidpointRounding.AwayFromZero));
                CFunctions.ShowStar(starScore, flpAverageStar, 20);
            }
            else
            {
                lblAverageStar.Text = "尚無評分";
                lblAverageStar.Font = new Font("標楷體", 12);
            }
        }
        Dictionary<int, int> dic = new Dictionary<int, int>()
            {
                {12, 5}, {11, 4}, {10, 3}, {9, 2}, {8, 1},
            };
        private void CommentFilter_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Button button = (Button)sender;
            int index = panel1.Controls.IndexOf(button);
            
            List<UCtrlComment> list;
            if (index == 13)
            {
                list = CFunctions.GetComments(productID);
            }
            else
            {
                list = CFunctions.GetComments(productID, dic[index]);
            }
            foreach (UCtrlComment uCtrl in list)
            {
                flowLayoutPanel1.Controls.Add(uCtrl);
                foreach (Control control in uCtrl.Controls)
                {
                    if (control.GetType() == typeof(LinkLabel))
                    {
                        LinkLabel linkLabel = (LinkLabel)control;
                        linkLabel.Click += ShowCommentPhoto_Click;
                    }
                }
            }
        }

        private void ShowCommentPhoto_Click(object sender, EventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;
            UCtrlComment uCtrl = (UCtrlComment)linkLabel.Parent;
            CommentPhotoForm form = new CommentPhotoForm();
            form.commentID = uCtrl.commentID;
            form.ShowDialog();
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
            var q = dbContext.OrderDetails.Where(i => i.ProductDetail.Product.ProductID == productID && i.Order.MemberID == memberID && i.Order.StatusID == 6).Select(i => i).ToList();
            if (memberID > 0)
            {
                if (q.Count == 0)
                {
                    MessageBox.Show("要先購買才能評論");
                    return;
                }
                else if (txtWriteComment.Text == "")
                {
                    MessageBox.Show("請寫評論");
                    return;
                }
                else if (starCount == 0)
                {
                    MessageBox.Show("請用星星評分");
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
                    if (flpCommentPhoto.Controls.Count > 0)
                    {
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
                    MessageBox.Show("感謝你的評論");
                    flowLayoutPanel1.Controls.Clear();
                    flpAverageStar.Controls.Clear();
                    List<UCtrlComment> list = CFunctions.GetComments(productID);
                    foreach (UCtrlComment uCtrl in list)
                    {
                        flowLayoutPanel1.Controls.Add(uCtrl);
                        foreach (Control control in uCtrl.Controls)
                        {
                            if (control.GetType() == typeof(LinkLabel))
                            {
                                LinkLabel linkLabel = (LinkLabel)control;
                                linkLabel.Click += ShowCommentPhoto_Click;
                            }
                        }
                    }
                    CFunctions.SendMemberInfoToEachForm(memberID, productID);
                    decimal averageStar = CFunctions.GetAverageStarScore(productID);
                    if (averageStar > 0)
                    {
                        lblAverageStar.Text = averageStar.ToString("0.0");
                        int starScore = Convert.ToInt32(Math.Floor(averageStar));
                        CFunctions.ShowStar(starScore, flpAverageStar, 20);
                    }
                    else
                    {
                        lblAverageStar.Text = "尚無評分";
                        lblAverageStar.Font = new Font("標楷體", 12);
                    }
                }
            }
            else
            {
                LoginForm form = new LoginForm();
                form.ShowDialog();
            }
        }

        

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (memberID > 0)
            {
                return;
            }
            LoginForm form = new LoginForm();
            form.ShowDialog();
        }
    }
}
