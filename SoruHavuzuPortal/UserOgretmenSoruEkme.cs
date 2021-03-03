using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace SoruHavuzuPortal
{
    public partial class UserOgretmenSoruEkme : UserControl
    {
        public UserOgretmenSoruEkme()
        {
            InitializeComponent();
        }

        protected string resimPath = string.Empty;
        protected string cevapResimPath = string.Empty;
        readonly UyarıClass uyarıClass = new UyarıClass();
        readonly DataBaseIslem dataBaseIslem = new DataBaseIslem();

        readonly OpenFileDialog ResimCek = new OpenFileDialog
        {
            Title = "Yüklemek İstediğiniz Resmi Seçiniz",
            Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Png Dosyası(*.png)|*.png"
        };

        private void PuctureREsimCEk_Click(object sender, EventArgs e)
        {
            if (ResimCek.ShowDialog() == DialogResult.OK)
            {
                SoruResim.Image = Image.FromFile(ResimCek.FileName);
                resimPath = ResimCek.FileName.ToString();
            }
        }

        private void LblCevap_Click(object sender, EventArgs e)
        {
            if (ResimCek.ShowDialog() == DialogResult.OK) 
            {
                CevapResim.Image = Image.FromFile(ResimCek.FileName);
                cevapResimPath = ResimCek.FileName.ToString(); 
            }
        }

        private void BtnSoruOlustur_Click(object sender, EventArgs e)
        {
            CmbControl();

            if (CevapResim.Image == null)
            {
                if (SoruResim.Image == null)
                {
                    if (ComAltBaslik.Text != string.Empty || ComZorluk.Text != string.Empty || ComDers.Text != string.Empty || ComDogruCevap.Text != string.Empty) 
                    {
                        dataBaseIslem.SoruEkle(resimPath, cevapResimPath, ComDers.Text, ComAltBaslik.Text, ComZorluk.Text, ComDers.Text);
                        uyarıClass.Alert("Soru Kağıdınız Oluşturuldu", BildirimForms.EnmType.Success);
                    }
                    else
                    {
                        uyarıClass.Alert("Lütfen Tüm Alanları Doldurunuz", BildirimForms.EnmType.Warning);
                    } 
                }
                else
                {
                    uyarıClass.Alert("Lütfen Bir Cevap Seçimi Yapınız", BildirimForms.EnmType.Warning);
                }
            }

            else
            {
                uyarıClass.Alert("Lütfen Bir Soru Seçimi Yapınız", BildirimForms.EnmType.Warning);
            }

        }

        private void ErrorFlash(object Yer, string msj)
        {
            Control control = (Control)Yer;
            errorProvider1.SetError(control, msj);
        }

        private void CmbControl()
        {
            if (ComAltBaslik.Text != string.Empty)
            {
                LblAltKonu.SendToBack();
                ErrorFlash(ComAltBaslik, string.Empty);
            }
            if (ComZorluk.Text != string.Empty)
            {
                LblZorluk.SendToBack();
                ErrorFlash(ComZorluk, string.Empty);
            }
            if (ComDers.Text != string.Empty)
            {
                LblDers.SendToBack();
                ErrorFlash(ComDers, string.Empty);
            }
            if (ComDogruCevap.Text != string.Empty)
            {
                LblDogruCevap.SendToBack();
                ErrorFlash(ComDogruCevap,string.Empty);
            }
            if(ComAltBaslik.Text==string.Empty || ComDers.Text==string.Empty || ComDogruCevap.Text==string.Empty || ComZorluk.Text==string.Empty)
            {
                if (ComAltBaslik.Text == string.Empty)
                {
                    ErrorFlash(ComAltBaslik, "Lütfen Bir Altbaşlık  Seçiniz");
                    LblAltKonu.BringToFront();
                }
                if (ComZorluk.Text == string.Empty)
                {
                    ErrorFlash(ComZorluk, "Lütfen Zorluk Seviyesi Seçiniz");
                    LblZorluk.BringToFront();
                }
                if (ComDers.Text == string.Empty)
                {
                    ErrorFlash(ComDers, "Lütfen Bir Ders seçiniz");
                    LblDers.BringToFront();
                }
                if(ComDogruCevap.Text==string.Empty)
                {
                    ErrorFlash(ComDogruCevap, "Lütfen Doğru Cevabı Seçiniz");
                    LblDogruCevap.BringToFront();
                }
            }
        }

        private void ComDers_TextChanged(object sender, EventArgs e)
        {
            ComAltBaslik.Items.Clear();
            dataBaseIslem.ComboBoxVeriCekme(ComDers.Text, ComAltBaslik);
            CmbControl();
        }

        private void ComAltBaslik_TextChanged(object sender, EventArgs e)
        {
            CmbControl();
        }
    }
}
