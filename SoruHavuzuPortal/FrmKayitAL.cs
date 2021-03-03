using DevExpress.Data.Mask;
using DevExpress.Utils.Serializing;
using DevExpress.XtraExport.Helpers;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruHavuzuPortal
{
    public partial class FrmKayitAL : Form
    {
        public FrmKayitAL()
        {
            InitializeComponent();
        }

        readonly Watermark watermark = new Watermark();
        readonly UyarıClass uyarıClass = new UyarıClass();
        readonly DataBaseIslem baseIslem = new DataBaseIslem();
        readonly ForeColorcontrol txtIslem = new ForeColorcontrol();

        private bool IzinSifre = false;
        private bool IzinTc = false;
        private bool IzinEmail = false;
        private bool IzinTekrarSifre = false;

        private void FrmKayitAL_Load(object sender, EventArgs e)
        {
            //textbox gölgeli yazı kontrol
            watermark.ForDongu(GrbBilgiler);
        }
        
        private void PictureExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBack_Click(object sender, EventArgs e)
        {
            FrmGiris frmGiris = new FrmGiris();
            frmGiris.Show();
            this.Hide();
        }

        private void TxtTc_Enter(object sender, EventArgs e)
        {
            watermark.TexboxGiris(sender);
        }

        private void TxtTc_Leave(object sender, EventArgs e)
        {
            GunaLineTextBox textBox = (GunaLineTextBox)sender;
            watermark.TexboxCikis(textBox.Tag.ToString(), textBox);

            //sifre uzunluk kontrol
            if (textBox.Name == TxtSifre.Name)
            {
                if(!txtIslem.TxtKontorIslemi(textBox))
                {
                    ErrorFlash(textBox, txtIslem.msj);
                    IzinSifre = false;
                }
                else
                {
                    ErrorFlash(textBox, string.Empty);
                    IzinSifre = true;
                }
            }

            //email kontrol
            if (textBox.Name == TxtGmail.Name)
            {
                if(!txtIslem.TxtKontorIslemi(textBox))
                {
                    ErrorFlash(textBox, txtIslem.msj);
                    IzinEmail = false;
                }
                else
                {
                    ErrorFlash(textBox, txtIslem.msj);
                    IzinEmail = true;
                }
            }

            //tc kontrol
            if (textBox.Name == TxtTc.Name)
            {
                if(!txtIslem.TxtKontorIslemi(textBox))
                {
                    ErrorFlash(textBox, txtIslem.msj);
                    IzinTc = false;
                }
                else
                {
                    ErrorFlash(textBox, txtIslem.msj);
                    IzinTc = true;
                }
            }

            //şifre bezerlik kontorol
            if (textBox.Name == TxtSifreTekrar.Name)
            {
                if(!txtIslem.SifreBenzerlik(TxtSifre,textBox))
                {
                    ErrorFlash(textBox, "Şifreler Uyuşmuyor!");
                    IzinTekrarSifre = false;
                }

                else
                {
                    ErrorFlash(textBox, string.Empty);
                    IzinTekrarSifre = true;
                }
            }

            if (textBox.Name == TxtKulAdSoyad.Name || textBox.Name == TxtGizliSoruCevap.Name || textBox.Name==TxtSifreTekrar.Name)
            {
                if (!txtIslem.TxtKontorIslemi(textBox))
                {
                    ErrorFlash(textBox, "Bu alan boş olamaz!");
                }
                else
                {
                    ErrorFlash(textBox, string.Empty);
                }
            }
        }

        public void CmbKontrol()
        {
            if (CmbGizliSoru.Text==string.Empty)
            {
                TxtGizli.BringToFront();
                ErrorFlash(CmbGizliSoru, "Bu alan boş olamaz!");
            }
            else
            {
                TxtGizli.SendToBack();
                ErrorFlash(CmbGizliSoru, string.Empty);
            }
        }

        private void CmbGizliSoru_TextChanged(object sender, EventArgs e)
        {
            CmbKontrol();
        }

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            CmbKontrol();
            
            foreach (Control item in GrbBilgiler.Controls)
            {
                if (item is GunaLineTextBox box)
                {
                    txtIslem.TxtKontorIslemi(box);
                    ErrorFlash(item,txtIslem.msj);
                }
            }

            if (!IzinTc || !IzinEmail || !IzinSifre  || !IzinTekrarSifre || CmbGizliSoru.Text == string.Empty || !(txtIslem.TxtBosluk(TxtKulAdSoyad,TxtGizliSoruCevap)))  
            {
                if (TxtSifre.Text != TxtSifreTekrar.Text && TxtSifreTekrar.ForeColor != Color.DarkGray && TxtSifre.ForeColor != Color.DarkGray)   
                {
                    uyarıClass.Alert("    Şifreler uyuşmuyor", BildirimForms.EnmType.Warning);
                    ErrorFlash(TxtSifreTekrar, "Şifreler Uyuşmuyor!");
                }
                else
                {
                    uyarıClass.Alert("Lütfen tüm alanları doldurunuz", BildirimForms.EnmType.Warning); 
                }
            }
            //kayıt işlemi
            else
            {
                if (baseIslem.TcVarlikKontrol(TxtTc.Text))
                {
                    baseIslem.Kayitol(TxtTc.Text, TxtSifre.Text, CmbGizliSoru.Text, TxtGizliSoruCevap.Text, TxtGmail.Text, TxtKulAdSoyad.Text, "Ogr");
                    uyarıClass.Alert("   Kayıt başarılı ile tamamlandı", BildirimForms.EnmType.Success); 
                }

                else
                {
                    uyarıClass.Alert("T.C. kimlik numarasına ait kayıt var", BildirimForms.EnmType.Error);
                }
                //textboxBoşaltma
                watermark.ForDongu(GrbBilgiler);
            }
        }
        //sadece rakam
        private void TxtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!txtIslem.SadeceRakkam(e))
            {
                ErrorFlash(sender, "T.C. Kimlik Numarası Sadece Rakamdan Oluşur!");
            }
            else
            {
                ErrorFlash(sender, string.Empty);
            }
        }

        private void ErrorFlash(object Yer,string msj)
        {
            Control control = (Control)Yer;
            errorProvider1.SetError(control, msj);
        }

        //sadece harf
        private void TxtKulAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtIslem.OzelRakamEngelle(e))
            {
                ErrorFlash(sender, "Adınız ve Soyadınız sadece 'HARF'TEN  oluşmalıdır!");
            }
            else
            {
                ErrorFlash(sender, string.Empty);
            }
        }

        private void CmbGizliSoru_Click(object sender, EventArgs e)
        {
            CmbKontrol();
        }

        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {
            watermark.SifreGizle(TxtSifre, PBoxSifreGoster);
            watermark.SifreGizle(TxtSifreTekrar, PBoxSifreGoster);
        }

        private void PBoxSifreGoster_MouseEnter(object sender, EventArgs e)
        {
            watermark.SifreGöster(TxtSifre, PBoxSifreGoster);
            watermark.SifreGöster(TxtSifreTekrar, PBoxSifreGoster);
        }

        private void PBoxSifreGoster_MouseLeave(object sender, EventArgs e)
        {
            watermark.SifreGizle(TxtSifre, PBoxSifreGoster);
            watermark.SifreGizle(TxtSifreTekrar, PBoxSifreGoster);
        }
    }
}
