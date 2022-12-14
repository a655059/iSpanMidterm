
namespace prjProject
{
    partial class CommentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpAverageStar = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAverageStar = new System.Windows.Forms.Label();
            this.lblStar = new System.Windows.Forms.Label();
            this.flpStar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnChoosePhoto = new System.Windows.Forms.Button();
            this.flpCommentPhoto = new System.Windows.Forms.FlowLayoutPanel();
            this.txtWriteComment = new System.Windows.Forms.TextBox();
            this.btnCommit = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.splitContainer1.Panel1.Controls.Add(this.lblWelcome);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabelLogin);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1107, 721);
            this.splitContainer1.SplitterDistance = 110;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWelcome.Location = new System.Drawing.Point(1041, 6);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(54, 27);
            this.lblWelcome.TabIndex = 40;
            this.lblWelcome.Text = "歡迎";
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabelLogin.ForeColor = System.Drawing.Color.Black;
            this.linkLabelLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelLogin.LinkColor = System.Drawing.Color.Black;
            this.linkLabelLogin.Location = new System.Drawing.Point(914, 6);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(54, 27);
            this.linkLabelLogin.TabIndex = 34;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "登入";
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogin_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::prjProject.Properties.Resources.LOGO3;
            this.pictureBox1.Location = new System.Drawing.Point(10, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 284);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1110, 450);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.flpAverageStar);
            this.panel1.Controls.Add(this.lblAverageStar);
            this.panel1.Controls.Add(this.lblStar);
            this.panel1.Controls.Add(this.flpStar);
            this.panel1.Controls.Add(this.btnChoosePhoto);
            this.panel1.Controls.Add(this.flpCommentPhoto);
            this.panel1.Controls.Add(this.txtWriteComment);
            this.panel1.Controls.Add(this.btnCommit);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnAll);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 283);
            this.panel1.TabIndex = 5;
            // 
            // flpAverageStar
            // 
            this.flpAverageStar.AutoScroll = true;
            this.flpAverageStar.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.flpAverageStar.Location = new System.Drawing.Point(9, 91);
            this.flpAverageStar.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.flpAverageStar.Name = "flpAverageStar";
            this.flpAverageStar.Size = new System.Drawing.Size(172, 43);
            this.flpAverageStar.TabIndex = 18;
            // 
            // lblAverageStar
            // 
            this.lblAverageStar.AutoSize = true;
            this.lblAverageStar.Font = new System.Drawing.Font("Times New Roman", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageStar.ForeColor = System.Drawing.Color.Red;
            this.lblAverageStar.Location = new System.Drawing.Point(14, 42);
            this.lblAverageStar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAverageStar.Name = "lblAverageStar";
            this.lblAverageStar.Size = new System.Drawing.Size(113, 43);
            this.lblAverageStar.TabIndex = 17;
            this.lblAverageStar.Text = "label3";
            // 
            // lblStar
            // 
            this.lblStar.AutoSize = true;
            this.lblStar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStar.Location = new System.Drawing.Point(460, 245);
            this.lblStar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(73, 20);
            this.lblStar.TabIndex = 16;
            this.lblStar.Text = "星星評分";
            // 
            // flpStar
            // 
            this.flpStar.Location = new System.Drawing.Point(225, 234);
            this.flpStar.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.flpStar.Name = "flpStar";
            this.flpStar.Size = new System.Drawing.Size(231, 39);
            this.flpStar.TabIndex = 15;
            // 
            // btnChoosePhoto
            // 
            this.btnChoosePhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnChoosePhoto.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChoosePhoto.Location = new System.Drawing.Point(788, 194);
            this.btnChoosePhoto.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnChoosePhoto.Name = "btnChoosePhoto";
            this.btnChoosePhoto.Size = new System.Drawing.Size(94, 33);
            this.btnChoosePhoto.TabIndex = 14;
            this.btnChoosePhoto.Text = "選擇照片";
            this.btnChoosePhoto.UseVisualStyleBackColor = false;
            this.btnChoosePhoto.Click += new System.EventHandler(this.btnChoosePhoto_Click);
            // 
            // flpCommentPhoto
            // 
            this.flpCommentPhoto.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.flpCommentPhoto.Location = new System.Drawing.Point(675, 96);
            this.flpCommentPhoto.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.flpCommentPhoto.Name = "flpCommentPhoto";
            this.flpCommentPhoto.Size = new System.Drawing.Size(206, 89);
            this.flpCommentPhoto.TabIndex = 13;
            // 
            // txtWriteComment
            // 
            this.txtWriteComment.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtWriteComment.Location = new System.Drawing.Point(225, 96);
            this.txtWriteComment.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtWriteComment.Multiline = true;
            this.txtWriteComment.Name = "txtWriteComment";
            this.txtWriteComment.Size = new System.Drawing.Size(434, 133);
            this.txtWriteComment.TabIndex = 12;
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCommit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCommit.Location = new System.Drawing.Point(563, 234);
            this.btnCommit.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(94, 39);
            this.btnCommit.TabIndex = 11;
            this.btnCommit.Text = "給評價";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.Location = new System.Drawing.Point(788, 42);
            this.button6.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 39);
            this.button6.TabIndex = 10;
            this.button6.Text = "一星";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(675, 42);
            this.button5.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 39);
            this.button5.TabIndex = 9;
            this.button5.Text = "二星";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(563, 42);
            this.button4.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 39);
            this.button4.TabIndex = 8;
            this.button4.Text = "三星";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(450, 42);
            this.button3.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 39);
            this.button3.TabIndex = 7;
            this.button3.Text = "四星";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(338, 42);
            this.button2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "五星";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.White;
            this.btnAll.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAll.Location = new System.Drawing.Point(225, 42);
            this.btnAll.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(94, 39);
            this.btnAll.TabIndex = 5;
            this.btnAll.Text = "全部";
            this.btnAll.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "商品評價";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProductName.Location = new System.Drawing.Point(229, 8);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(96, 27);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "商品名稱";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // CommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 721);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "CommentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CommentForm";
            this.Load += new System.EventHandler(this.CommentForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtWriteComment;
        private System.Windows.Forms.Button btnChoosePhoto;
        private System.Windows.Forms.FlowLayoutPanel flpCommentPhoto;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.FlowLayoutPanel flpStar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblAverageStar;
        private System.Windows.Forms.FlowLayoutPanel flpAverageStar;
    }
}