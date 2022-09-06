
namespace prjProject.Member
{
    partial class memberCoupon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_couName = new System.Windows.Forms.TextBox();
            this.txt_couStar = new System.Windows.Forms.TextBox();
            this.txt_couEnd = new System.Windows.Forms.TextBox();
            this.txt_couDiscount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(51, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "優惠眷名稱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(51, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "優惠眷開始日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(51, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "優惠眷結束日期";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(51, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "優惠內容";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(277, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 44);
            this.label5.TabIndex = 4;
            this.label5.Text = "我的優惠眷";
            // 
            // txt_couName
            // 
            this.txt_couName.Location = new System.Drawing.Point(253, 118);
            this.txt_couName.Name = "txt_couName";
            this.txt_couName.Size = new System.Drawing.Size(100, 22);
            this.txt_couName.TabIndex = 5;
            // 
            // txt_couStar
            // 
            this.txt_couStar.Location = new System.Drawing.Point(253, 177);
            this.txt_couStar.Multiline = true;
            this.txt_couStar.Name = "txt_couStar";
            this.txt_couStar.Size = new System.Drawing.Size(203, 22);
            this.txt_couStar.TabIndex = 6;
            // 
            // txt_couEnd
            // 
            this.txt_couEnd.Location = new System.Drawing.Point(253, 246);
            this.txt_couEnd.Multiline = true;
            this.txt_couEnd.Name = "txt_couEnd";
            this.txt_couEnd.Size = new System.Drawing.Size(203, 22);
            this.txt_couEnd.TabIndex = 7;
            // 
            // txt_couDiscount
            // 
            this.txt_couDiscount.Location = new System.Drawing.Point(253, 313);
            this.txt_couDiscount.Name = "txt_couDiscount";
            this.txt_couDiscount.Size = new System.Drawing.Size(100, 22);
            this.txt_couDiscount.TabIndex = 8;
            // 
            // memberCoupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_couDiscount);
            this.Controls.Add(this.txt_couEnd);
            this.Controls.Add(this.txt_couStar);
            this.Controls.Add(this.txt_couName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "memberCoupon";
            this.Text = "memberCoupon";
            this.Load += new System.EventHandler(this.memberCoupon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_couName;
        private System.Windows.Forms.TextBox txt_couStar;
        private System.Windows.Forms.TextBox txt_couEnd;
        private System.Windows.Forms.TextBox txt_couDiscount;
    }
}