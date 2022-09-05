
namespace WindowsFormsApp2
{
    partial class 問題表
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
            this.txtqs = new System.Windows.Forms.TextBox();
            this.txtas = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.Location = new System.Drawing.Point(47, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "問題";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15F);
            this.label2.Location = new System.Drawing.Point(47, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "回答";
            // 
            // txtqs
            // 
            this.txtqs.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtqs.Location = new System.Drawing.Point(190, 35);
            this.txtqs.Multiline = true;
            this.txtqs.Name = "txtqs";
            this.txtqs.Size = new System.Drawing.Size(502, 56);
            this.txtqs.TabIndex = 2;
            // 
            // txtas
            // 
            this.txtas.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtas.Location = new System.Drawing.Point(190, 157);
            this.txtas.Multiline = true;
            this.txtas.Name = "txtas";
            this.txtas.Size = new System.Drawing.Size(502, 56);
            this.txtas.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 15F);
            this.button1.Location = new System.Drawing.Point(135, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 66);
            this.button1.TabIndex = 4;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.新增_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 15F);
            this.button2.Location = new System.Drawing.Point(347, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 66);
            this.button2.TabIndex = 5;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.修改刪除_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15F);
            this.label3.Location = new System.Drawing.Point(47, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "問題類型";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("新細明體", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(247, 267);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(402, 32);
            this.comboBox1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 15F);
            this.button3.Location = new System.Drawing.Point(543, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 66);
            this.button3.TabIndex = 8;
            this.button3.Text = "刪除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.刪除_Click);
            // 
            // 問題表
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtas);
            this.Controls.Add(this.txtqs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "問題表";
            this.Text = "問題表";
            this.Load += new System.EventHandler(this.問題表_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtqs;
        private System.Windows.Forms.TextBox txtas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
    }
}