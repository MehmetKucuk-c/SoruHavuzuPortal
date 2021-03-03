using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruHavuzuPortal
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        public string GirisTür = string.Empty;
        readonly DataBaseIslem baseIslem = new DataBaseIslem();
        readonly Watermark watermark = new Watermark();
        readonly UyarıClass uyarıClass = new UyarıClass();
        readonly GirisBilgiTut girisBilgi = GirisBilgiTut.GetInstance();

        public string BilgiTut { get; private set; }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            GrubGirisTürü.BringToFront();
            foreach (Control item in GrubKuLBilgiler.Controls)
            {
                if (item is GunaLineTextBox textBox)
                {
                    watermark.TexboxCikis(item.Tag.ToString(), textBox);
                }
            }
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            foreach (Control item in GrubKuLBilgiler.Controls)
            {
                if (item is GunaLineTextBox)
                {
                    if (item.ForeColor ==Color.DarkGray)
                    {
                        errorProvider1.SetError(item, "Bu alan boş olamaz!");
                    }
                }
            }

            if ((TxtSifre.ForeColor == Color.DarkGray) || (TxtTc.ForeColor == Color.DarkGray))
            {
                uyarıClass.Alert("Lütfen Tüm Alanları Doldurunuz", BildirimForms.EnmType.Warning);
            }
            else
            {
                if (TxtTc.Text.Length == 11)
                {
                    if (TxtSifre.Text.Length == 8)
                    {
                        if (baseIslem.GirisKontrol(TxtTc.Text, TxtSifre.Text, GirisTür))
                        {
                            if (GirisTür == "Ogr")
                            {
                                FrmOgr frmOgr = new FrmOgr();
                                frmOgr.Show();
                            }
                            else
                            {
                                FrmOgretmen frmOgretmen = new FrmOgretmen();
                                frmOgretmen.Show();
                            }
                            uyarıClass.Alert("Hoşgeldiniz, " + girisBilgi.IsimTut, BildirimForms.EnmType.Success);
                            this.Hide();
                        }
                        else
                        {
                            uyarıClass.Alert("Girdiğiniz Bilgiler Uyuşmamaktadır", BildirimForms.EnmType.Error);
                        }

                    }
                    else
                    {
                        errorProvider1.SetError(TxtSifre, "Şifre 8 karekterli olmalıdır!");
                    }
                }
                else
                {
                    errorProvider1.SetError(TxtTc, "T.C. Kimlik numarası 11 karekterli olmalıdır");
                } 
            }
        }

        private void BtnDegis_Click(object sender, EventArgs e)
        {
            if (CheckBoxOgr.Checked && CheckBoxOgrtmen.Checked || CheckBoxOgr.Checked == false && CheckBoxOgrtmen.Checked == false)
            {
                uyarıClass.Alert("              Giriş Türü Şeçiniz",BildirimForms.EnmType.Warning);
            }
            else
            {
                if (CheckBoxOgr.Checked == true)
                {
                    GirisTür = "Ogr";
                }
                else
                {
                    GirisTür = "Ogm";
                }
                if (CheckBoxOgr.Checked)
                {
                    CheckBoxOgr.CheckState = CheckState.Unchecked;
                }
                else
                {
                    CheckBoxOgrtmen.CheckState = CheckState.Unchecked;
                }
                GrubKuLBilgiler.BringToFront();
            }
        }

        private void ClosePicture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBack_Click(object sender, EventArgs e)
        {
            GrubGirisTürü.BringToFront();
        }

        private void TxtSifre_Enter(object sender, EventArgs e)
        {
            watermark.TexboxGiris(sender);
        }

        private void TxtSifre_Leave(object sender, EventArgs e)
        {
            GunaLineTextBox textBox = (GunaLineTextBox)sender;
            watermark.TexboxCikis(textBox.Tag.ToString(), textBox);
        }

        private void CheckBoxOgr_Click(object sender, EventArgs e)
        {
            CheckBoxOgrtmen.Checked = false;
        }

        private void CheckBoxOgrtmen_Click(object sender, EventArgs e)
        {
            CheckBoxOgr.Checked = false;
        }

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            FrmKayitAL frmKayitAL = new FrmKayitAL();
            frmKayitAL.Show();
            this.Hide();
        }

        private void BtnSifreUnttum_Click(object sender, EventArgs e)
        {
            FrmSifreYenile frmSifreYenile = new FrmSifreYenile();
            frmSifreYenile.Show();
            this.Hide();
        }

        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {
            watermark.SifreGizle(TxtSifre, PBoxSifreGoster);
        }

        private void PBoxSifreGoster_MouseEnter(object sender, EventArgs e)
        {
            watermark.SifreGöster(TxtSifre, PBoxSifreGoster);
        }

        private void PBoxSifreGoster_MouseLeave(object sender, EventArgs e)
        {
            watermark.SifreGizle(TxtSifre, PBoxSifreGoster);
        }
    }
}