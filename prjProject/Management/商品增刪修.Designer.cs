
namespace WindowsFormsApp2
{
    partial class 商品增刪修
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtpdname = new System.Windows.Forms.TextBox();
            this.cbBig = new System.Windows.Forms.ComboBox();
            this.cbSmall = new System.Windows.Forms.ComboBox();
            this.txtpdup = new System.Windows.Forms.TextBox();
            this.cbContry = new System.Windows.Forms.ComboBox();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.cbship = new System.Windows.Forms.ComboBox();
            this.txtpdfee = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtstyle = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.picPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtpdquty = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.tPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button7 = new System.Windows.Forms.Button();
            this.picmore = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(72, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "名稱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(676, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "價格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(676, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "數量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.Location = new System.Drawing.Point(72, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "大類";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F);
            this.label5.Location = new System.Drawing.Point(72, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "小類";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F);
            this.label6.Location = new System.Drawing.Point(72, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "廣告費";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F);
            this.label7.Location = new System.Drawing.Point(761, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "運送方式";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F);
            this.label8.Location = new System.Drawing.Point(72, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "地區";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F);
            this.label9.Location = new System.Drawing.Point(1003, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "樣式相片";
            // 
            // txtpdname
            // 
            this.txtpdname.Font = new System.Drawing.Font("新細明體", 15F);
            this.txtpdname.Location = new System.Drawing.Point(212, 28);
            this.txtpdname.Multiline = true;
            this.txtpdname.Name = "txtpdname";
            this.txtpdname.Size = new System.Drawing.Size(149, 41);
            this.txtpdname.TabIndex = 9;
            // 
            // cbBig
            // 
            this.cbBig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBig.Font = new System.Drawing.Font("新細明體", 15F);
            this.cbBig.FormattingEnabled = true;
            this.cbBig.Location = new System.Drawing.Point(212, 105);
            this.cbBig.Name = "cbBig";
            this.cbBig.Size = new System.Drawing.Size(149, 38);
            this.cbBig.TabIndex = 10;
            this.cbBig.SelectedIndexChanged += new System.EventHandler(this.cbBig_SelectedIndexChanged);
            // 
            // cbSmall
            // 
            this.cbSmall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSmall.Font = new System.Drawing.Font("新細明體", 15F);
            this.cbSmall.FormattingEnabled = true;
            this.cbSmall.Location = new System.Drawing.Point(212, 182);
            this.cbSmall.Name = "cbSmall";
            this.cbSmall.Size = new System.Drawing.Size(149, 38);
            this.cbSmall.TabIndex = 11;
            // 
            // txtpdup
            // 
            this.txtpdup.Location = new System.Drawing.Point(740, 228);
            this.txtpdup.Multiline = true;
            this.txtpdup.Name = "txtpdup";
            this.txtpdup.Size = new System.Drawing.Size(149, 41);
            this.txtpdup.TabIndex = 12;
            // 
            // cbContry
            // 
            this.cbContry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContry.Font = new System.Drawing.Font("新細明體", 15F);
            this.cbContry.FormattingEnabled = true;
            this.cbContry.Location = new System.Drawing.Point(159, 254);
            this.cbContry.Name = "cbContry";
            this.cbContry.Size = new System.Drawing.Size(149, 38);
            this.cbContry.TabIndex = 14;
            this.cbContry.SelectedIndexChanged += new System.EventHandler(this.cbContry_SelectedIndexChanged);
            // 
            // cbRegion
            // 
            this.cbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegion.Font = new System.Drawing.Font("新細明體", 15F);
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(314, 254);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(149, 38);
            this.cbRegion.TabIndex = 15;
            // 
            // cbship
            // 
            this.cbship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbship.FormattingEnabled = true;
            this.cbship.Location = new System.Drawing.Point(740, 74);
            this.cbship.Name = "cbship";
            this.cbship.Size = new System.Drawing.Size(149, 26);
            this.cbship.TabIndex = 16;
            // 
            // txtpdfee
            // 
            this.txtpdfee.Font = new System.Drawing.Font("新細明體", 15F);
            this.txtpdfee.Location = new System.Drawing.Point(212, 324);
            this.txtpdfee.Multiline = true;
            this.txtpdfee.Name = "txtpdfee";
            this.txtpdfee.Size = new System.Drawing.Size(149, 41);
            this.txtpdfee.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(956, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 91);
            this.button1.TabIndex = 19;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.新增_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(765, 331);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 31);
            this.button4.TabIndex = 22;
            this.button4.Text = "瀏覽";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.瀏覽照片_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 12F);
            this.label10.Location = new System.Drawing.Point(76, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 24);
            this.label10.TabIndex = 23;
            this.label10.Text = "描述";
            // 
            // txtdesc
            // 
            this.txtdesc.Font = new System.Drawing.Font("新細明體", 15F);
            this.txtdesc.Location = new System.Drawing.Point(212, 404);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(149, 41);
            this.txtdesc.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 12F);
            this.label11.Location = new System.Drawing.Point(676, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 24);
            this.label11.TabIndex = 25;
            this.label11.Text = "樣式";
            // 
            // txtstyle
            // 
            this.txtstyle.Location = new System.Drawing.Point(740, 169);
            this.txtstyle.Multiline = true;
            this.txtstyle.Name = "txtstyle";
            this.txtstyle.Size = new System.Drawing.Size(149, 41);
            this.txtstyle.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(956, 561);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(333, 91);
            this.button2.TabIndex = 27;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.修改_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(956, 662);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 91);
            this.button3.TabIndex = 28;
            this.button3.Text = "刪除商品";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.刪除product_Click);
            // 
            // picPanel3
            // 
            this.picPanel3.AutoScroll = true;
            this.picPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPanel3.Location = new System.Drawing.Point(221, 496);
            this.picPanel3.Name = "picPanel3";
            this.picPanel3.Size = new System.Drawing.Size(380, 233);
            this.picPanel3.TabIndex = 29;
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Location = new System.Drawing.Point(926, 32);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(363, 91);
            this.Panel2.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 12F);
            this.label12.Location = new System.Drawing.Point(676, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 24);
            this.label12.TabIndex = 1;
            this.label12.Text = "價格";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新細明體", 12F);
            this.label13.Location = new System.Drawing.Point(676, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 24);
            this.label13.TabIndex = 2;
            this.label13.Text = "數量";
            // 
            // txtpdquty
            // 
            this.txtpdquty.Location = new System.Drawing.Point(740, 287);
            this.txtpdquty.Multiline = true;
            this.txtpdquty.Name = "txtpdquty";
            this.txtpdquty.Size = new System.Drawing.Size(149, 41);
            this.txtpdquty.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("新細明體", 12F);
            this.label14.Location = new System.Drawing.Point(676, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 24);
            this.label14.TabIndex = 25;
            this.label14.Text = "樣式";
            // 
            // Panel1
            // 
            this.Panel1.AutoScroll = true;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Location = new System.Drawing.Point(926, 32);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(964, 126);
            this.Panel1.TabIndex = 30;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(765, 371);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 41);
            this.button6.TabIndex = 31;
            this.button6.Text = "樣式確定";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.新增樣式_Click);
            // 
            // tPanel2
            // 
            this.tPanel2.AutoScroll = true;
            this.tPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tPanel2.Location = new System.Drawing.Point(1159, 192);
            this.tPanel2.Name = "tPanel2";
            this.tPanel2.Size = new System.Drawing.Size(731, 164);
            this.tPanel2.TabIndex = 32;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(740, 106);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(151, 42);
            this.button7.TabIndex = 33;
            this.button7.Text = "增加運送方式";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.增加送方式_Click);
            // 
            // picmore
            // 
            this.picmore.Location = new System.Drawing.Point(76, 678);
            this.picmore.Name = "picmore";
            this.picmore.Size = new System.Drawing.Size(94, 42);
            this.picmore.TabIndex = 34;
            this.picmore.Text = "相片確定";
            this.picmore.UseVisualStyleBackColor = true;
            this.picmore.Click += new System.EventHandler(this.picmore_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(80, 489);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(91, 33);
            this.button8.TabIndex = 36;
            this.button8.Text = "瀏覽";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.照片庫瀏覽_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(44, 528);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 144);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(973, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1127, 662);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 91);
            this.button5.TabIndex = 37;
            this.button5.Text = "刪除明細";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.刪除productdetail_Click);
            // 
            // 商品增刪修
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 815);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picmore);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.tPanel2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.picPanel3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtstyle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtpdfee);
            this.Controls.Add(this.cbship);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.txtpdquty);
            this.Controls.Add(this.cbContry);
            this.Controls.Add(this.txtpdup);
            this.Controls.Add(this.cbSmall);
            this.Controls.Add(this.cbBig);
            this.Controls.Add(this.txtpdname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "商品增刪修";
            this.Text = "增刪修";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.商品增刪修_Load);
            this.Leave += new System.EventHandler(this.商品增刪修_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtpdname;
        private System.Windows.Forms.ComboBox cbBig;
        private System.Windows.Forms.ComboBox cbSmall;
        private System.Windows.Forms.TextBox txtpdup;
        private System.Windows.Forms.ComboBox cbContry;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.ComboBox cbship;
        private System.Windows.Forms.TextBox txtpdfee;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtstyle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel picPanel3;
        private System.Windows.Forms.FlowLayoutPanel Panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtpdquty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.FlowLayoutPanel Panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.FlowLayoutPanel tPanel2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button picmore;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
    }
}