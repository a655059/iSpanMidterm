
namespace Project_期中專案
{
    partial class Form1
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cancle = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_backMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_phon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassworld = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_nickName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pic_box = new System.Windows.Forms.PictureBox();
            this.btn_pic = new System.Windows.Forms.Button();
            this.cmbo_city = new System.Windows.Forms.ComboBox();
            this.ckbox_yes = new System.Windows.Forms.CheckBox();
            this.DTP_BIR = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmb_are = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancle
            // 
            this.btn_cancle.Location = new System.Drawing.Point(129, 528);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(75, 23);
            this.btn_cancle.TabIndex = 36;
            this.btn_cancle.Text = "取消";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(23, 528);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 34;
            this.btn_save.Text = "儲存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_backMail
            // 
            this.txt_backMail.Location = new System.Drawing.Point(104, 323);
            this.txt_backMail.Name = "txt_backMail";
            this.txt_backMail.Size = new System.Drawing.Size(100, 22);
            this.txt_backMail.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 32;
            this.label7.Text = "備用信箱";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(104, 280);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(100, 22);
            this.txt_mail.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "電子信箱";
            // 
            // txt_phon
            // 
            this.txt_phon.Location = new System.Drawing.Point(104, 235);
            this.txt_phon.Name = "txt_phon";
            this.txt_phon.Size = new System.Drawing.Size(100, 22);
            this.txt_phon.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "電話";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "所在縣市";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "國籍:";
            // 
            // txtPassworld
            // 
            this.txtPassworld.Location = new System.Drawing.Point(104, 68);
            this.txtPassworld.Name = "txtPassworld";
            this.txtPassworld.Size = new System.Drawing.Size(100, 22);
            this.txtPassworld.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "密碼:";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(104, 31);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(100, 22);
            this.txtAccount.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "使用者帳號:";
            // 
            // txt_bio
            // 
            this.txt_bio.Location = new System.Drawing.Point(352, 279);
            this.txt_bio.Multiline = true;
            this.txt_bio.Name = "txt_bio";
            this.txt_bio.Size = new System.Drawing.Size(246, 190);
            this.txt_bio.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(278, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 12);
            this.label10.TabIndex = 47;
            this.label10.Text = "簡介:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 491);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 45;
            this.label11.Text = "生日";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(104, 446);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 22);
            this.txt_name.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 449);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 43;
            this.label12.Text = "姓名";
            // 
            // txt_nickName
            // 
            this.txt_nickName.Location = new System.Drawing.Point(104, 409);
            this.txt_nickName.Name = "txt_nickName";
            this.txt_nickName.Size = new System.Drawing.Size(100, 22);
            this.txt_nickName.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 412);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 41;
            this.label13.Text = "暱稱";
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(104, 372);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(100, 22);
            this.txtadd.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 375);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 39;
            this.label14.Text = "地址";
            // 
            // pic_box
            // 
            this.pic_box.Location = new System.Drawing.Point(352, 48);
            this.pic_box.Name = "pic_box";
            this.pic_box.Size = new System.Drawing.Size(246, 179);
            this.pic_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_box.TabIndex = 79;
            this.pic_box.TabStop = false;
            // 
            // btn_pic
            // 
            this.btn_pic.Location = new System.Drawing.Point(255, 48);
            this.btn_pic.Name = "btn_pic";
            this.btn_pic.Size = new System.Drawing.Size(75, 23);
            this.btn_pic.TabIndex = 80;
            this.btn_pic.Text = "上傳照片";
            this.btn_pic.UseVisualStyleBackColor = true;
            this.btn_pic.Click += new System.EventHandler(this.btn_pic_Click);
            // 
            // cmbo_city
            // 
            this.cmbo_city.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cmbo_city.FormattingEnabled = true;
            this.cmbo_city.Location = new System.Drawing.Point(104, 147);
            this.cmbo_city.Name = "cmbo_city";
            this.cmbo_city.Size = new System.Drawing.Size(121, 20);
            this.cmbo_city.TabIndex = 81;
            this.cmbo_city.UseWaitCursor = true;
            this.cmbo_city.SelectedIndexChanged += new System.EventHandler(this.cmbo_city_SelectedIndexChanged);
            // 
            // ckbox_yes
            // 
            this.ckbox_yes.AutoSize = true;
            this.ckbox_yes.Location = new System.Drawing.Point(104, 108);
            this.ckbox_yes.Name = "ckbox_yes";
            this.ckbox_yes.Size = new System.Drawing.Size(60, 16);
            this.ckbox_yes.TabIndex = 82;
            this.ckbox_yes.Text = "非本國";
            this.ckbox_yes.UseVisualStyleBackColor = true;
            // 
            // DTP_BIR
            // 
            this.DTP_BIR.Location = new System.Drawing.Point(104, 488);
            this.DTP_BIR.Name = "DTP_BIR";
            this.DTP_BIR.Size = new System.Drawing.Size(200, 22);
            this.DTP_BIR.TabIndex = 83;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmb_are
            // 
            this.cmb_are.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cmb_are.FormattingEnabled = true;
            this.cmb_are.Location = new System.Drawing.Point(104, 192);
            this.cmb_are.Name = "cmb_are";
            this.cmb_are.Size = new System.Drawing.Size(121, 20);
            this.cmb_are.TabIndex = 85;
            this.cmb_are.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 84;
            this.label8.Text = "所在地區";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 574);
            this.Controls.Add(this.cmb_are);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DTP_BIR);
            this.Controls.Add(this.ckbox_yes);
            this.Controls.Add(this.cmbo_city);
            this.Controls.Add(this.btn_pic);
            this.Controls.Add(this.pic_box);
            this.Controls.Add(this.txt_bio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_nickName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_backMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_phon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassworld);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_backMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_phon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassworld;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_nickName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pic_box;
        private System.Windows.Forms.Button btn_pic;
        private System.Windows.Forms.ComboBox cmbo_city;
        private System.Windows.Forms.CheckBox ckbox_yes;
        private System.Windows.Forms.DateTimePicker DTP_BIR;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmb_are;
        private System.Windows.Forms.Label label8;
    }
}

