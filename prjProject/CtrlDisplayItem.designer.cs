
namespace pgjMidtermProject
{
    partial class CtrlDisplayItem
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
            this.pbItemPhoto = new System.Windows.Forms.PictureBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblSoldOut = new System.Windows.Forms.Label();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbItemPhoto
            // 
            this.pbItemPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbItemPhoto.Location = new System.Drawing.Point(4, 3);
            this.pbItemPhoto.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pbItemPhoto.Name = "pbItemPhoto";
            this.pbItemPhoto.Size = new System.Drawing.Size(147, 110);
            this.pbItemPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbItemPhoto.TabIndex = 6;
            this.pbItemPhoto.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.White;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbName.Location = new System.Drawing.Point(10, 116);
            this.tbName.MinimumSize = new System.Drawing.Size(139, 44);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(139, 44);
            this.tbName.TabIndex = 9;
            this.tbName.Text = "123";
            // 
            // lblSoldOut
            // 
            this.lblSoldOut.AutoSize = true;
            this.lblSoldOut.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSoldOut.ForeColor = System.Drawing.Color.Red;
            this.lblSoldOut.Location = new System.Drawing.Point(6, 5);
            this.lblSoldOut.Name = "lblSoldOut";
            this.lblSoldOut.Size = new System.Drawing.Size(0, 21);
            this.lblSoldOut.TabIndex = 8;
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblItemPrice.ForeColor = System.Drawing.Color.Red;
            this.lblItemPrice.Location = new System.Drawing.Point(6, 227);
            this.lblItemPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(73, 20);
            this.lblItemPrice.TabIndex = 7;
            this.lblItemPrice.Text = "商品價格";
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.White;
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.Enabled = false;
            this.tbDescription.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbDescription.Location = new System.Drawing.Point(10, 164);
            this.tbDescription.MinimumSize = new System.Drawing.Size(139, 44);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(139, 60);
            this.tbDescription.TabIndex = 10;
            this.tbDescription.Text = "123";
            // 
            // CtrlDisplayItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.pbItemPhoto);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblSoldOut);
            this.Controls.Add(this.lblItemPrice);
            this.Name = "CtrlDisplayItem";
            this.Size = new System.Drawing.Size(156, 252);
            ((System.ComponentModel.ISupportInitialize)(this.pbItemPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbItemPhoto;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblSoldOut;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.TextBox tbDescription;
    }
}
