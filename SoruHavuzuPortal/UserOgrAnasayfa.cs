using System;
using Guna.UI2.WinForms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SoruHavuzuPortal
{
    public partial class UserOgrAnasayfa : UserControl
    {
        public bool izin = true;

        public UserOgrAnasayfa()
        {
            InitializeComponent();
        }

        public string DersAd = string.Empty;

        readonly UyarıClass uyarıClass = new UyarıClass();
        readonly DataBaseIslem dataBaseIslem = new DataBaseIslem();


        private void CheckBoxBio_Click(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = (Guna2CheckBox)sender;
            ChechBoxControl(PanelSayisal, checkBox);
            ChechBoxControl(PanelSozel, checkBox);
            DersAd = checkBox.Text;
            ComAltBaslik.Items.Clear();
            dataBaseIslem.ComboBoxVeriCekme(checkBox.Text, ComAltBaslik);
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
            }
            else if (ComZorluk.Text != string.Empty) 
            {
                LblZorluk.SendToBack();
            }
            else
            {
                if(ComAltBaslik.Text==string.Empty)
                {
                    ErrorFlash(ComAltBaslik, "Lütfen bir altbaşlık  seçiniz");
                }
                if (ComZorluk.Text == string.Empty)
                {
                    ErrorFlash(ComZorluk, "Lütfen zorluk seviyesi seçiniz"); 
                }
                LblAltKonu.BringToFront();
                LblZorluk.BringToFront();
            }
        }

        private void BtnSoruOlustur_Click(object sender, EventArgs e)
        {
            CmbControl();

            if (DersAd != string.Empty)
            {
                if (ComAltBaslik.Text != string.Empty || ComZorluk.Text != string.Empty || DersAd != string.Empty)
                {
                    FrmSoruOlustur frmSoruOlustur = new FrmSoruOlustur();
                    frmSoruOlustur.SoruOlustur(ComZorluk.Text, DersAd, ComAltBaslik.Text);
                    this.Hide();
                    frmSoruOlustur.Show();
                    
                    uyarıClass.Alert("Soru Kağıdınız Oluşturuldu", BildirimForms.EnmType.Success);
                }
                else
                {
                    uyarıClass.Alert("Lütfen Tüm Alanları Doldurunuz", BildirimForms.EnmType.Warning);
                } 
            }

            else
            {
                uyarıClass.Alert("Lütfen Bir Ders Seçimi Yapınız", BildirimForms.EnmType.Warning);
            }
        }

        private void ComZorluk_TextChanged(object sender, EventArgs e)
        {
            CmbControl();
        }

        private void UserOgrAnasayfa_Load(object sender, EventArgs e)
        {
            //cozuzlecek sorular çekiliyor
            dataBaseIslem.CozulucekSoruCek();
            LblMat.Text = dataBaseIslem.Mat;
            LblGeo.Text = dataBaseIslem.Geo;
            LblFiz.Text = dataBaseIslem.Fiz;
            LblKim.Text = dataBaseIslem.Kim;
            LblBio.Text = dataBaseIslem.Bio;
            LblEde.Text = dataBaseIslem.Edeb;
            LblTar.Text = dataBaseIslem.Tar;
            LblFelse.Text = dataBaseIslem.Fel;
            LblCog.Text = dataBaseIslem.Cog;
            LblDil.Text = dataBaseIslem.DilAn;
            dataBaseIslem.OneriKonuCek();
            //öneri konu çekiliyor
            LblCalskonu.Text = dataBaseIslem.Kon1;
            LblCalskonu1.Text = dataBaseIslem.Kon2;
            LblCalskonu2.Text = dataBaseIslem.Kon3;
            LblCalskonu3.Text = dataBaseIslem.Kon4;
            LblCalskonu4.Text = dataBaseIslem.Kon5;
            LblCalskonu5.Text = dataBaseIslem.Kon6;
        }
    }
}
