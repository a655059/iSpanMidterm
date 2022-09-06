
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
            this.flpCommentPhoto = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemberPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMemberPhoto
            // 
            this.pbMemberPhoto.Location = new System.Drawing.Point(32, 38);
            this.pbMemberPhoto.Name = "pbMemberPhoto";
            this.pbMemberPhoto.Size = new System.Drawing.Size(200, 200);
            this.pbMemberPhoto.TabIndex = 0;
            this.pbMemberPhoto.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(270, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 32);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "評論人";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(270, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 59);
            this.panel1.TabIndex = 2;
            // 
            // txtComment
            // 
            this.txtComment.Enabled = false;
            this.txtComment.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtComment.Location = new System.Drawing.Point(478, 38);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(688, 164);
            this.txtComment.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(478, 207);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(70, 31);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "時間";
            // 
            // flpCommentPhoto
            // 
            this.flpCommentPhoto.Location = new System.Drawing.Point(1228, 38);
            this.flpCommentPhoto.Name = "flpCommentPhoto";
            this.flpCommentPhoto.Size = new System.Drawing.Size(399, 164);
            this.flpCommentPhoto.TabIndex = 5;
            // 
            // UCtrlComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 271);
            this.Controls.Add(this.flpCommentPhoto);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbMemberPhoto);
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
        private System.Windows.Forms.FlowLayoutPanel flpCommentPhoto;
    }
}