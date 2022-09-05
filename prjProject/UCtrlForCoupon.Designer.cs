
namespace prjProject
{
    partial class UCtrlForCoupon
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
            this.btnUseOrNot = new System.Windows.Forms.Button();
            this.lblCouponName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUseOrNot
            // 
            this.btnUseOrNot.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUseOrNot.Location = new System.Drawing.Point(210, 16);
            this.btnUseOrNot.Name = "btnUseOrNot";
            this.btnUseOrNot.Size = new System.Drawing.Size(186, 48);
            this.btnUseOrNot.TabIndex = 3;
            this.btnUseOrNot.Text = "這次不用";
            this.btnUseOrNot.UseVisualStyleBackColor = true;
            // 
            // lblCouponName
            // 
            this.lblCouponName.AutoSize = true;
            this.lblCouponName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCouponName.Location = new System.Drawing.Point(5, 24);
            this.lblCouponName.Name = "lblCouponName";
            this.lblCouponName.Size = new System.Drawing.Size(111, 32);
            this.lblCouponName.TabIndex = 2;
            this.lblCouponName.Text = "九折券";
            // 
            // UCtrlForCoupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUseOrNot);
            this.Controls.Add(this.lblCouponName);
            this.Name = "UCtrlForCoupon";
            this.Size = new System.Drawing.Size(399, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUseOrNot;
        private System.Windows.Forms.Label lblCouponName;
    }
}
