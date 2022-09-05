
namespace WindowsFormsApp2
{
    partial class 會員查詢
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
            this.txtselect = new System.Windows.Forms.TextBox();
            this.btnselect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(326, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "輸入手機";
            // 
            // txtselect
            // 
            this.txtselect.Font = new System.Drawing.Font("新細明體", 30F);
            this.txtselect.Location = new System.Drawing.Point(81, 159);
            this.txtselect.Multiline = true;
            this.txtselect.Name = "txtselect";
            this.txtselect.Size = new System.Drawing.Size(653, 107);
            this.txtselect.TabIndex = 1;
            // 
            // btnselect
            // 
            this.btnselect.Font = new System.Drawing.Font("新細明體", 20F);
            this.btnselect.Location = new System.Drawing.Point(292, 321);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(234, 74);
            this.btnselect.TabIndex = 2;
            this.btnselect.Text = "開始查詢";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // 會員查詢
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.txtselect);
            this.Controls.Add(this.label1);
            this.Name = "會員查詢";
            this.Text = "會員查詢";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtselect;
        private System.Windows.Forms.Button btnselect;
    }
}