﻿
namespace Project_期中專案
{
    partial class PdSearch
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.mem_Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_datime = new System.Windows.Forms.TextBox();
            this.txt_reAdd = new System.Windows.Forms.TextBox();
            this.txt_coupid = new System.Windows.Forms.TextBox();
            this.txt_finday = new System.Windows.Forms.TextBox();
            this.txt_statid = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_未結帳 = new System.Windows.Forms.Button();
            this.btn_已到貨 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(461, 463);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(81, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "您好";
            // 
            // mem_Name
            // 
            this.mem_Name.AutoSize = true;
            this.mem_Name.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mem_Name.ForeColor = System.Drawing.Color.Chocolate;
            this.mem_Name.Location = new System.Drawing.Point(156, 12);
            this.mem_Name.Name = "mem_Name";
            this.mem_Name.Size = new System.Drawing.Size(65, 40);
            this.mem_Name.TabIndex = 2;
            this.mem_Name.Text = "xxx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(81, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "您的訂單資訊如下";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(56, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "訂單編號";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(24, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "訂單成立時間";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Chocolate;
            this.label5.Location = new System.Drawing.Point(56, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "收件地址";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Chocolate;
            this.label7.Location = new System.Drawing.Point(24, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "訂單完成時間";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Chocolate;
            this.label8.Location = new System.Drawing.Point(40, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 26);
            this.label8.TabIndex = 9;
            this.label8.Text = "優惠券名稱";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.Chocolate;
            this.label9.Location = new System.Drawing.Point(57, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 26);
            this.label9.TabIndex = 10;
            this.label9.Text = "訂單情況";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_id.Location = new System.Drawing.Point(163, 131);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 29);
            this.txt_id.TabIndex = 11;
            // 
            // txt_datime
            // 
            this.txt_datime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_datime.Location = new System.Drawing.Point(163, 180);
            this.txt_datime.Multiline = true;
            this.txt_datime.Name = "txt_datime";
            this.txt_datime.Size = new System.Drawing.Size(170, 22);
            this.txt_datime.TabIndex = 12;
            // 
            // txt_reAdd
            // 
            this.txt_reAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_reAdd.Location = new System.Drawing.Point(163, 230);
            this.txt_reAdd.Multiline = true;
            this.txt_reAdd.Name = "txt_reAdd";
            this.txt_reAdd.Size = new System.Drawing.Size(170, 22);
            this.txt_reAdd.TabIndex = 13;
            // 
            // txt_coupid
            // 
            this.txt_coupid.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_coupid.Location = new System.Drawing.Point(163, 335);
            this.txt_coupid.Name = "txt_coupid";
            this.txt_coupid.Size = new System.Drawing.Size(100, 29);
            this.txt_coupid.TabIndex = 16;
            // 
            // txt_finday
            // 
            this.txt_finday.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_finday.Location = new System.Drawing.Point(163, 276);
            this.txt_finday.Multiline = true;
            this.txt_finday.Name = "txt_finday";
            this.txt_finday.Size = new System.Drawing.Size(170, 22);
            this.txt_finday.TabIndex = 15;
            // 
            // txt_statid
            // 
            this.txt_statid.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_statid.Location = new System.Drawing.Point(163, 386);
            this.txt_statid.Name = "txt_statid";
            this.txt_statid.Size = new System.Drawing.Size(100, 29);
            this.txt_statid.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ForeColor = System.Drawing.Color.Chocolate;
            this.button2.Location = new System.Drawing.Point(29, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 46);
            this.button2.TabIndex = 19;
            this.button2.Text = "完成訂單";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_未結帳
            // 
            this.btn_未結帳.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_未結帳.Location = new System.Drawing.Point(25, 12);
            this.btn_未結帳.Name = "btn_未結帳";
            this.btn_未結帳.Size = new System.Drawing.Size(123, 40);
            this.btn_未結帳.TabIndex = 20;
            this.btn_未結帳.Text = "已完成訂單";
            this.btn_未結帳.UseVisualStyleBackColor = true;
            this.btn_未結帳.Click += new System.EventHandler(this.btn_未結帳_Click);
            // 
            // btn_已到貨
            // 
            this.btn_已到貨.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_已到貨.Location = new System.Drawing.Point(194, 12);
            this.btn_已到貨.Name = "btn_已到貨";
            this.btn_已到貨.Size = new System.Drawing.Size(123, 40);
            this.btn_已到貨.TabIndex = 22;
            this.btn_已到貨.Text = "已到貨訂單";
            this.btn_已到貨.UseVisualStyleBackColor = true;
            this.btn_已到貨.Click += new System.EventHandler(this.btn_已到貨_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(363, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 40);
            this.button3.TabIndex = 24;
            this.button3.Text = "全部訂單";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btn_未結帳);
            this.panel1.Controls.Add(this.btn_已到貨);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(337, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 541);
            this.panel1.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.Color.Chocolate;
            this.button1.Location = new System.Drawing.Point(182, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 46);
            this.button1.TabIndex = 26;
            this.button1.Text = "離開";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_id);
            this.panel2.Controls.Add(this.txt_coupid);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txt_finday);
            this.panel2.Controls.Add(this.txt_statid);
            this.panel2.Controls.Add(this.txt_reAdd);
            this.panel2.Controls.Add(this.txt_datime);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.mem_Name);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 543);
            this.panel2.TabIndex = 27;
            // 
            // PdSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(837, 543);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.Chocolate;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PdSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PdSearch";
            this.Load += new System.EventHandler(this.PdSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mem_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_datime;
        private System.Windows.Forms.TextBox txt_reAdd;
        private System.Windows.Forms.TextBox txt_coupid;
        private System.Windows.Forms.TextBox txt_finday;
        private System.Windows.Forms.TextBox txt_statid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_未結帳;
        private System.Windows.Forms.Button btn_已到貨;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}