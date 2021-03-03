using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruHavuzuPortal
{
    public partial class FrmSifreYenile : Form
    {
        public FrmSifreYenile()
        {
            InitializeComponent();
        }

        readonly Watermark watermark = new Watermark();
        readonly ForeColorcontrol txtIslem = new ForeColorcontrol();
        readonly UyarıClass uyarıClass = new UyarıClass();
        readonly DataBaseIslem dataBaseIslem = new DataBaseIslem();

        public bool IzinEmail = false;
        public bool IzinTc = false;
        public bool IzinTxt = false;
        public bool IzinCmb = false;

        private void PictureBack_Click(object sender, EventArgs e)
        {
            FrmGiris frmGiris = new FrmGiris();
            frmGiris.Show();
            this.Hide();
        }

        private void PictureExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmSifreYenile_Load(object sender, EventArgs e)
        {
            GrbSifreYenilemeSon.SendToBack();
            watermark.ForDongu(GrbSifreYenilemeSon);
            watermark.ForDongu(GbrSifreYenileme);
        }

        private void TxtTc_Enter(object sender, EventArgs e)
        {
            watermark.TexboxGiris(sender);
        }

        private void TxtTc_Leave(object sender, EventArgs e)
        {
            GunaLineTextBox textBox = (GunaLineTextBox)sender;
            watermark.TexboxCikis(textBox.Tag.ToString(), textBox);

            //mail kontrol
            if (textBox.Name == TxtGmail.Name)
            {
                if (!txtIslem.TxtKontorIslemi(textBox))
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
                if (!txtIslem.TxtKontorIslemi(textBox))
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

            //kontrol txt
            if (textBox.Name == TxtKulAdSoyad.Name || textBox.Name == TxtGizliSoruCevap.Name)
            {
                if (!txtIslem.TxtKontorIslemi(textBox))
                {
                    ErrorFlash(textBox, txtIslem.msj);
                    IzinTxt = false;
                }
                else
                {
                    IzinTxt = true;
                    ErrorFlash(textBox, string.Empty);
                }
            }

            if(textBox.Name==TxtSifre.Name || textBox.Name==TxtSifreTekrar.Name)
            {
                if (!txtIslem.TxtKontorIslemi(textBox))
                {
                    ErrorFlash(textBox, txtIslem.msj);
                }

                else
                {
                    ErrorFlash(textBox, string.Empty);
                }
            }
        }

        private void CmbGizliSoru_TextChanged(object sender, EventArgs e)
        {
            CmbKontrol();
        }

        private void CmbGizliSoru_Click(object sender, EventArgs e)
        {
            CmbKontrol();
        }

        private void BtnSifreYenile_Click(object sender, EventArgs e)
        {
            //kişi kontrol varmı diye
            if (BtnSifreYenile.Text== "İleri")
            {
                CmbKontrol();
                //hata verdirme
                foreach (Control item in GbrSifreYenileme.Controls)
                {
                    if (item is GunaLineTextBox)
                    {
                        txtIslem.TxtKontorIslemi((GunaLineTextBox)item);
                        ErrorFlash(item, txtIslem.msj);
                    }
                }

                if (!IzinEmail || !IzinTc || !IzinTxt || !IzinCmb)
                {
                    uyarıClass.Alert("Lütfen tüm alanları doldurunuz", BildirimForms.EnmType.Warning);
                }

                else
                {
                    if(dataBaseIslem.KayitKontrol(TxtTc.Text, TxtGmail.Text, CmbGizliSoru.Text, TxtGizliSoruCevap.Text, TxtKulAdSoyad.Text))
                    {
                        GrbSifreYenilemeSon.BringToFront();
                        BtnSifreYenile.Text = "Şifreyi Yenile";
                        CmbGizliSoru.Visible = false;
                    }
                    else
                    {
                        uyarıClass.Alert("Böyle bir Kullanıcı bulunamdı", BildirimForms.EnmType.Error);
                    }
                } 
            }
            //şifre güncelleme 
            else
            {
                //hata verdirme
                foreach (Control item in GrbSifreYenilemeSon.Controls)
                {
                    if (item is GunaLineTextBox box)
                    {
                        txtIslem.TxtKontorIslemi(box);
                        ErrorFlash(item, txtIslem.msj);
                    }
                }

                if (TxtSifre.Text.Length == 8) 
                {
                    if (TxtSifre.Text == TxtSifreTekrar.Text)
                    {
                        dataBaseIslem.SifreGüncelle(TxtSifre.Text);
                        GrbSifreYenilemeSon.SendToBack();
                        uyarıClass.Alert("Şifre Güncellenmiştir", BildirimForms.EnmType.Success);
                        BtnSifreYenile.Text = "İleri";
                        CmbGizliSoru.Visible = true;
                        //txt boşatma
                        watermark.ForDongu(GbrSifreYenileme);
                        watermark.ForDongu(GrbSifreYenilemeSon);
                    }
                    else
                    {
                        uyarıClass.Alert("    Şifreler uyuşmuyor", BildirimForms.EnmType.Warning);
                        ErrorFlash(TxtSifreTekrar, "Şifreler Uyuşmuyor!");
                    }
                }

                else
                {
                    uyarıClass.Alert("Şifre 8 Karakterden Oluşmalıdır!", BildirimForms.EnmType.Warning);
                    ErrorFlash(TxtSifre, "Şifre 8 Karakterden Oluşmalıdır!");
                }
            }
        }

        private void ErrorFlash(object Yer, string msj)
        {
            Control control = (Control)Yer;
            errorProvider1.SetError(control, msj);
        }

        //combo box kontorl
        private void CmbKontrol()
        {
            if (CmbGizliSoru.Text == string.Empty)
            {
                TxtGizli.BringToFront();
                ErrorFlash(CmbGizliSoru, "Bu alan boş olamaz!");
                IzinCmb = false;
            }
            else
            {
                TxtGizli.SendToBack();
                ErrorFlash(CmbGizliSoru, string.Empty);
                IzinCmb = true;
            }
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

        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {
            watermark.SifreGizle(TxtSifre, PBoxSifreGoster);
            watermark.SifreGizle(TxtSifreTekrar, PBoxSifreGoster);
        }
    }
}
