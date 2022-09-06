
namespace prjProject
{
    partial class UCtrlComment
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
            this.pbMemberPhoto = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemberPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMemberPhoto
            // 
            this.pbMemberPhoto.Location = new System.Drawing.Point(15, 19);
            this.pbMemberPhoto.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pbMemberPhoto.Name = "pbMemberPhoto";
            this.pbMemberPhoto.Size = new System.Drawing.Size(92, 100);
            this.pbMemberPhoto.TabIndex = 0;
            this.pbMemberPhoto.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(125, 19);
            this.lblName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "評論人";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(125, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 30);
            this.panel1.TabIndex = 2;
            // 
            // txtComment
            // 
            this.txtComment.Enabled = false;
            this.txtComment.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtComment.Location = new System.Drawing.Point(221, 19);
            this.txtComment.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(320, 84);
            this.txtComment.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(221, 104);
            this.lblTime.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 16);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "時間";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabel1.Location = new System.Drawing.Point(600, 53);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 16);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "附圖";
            // 
            // UCtrlComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 136);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbMemberPhoto);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "UCtrlComment";
            this.Text = "UCtrlComment";
            ((System.ComponentModel.ISupportInitialize)(this.pbMemberPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMemberPhoto;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}