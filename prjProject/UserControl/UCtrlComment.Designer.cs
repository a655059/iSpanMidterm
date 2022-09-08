
namespace prjProject.Buyer
{
    partial class UCtrlComment
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLabelCommentPhoto = new System.Windows.Forms.LinkLabel();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pbMemberPhoto = new System.Windows.Forms.PictureBox();
            this.flpStar = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemberPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelCommentPhoto
            // 
            this.linkLabelCommentPhoto.AutoSize = true;
            this.linkLabelCommentPhoto.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabelCommentPhoto.Location = new System.Drawing.Point(725, 53);
            this.linkLabelCommentPhoto.Name = "linkLabelCommentPhoto";
            this.linkLabelCommentPhoto.Size = new System.Drawing.Size(41, 20);
            this.linkLabelCommentPhoto.TabIndex = 11;
            this.linkLabelCommentPhoto.TabStop = true;
            this.linkLabelCommentPhoto.Text = "附圖";
            // 
            // txtComment
            // 
            this.txtComment.Enabled = false;
            this.txtComment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtComment.Location = new System.Drawing.Point(372, 19);
            this.txtComment.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(349, 84);
            this.txtComment.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(129, 19);
            this.lblName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 24);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "評論人";
            // 
            // pbMemberPhoto
            // 
            this.pbMemberPhoto.Location = new System.Drawing.Point(19, 19);
            this.pbMemberPhoto.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pbMemberPhoto.Name = "pbMemberPhoto";
            this.pbMemberPhoto.Size = new System.Drawing.Size(92, 100);
            this.pbMemberPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMemberPhoto.TabIndex = 6;
            this.pbMemberPhoto.TabStop = false;
            // 
            // flpStar
            // 
            this.flpStar.AutoScroll = true;
            this.flpStar.Location = new System.Drawing.Point(133, 53);
            this.flpStar.Name = "flpStar";
            this.flpStar.Size = new System.Drawing.Size(192, 38);
            this.flpStar.TabIndex = 12;
            // 
            // UCtrlComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpStar);
            this.Controls.Add(this.linkLabelCommentPhoto);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbMemberPhoto);
            this.Name = "UCtrlComment";
            this.Size = new System.Drawing.Size(814, 137);
            ((System.ComponentModel.ISupportInitialize)(this.pbMemberPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelCommentPhoto;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbMemberPhoto;
        private System.Windows.Forms.FlowLayoutPanel flpStar;
    }
}
