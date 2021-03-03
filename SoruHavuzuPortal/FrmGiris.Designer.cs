namespace SoruHavuzuPortal
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.BtnSifreUnttum = new System.Windows.Forms.Button();
            this.BtnKayitOl = new System.Windows.Forms.Button();
            this.GrubGirisTürü = new System.Windows.Forms.GroupBox();
            this.CheckBoxOgrtmen = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ClosePicture = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnDegis = new Guna.UI2.WinForms.Guna2Button();
            this.CheckBoxOgr = new Guna.UI2.WinForms.Guna2CheckBox();
            this.GrubKuLBilgiler = new System.Windows.Forms.GroupBox();
            this.PBoxSifreGoster = new System.Windows.Forms.PictureBox();
            this.PictureBack = new System.Windows.Forms.PictureBox();
            this.PictureExit = new System.Windows.Forms.PictureBox();
            this.BtnGiris = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtSifre = new Guna.UI.WinForms.GunaLineTextBox();
            this.TxtTc = new Guna.UI.WinForms.GunaLineTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.GrubGirisTürü.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.GrubKuLBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxSifreGoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse1
            // 
            this.Elipse1.BorderRadius = 20;
            this.Elipse1.TargetControl = this;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.BtnSifreUnttum);
            this.guna2CustomGradientPanel1.Controls.Add(this.BtnKayitOl);
            this.guna2CustomGradientPanel1.Controls.Add(this.GrubKuLBilgiler);
            this.guna2CustomGradientPanel1.Controls.Add(this.GrubGirisTürü);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(12, 12);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(350, 304);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // BtnSifreUnttum
            // 
            this.BtnSifreUnttum.BackColor = System.Drawing.Color.Transparent;
            this.BtnSifreUnttum.FlatAppearance.BorderSize = 0;
            this.BtnSifreUnttum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSifreUnttum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSifreUnttum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.BtnSifreUnttum.Image = global::SoruHavuzuPortal.Properties.Resources.icons8_forgot_password_24px_1;
            this.BtnSifreUnttum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSifreUnttum.Location = new System.Drawing.Point(203, 266);
            this.BtnSifreUnttum.Name = "BtnSifreUnttum";
            this.BtnSifreUnttum.Size = new System.Drawing.Size(158, 35);
            this.BtnSifreUnttum.TabIndex = 6;
            this.BtnSifreUnttum.Text = "Şiremi Unutum";
            this.BtnSifreUnttum.UseVisualStyleBackColor = false;
            this.BtnSifreUnttum.Click += new System.EventHandler(this.BtnSifreUnttum_Click);
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
            this.BtnKayitOl.Location = new System.Drawing.Point(203, 226);
            this.BtnKayitOl.Name = "BtnKayitOl";
            this.BtnKayitOl.Size = new System.Drawing.Size(135, 35);
            this.BtnKayitOl.TabIndex = 6;
            this.BtnKayitOl.Text = "Kayıt Ol";
            this.BtnKayitOl.UseVisualStyleBackColor = false;
            this.BtnKayitOl.Click += new System.EventHandler(this.BtnKayitOl_Click);
            // 
            // GrubGirisTürü
            // 
            this.GrubGirisTürü.BackColor = System.Drawing.Color.Transparent;
            this.GrubGirisTürü.Controls.Add(this.CheckBoxOgrtmen);
            this.GrubGirisTürü.Controls.Add(this.ClosePicture);
            this.GrubGirisTürü.Controls.Add(this.pictureBox2);
            this.GrubGirisTürü.Controls.Add(this.BtnDegis);
            this.GrubGirisTürü.Controls.Add(this.CheckBoxOgr);
            this.GrubGirisTürü.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrubGirisTürü.ForeColor = System.Drawing.Color.Black;
            this.GrubGirisTürü.Location = new System.Drawing.Point(9, 3);
            this.GrubGirisTürü.Name = "GrubGirisTürü";
            this.GrubGirisTürü.Size = new System.Drawing.Size(332, 217);
            this.GrubGirisTürü.TabIndex = 0;
            this.GrubGirisTürü.TabStop = false;
            this.GrubGirisTürü.Text = "Giriş Türü";
            // 
            // CheckBoxOgrtmen
            // 
            this.CheckBoxOgrtmen.AutoSize = true;
            this.CheckBoxOgrtmen.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.CheckBoxOgrtmen.CheckedState.BorderRadius = 3;
            this.CheckBoxOgrtmen.CheckedState.BorderThickness = 0;
            this.CheckBoxOgrtmen.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.CheckBoxOgrtmen.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.CheckBoxOgrtmen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.CheckBoxOgrtmen.Location = new System.Drawing.Point(122, 112);
            this.CheckBoxOgrtmen.Name = "CheckBoxOgrtmen";
            this.CheckBoxOgrtmen.Size = new System.Drawing.Size(88, 23);
            this.CheckBoxOgrtmen.TabIndex = 8;
            this.CheckBoxOgrtmen.Text = "Öğretmen";
            this.CheckBoxOgrtmen.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBoxOgrtmen.UncheckedState.BorderRadius = 2;
            this.CheckBoxOgrtmen.UncheckedState.BorderThickness = 0;
            this.CheckBoxOgrtmen.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBoxOgrtmen.UseVisualStyleBackColor = false;
            this.CheckBoxOgrtmen.Click += new System.EventHandler(this.CheckBoxOgrtmen_Click);
            // 
            // ClosePicture
            // 
            this.ClosePicture.Image = global::SoruHavuzuPortal.Properties.Resources.icons8_cancel_64px;
            this.ClosePicture.Location = new System.Drawing.Point(302, 9);
            this.ClosePicture.Name = "ClosePicture";
            this.ClosePicture.Size = new System.Drawing.Size(30, 30);
            this.ClosePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClosePicture.TabIndex = 7;
            this.ClosePicture.TabStop = false;
            this.ClosePicture.Click += new System.EventHandler(this.ClosePicture_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SoruHavuzuPortal.Properties.Resources.arma;
            this.pictureBox2.Location = new System.Drawing.Point(116, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // BtnDegis
            // 
            this.BtnDegis.BackColor = System.Drawing.Color.Transparent;
            this.BtnDegis.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.BtnDegis.BorderRadius = 24;
            this.BtnDegis.BorderThickness = 1;
            this.BtnDegis.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnDegis.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.BtnDegis.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.BtnDegis.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("BtnDegis.CheckedState.Image")));
            this.BtnDegis.CheckedState.Parent = this.BtnDegis;
            this.BtnDegis.CustomImages.Parent = this.BtnDegis;
            this.BtnDegis.FillColor = System.Drawing.Color.Transparent;
            this.BtnDegis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDegis.ForeColor = System.Drawing.Color.White;
            this.BtnDegis.HoverState.Parent = this.BtnDegis;
            this.BtnDegis.Image = ((System.Drawing.Image)(resources.GetObject("BtnDegis.Image")));
            this.BtnDegis.Location = new System.Drawing.Point(138, 161);
            this.BtnDegis.Name = "BtnDegis";
            this.BtnDegis.ShadowDecoration.Parent = this.BtnDegis;
            this.BtnDegis.Size = new System.Drawing.Size(60, 50);
            this.BtnDegis.TabIndex = 3;
            this.BtnDegis.UseTransparentBackground = true;
            this.BtnDegis.Click += new System.EventHandler(this.BtnDegis_Click);
            // 
            // CheckBoxOgr
            // 
            this.CheckBoxOgr.AutoSize = true;
            this.CheckBoxOgr.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxOgr.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.CheckBoxOgr.CheckedState.BorderRadius = 3;
            this.CheckBoxOgr.CheckedState.BorderThickness = 0;
            this.CheckBoxOgr.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.CheckBoxOgr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxOgr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.CheckBoxOgr.Location = new System.Drawing.Point(122, 77);
            this.CheckBoxOgr.Name = "CheckBoxOgr";
            this.CheckBoxOgr.Size = new System.Drawing.Size(76, 23);
            this.CheckBoxOgr.TabIndex = 2;
            this.CheckBoxOgr.Text = "Öğrenci";
            this.CheckBoxOgr.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBoxOgr.UncheckedState.BorderRadius = 2;
            this.CheckBoxOgr.UncheckedState.BorderThickness = 0;
            this.CheckBoxOgr.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBoxOgr.UseVisualStyleBackColor = false;
            this.CheckBoxOgr.Click += new System.EventHandler(this.CheckBoxOgr_Click);
            // 
            // GrubKuLBilgiler
            // 
            this.GrubKuLBilgiler.BackColor = System.Drawing.Color.Transparent;
            this.GrubKuLBilgiler.Controls.Add(this.PBoxSifreGoster);
            this.GrubKuLBilgiler.Controls.Add(this.PictureBack);
            this.GrubKuLBilgiler.Controls.Add(this.PictureExit);
            this.GrubKuLBilgiler.Controls.Add(this.BtnGiris);
            this.GrubKuLBilgiler.Controls.Add(this.pictureBox1);
            this.GrubKuLBilgiler.Controls.Add(this.TxtSifre);
            this.GrubKuLBilgiler.Controls.Add(this.TxtTc);
            this.GrubKuLBilgiler.Location = new System.Drawing.Point(9, 3);
            this.GrubKuLBilgiler.Name = "GrubKuLBilgiler";
            this.GrubKuLBilgiler.Size = new System.Drawing.Size(332, 217);
            this.GrubKuLBilgiler.TabIndex = 4;
            this.GrubKuLBilgiler.TabStop = false;
            this.GrubKuLBilgiler.Text = "Kullanıci Bilgileri";
            // 
            // PBoxSifreGoster
            // 
            this.PBoxSifreGoster.Image = global::SoruHavuzuPortal.Properties.Resources.icons8_eye_50px_1;
            this.PBoxSifreGoster.Location = new System.Drawing.Point(235, 118);
            this.PBoxSifreGoster.Name = "PBoxSifreGoster";
            this.PBoxSifreGoster.Size = new System.Drawing.Size(20, 18);
            this.PBoxSifreGoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxSifreGoster.TabIndex = 42;
            this.PBoxSifreGoster.TabStop = false;
            this.PBoxSifreGoster.MouseEnter += new System.EventHandler(this.PBoxSifreGoster_MouseEnter);
            this.PBoxSifreGoster.MouseLeave += new System.EventHandler(this.PBoxSifreGoster_MouseLeave);
            // 
            // PictureBack
            // 
            this.PictureBack.Image = global::SoruHavuzuPortal.Properties.Resources.icons8_go_back_64px_3;
            this.PictureBack.Location = new System.Drawing.Point(273, 9);
            this.PictureBack.Name = "PictureBack";
            this.PictureBack.Size = new System.Drawing.Size(30, 30);
            this.PictureBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBack.TabIndex = 8;
            this.PictureBack.TabStop = false;
            this.PictureBack.Click += new System.EventHandler(this.PictureBack_Click);
            // 
            // PictureExit
            // 
            this.PictureExit.Image = global::SoruHavuzuPortal.Properties.Resources.icons8_cancel_64px;
            this.PictureExit.Location = new System.Drawing.Point(302, 9);
            this.PictureExit.Name = "PictureExit";
            this.PictureExit.Size = new System.Drawing.Size(30, 30);
            this.PictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureExit.TabIndex = 9;
            this.PictureExit.TabStop = false;
            this.PictureExit.Click += new System.EventHandler(this.ClosePicture_Click);
            // 
            // BtnGiris
            // 
            this.BtnGiris.BackColor = System.Drawing.Color.Transparent;
            this.BtnGiris.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.BtnGiris.BorderRadius = 24;
            this.BtnGiris.BorderThickness = 1;
            this.BtnGiris.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnGiris.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnGiris.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.BtnGiris.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("BtnGiris.CheckedState.Image")));
            this.BtnGiris.CheckedState.Parent = this.BtnGiris;
            this.BtnGiris.CustomImages.Parent = this.BtnGiris;
            this.BtnGiris.FillColor = System.Drawing.Color.Transparent;
            this.BtnGiris.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnGiris.ForeColor = System.Drawing.Color.White;
            this.BtnGiris.HoverState.Parent = this.BtnGiris;
            this.BtnGiris.Image = ((System.Drawing.Image)(resources.GetObject("BtnGiris.Image")));
            this.BtnGiris.Location = new System.Drawing.Point(138, 161);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.ShadowDecoration.Parent = this.BtnGiris;
            this.BtnGiris.Size = new System.Drawing.Size(60, 50);
            this.BtnGiris.TabIndex = 3;
            this.BtnGiris.UseTransparentBackground = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SoruHavuzuPortal.Properties.Resources.arma;
            this.pictureBox1.Location = new System.Drawing.Point(116, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
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
            this.TxtSifre.Location = new System.Drawing.Point(95, 118);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.PasswordChar = '\0';
            this.TxtSifre.SelectedText = "";
            this.TxtSifre.Size = new System.Drawing.Size(160, 26);
            this.TxtSifre.TabIndex = 2;
            this.TxtSifre.Tag = "Şifre";
            this.TxtSifre.TextChanged += new System.EventHandler(this.TxtSifre_TextChanged);
            this.TxtSifre.Enter += new System.EventHandler(this.TxtSifre_Enter);
            this.TxtSifre.Leave += new System.EventHandler(this.TxtSifre_Leave);
            // 
            // TxtTc
            // 
            this.TxtTc.Animated = true;
            this.TxtTc.BackColor = System.Drawing.Color.White;
            this.TxtTc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTc.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.TxtTc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TxtTc.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtTc.LineColor = System.Drawing.Color.Gainsboro;
            this.TxtTc.Location = new System.Drawing.Point(95, 77);
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.PasswordChar = '\0';
            this.TxtTc.SelectedText = "";
            this.TxtTc.Size = new System.Drawing.Size(160, 28);
            this.TxtTc.TabIndex = 1;
            this.TxtTc.Tag = "T.C. Kimlik Numarası";
            this.TxtTc.Enter += new System.EventHandler(this.TxtSifre_Enter);
            this.TxtTc.Leave += new System.EventHandler(this.TxtSifre_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(374, 328);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGiris";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.GrubGirisTürü.ResumeLayout(false);
            this.GrubGirisTürü.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.GrubKuLBilgiler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxSifreGoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Elipse1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.GroupBox GrubGirisTürü;
        private Guna.UI2.WinForms.Guna2CheckBox CheckBoxOgr;
        private Guna.UI2.WinForms.Guna2Button BtnDegis;
        private System.Windows.Forms.GroupBox GrubKuLBilgiler;
        private Guna.UI.WinForms.GunaLineTextBox TxtTc;
        private Guna.UI.WinForms.GunaLineTextBox TxtSifre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button BtnGiris;
        private System.Windows.Forms.PictureBox ClosePicture;
        private System.Windows.Forms.PictureBox PictureBack;
        private System.Windows.Forms.PictureBox PictureExit;
        private Guna.UI2.WinForms.Guna2CheckBox CheckBoxOgrtmen;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BtnKayitOl;
        private System.Windows.Forms.Button BtnSifreUnttum;
        private System.Windows.Forms.PictureBox PBoxSifreGoster;
    }
}