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
    public partial class UserOgrSinav : UserControl
    {
        public UserOgrSinav()
        {
            InitializeComponent();
        }

        readonly DataBaseIslem dataBaseIslem = new DataBaseIslem();
        readonly UyarıClass uyarıClass = new UyarıClass();
        private int i = 0;
        private int dakika = 1;
        private int saniye = 60;
        private int DogruSayisi = 0;
        private int YanlisSayisi = 0;
        private string CevapSecenegi = string.Empty;
        private string DogruCevapSecenegi = string.Empty;

        private void UserOgrSinav_Load(object sender, EventArgs e)
        {

        }

        private void TmrSinavSure_Tick(object sender, EventArgs e)
        {
            TmrSinavSure.Interval = 1000;//bir dakkika =1000
            saniye -= 1;
            LblSaniye.Text = saniye.ToString();
            Lbldakika.Text = (dakika - 1).ToString();
            if (saniye == 0)
            {
                dakika -= 1;
                Lbldakika.Text = dakika.ToString();
                saniye = 60;
            }
            if (Lbldakika.Text == "-1")
            {
                TmrSinavSure.Stop();
                Lbldakika.Text = "00";
                LblSaniye.Text = "00";
                GrubSonuc.Visible = true;
                PanelSoru.Visible = false;
                GrubBilgilendirme.Visible = false;
                pictureBox1.Image = null;
                GrubSoruPanel.BringToFront();
                LblDogru.Text = DogruSayisi.ToString();
                LblYanlıs.Text = YanlisSayisi.ToString();
                uyarıClass.Alert("      Sınavınız Bitmiştir", BildirimForms.EnmType.Warning);
            }
        }

        private void ChechBoxControl(Panel panel, Guna2CheckBox checkBox)
        {
            foreach (Control item in panel.Controls)
            {
                if (item is Guna2CheckBox box)
                {
                    if (checkBox.Name != item.Name)
                    {
                        box.Checked = false;
                    }
                }
            }
        }
        private void ChechBoxBosatma()
        {
            foreach (Control item in PanelSoru.Controls)
            {
                if (item is Guna2CheckBox box)
                {
                    if (box.Checked)
                    {
                        box.Checked = false; 
                    }
                }
            }
        }

        private void DogrusayiControl(string Cevap)
        {
            if (i != dataBaseIslem.Cevap.Count)
            {
                MessageBox.Show(DogruCevapSecenegi + "   " + "    " + Cevap);
                if (DogruCevapSecenegi == Cevap)
                {
                    DogruSayisi++;
                }
                else
                {
                    YanlisSayisi++;
                } 
            }
        }

        private void SoruCek()
        {
            //SoruHavuzuPortal degistiriyoruz
            pictureBox1.Image = dataBaseIslem.sor.Images[i];
            DogruCevapSecenegi = dataBaseIslem.Cevap[i];
        }

        private void BtnSoruIleri_Click(object sender, EventArgs e)
        {
            if (i != dataBaseIslem.sor.Images.Count)
            {
                DogrusayiControl(CevapSecenegi);
                SoruCek();
                ChechBoxBosatma();
            }
            else
            {
                uyarıClass.Alert("                 Son Sorudasınız", BildirimForms.EnmType.Warning);
            }
            i++;
        }

        private void CheckBoxA_Click(object sender, EventArgs e)
        {
            //soru sayısının bitiğini kontrol ediyoruz
            if (i == dataBaseIslem.sor.Images.Count)
            {
                GrubSonuc.Visible = true;
                PanelSoru.Visible = false;
                GrubBilgilendirme.Visible = false;
                pictureBox1.Image = null;
                GrubSoruPanel.BringToFront();
                LblDogru.Text = DogruSayisi.ToString();
                LblYanlıs.Text = YanlisSayisi.ToString();
            }
            else
            {
                Guna2CheckBox checkBox = (Guna2CheckBox)sender;
                CevapSecenegi = checkBox.Text;
                ChechBoxControl(PanelSoru, checkBox);
            }
        }

        private void CheckBoxEdeb_Click(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            dataBaseIslem.SınavSorusu(checkBox.Text);
            GrubBilgilendirme.Visible = false; 
            GrubSonuc.Visible = true;
            GrubSoruPanel.Visible = true;
            PanelSoru.BringToFront();
            SoruCek();
            checkBox.Checked = false;
            TmrSinavSure.Start();
        }

        private void BtnSinavBitir_Click(object sender, EventArgs e)
        {
            GrubBilgilendirme.Visible = true;
            GrubSonuc.Visible = false;
            GrubSoruPanel.Visible = false;
            GrubSoruPanel.BringToFront();
            GrubBilgilendirme.BringToFront();
            uyarıClass.Alert("      Sınavınız Bitmiştir", BildirimForms.EnmType.Warning);
            TmrSinavSure.Stop();
        }
    }
}
