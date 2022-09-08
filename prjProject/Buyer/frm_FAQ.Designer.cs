
namespace prjProject.Buyer
{
    partial class frm_FAQ
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
            this.lst_Type = new System.Windows.Forms.ListBox();
            this.txt_FAQ = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lst_Type);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txt_FAQ);
            this.splitContainer1.Size = new System.Drawing.Size(923, 552);
            this.splitContainer1.SplitterDistance = 244;
            this.splitContainer1.TabIndex = 0;
            // 
            // lst_Type
            // 
            this.lst_Type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_Type.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lst_Type.FormattingEnabled = true;
            this.lst_Type.ItemHeight = 27;
            this.lst_Type.Location = new System.Drawing.Point(0, 0);
            this.lst_Type.Name = "lst_Type";
            this.lst_Type.Size = new System.Drawing.Size(244, 552);
            this.lst_Type.TabIndex = 0;
            this.lst_Type.SelectedIndexChanged += new System.EventHandler(this.lst_Type_SelectedIndexChanged);
            // 
            // txt_FAQ
            // 
            this.txt_FAQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_FAQ.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_FAQ.Location = new System.Drawing.Point(0, 0);
            this.txt_FAQ.Name = "txt_FAQ";
            this.txt_FAQ.ReadOnly = true;
            this.txt_FAQ.Size = new System.Drawing.Size(675, 552);
            this.txt_FAQ.TabIndex = 0;
            this.txt_FAQ.Text = "";
            // 
            // frm_FAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 552);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_FAQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FAQ";
            this.Load += new System.EventHandler(this.FAQ_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lst_Type;
        private System.Windows.Forms.RichTextBox txt_FAQ;
    }
}