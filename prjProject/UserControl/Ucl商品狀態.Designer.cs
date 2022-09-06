
namespace seller
{
    partial class Ucl商品狀態
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
            this.lbl_商品運送狀態 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_商品運送狀態
            // 
            this.lbl_商品運送狀態.AutoSize = true;
            this.lbl_商品運送狀態.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_商品運送狀態.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_商品運送狀態.Location = new System.Drawing.Point(3, 12);
            this.lbl_商品運送狀態.Name = "lbl_商品運送狀態";
            this.lbl_商品運送狀態.Size = new System.Drawing.Size(76, 21);
            this.lbl_商品運送狀態.TabIndex = 1;
            this.lbl_商品運送狀態.Text = "label1";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(100, 14);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(69, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "刪除";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // Ucl商品狀態
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lbl_商品運送狀態);
            this.Name = "Ucl商品狀態";
            this.Size = new System.Drawing.Size(185, 53);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_商品運送狀態;
        private System.Windows.Forms.Button btn_delete;
    }
}
