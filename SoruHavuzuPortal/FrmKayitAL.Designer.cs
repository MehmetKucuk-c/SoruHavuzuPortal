namespace SoruHavuzuPortal
{
    partial class FrmKayitAL
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKayitAL));
            this.Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.GrbBilgiler = new System.Windows.Forms.GroupBox();
            this.PBoxSifreGoster = new System.Windows.Forms.PictureBox();
            this.TxtGizli = new System.Windows.Forms.Label();
            this.CmbGizliSoru = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtGizliSoruCevap = new Guna.UI.WinForms.GunaLineTextBox();
            this.TxtKulAdSoyad = new Guna.UI.WinForms.GunaLineTextBox();
            this.TxtGmail = new Guna.UI.WinForms.GunaLineTextBox();
            this.TxtSifreTekrar = new Guna.UI.WinForms.GunaLineTextBox();
            this.TxtSifre = new Guna.UI.WinForms.GunaLineTextBox();
            this.TxtTc = new Guna.UI.WinForms.GunaLineTextBox();
            this.PictureBack = new System.Windows.Forms.PictureBox();
            this.PictureExit = new System.Windows.Forms.PictureBox();
            this.BtnKayitOl = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.GrbBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxSifreGoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse1
            // 
            this.Elipse1.BorderRadius = 15;
            this.Elipse1.TargetControl = this;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.GrbBilgiler);
            this.guna2CustomGradientPanel1.Controls.Add(this.BtnKayitOl);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(12, 12);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(328, 543);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // GrbBilgiler
            // 
            this.GrbBilgiler.BackColor = System.Drawing.Color.White;
            this.GrbBilgiler.Controls.Add(this.PBoxSifreGoster);
            this.GrbBilgiler.Controls.Add(this.TxtGizli);
            this.GrbBilgiler.Controls.Add(this.CmbGizliSoru);
            this.GrbBilgiler.Controls.Add(this.pictureBox1);
            this.GrbBilgiler.Controls.Add(this.TxtGizliSoruCevap);
            this.GrbBilgiler.Controls.Add(this.TxtKulAdSoyad);
            this.GrbBilgiler.Controls.Add(this.TxtGmail);
            this.GrbBilgiler.Controls.Add(this.TxtSifreTekrar);
            this.GrbBilgiler.Controls.Add(this.TxtSifre);
            this.GrbBilgiler.Controls.Add(this.TxtTc);
            this.GrbBilgiler.Controls.Add(this.PictureBack);
            this.GrbBilgiler.Controls.Add(this.PictureExit);
            this.GrbBilgiler.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbBilgiler.Location = new System.Drawing.Point(3, 14);
            this.GrbBilgiler.Name = "GrbBilgiler";
            this.GrbBilgiler.Size = new System.Drawing.Size(322, 446);
            this.GrbBilgiler.TabIndex = 1;
            this.GrbBilgiler.TabStop = false;
            this.GrbBilgiler.Text = "Bilgiler";
            // 
            // PBoxSifreGoster
            // 
            this.PBoxSifreGoster.Image = global::SoruHavuzuPortal.Properties.Resources.icons8_eye_50px_1;
            this.PBoxSifreGoster.Location = new System.Drawing.Point(260, 206);
            this.PBoxSifreGoster.Name = "PBoxSifreGoster";
            this.PBoxSifreGoster.Size = new System.Drawing.Size(20, 18);
            this.PBoxSifreGoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxSifreGoster.TabIndex = 43;
            this.PBoxSifreGoster.TabStop = false;
            this.PBoxSifreGoster.MouseEnter += new System.EventHandler(this.PBoxSifreGoster_MouseEnter);
            this.PBoxSifreGoster.MouseLeave += new System.EventHandler(this.PBoxSifreGoster_MouseLeave);
            // 
            // TxtGizli
            // 
            this.TxtGizli.AutoSize = true;
            this.TxtGizli.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.TxtGizli.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtGizli.Location = new System.Drawing.Point(53, 365);
            this.TxtGizli.Name = "TxtGizli";
            this.TxtGizli.Size = new System.Drawing.Size(73, 19);
            this.TxtGizli.TabIndex = 42;
            this.TxtGizli.Text = "Gizli Soru";
            // 
            // CmbGizliSoru
            // 
            this.CmbGizliSoru.Animated = true;
            this.CmbGizliSoru.BackColor = System.Drawing.Color.Transparent;
            this.CmbGizliSoru.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.CmbGizliSoru.BorderRadius = 18;
            this.CmbGizliSoru.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbGizliSoru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGizliSoru.FocusedColor = System.Drawing.Color.Empty;
            this.CmbGizliSoru.FocusedState.Parent = this.CmbGizliSoru;
            this.CmbGizliSoru.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbGizliSoru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.CmbGizliSoru.FormattingEnabled = true;
            this.CmbGizliSoru.HoverState.Parent = this.CmbGizliSoru;
            this.CmbGizliSoru.ItemHeight = 30;
            this.CmbGizliSoru.Items.AddRange(new object[] {
            "Annenizin kızlık soyadı nedir?",
            "İlk okulumuzun adı nedir?",
            "İlk evcil hayvanınızın adı nedir?",
            "İlk aracınızın markası nedir?",
            "Hangi şehirde doğdunuz?",
            "Babanızın ortanca ismi nedir?",
            "Çocukluk lakabınız nedir?"});
            this.CmbGizliSoru.ItemsAppearance.Parent = this.CmbGizliSoru;
            this.CmbGizliSoru.Location = new System.Drawing.Point(47, 356);
            this.CmbGizliSoru.Name = "CmbGizliSoru";
            this.CmbGizliSoru.ShadowDecoration.Parent = this.CmbGizliSoru;
            this.CmbGizliSoru.Size = new System.Drawing.Size(235, 36);
            this.CmbGizliSoru.TabIndex = 41;
            this.CmbGizliSoru.Tag = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SoruHavuzuPortal.Properties.Resources.arma;
            this.pictureBox1.Location = new System.Drawing.Point(114, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // TxtGizliSoruCevap
            // 
            this.TxtGizliSoruCevap.Animated = true;
            this.TxtGizliSoruCevap.BackColor = System.Drawing.Color.White;
            this.TxtGizliSoruCevap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtGizliSoruCevap.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.TxtGizliSoruCevap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TxtGizliSoruCevap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.TxtGizliSoruCevap.LineColor = System.Drawing.Color.Gainsboro;
            this.TxtGizliSoruCevap.Location = new System.Drawing.Point(47, 406);
            this.TxtGizliSoruCevap.Name = "TxtGizliSoruCevap";
            this.TxtGizliSoruCevap.PasswordChar = '\0';
            this.TxtGizliSoruCevap.SelectedText = "";
            this.TxtGizliSoruCevap.Size = new System.Drawing.Size(235, 26);
            this.TxtGizliSoruCevap.TabIndex = 6;
            this.TxtGizliSoruCevap.Tag = "Gizli Soru Cevap";
            this.TxtGizliSoruCevap.Enter += new System.EventHandler(this.TxtTc_Enter);
            this.TxtGizliSoruCevap.Leave += new System.EventHandler(this.TxtTc_Leave);
            // 
            // TxtKulAdSoyad
            // 
            this.TxtKulAdSoyad.Animated = true;
            this.TxtKulAdSoyad.BackColor = System.Drawing.Color.White;
            this.TxtKulAdSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtKulAdSoyad.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.TxtKulAdSoyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TxtKulAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.TxtKulAdSoyad.LineColor = System.Drawing.Color.Gainsboro;
            this.TxtKulAdSoyad.Location = new System.Drawing.Point(47, 306);
            this.TxtKulAdSoyad.Name = "TxtKulAdSoyad";
            this.TxtKulAdSoyad.PasswordChar = '\0';
            this.TxtKulAdSoyad.SelectedText = "";
            this.TxtKulAdSoyad.Size = new System.Drawing.Size(235, 26);
            this.TxtKulAdSoyad.TabIndex = 4;
            this.TxtKulAdSoyad.Tag = "Ad Soyad";
            this.TxtKulAdSoyad.Enter += new System.EventHandler(this.TxtTc_Enter);
            this.TxtKulAdSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKulAdSoyad_KeyPress);
            this.TxtKulAdSoyad.Leave += new System.EventHandler(this.TxtTc_Leave);
            // 
            // TxtGmail
            // 
            this.TxtGmail.Animated = true;
            this.TxtGmail.BackColor = System.Drawing.Color.White;
            this.TxtGmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtGmail.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.TxtGmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TxtGmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.TxtGmail.LineColor = System.Drawing.Color.Gainsboro;
            this.TxtGmail.Location = new System.Drawing.Point(49, 256);
            this.TxtGmail.Name = "TxtGmail";
            this.TxtGmail.PasswordChar = '\0';
            this.TxtGmail.SelectedText = "";
            this.TxtGmail.Size = new System.Drawing.Size(231, 26);
            this.TxtGmail.TabIndex = 3;
            this.TxtGmail.Tag = "Kullanıcı Email";
            this.TxtGmail.Enter += new System.EventHandler(this.TxtTc_Enter);
            this.TxtGmail.Leave += new System.EventHandler(this.TxtTc_Leave);
            // 
            // TxtSifreTekrar
            // 
            this.TxtSifreTekrar.Animated = true;
            this.TxtSifreTekrar.BackColor = System.Drawing.Color.White;
            this.TxtSifreTekrar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSifreTekrar.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.TxtSifreTekrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TxtSifreTekrar.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtSifreTekrar.LineColor = System.Drawing.Color.Gainsboro;
            this.TxtSifreTekrar.Location = new System.Drawing.Point(49, 206);
            this.TxtSifreTekrar.Name = "TxtSifreTekrar";
            this.TxtSifreTekrar.PasswordChar = '\0';
            this.TxtSifreTekrar.SelectedText = "";
            this.TxtSifreTekrar.Size = new System.Drawing.Size(231, 26);
            this.TxtSifreTekrar.TabIndex = 2;
            this.TxtSifreTekrar.Tag = "Şifre Tekrar";
            this.TxtSifreTekrar.TextChanged += new System.EventHandler(this.TxtSifre_TextChanged);
            this.TxtSifreTekrar.Enter += new System.EventHandler(this.TxtTc_Enter);
            this.TxtSifreTekrar.Leave += new System.EventHandler(this.TxtTc_Leave);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Animated = true;
            this.TxtSifre.BackColor = System.Drawing.Color.White;
            this.TxtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSifre.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.TxtSifre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TxtSifre.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtSifre.LineColor = System.Drawing.Color.Gainsboro;
            this.TxtSifre.Location = new System.Drawing.Point(49, 156);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.PasswordChar = '\0';
            this.TxtSifre.SelectedText = "";
            this.TxtSifre.Size = new System.Drawing.Size(231, 26);
            this.TxtSifre.TabIndex = 1;
            this.TxtSifre.Tag = "Şifre";
            this.TxtSifre.TextChanged += new System.EventHandler(this.TxtSifre_TextChanged);
            this.TxtSifre.Enter += new System.EventHandler(this.TxtTc_Enter);
            this.TxtSifre.Leave += new System.EventHandler(this.TxtTc_Leave);
            // 
            // TxtTc
            // 
            this.TxtTc.Animated = true;
            this.TxtTc.BackColor = System.Drawing.Color.White;
            this.TxtTc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTc.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.TxtTc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TxtTc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.TxtTc.LineColor = System.Drawing.Color.Gainsboro;
            this.TxtTc.Location = new System.Drawing.Point(49, 106);
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.PasswordChar = '\0';
            this.TxtTc.SelectedText = "";
            this.TxtTc.Size = new System.Drawing.Size(231, 28);
            this.TxtTc.TabIndex = 0;
            this.TxtTc.Tag = "T.C. Kimlik Numarası";
            this.TxtTc.Enter += new System.EventHandler(this.TxtTc_Enter);
            this.TxtTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTc_KeyPress);
            this.TxtTc.Leave += new System.EventHandler(this.TxtTc_Leave);
            // 
            // PictureBack
            // 
            this.PictureBack.Image = global::SoruHavuzuPortal.Properties.Resources.icons8_go_back_64px_3;
            this.PictureBack.Location = new System.Drawing.Point(263, 11);
            this.PictureBack.Name = "PictureBack";
            this.PictureBack.Size = new System.Drawing.Size(30, 30);
            this.PictureBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBack.TabIndex = 10;
            this.PictureBack.TabStop = false;
            this.PictureBack.Click += new System.EventHandler(this.PictureBack_Click);
            // 
            // PictureExit
            // 
            this.PictureExit.Image = global::SoruHavuzuPortal.Properties.Resources.icons8_cancel_64px;
            this.PictureExit.Location = new System.Drawing.Point(292, 11);
            this.PictureExit.Name = "PictureExit";
            this.PictureExit.Size = new System.Drawing.Size(30, 30);
            this.PictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureExit.TabIndex = 11;
            this.PictureExit.TabStop = false;
            this.PictureExit.Click += new System.EventHandler(this.PictureExit_Click);
            // 
            // BtnKayitOl
            // 
            this.BtnKayitOl.BackColor = System.Drawing.Color.Transparent;
            this.BtnKayitOl.FlatAppearance.BorderSize = 0;
            this.BtnKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKayitOl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.BtnKayitOl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.BtnKayitOl.Image = global::SoruHavuzuPortal.Properties.Resources.icons8_student_registration_24px;
            this.BtnKayitOl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKayitOl.Location = new System.Drawing.Point(102, 505);
            this.BtnKayitOl.Name = "BtnKayitOl";
            this.BtnKayitOl.Size = new System.Drawing.Size(146, 35);
            this.BtnKayitOl.TabIndex = 6;
            this.BtnKayitOl.Text = "Kayıt Ol";
            this.BtnKayitOl.UseVisualStyleBackColor = false;
            this.BtnKayitOl.Click += new System.EventHandler(this.BtnKayitOl_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmKayitAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(352, 567);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKayitAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKayitAL";
            this.Load += new System.EventHandler(this.FrmKayitAL_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.GrbBilgiler.ResumeLayout(false);
            this.GrbBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxSifreGoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse Elipse1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.GroupBox GrbBilgiler;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLineTextBox TxtSifreTekrar;
        private Guna.UI.WinForms.GunaLineTextBox TxtSifre;
        private Guna.UI.WinForms.GunaLineTextBox TxtTc;
        private System.Windows.Forms.PictureBox PictureBack;
        private System.Windows.Forms.PictureBox PictureExit;
        private System.Windows.Forms.Button BtnKayitOl;
        private Guna.UI.WinForms.GunaLineTextBox TxtGizliSoruCevap;
        private Guna.UI.WinForms.GunaLineTextBox TxtKulAdSoyad;
        private Guna.UI.WinForms.GunaLineTextBox TxtGmail;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label TxtGizli;
        private Guna.UI2.WinForms.Guna2ComboBox CmbGizliSoru;
        private System.Windows.Forms.PictureBox PBoxSifreGoster;
    }
}