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
using Guna.UI.WinForms;

namespace SoruHavuzuPortal
{
    public partial class UserSoruOner : UserControl
    {
        public UserSoruOner()
        {
            InitializeComponent();
        }

        readonly DataBaseIslem dataBaseIslem = new DataBaseIslem();
        readonly Watermark watermark = new Watermark();
        readonly UyarıClass UyarıClass = new UyarıClass();
        readonly ForeColorcontrol foreColorcontrol = new ForeColorcontrol();
        private int clickSay=0;
        private string clickTag = string.Empty;
        private string chechkTag = string.Empty;
        private Label labelAd;
        private bool izinOner = false;
        private bool izinDegis = false;
        private bool izinCheck = false;

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

        private void UserSoruOner_Load(object sender, EventArgs e)
        {
            clickSay = 0;
            watermark.TexboxCikis(TxtSoruSayi.Tag.ToString(), TxtSoruSayi);
            watermark.TexboxCikis(TxtSayiDegis.Tag.ToString(), TxtSayiDegis);
            PanelDegis.Visible = false;
        }

        private void CheckBoxMat_Click(object sender, EventArgs e)
        {
            izinCheck = true;
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            ChechBoxControl(PanelSayisal, checkBox);
            ChechBoxControl(PanelSozel, checkBox);
            ComAltBaslik.Items.Clear();
            LblAltKonu.BringToFront();
            chechkTag = checkBox.Text;
            dataBaseIslem.ComboBoxVeriCekme(checkBox.Text, ComAltBaslik);
            clickTag=checkBox.Tag.ToString();
        }

        private void BtnKonuOner_Click(object sender, EventArgs e)
        {
            if (izinCheck)
            {
                if (TxtSoruSayi.ForeColor == Color.DarkGray && ComAltBaslik.Text == string.Empty)
                {
                    UyarıClass.Alert("Lütfen Boş Alanları Doldurunuz", BildirimForms.EnmType.Warning);
                }
                else
                {
                    KonuOner();
                    if (izinDegis)
                    {
                        SoruSayisiDegis(clickTag, TxtSoruSayi.Text);
                        TxtSoruSayi.Text = string.Empty;
                        watermark.TexboxCikis(TxtSoruSayi.Tag.ToString(), TxtSoruSayi); 
                    }
                    izinDegis = false;
                    izinOner = false;
                } 
            }
            else
            {
                UyarıClass.Alert("Lütfen Bir Ders Seçiniz", BildirimForms.EnmType.Warning);
            }
        }

        private void ComAltBaslik_TextChanged(object sender, EventArgs e)
        {
            if (ComAltBaslik.Text != string.Empty)
            {
                LblAltKonu.SendToBack();
                izinOner = true;
            }
            else
            {
                LblAltKonu.BringToFront();
            }
        }

        private void TxtTc_Leave(object sender, EventArgs e)
        {

            GunaLineTextBox textBox = (GunaLineTextBox)sender;
            watermark.TexboxCikis(textBox.Tag.ToString(), textBox);
            BtnKonuOner.Text = "Konu Öner"; 
        }

        private void TxtTc_Enter(object sender, EventArgs e)
        {
            watermark.TexboxGiris(sender);
            BtnKonuOner.Text = "Soru Sayısı Ver";
        }

        private void KonuOner()
        {
            if (izinOner)
            {
                if (ComAltBaslik.Text != string.Empty)
                {

                    if (clickSay == 0)
                    {
                        LblCalskonu.Text = ComAltBaslik.Text;
                    }
                    else if (clickSay == 1)
                    {
                        LblCalskonu1.Text = ComAltBaslik.Text;
                    }
                    else if (clickSay == 2)
                    {
                        LblCalskonu2.Text = ComAltBaslik.Text;
                    }
                    else if (clickSay == 3)
                    {
                        LblCalskonu3.Text = ComAltBaslik.Text;
                    }
                    else if (clickSay == 4)
                    {
                        LblCalskonu4.Text = ComAltBaslik.Text;
                    }
                    else
                    {
                        LblCalskonu5.Text = ComAltBaslik.Text;
                        clickSay = 0;
                    }
                    clickSay++;
                }
                else
                {
                    UyarıClass.Alert("Alt Konu Boş İse Konu Önerilemez", BildirimForms.EnmType.Warning);
                } 
            }
        }

        private void SoruSayisiDegis(string SeciliDers, string sayi)
        {
            if (izinDegis)
            {
                foreach (Control item in GradelOnerilenler.Controls)
                {
                    if (item is Label box)
                    {
                        if (box.Tag != null)
                        {
                            if (box.Tag.ToString() == SeciliDers)
                            {
                                box.Text = sayi;
                            }
                        }
                    }
                } 
            }
        }

        private void PanelHareket()
        {
            PanelDegis.Visible = true;
            PanelDegis.Location = new Point(labelAd.Location.X + 500, labelAd.Location.Y + 40);
        }
        private void ComHareket()
        {
            if (chechkTag != string.Empty)
            {
                dataBaseIslem.ComboBoxVeriCekme(chechkTag, ComDegisAlt);
                ComDegisAlt.Visible = true;
                if (labelAd.Name != LblCalskonu5.Name)
                {
                    ComDegisAlt.Location = new Point(labelAd.Location.X + 550, labelAd.Location.Y + 385);
                }
                else
                {
                    ComDegisAlt.Location = new Point(labelAd.Location.X + 385, labelAd.Location.Y + 350);
                }
            }
            else
            {
                UyarıClass.Alert("Lütfen Bir Ders seçiniz", BildirimForms.EnmType.Warning);
            }
        }

        private void LblCog_Click(object sender, EventArgs e)
        {
            labelAd = (Label)sender;
            if (labelAd.Text!="0")
            {
                PanelHareket(); 
            }
        }

        private void BtnDegis_Click(object sender, EventArgs e)
        {
            if (TxtSayiDegis.Text != "Yeni Soru Sayisi") 
            {
                labelAd.Text = TxtSayiDegis.Text;
                PanelDegis.Visible = false;
            }
            else
            {
                UyarıClass.Alert("Lütfen Bir Sayi Giriniz", BildirimForms.EnmType.Warning);
            }
        }

        private void TxtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!foreColorcontrol.SadeceRakkam(e))
            {
                UyarıClass.Alert("Lütfen Sadece Rakam Giriniz", BildirimForms.EnmType.Warning);
            }
        }

        private void TxtSoruSayi_TextChanged(object sender, EventArgs e)
        {
            if (TxtSoruSayi.Text != "Soru Sayısı") 
            {
                izinDegis = true; 
            }
        }

        private void LblCalskonu_Click(object sender, EventArgs e)
        {
            labelAd = (Label)sender;
            ComHareket();
        }

        private void ComDegisAlt_TextChanged(object sender, EventArgs e)
        {
            ComDegisAlt.Visible = false;
            labelAd.Text = ComDegisAlt.Text;
            ComDegisAlt.Items.Clear();
        }

        private DialogResult dialogResult;

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            dialogResult = MessageBox.Show("Değişiklikleri Kayıt Etmek İster Misiniz?","Soru Portalı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dialogResult==DialogResult.Yes)
            {
                dataBaseIslem.CozulecekSorGuncelle(LblMat.Text, LblGeo.Text, LblFiz.Text, LblKim.Text, LblBio.Text, LblEde.Text, LblTar.Text, LblFelse.Text, LblCog.Text, LblDil.Text);
                dataBaseIslem.OneriKonuGuncelle(LblCalskonu.Text, LblCalskonu1.Text, LblCalskonu2.Text, LblCalskonu3.Text, LblCalskonu4.Text, LblCalskonu5.Text);
                UyarıClass.Alert("Verileriniz Kayıt Edildilmiştir", BildirimForms.EnmType.Success);
            }
        }

        private void BtnRasgele_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            for (int i = 0; i < 10; i++)
            {
                int sayi = rastgele.Next(20, 60);
                if (i==0)
                {
                    LblMat.Text = sayi.ToString();
                }
                else if(i==1)
                {
                    LblGeo.Text = sayi.ToString();
                }
                else if (i == 2)
                {
                    LblFiz.Text = sayi.ToString();
                }
                else if (i == 3)
                {
                    LblKim.Text = sayi.ToString();
                }
                else if (i == 4)
                {
                    LblBio.Text = sayi.ToString();
                }
                else if (i == 5)
                {
                    LblEde.Text = sayi.ToString();
                }
                else if (i == 6)
                {
                    LblTar.Text = sayi.ToString();
                }
                else if (i == 7)
                {
                    LblDil.Text = sayi.ToString();
                }
                else if (i == 8)
                {
                    LblFelse.Text = sayi.ToString();
                }
                else
                {
                    LblCog.Text = sayi.ToString();
                }
            }
        }
    }
}
