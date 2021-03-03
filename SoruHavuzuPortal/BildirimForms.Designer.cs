namespace SoruHavuzuPortal
{
    partial class BildirimForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BildirimForms));
            this.LblMsg = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Picture_Kapatma = new System.Windows.Forms.PictureBox();
            this.Zamanlayici = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Kapatma)).BeginInit();
            this.SuspendLayout();
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMsg.Location = new System.Drawing.Point(67, 18);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(116, 21);
            this.LblMsg.TabIndex = 11;
            this.LblMsg.Text = "Message Text";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SoruHavuzuPortal.Properties.Resources.tick;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Picture_Kapatma
            // 
            this.Picture_Kapatma.Image = ((System.Drawing.Image)(resources.GetObject("Picture_Kapatma.Image")));
            this.Picture_Kapatma.Location = new System.Drawing.Point(347, 12);
            this.Picture_Kapatma.Name = "Picture_Kapatma";
            this.Picture_Kapatma.Size = new System.Drawing.Size(32, 32);
            this.Picture_Kapatma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_Kapatma.TabIndex = 12;
            this.Picture_Kapatma.TabStop = false;
            this.Picture_Kapatma.Click += new System.EventHandler(this.Picture_Kapatma_Click_1);
            // 
            // Zamanlayici
            // 
            this.Zamanlayici.Tick += new System.EventHandler(this.Zamanlayici_Tick);
            // 
            // BildirimForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(391, 58);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Picture_Kapatma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BildirimForms";
            this.Text = "BildirimForms";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Kapatma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Picture_Kapatma;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer Zamanlayici;
    }
}