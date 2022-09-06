
namespace prjProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.spContainerMainPage = new System.Windows.Forms.SplitContainer();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.linkLabelMemberCenter = new System.Windows.Forms.LinkLabel();
            this.linkLabelHouTai = new System.Windows.Forms.LinkLabel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.linkLabelRegister = new System.Windows.Forms.LinkLabel();
            this.pbCart = new System.Windows.Forms.PictureBox();
            this.lblProductNumInCart = new System.Windows.Forms.Label();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.lblName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.lblToSellerForm = new System.Windows.Forms.LinkLabel();
            this.spContainerBotton = new System.Windows.Forms.SplitContainer();
            this.flowpanelType = new System.Windows.Forms.FlowLayoutPanel();
            this.spContainerItem = new System.Windows.Forms.SplitContainer();
            this.spContainerGuessYouLike = new System.Windows.Forms.SplitContainer();
            this.lblGuessYouLike = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowpanelAD = new System.Windows.Forms.FlowLayoutPanel();
            this.flowpanelItem = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flowpanelTypeItem = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.spContainerMainPage)).BeginInit();
            this.spContainerMainPage.Panel1.SuspendLayout();
            this.spContainerMainPage.Panel2.SuspendLayout();
            this.spContainerMainPage.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spContainerBotton)).BeginInit();
            this.spContainerBotton.Panel1.SuspendLayout();
            this.spContainerBotton.Panel2.SuspendLayout();
            this.spContainerBotton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainerItem)).BeginInit();
            this.spContainerItem.Panel1.SuspendLayout();
            this.spContainerItem.Panel2.SuspendLayout();
            this.spContainerItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainerGuessYouLike)).BeginInit();
            this.spContainerGuessYouLike.Panel1.SuspendLayout();
            this.spContainerGuessYouLike.Panel2.SuspendLayout();
            this.spContainerGuessYouLike.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // spContainerMainPage
            // 
            this.spContainerMainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainerMainPage.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spContainerMainPage.Location = new System.Drawing.Point(0, 0);
            this.spContainerMainPage.Margin = new System.Windows.Forms.Padding(0);
            this.spContainerMainPage.Name = "spContainerMainPage";
            this.spContainerMainPage.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spContainerMainPage.Panel1
            // 
            this.spContainerMainPage.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.spContainerMainPage.Panel1.Controls.Add(this.panelTopBar);
            this.spContainerMainPage.Panel1.Controls.Add(this.panel3);
            this.spContainerMainPage.Panel1.Controls.Add(this.panel1);
            this.spContainerMainPage.Panel1.Controls.Add(this.linkLabel2);
            this.spContainerMainPage.Panel1.Controls.Add(this.lblToSellerForm);
            // 
            // spContainerMainPage.Panel2
            // 
            this.spContainerMainPage.Panel2.Controls.Add(this.spContainerBotton);
            this.spContainerMainPage.Size = new System.Drawing.Size(1680, 900);
            this.spContainerMainPage.SplitterDistance = 128;
            this.spContainerMainPage.TabIndex = 1;
            // 
            // panelTopBar
            // 
            this.panelTopBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopBar.Controls.Add(this.linkLabelMemberCenter);
            this.panelTopBar.Controls.Add(this.linkLabelHouTai);
            this.panelTopBar.Controls.Add(this.panelSearch);
            this.panelTopBar.Controls.Add(this.linkLabelRegister);
            this.panelTopBar.Controls.Add(this.pbCart);
            this.panelTopBar.Controls.Add(this.lblProductNumInCart);
            this.panelTopBar.Controls.Add(this.linkLabelLogin);
            this.panelTopBar.Controls.Add(this.lblName);
            this.panelTopBar.Location = new System.Drawing.Point(1075, 24);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(605, 104);
            this.panelTopBar.TabIndex = 28;
            // 
            // linkLabelMemberCenter
            // 
            this.linkLabelMemberCenter.AutoSize = true;
            this.linkLabelMemberCenter.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabelMemberCenter.ForeColor = System.Drawing.Color.Black;
            this.linkLabelMemberCenter.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelMemberCenter.LinkColor = System.Drawing.Color.Black;
            this.linkLabelMemberCenter.Location = new System.Drawing.Point(230, 4);
            this.linkLabelMemberCenter.Name = "linkLabelMemberCenter";
            this.linkLabelMemberCenter.Size = new System.Drawing.Size(96, 27);
            this.linkLabelMemberCenter.TabIndex = 24;
            this.linkLabelMemberCenter.TabStop = true;
            this.linkLabelMemberCenter.Text = "會員中心";
            this.linkLabelMemberCenter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMemberCenter_LinkClicked);
            // 
            // linkLabelHouTai
            // 
            this.linkLabelHouTai.AutoSize = true;
            this.linkLabelHouTai.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabelHouTai.ForeColor = System.Drawing.Color.Black;
            this.linkLabelHouTai.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelHouTai.LinkColor = System.Drawing.Color.Black;
            this.linkLabelHouTai.Location = new System.Drawing.Point(25, 7);
            this.linkLabelHouTai.Name = "linkLabelHouTai";
            this.linkLabelHouTai.Size = new System.Drawing.Size(54, 27);
            this.linkLabelHouTai.TabIndex = 23;
            this.linkLabelHouTai.TabStop = true;
            this.linkLabelHouTai.Text = "後台";
            this.linkLabelHouTai.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHouTai_LinkClicked);
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.tbSearch);
            this.panelSearch.Location = new System.Drawing.Point(30, 62);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(413, 41);
            this.panelSearch.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(376, -1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(33, 33);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbSearch.ForeColor = System.Drawing.Color.LightGray;
            this.tbSearch.Location = new System.Drawing.Point(0, -1);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(398, 35);
            this.tbSearch.TabIndex = 16;
            this.tbSearch.Text = "從全部商品中搜尋...";
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // linkLabelRegister
            // 
            this.linkLabelRegister.AutoSize = true;
            this.linkLabelRegister.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabelRegister.ForeColor = System.Drawing.Color.Black;
            this.linkLabelRegister.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelRegister.LinkColor = System.Drawing.Color.Black;
            this.linkLabelRegister.Location = new System.Drawing.Point(332, 4);
            this.linkLabelRegister.Name = "linkLabelRegister";
            this.linkLabelRegister.Size = new System.Drawing.Size(54, 27);
            this.linkLabelRegister.TabIndex = 12;
            this.linkLabelRegister.TabStop = true;
            this.linkLabelRegister.Text = "註冊";
            // 
            // pbCart
            // 
            this.pbCart.Image = ((System.Drawing.Image)(resources.GetObject("pbCart.Image")));
            this.pbCart.Location = new System.Drawing.Point(537, 62);
            this.pbCart.Name = "pbCart";
            this.pbCart.Size = new System.Drawing.Size(38, 37);
            this.pbCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCart.TabIndex = 18;
            this.pbCart.TabStop = false;
            this.pbCart.Click += new System.EventHandler(this.pbCart_Click);
            // 
            // lblProductNumInCart
            // 
            this.lblProductNumInCart.AutoSize = true;
            this.lblProductNumInCart.Location = new System.Drawing.Point(574, 50);
            this.lblProductNumInCart.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblProductNumInCart.Name = "lblProductNumInCart";
            this.lblProductNumInCart.Size = new System.Drawing.Size(11, 12);
            this.lblProductNumInCart.TabIndex = 20;
            this.lblProductNumInCart.Text = "0";
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabelLogin.ForeColor = System.Drawing.Color.Black;
            this.linkLabelLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelLogin.LinkColor = System.Drawing.Color.Black;
            this.linkLabelLogin.Location = new System.Drawing.Point(408, 4);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(54, 27);
            this.linkLabelLogin.TabIndex = 13;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "登入";
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogin_LinkClicked);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(458, 4);
            this.lblName.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 27);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "歡迎";
            this.lblName.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1680, 24);
            this.panel3.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Location = new System.Drawing.Point(1569, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(111, 21);
            this.panel4.TabIndex = 28;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::prjProject.Properties.Resources._8664917_window_minimize_icon;
            this.pictureBox5.Location = new System.Drawing.Point(3, -2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 20);
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.btnWindowMinimized_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::prjProject.Properties.Resources.close;
            this.pictureBox3.Location = new System.Drawing.Point(85, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 21);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::prjProject.Properties.Resources._8675159_ic_fluent_maximize_regular_icon;
            this.pictureBox4.Location = new System.Drawing.Point(43, -2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 20);
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.btnWindowMaximized_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 94);
            this.panel1.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(7, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 35);
            this.label4.TabIndex = 14;
            this.label4.Text = "蝦到爆";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(8, -3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(91, 77);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linkLabel2.ForeColor = System.Drawing.Color.Black;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(271, 23);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(96, 27);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "追蹤我們";
            // 
            // lblToSellerForm
            // 
            this.lblToSellerForm.AutoSize = true;
            this.lblToSellerForm.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblToSellerForm.ForeColor = System.Drawing.Color.Black;
            this.lblToSellerForm.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblToSellerForm.LinkColor = System.Drawing.Color.Black;
            this.lblToSellerForm.Location = new System.Drawing.Point(169, 23);
            this.lblToSellerForm.Name = "lblToSellerForm";
            this.lblToSellerForm.Size = new System.Drawing.Size(96, 27);
            this.lblToSellerForm.TabIndex = 10;
            this.lblToSellerForm.TabStop = true;
            this.lblToSellerForm.Text = "賣家中心";
            this.lblToSellerForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblToSellerForm_LinkClicked);
            // 
            // spContainerBotton
            // 
            this.spContainerBotton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainerBotton.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spContainerBotton.IsSplitterFixed = true;
            this.spContainerBotton.Location = new System.Drawing.Point(0, 0);
            this.spContainerBotton.Name = "spContainerBotton";
            // 
            // spContainerBotton.Panel1
            // 
            this.spContainerBotton.Panel1.Controls.Add(this.flowpanelType);
            // 
            // spContainerBotton.Panel2
            // 
            this.spContainerBotton.Panel2.BackColor = System.Drawing.Color.MistyRose;
            this.spContainerBotton.Panel2.Controls.Add(this.spContainerItem);
            this.spContainerBotton.Panel2.Controls.Add(this.panel5);
            this.spContainerBotton.Size = new System.Drawing.Size(1680, 768);
            this.spContainerBotton.SplitterDistance = 168;
            this.spContainerBotton.TabIndex = 0;
            // 
            // flowpanelType
            // 
            this.flowpanelType.AutoScroll = true;
            this.flowpanelType.BackColor = System.Drawing.Color.Black;
            this.flowpanelType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpanelType.Location = new System.Drawing.Point(0, 0);
            this.flowpanelType.Name = "flowpanelType";
            this.flowpanelType.Size = new System.Drawing.Size(168, 768);
            this.flowpanelType.TabIndex = 0;
            // 
            // spContainerItem
            // 
            this.spContainerItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spContainerItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainerItem.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spContainerItem.IsSplitterFixed = true;
            this.spContainerItem.Location = new System.Drawing.Point(0, 0);
            this.spContainerItem.Name = "spContainerItem";
            this.spContainerItem.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spContainerItem.Panel1
            // 
            this.spContainerItem.Panel1.Controls.Add(this.spContainerGuessYouLike);
            // 
            // spContainerItem.Panel2
            // 
            this.spContainerItem.Panel2.Controls.Add(this.flowpanelItem);
            this.spContainerItem.Size = new System.Drawing.Size(1508, 768);
            this.spContainerItem.SplitterDistance = 303;
            this.spContainerItem.TabIndex = 0;
            this.spContainerItem.Visible = false;
            // 
            // spContainerGuessYouLike
            // 
            this.spContainerGuessYouLike.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainerGuessYouLike.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spContainerGuessYouLike.IsSplitterFixed = true;
            this.spContainerGuessYouLike.Location = new System.Drawing.Point(0, 0);
            this.spContainerGuessYouLike.Name = "spContainerGuessYouLike";
            this.spContainerGuessYouLike.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spContainerGuessYouLike.Panel1
            // 
            this.spContainerGuessYouLike.Panel1.Controls.Add(this.lblGuessYouLike);
            // 
            // spContainerGuessYouLike.Panel2
            // 
            this.spContainerGuessYouLike.Panel2.Controls.Add(this.panel2);
            this.spContainerGuessYouLike.Size = new System.Drawing.Size(1506, 301);
            this.spContainerGuessYouLike.SplitterDistance = 39;
            this.spContainerGuessYouLike.TabIndex = 0;
            // 
            // lblGuessYouLike
            // 
            this.lblGuessYouLike.AutoSize = true;
            this.lblGuessYouLike.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGuessYouLike.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGuessYouLike.Location = new System.Drawing.Point(0, 0);
            this.lblGuessYouLike.Name = "lblGuessYouLike";
            this.lblGuessYouLike.Size = new System.Drawing.Size(154, 37);
            this.lblGuessYouLike.TabIndex = 0;
            this.lblGuessYouLike.Text = "猜你喜歡...";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.Controls.Add(this.flowpanelAD);
            this.panel2.Location = new System.Drawing.Point(351, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 252);
            this.panel2.TabIndex = 0;
            // 
            // flowpanelAD
            // 
            this.flowpanelAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpanelAD.Location = new System.Drawing.Point(0, 0);
            this.flowpanelAD.Name = "flowpanelAD";
            this.flowpanelAD.Size = new System.Drawing.Size(830, 252);
            this.flowpanelAD.TabIndex = 0;
            // 
            // flowpanelItem
            // 
            this.flowpanelItem.AutoScroll = true;
            this.flowpanelItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpanelItem.Location = new System.Drawing.Point(0, 0);
            this.flowpanelItem.Name = "flowpanelItem";
            this.flowpanelItem.Size = new System.Drawing.Size(1506, 459);
            this.flowpanelItem.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.flowpanelTypeItem);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1413, 766);
            this.panel5.TabIndex = 1;
            // 
            // flowpanelTypeItem
            // 
            this.flowpanelTypeItem.AutoScroll = true;
            this.flowpanelTypeItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpanelTypeItem.Location = new System.Drawing.Point(0, 0);
            this.flowpanelTypeItem.Name = "flowpanelTypeItem";
            this.flowpanelTypeItem.Size = new System.Drawing.Size(1413, 766);
            this.flowpanelTypeItem.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1680, 900);
            this.Controls.Add(this.spContainerMainPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.spContainerMainPage.Panel1.ResumeLayout(false);
            this.spContainerMainPage.Panel1.PerformLayout();
            this.spContainerMainPage.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainerMainPage)).EndInit();
            this.spContainerMainPage.ResumeLayout(false);
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.spContainerBotton.Panel1.ResumeLayout(false);
            this.spContainerBotton.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainerBotton)).EndInit();
            this.spContainerBotton.ResumeLayout(false);
            this.spContainerItem.Panel1.ResumeLayout(false);
            this.spContainerItem.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainerItem)).EndInit();
            this.spContainerItem.ResumeLayout(false);
            this.spContainerGuessYouLike.Panel1.ResumeLayout(false);
            this.spContainerGuessYouLike.Panel1.PerformLayout();
            this.spContainerGuessYouLike.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainerGuessYouLike)).EndInit();
            this.spContainerGuessYouLike.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spContainerMainPage;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.LinkLabel linkLabelRegister;
        private System.Windows.Forms.PictureBox pbCart;
        private System.Windows.Forms.Label lblProductNumInCart;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel lblToSellerForm;
        private System.Windows.Forms.LinkLabel linkLabelHouTai;
        private System.Windows.Forms.SplitContainer spContainerBotton;
        private System.Windows.Forms.FlowLayoutPanel flowpanelType;
        private System.Windows.Forms.SplitContainer spContainerItem;
        private System.Windows.Forms.FlowLayoutPanel flowpanelItem;
        private System.Windows.Forms.LinkLabel linkLabelMemberCenter;
        private System.Windows.Forms.SplitContainer spContainerGuessYouLike;
        private System.Windows.Forms.Label lblGuessYouLike;
        private System.Windows.Forms.FlowLayoutPanel flowpanelTypeItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowpanelAD;
        private System.Windows.Forms.Panel panel5;
    }
}

