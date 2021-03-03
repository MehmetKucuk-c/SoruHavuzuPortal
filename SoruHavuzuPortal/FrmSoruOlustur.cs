using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruHavuzuPortal
{
    public partial class FrmSoruOlustur : Form
    {
        public FrmSoruOlustur()
        {
            InitializeComponent();
        }

        public ImageList sor = new ImageList();
        public ImageList cevap = new ImageList();
        readonly FrmOgr frmOgr = new FrmOgr();
        readonly UyarıClass uyarıClass = new UyarıClass();
        readonly DataBase db = new DataBase();
        readonly DataBaseIslem dataBaseIslem = new DataBaseIslem();

        private void PictureExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBack_Click(object sender, EventArgs e)
        {

            frmOgr.Show();
            this.Hide();
        }

        public void SoruOlustur(string zorluk_seviye, string ders, string Altkonu)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                sor.ImageSize = new Size(256, 190);
                sor.ColorDepth = ColorDepth.Depth32Bit;
                cevap.ImageSize = new Size(256, 190);
                cevap.ColorDepth = ColorDepth.Depth32Bit;
                db.baglanti.Open();
                // not burayı kullanıcı giricek
                for (int i = 0; i < 20; i++)
                {
                    // resimleri çekiyoruz
                    SqlCommand listele = new SqlCommand("SELECT TOP 1 * FROM ResimliSorular where Zorluk=@Zorluk and Konu=@Konu and AltBaslık=@AltBaslık  ORDER BY NEWID() ", db.baglanti);
                    listele.Parameters.AddWithValue("@Zorluk", zorluk_seviye.ToString());
                    listele.Parameters.AddWithValue("@Konu", ders.ToString());
                    listele.Parameters.AddWithValue("@AltBaslık", Altkonu.ToString());
                    SqlDataReader ListeOku = listele.ExecuteReader();
                    while (ListeOku.Read())
                    {
                        byte[] ResimliSorular = (byte[])ListeOku[1];//1. indise soru 2. indise cevap kayıt oluyor
                        MemoryStream ms = new MemoryStream();
                        ms.Write(ResimliSorular, 0, ResimliSorular.Length);
                        sor.Images.Add(Image.FromStream(ms));
                        //
                        byte[] ResimliCevap = (byte[])ListeOku[2];
                        MemoryStream mc = new MemoryStream();
                        mc.Write(ResimliCevap, 0, ResimliCevap.Length);
                        cevap.Images.Add(Image.FromStream(mc));
                    }
                }
                
                //Resimleri pictureBox yazıdırıyorum
                int x = 20;
                int y = 20;
                int maxHeight = -1;
                for (int j = 0; j < 20; j++)
                {
                    PictureBox pic = new PictureBox
                    {
                        Image = sor.Images[j],
                        Location = new Point(x - 20, y - 20),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Size = new Size(197, 195)
                    };
                    x += pic.Width + 1;
                    maxHeight = Math.Max(pic.Height, maxHeight);
                    if (x > this.ClientSize.Width - 185)
                    {
                        x = 20;
                        y += maxHeight + 1;
                    }
                    this.PictureSoru.Controls.Add(pic);
                }

                //cevaplarıyazdırıyorum
                int xx = 20;
                int yy = 20;
                int maxHeightc = -1;
                for (int k = 0; k < 20; k++)
                {
                    PictureBox picCevap = new PictureBox
                    {
                        Image = cevap.Images[k],
                        Location = new Point(xx - 20, yy - 20),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Size = new Size(256, 185)
                    };

                    xx += picCevap.Width + 1;
                    maxHeightc = Math.Max(picCevap.Height, maxHeightc);
                    if (xx > this.ClientSize.Width - 185)
                    {
                        xx = 20;
                        yy += maxHeightc + 1;
                    }
                    this.PictureCevap.Controls.Add(picCevap);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("" + hata);
            }
            finally
            {
                db.baglanti.Close();
            }
        }
        //yazdırma işleme 
        private void BtnYazıdr_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            doc.DocumentName = "Sorular";
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
                CevapYaz.BringToFront();
                PictureCevap.BringToFront();
                uyarıClass.Alert("Sorularınız başarlıyla kayıt edildi", BildirimForms.EnmType.Success);
                dataBaseIslem.SorulariGuncelle(20);
            }
        }
        //yazdırma işleme 
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(PictureSoru.Width, PictureSoru.Height);
            PictureSoru.DrawToBitmap(bm, new Rectangle(0, 0, PictureSoru.Width, PictureSoru.Height));
            e.Graphics.DrawImage(bm, 10, 10);
            bm.Dispose();
        }

        private void CevapYaz_Click(object sender, EventArgs e)
        {
            PrintDialog pc = new PrintDialog();
            PrintDocument docCevap = new PrintDocument();
            docCevap.PrintPage += DocCevap_PrintPage;
            docCevap.DocumentName = "Cevap Anahtarı";
            pc.Document = docCevap;
            if (pc.ShowDialog() == DialogResult.OK)
            {
                docCevap.Print();
                PictureSoru.BringToFront();
                BtnYazıdr.BringToFront();
                frmOgr.Show();
                this.Hide();
                uyarıClass.Alert("Cevaplarınız başarlıyla kayıt edildi", BildirimForms.EnmType.Success);
            }
        }

        private void DocCevap_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bc = new Bitmap(PictureCevap.Width, PictureCevap.Height);
            PictureCevap.DrawToBitmap(bc, new Rectangle(0, 0, PictureCevap.Width, PictureCevap.Height));
            e.Graphics.DrawImage(bc, 10, 10);
            bc.Dispose();
        }
    }
}
