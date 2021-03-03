namespace SoruHavuzuPortal
{
    partial class UserOgretmenSoruEkme
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LblAltKonu = new System.Windows.Forms.Label();
            this.LblDers = new System.Windows.Forms.Label();
            this.ComAltBaslik = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComDers = new Guna.UI2.WinForms.Guna2ComboBox();
            this.PanelSozel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.PictureResimSoru = new System.Windows.Forms.PictureBox();
            this.PictureResimCevap = new System.Windows.Forms.PictureBox();
            this.LblCevap = new System.Windows.Forms.Label();
            this.LblSoru = new System.Windows.Forms.Label();
            this.CevapResim = new System.Windows.Forms.PictureBox();
            this.SoruResim = new System.Windows.Forms.PictureBox();
            this.BtnSoruOlustur = new System.Windows.Forms.Button();
            this.ComZorluk = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComDogruCevap = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LblZorluk = new System.Windows.Forms.Label();
            this.LblDogruCevap = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelSozel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureResimSoru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureResimCevap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CevapResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoruResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAltKonu
            // 
            this.LblAltKonu.AutoSize = true;
            this.LblAltKonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAltKonu.Location = new System.Drawing.Point(20, 362);
            this.LblAltKonu.Name = "LblAltKonu";
            this.LblAltKonu.Size = new System.Drawing.Size(69, 13);
            this.LblAltKonu.TabIndex = 16;
            this.LblAltKonu.Text = "Alt Konular";
            // 
            // LblDers
            // 
            this.LblDers.AutoSize = true;
            this.LblDers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDers.Location = new System.Drawing.Point(18, 297);
            this.LblDers.Name = "LblDers";
            this.LblDers.Size = new System.Drawing.Size(55, 13);
            this.LblDers.TabIndex = 15;
            this.LblDers.Text = "Ders Adı";
            // 
            // ComAltBaslik
            // 
            this.ComAltBaslik.BackColor = System.Drawing.Color.Transparent;
            this.ComAltBaslik.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.ComAltBaslik.BorderRadius = 18;
            this.ComAltBaslik.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComAltBaslik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComAltBaslik.FocusedColor = System.Drawing.Color.Empty;
            this.ComAltBaslik.FocusedState.Parent = this.ComAltBaslik;
            this.ComAltBaslik.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComAltBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComAltBaslik.FormattingEnabled = true;
            this.ComAltBaslik.HoverState.Parent = this.ComAltBaslik;
            this.ComAltBaslik.ItemHeight = 30;
            this.ComAltBaslik.ItemsAppearance.Parent = this.ComAltBaslik;
            this.ComAltBaslik.Location = new System.Drawing.Point(8, 350);
            this.ComAltBaslik.Name = "ComAltBaslik";
            this.ComAltBaslik.ShadowDecoration.Parent = this.ComAltBaslik;
            this.ComAltBaslik.Size = new System.Drawing.Size(188, 36);
            this.ComAltBaslik.TabIndex = 13;
            this.ComAltBaslik.TextChanged += new System.EventHandler(this.ComAltBaslik_TextChanged);
            // 
            // ComDers
            // 
            this.ComDers.BackColor = System.Drawing.Color.Transparent;
            this.ComDers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.ComDers.BorderRadius = 18;
            this.ComDers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComDers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComDers.FocusedColor = System.Drawing.Color.Empty;
            this.ComDers.FocusedState.Parent = this.ComDers;
            this.ComDers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComDers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComDers.FormattingEnabled = true;
            this.ComDers.HoverState.Parent = this.ComDers;
            this.ComDers.ItemHeight = 30;
            this.ComDers.Items.AddRange(new object[] {
            "MATEMATİK",
            "GEOMETRİ",
            "FİZİK",
            "KİMYA",
            "BİYOLOJİ",
            "EDEBİYAT",
            "TARİH",
            "FELSEFE",
            "COĞRAFYA",
            "DİL VE ANLATIM"});
            this.ComDers.ItemsAppearance.Parent = this.ComDers;
            this.ComDers.Location = new System.Drawing.Point(8, 286);
            this.ComDers.Name = "ComDers";
            this.ComDers.ShadowDecoration.Parent = this.ComDers;
            this.ComDers.Size = new System.Drawing.Size(188, 36);
            this.ComDers.TabIndex = 14;
            this.ComDers.TextChanged += new System.EventHandler(this.ComDers_TextChanged);
            // 
            // PanelSozel
            // 
            this.PanelSozel.BackColor = System.Drawing.Color.White;
            this.PanelSozel.BorderRadius = 20;
            this.PanelSozel.Controls.Add(this.PictureResimSoru);
            this.PanelSozel.Controls.Add(this.PictureResimCevap);
            this.PanelSozel.Controls.Add(this.LblCevap);
            this.PanelSozel.Controls.Add(this.LblSoru);
            this.PanelSozel.Controls.Add(this.CevapResim);
            this.PanelSozel.Controls.Add(this.SoruResim);
            this.PanelSozel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.PanelSozel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.PanelSozel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.PanelSozel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.PanelSozel.Location = new System.Drawing.Point(8, 12);
            this.PanelSozel.Name = "PanelSozel";
            this.PanelSozel.ShadowDecoration.Parent = this.PanelSozel;
            this.PanelSozel.Size = new System.Drawing.Size(778, 252);
            this.PanelSozel.TabIndex = 21;
            // 
            // PictureResimSoru
            // 
            this.PictureResimSoru.BackColor = System.Drawing.Color.Transparent;
            this.PictureResimSoru.Image = global::SoruHavuzuPortal.Properties.Resources.icons8_ellipsis_60px;
            this.PictureResimSoru.Location = new System.Drawing.Point(93, 6);
            this.PictureResimSoru.Name = "PictureResimSoru";
            this.PictureResimSoru.Size = new System.Drawing.Size(20, 20);
            this.PictureResimSoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureResimSoru.TabIndex = 41;
            this.PictureResimSoru.TabStop = false;
            this.PictureResimSoru.Click += new System.EventHandler(this.PuctureREsimCEk_Click);
            // 
            // PictureResimCevap
            // 
            this.PictureResimCevap.BackColor = System.Drawing.Color.Transparent;
            this.PictureResimCevap.Image = global::SoruHavuzuPortal.Properties.Resources.icons8_ellipsis_60px;
            this.PictureResimCevap.Location = new System.Drawing.Point(485, 6);
            this.PictureResimCevap.Name = "PictureResimCevap";
            this.PictureResimCevap.Size = new System.Drawing.Size(20, 20);
            this.PictureResimCevap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureResimCevap.TabIndex = 40;
            this.PictureResimCevap.TabStop = false;
            this.PictureResimCevap.Click += new System.EventHandler(this.LblCevap_Click);
            // 
            // LblCevap
            // 
            this.LblCevap.AutoSize = true;
            this.LblCevap.BackColor = System.Drawing.Color.Transparent;
            this.LblCevap.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LblCevap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblCevap.Location = new System.Drawing.Point(383, 2);
            this.LblCevap.Name = "LblCevap";
            this.LblCevap.Size = new System.Drawing.Size(107, 21);
            this.LblCevap.TabIndex = 38;
            this.LblCevap.Text = "Cevap Resimi";
            this.LblCevap.Click += new System.EventHandler(this.LblCevap_Click);
            // 
            // LblSoru
            // 
            this.LblSoru.AutoSize = true;
            this.LblSoru.BackColor = System.Drawing.Color.Transparent;
            this.LblSoru.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSoru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblSoru.Location = new System.Drawing.Point(1, 2);
            this.LblSoru.Name = "LblSoru";
            this.LblSoru.Size = new System.Drawing.Size(96, 21);
            this.LblSoru.TabIndex = 39;
            this.LblSoru.Text = "Soru Resimi";
            this.LblSoru.Click += new System.EventHandler(this.PuctureREsimCEk_Click);
            // 
            // CevapResim
            // 
            this.CevapResim.BackColor = System.Drawing.Color.Transparent;
            this.CevapResim.Location = new System.Drawing.Point(383, 26);
            this.CevapResim.Name = "CevapResim";
            this.CevapResim.Size = new System.Drawing.Size(395, 224);
            this.CevapResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CevapResim.TabIndex = 36;
            this.CevapResim.TabStop = false;
            // 
            // SoruResim
            // 
            this.SoruResim.BackColor = System.Drawing.Color.Transparent;
            this.SoruResim.Location = new System.Drawing.Point(2, 26);
            this.SoruResim.Name = "SoruResim";
            this.SoruResim.Size = new System.Drawing.Size(361, 224);
            this.SoruResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SoruResim.TabIndex = 37;
            this.SoruResim.TabStop = false;
            // 
            // BtnSoruOlustur
            // 
            this.BtnSoruOlustur.BackColor = System.Drawing.Color.Transparent;
            this.BtnSoruOlustur.FlatAppearance.BorderSize = 0;
            this.BtnSoruOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSoruOlustur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSoruOlustur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSoruOlustur.Image = global::SoruHavuzuPortal.Properties.Resources.icons8_questions_24px;
            this.BtnSoruOlustur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSoruOlustur.Location = new System.Drawing.Point(69, 532);
            this.BtnSoruOlustur.Name = "BtnSoruOlustur";
            this.BtnSoruOlustur.Size = new System.Drawing.Size(152, 35);
            this.BtnSoruOlustur.TabIndex = 42;
            this.BtnSoruOlustur.Text = "Soru Olştur";
            this.BtnSoruOlustur.UseVisualStyleBackColor = false;
            this.BtnSoruOlustur.Click += new System.EventHandler(this.BtnSoruOlustur_Click);
            // 
            // ComZorluk
            // 
            this.ComZorluk.BackColor = System.Drawing.Color.Transparent;
            this.ComZorluk.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.ComZorluk.BorderRadius = 18;
            this.ComZorluk.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComZorluk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComZorluk.FocusedColor = System.Drawing.Color.Empty;
            this.ComZorluk.FocusedState.Parent = this.ComZorluk;
            this.ComZorluk.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComZorluk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComZorluk.FormattingEnabled = true;
            this.ComZorluk.HoverState.Parent = this.ComZorluk;
            this.ComZorluk.ItemHeight = 30;
            this.ComZorluk.Items.AddRange(new object[] {
            "Kolay",
            "Orta",
            "Zor"});
            this.ComZorluk.ItemsAppearance.Parent = this.ComZorluk;
            this.ComZorluk.Location = new System.Drawing.Point(8, 414);
            this.ComZorluk.Name = "ComZorluk";
            this.ComZorluk.ShadowDecoration.Parent = this.ComZorluk;
            this.ComZorluk.Size = new System.Drawing.Size(188, 36);
            this.ComZorluk.TabIndex = 14;
            this.ComZorluk.TextChanged += new System.EventHandler(this.ComAltBaslik_TextChanged);
            // 
            // ComDogruCevap
            // 
            this.ComDogruCevap.BackColor = System.Drawing.Color.Transparent;
            this.ComDogruCevap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(1)))));
            this.ComDogruCevap.BorderRadius = 18;
            this.ComDogruCevap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComDogruCevap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComDogruCevap.FocusedColor = System.Drawing.Color.Empty;
            this.ComDogruCevap.FocusedState.Parent = this.ComDogruCevap;
            this.ComDogruCevap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComDogruCevap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComDogruCevap.FormattingEnabled = true;
            this.ComDogruCevap.HoverState.Parent = this.ComDogruCevap;
            this.ComDogruCevap.ItemHeight = 30;
            this.ComDogruCevap.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.ComDogruCevap.ItemsAppearance.Parent = this.ComDogruCevap;
            this.ComDogruCevap.Location = new System.Drawing.Point(8, 478);
            this.ComDogruCevap.Name = "ComDogruCevap";
            this.ComDogruCevap.ShadowDecoration.Parent = this.ComDogruCevap;
            this.ComDogruCevap.Size = new System.Drawing.Size(188, 36);
            this.ComDogruCevap.TabIndex = 13;
            this.ComDogruCevap.TextChanged += new System.EventHandler(this.ComAltBaslik_TextChanged);
            // 
            // LblZorluk
            // 
            this.LblZorluk.AutoSize = true;
            this.LblZorluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblZorluk.Location = new System.Drawing.Point(18, 425);
            this.LblZorluk.Name = "LblZorluk";
            this.LblZorluk.Size = new System.Drawing.Size(94, 13);
            this.LblZorluk.TabIndex = 15;
            this.LblZorluk.Text = "Zorluk Seviyesi";
            // 
            // LblDogruCevap
            // 
            this.LblDogruCevap.AutoSize = true;
            this.LblDogruCevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDogruCevap.Location = new System.Drawing.Point(20, 490);
            this.LblDogruCevap.Name = "LblDogruCevap";
            this.LblDogruCevap.Size = new System.Drawing.Size(81, 13);
            this.LblDogruCevap.TabIndex = 16;
            this.LblDogruCevap.Text = "Doğru Cevap";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserOgretmenSoruEkme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnSoruOlustur);
            this.Controls.Add(this.PanelSozel);
            this.Controls.Add(this.LblDogruCevap);
            this.Controls.Add(this.LblAltKonu);
            this.Controls.Add(this.LblZorluk);
            this.Controls.Add(this.LblDers);
            this.Controls.Add(this.ComDogruCevap);
            this.Controls.Add(this.ComAltBaslik);
            this.Controls.Add(this.ComZorluk);
            this.Controls.Add(this.ComDers);
            this.Name = "UserOgretmenSoruEkme";
            this.Size = new System.Drawing.Size(796, 570);
            this.PanelSozel.ResumeLayout(false);
            this.PanelSozel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureResimSoru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureResimCevap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CevapResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoruResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAltKonu;
        private System.Windows.Forms.Label LblDers;
        private Guna.UI2.WinForms.Guna2ComboBox ComAltBaslik;
        private Guna.UI2.WinForms.Guna2ComboBox ComDers;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel PanelSozel;
        private System.Windows.Forms.PictureBox PictureResimSoru;
        private System.Windows.Forms.PictureBox PictureResimCevap;
        private System.Windows.Forms.Label LblCevap;
        private System.Windows.Forms.Label LblSoru;
        private System.Windows.Forms.PictureBox CevapResim;
        private System.Windows.Forms.PictureBox SoruResim;
        private System.Windows.Forms.Button BtnSoruOlustur;
        private Guna.UI2.WinForms.Guna2ComboBox ComZorluk;
        private Guna.UI2.WinForms.Guna2ComboBox ComDogruCevap;
        private System.Windows.Forms.Label LblZorluk;
        private System.Windows.Forms.Label LblDogruCevap;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
