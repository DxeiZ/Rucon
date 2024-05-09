namespace Rucon
{
    partial class SettingsForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.siticoneGroupBox1 = new ns1.SiticoneGroupBox();
            this.siticonePictureBox1 = new ns1.SiticonePictureBox();
            this.cyberAppBtn = new FontAwesome.Sharp.IconButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.siticoneGroupBox2 = new ns1.SiticoneGroupBox();
            this.siticonePictureBox2 = new ns1.SiticonePictureBox();
            this.devAppBtn = new FontAwesome.Sharp.IconButton();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.siticoneGroupBox3 = new ns1.SiticoneGroupBox();
            this.siticonePictureBox3 = new ns1.SiticonePictureBox();
            this.usrAppBtn = new FontAwesome.Sharp.IconButton();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.siticoneGradientButton1 = new ns1.SiticoneGradientButton();
            this.siticoneGradientButton2 = new ns1.SiticoneGradientButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.siticoneGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.siticoneGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox2)).BeginInit();
            this.siticoneGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox3)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.AutoScroll = true;
            this.siticoneGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.siticoneGroupBox1.BorderRadius = 6;
            this.siticoneGroupBox1.Controls.Add(this.siticonePictureBox1);
            this.siticoneGroupBox1.Controls.Add(this.cyberAppBtn);
            this.siticoneGroupBox1.Controls.Add(this.checkedListBox1);
            this.siticoneGroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.siticoneGroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.siticoneGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.ShadowDecoration.Parent = this.siticoneGroupBox1;
            this.siticoneGroupBox1.Size = new System.Drawing.Size(270, 426);
            this.siticoneGroupBox1.TabIndex = 0;
            this.siticoneGroupBox1.Text = "Siber Güvenlik Arayüzü";
            this.siticoneGroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BackgroundImage = global::Rucon.Properties.Resources.empty;
            this.siticonePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.siticonePictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePictureBox1.Location = new System.Drawing.Point(0, 0);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(270, 395);
            this.siticonePictureBox1.TabIndex = 3;
            this.siticonePictureBox1.TabStop = false;
            this.siticonePictureBox1.WaitOnLoad = true;
            // 
            // cyberAppBtn
            // 
            this.cyberAppBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.cyberAppBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cyberAppBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.cyberAppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cyberAppBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cyberAppBtn.IconChar = FontAwesome.Sharp.IconChar.Phabricator;
            this.cyberAppBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.cyberAppBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cyberAppBtn.IconSize = 24;
            this.cyberAppBtn.Location = new System.Drawing.Point(0, 395);
            this.cyberAppBtn.Name = "cyberAppBtn";
            this.cyberAppBtn.Size = new System.Drawing.Size(270, 31);
            this.cyberAppBtn.TabIndex = 2;
            this.cyberAppBtn.Text = "Uygulama Ekle";
            this.cyberAppBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cyberAppBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cyberAppBtn.UseVisualStyleBackColor = false;
            this.cyberAppBtn.Click += new System.EventHandler(this.cyberAppBtn_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Enabled = false;
            this.checkedListBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(6, 47);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(242, 324);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // siticoneGroupBox2
            // 
            this.siticoneGroupBox2.AutoScroll = true;
            this.siticoneGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.siticoneGroupBox2.BorderRadius = 6;
            this.siticoneGroupBox2.Controls.Add(this.siticonePictureBox2);
            this.siticoneGroupBox2.Controls.Add(this.devAppBtn);
            this.siticoneGroupBox2.Controls.Add(this.checkedListBox2);
            this.siticoneGroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.siticoneGroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.siticoneGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.siticoneGroupBox2.Location = new System.Drawing.Point(288, 12);
            this.siticoneGroupBox2.Name = "siticoneGroupBox2";
            this.siticoneGroupBox2.ShadowDecoration.Parent = this.siticoneGroupBox2;
            this.siticoneGroupBox2.Size = new System.Drawing.Size(270, 426);
            this.siticoneGroupBox2.TabIndex = 4;
            this.siticoneGroupBox2.Text = "Yazılım Arayüzü";
            this.siticoneGroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticonePictureBox2
            // 
            this.siticonePictureBox2.BackgroundImage = global::Rucon.Properties.Resources.empty;
            this.siticonePictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.siticonePictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePictureBox2.Location = new System.Drawing.Point(0, 0);
            this.siticonePictureBox2.Name = "siticonePictureBox2";
            this.siticonePictureBox2.ShadowDecoration.Parent = this.siticonePictureBox2;
            this.siticonePictureBox2.Size = new System.Drawing.Size(270, 395);
            this.siticonePictureBox2.TabIndex = 3;
            this.siticonePictureBox2.TabStop = false;
            this.siticonePictureBox2.WaitOnLoad = true;
            // 
            // devAppBtn
            // 
            this.devAppBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.devAppBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.devAppBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.devAppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devAppBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devAppBtn.IconChar = FontAwesome.Sharp.IconChar.Phabricator;
            this.devAppBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.devAppBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.devAppBtn.IconSize = 24;
            this.devAppBtn.Location = new System.Drawing.Point(0, 395);
            this.devAppBtn.Name = "devAppBtn";
            this.devAppBtn.Size = new System.Drawing.Size(270, 31);
            this.devAppBtn.TabIndex = 2;
            this.devAppBtn.Text = "Uygulama Ekle";
            this.devAppBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.devAppBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.devAppBtn.UseVisualStyleBackColor = false;
            this.devAppBtn.Click += new System.EventHandler(this.devAppBtn_Click);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.checkedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.Enabled = false;
            this.checkedListBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(6, 47);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(242, 324);
            this.checkedListBox2.TabIndex = 1;
            this.checkedListBox2.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox2_ItemCheck);
            // 
            // siticoneGroupBox3
            // 
            this.siticoneGroupBox3.AutoScroll = true;
            this.siticoneGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.siticoneGroupBox3.BorderRadius = 6;
            this.siticoneGroupBox3.Controls.Add(this.siticonePictureBox3);
            this.siticoneGroupBox3.Controls.Add(this.usrAppBtn);
            this.siticoneGroupBox3.Controls.Add(this.checkedListBox3);
            this.siticoneGroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.siticoneGroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.siticoneGroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.siticoneGroupBox3.Location = new System.Drawing.Point(564, 12);
            this.siticoneGroupBox3.Name = "siticoneGroupBox3";
            this.siticoneGroupBox3.ShadowDecoration.Parent = this.siticoneGroupBox3;
            this.siticoneGroupBox3.Size = new System.Drawing.Size(270, 426);
            this.siticoneGroupBox3.TabIndex = 5;
            this.siticoneGroupBox3.Text = "Kullanıcı Arayüzü";
            this.siticoneGroupBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticonePictureBox3
            // 
            this.siticonePictureBox3.BackgroundImage = global::Rucon.Properties.Resources.empty;
            this.siticonePictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.siticonePictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePictureBox3.Location = new System.Drawing.Point(0, 0);
            this.siticonePictureBox3.Name = "siticonePictureBox3";
            this.siticonePictureBox3.ShadowDecoration.Parent = this.siticonePictureBox3;
            this.siticonePictureBox3.Size = new System.Drawing.Size(270, 395);
            this.siticonePictureBox3.TabIndex = 3;
            this.siticonePictureBox3.TabStop = false;
            this.siticonePictureBox3.WaitOnLoad = true;
            // 
            // usrAppBtn
            // 
            this.usrAppBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.usrAppBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usrAppBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.usrAppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usrAppBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrAppBtn.IconChar = FontAwesome.Sharp.IconChar.Phabricator;
            this.usrAppBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.usrAppBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.usrAppBtn.IconSize = 24;
            this.usrAppBtn.Location = new System.Drawing.Point(0, 395);
            this.usrAppBtn.Name = "usrAppBtn";
            this.usrAppBtn.Size = new System.Drawing.Size(270, 31);
            this.usrAppBtn.TabIndex = 2;
            this.usrAppBtn.Text = "Uygulama Ekle";
            this.usrAppBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usrAppBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.usrAppBtn.UseVisualStyleBackColor = false;
            this.usrAppBtn.Click += new System.EventHandler(this.usrAppBtn_Click);
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.checkedListBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox3.CheckOnClick = true;
            this.checkedListBox3.Enabled = false;
            this.checkedListBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Location = new System.Drawing.Point(6, 47);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(242, 324);
            this.checkedListBox3.TabIndex = 1;
            this.checkedListBox3.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox3_ItemCheck);
            // 
            // siticoneGradientButton1
            // 
            this.siticoneGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGradientButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.siticoneGradientButton1.BorderRadius = 4;
            this.siticoneGradientButton1.BorderThickness = 1;
            this.siticoneGradientButton1.CheckedState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.siticoneGradientButton1.CustomImages.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.siticoneGradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.siticoneGradientButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneGradientButton1.ForeColor = System.Drawing.Color.Silver;
            this.siticoneGradientButton1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.siticoneGradientButton1.HoveredState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.siticoneGradientButton1.HoveredState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Location = new System.Drawing.Point(12, 459);
            this.siticoneGradientButton1.Name = "siticoneGradientButton1";
            this.siticoneGradientButton1.PressedDepth = 1;
            this.siticoneGradientButton1.ShadowDecoration.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Size = new System.Drawing.Size(671, 44);
            this.siticoneGradientButton1.TabIndex = 7;
            this.siticoneGradientButton1.Text = "KAPAT";
            this.siticoneGradientButton1.Click += new System.EventHandler(this.siticoneGradientButton1_Click);
            // 
            // siticoneGradientButton2
            // 
            this.siticoneGradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGradientButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.siticoneGradientButton2.BorderRadius = 4;
            this.siticoneGradientButton2.BorderThickness = 1;
            this.siticoneGradientButton2.CheckedState.Parent = this.siticoneGradientButton2;
            this.siticoneGradientButton2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.siticoneGradientButton2.CustomImages.Parent = this.siticoneGradientButton2;
            this.siticoneGradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.siticoneGradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.siticoneGradientButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneGradientButton2.ForeColor = System.Drawing.Color.Silver;
            this.siticoneGradientButton2.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.siticoneGradientButton2.HoveredState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.siticoneGradientButton2.HoveredState.Parent = this.siticoneGradientButton2;
            this.siticoneGradientButton2.Location = new System.Drawing.Point(689, 459);
            this.siticoneGradientButton2.Name = "siticoneGradientButton2";
            this.siticoneGradientButton2.PressedDepth = 1;
            this.siticoneGradientButton2.ShadowDecoration.Parent = this.siticoneGradientButton2;
            this.siticoneGradientButton2.Size = new System.Drawing.Size(145, 44);
            this.siticoneGradientButton2.TabIndex = 8;
            this.siticoneGradientButton2.Text = "SIFIRLA";
            this.siticoneGradientButton2.Click += new System.EventHandler(this.siticoneGradientButton2_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Rucon";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 110);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Image = global::Rucon.Properties.Resources.drk_rucon;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(184, 26);
            this.toolStripMenuItem2.Text = "Rucon";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.toolStripMenuItem1.Text = "Ayarlar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.stgsStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(184, 26);
            this.toolStripMenuItem3.Text = "Kapat";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.clseStripMenuItem_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 515);
            this.Controls.Add(this.siticoneGradientButton2);
            this.Controls.Add(this.siticoneGradientButton1);
            this.Controls.Add(this.siticoneGroupBox3);
            this.Controls.Add(this.siticoneGroupBox2);
            this.Controls.Add(this.siticoneGroupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.siticoneGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.siticoneGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox2)).EndInit();
            this.siticoneGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox3)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.SiticoneGroupBox siticoneGroupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private FontAwesome.Sharp.IconButton cyberAppBtn;
        private ns1.SiticonePictureBox siticonePictureBox1;
        private ns1.SiticoneGroupBox siticoneGroupBox2;
        private ns1.SiticonePictureBox siticonePictureBox2;
        private FontAwesome.Sharp.IconButton devAppBtn;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private ns1.SiticoneGroupBox siticoneGroupBox3;
        private ns1.SiticonePictureBox siticonePictureBox3;
        private FontAwesome.Sharp.IconButton usrAppBtn;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private ns1.SiticoneGradientButton siticoneGradientButton1;
        private ns1.SiticoneGradientButton siticoneGradientButton2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

