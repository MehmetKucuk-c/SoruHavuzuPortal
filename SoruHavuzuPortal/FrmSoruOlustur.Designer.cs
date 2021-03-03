namespace SoruHavuzuPortal
{
    partial class FrmSoruOlustur
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
            this.BtnYazıdr = new System.Windows.Forms.Button();
            this.PictureSoru = new System.Windows.Forms.PictureBox();
            this.PictureCevap = new System.Windows.Forms.PictureBox();
            this.PictureBack = new System.Windows.Forms.PictureBox();
            this.PictureExit = new System.Windows.Forms.PictureBox();
            this.CevapYaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSoru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCevap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureExit)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnYazıdr
            // 
            this.BtnYazıdr.BackColor = System.Drawing.Color.Green;
            this.BtnYazıdr.Location = new System.Drawing.Point(1, 0);
            this.BtnYazıdr.Name = "BtnYazıdr";
            this.BtnYazıdr.Size = new System.Drawing.Size(75, 23);
            this.BtnYazıdr.TabIndex = 2;
            this.BtnYazıdr.Text = "Kaydet";
            this.BtnYazıdr.UseVisualStyleBackColor = false;
            this.BtnYazıdr.Click += new System.EventHandler(this.BtnYazıdr_Click);
            // 
            // PictureSoru
            // 
            this.PictureSoru.BackColor = System.Drawing.Color.White;
            this.PictureSoru.Location = new System.Drawing.Point(1, 29);
            this.PictureSoru.Name = "PictureSoru";
            this.PictureSoru.Size = new System.Drawing.Size(795, 1084);
            this.PictureSoru.TabIndex = 0;
            this.PictureSoru.TabStop = false;
            // 
            // PictureCevap
            // 
            this.PictureCevap.BackColor = System.Drawing.Color.White;
            this.PictureCevap.Location = new System.Drawing.Point(1, 29);
            this.PictureCevap.Name = "PictureCevap";
            this.PictureCevap.Size = new System.Drawing.Size(795, 1084);
            this.PictureCevap.TabIndex = 0;
            this.PictureCevap.TabStop = false;
            // 
            // PictureBack
            // 
            this.PictureBack.Image = global::SoruHavuzuPortal.Properties.Resources.icons8_go_back_64px_3;
            this.PictureBack.Location = new System.Drawing.Point(737, 0);
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
            this.PictureExit.Location = new System.Drawing.Point(766, 0);
            this.PictureExit.Name = "PictureExit";
            this.PictureExit.Size = new System.Drawing.Size(30, 30);
            this.PictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureExit.TabIndex = 11;
            this.PictureExit.TabStop = false;
            this.PictureExit.Click += new System.EventHandler(this.PictureExit_Click);
            // 
            // CevapYaz
            // 
            this.CevapYaz.BackColor = System.Drawing.Color.Yellow;
            this.CevapYaz.Location = new System.Drawing.Point(1, 0);
            this.CevapYaz.Name = "CevapYaz";
            this.CevapYaz.Size = new System.Drawing.Size(75, 23);
            this.CevapYaz.TabIndex = 12;
            this.CevapYaz.Text = "Cevaplar";
            this.CevapYaz.UseVisualStyleBackColor = false;
            this.CevapYaz.Click += new System.EventHandler(this.CevapYaz_Click);
            // 
            // FrmSoruOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 1084);
            this.Controls.Add(this.PictureBack);
            this.Controls.Add(this.PictureExit);
            this.Controls.Add(this.PictureSoru);
            this.Controls.Add(this.PictureCevap);
            this.Controls.Add(this.BtnYazıdr);
            this.Controls.Add(this.CevapYaz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSoruOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSoruOlustur";
            ((System.ComponentModel.ISupportInitialize)(this.PictureSoru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCevap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureSoru;
        private System.Windows.Forms.Button BtnYazıdr;
        private System.Windows.Forms.PictureBox PictureCevap;
        private System.Windows.Forms.PictureBox PictureBack;
        private System.Windows.Forms.PictureBox PictureExit;
        private System.Windows.Forms.Button CevapYaz;
    }
}