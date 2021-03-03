using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruHavuzuPortal
{
    class ForeColorcontrol
    {
        public Color color;
        private readonly Color soruAzRenk = Color.Red;
        private readonly Color normalSoruRenk = Color.FromArgb(64, 64, 64);
        private readonly Color iyiSoruRenk = Color.Green;
        public string Durum;
        public Point point;
        private int AylıkOrt=0;


        public string Bugun = string.Empty;
        public string Dun = string.Empty;
        public string Yil = string.Empty;
        public string Ay = string.Empty;
        readonly DateTime dateTime = DateTime.Today;

        public string msj = string.Empty; 
        private bool izin = false;

        public int Toplam = 0;

        public Color Control (int Sayi)
        {
            if (Sayi < 200)
            {
                color= soruAzRenk;
                
            }

            else if (Sayi <= 400 && 200 <= Sayi) 
            {
                color = normalSoruRenk;
            }

            else
            {
                color = iyiSoruRenk;
            }
            return color;
        }

        public Color HaftalikControl(int Sayi)
        {
            if (Sayi < 500)
            {
                color = soruAzRenk;
                Durum = "Zayıf";
                point = new Point(36, 66);
            }

            else if (500 <= Sayi && Sayi <= 550) 
            {
                color = normalSoruRenk;
                Durum = "Normal";
                point = new Point(23, 66);
            }

            else
            {
                color = iyiSoruRenk;
                Durum = "Çok İyi";
                point = new Point(26, 66);
            }
            return color;
        }

        public Color DenemeRenk(int Sayi)
        {
            if (Sayi < 7)
            {
                color = soruAzRenk;
            }
            else if (7 < Sayi && Sayi < 9)
            {
                color = normalSoruRenk;
            }
            else
            {
                color = iyiSoruRenk;
            }
            return color;
        }

        public int HaftalikYuzde(int Sayi)
        {
            AylıkOrt = (Sayi * 100) / 500;

            if (Sayi<50)
            {
                color = soruAzRenk;
            }

            else if(Sayi>=50 && Sayi<=60)
            {
                color = normalSoruRenk;
            }

            else
            {
                color = iyiSoruRenk;
            }

            return AylıkOrt;
        }

        public int AylıkYuzde(int Sayi)
        {
            AylıkOrt = (Sayi * 100) / 14000;

            if (AylıkOrt < 50)
            {
                color = soruAzRenk;
            }

            else if (AylıkOrt >= 50 && AylıkOrt <= 60)
            {
                color = normalSoruRenk;
            }

            else
            {
                color = iyiSoruRenk;
            }

            return AylıkOrt;
        }

        public string TarihIslemleri()
        {
            Yil = dateTime.Year.ToString();
            Bugun = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)DateTime.Now.DayOfWeek];
            Ay = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.MonthNames[(int)DateTime.Now.Month - 1];

            if (DateTime.Now.DayOfWeek.ToString()=="Sunday")
            {
                Dun = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[6];
            }

            else
            {
                Dun = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)DateTime.Now.DayOfWeek - 1]; 
            }

            return Ay;
        }

        public int GunYuzde(int Sayi)
        {

            AylıkOrt = (Sayi * 100) / 500;
            if (AylıkOrt < 50)
            {
                color = soruAzRenk;
            }

            else if (AylıkOrt >= 50 && AylıkOrt <= 60)
            {
                color = normalSoruRenk;
            }

            else
            {
                color = iyiSoruRenk;
            }

            Toplam += Sayi;
            return AylıkOrt; 
        }

        private static bool Email_Format_Kontrol(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SifreBenzerlik(GunaLineTextBox sifre, GunaLineTextBox sifreTekrar)
        {
            if (sifre.Text != sifreTekrar.Text)
            {
                izin = false;
            }

            else
            {
                izin = true;
            }
            return izin;
        }

        public bool TxtBosluk(GunaLineTextBox Kulad, GunaLineTextBox GizYanit)
        {
            if(Kulad.ForeColor==Color.DarkGray || GizYanit.ForeColor==Color.DarkGray)
            {
                izin = false;

            }
            else
            {
                izin = true;
            }
            return izin;
        }


        public bool TxtKontorIslemi(GunaLineTextBox textBox)
        {
            //sifre uzunluk kontrol
            if (textBox.Name == "TxtSifre")
            {
                if (textBox.ForeColor == Color.DarkGray)
                {
                    izin = false;
                    msj = "Bu alan boş olamaz!";
                }

                else if(textBox.Text.Length != 8)
                {
                    izin = false;
                    msj = "Şifre 8 Karakterden Oluşmalıdır!";

                }

                else
                {
                    izin = true;
                    msj = string.Empty;
                }
            }

            //email kontrol
            if (textBox.Name == "TxtGmail")
            {
                if (textBox.ForeColor == Color.DarkGray)
                {
                    izin = false;
                    msj = "Bu alan boş olamaz!";
                }

                else if (!Email_Format_Kontrol(textBox.Text)) 
                {
                    izin = false;
                    msj = "E-mailiniz Doğru Formatta Değil!";
                }

                else
                {
                    izin = true;
                    msj = string.Empty;
                }

            }

            //tc kontrol
            if (textBox.Name == "TxtTc")
            {
                if (textBox.ForeColor==Color.DarkGray)
                {
                    izin = false;
                    msj= "Bu alan boş olamaz!"; 
                }

                else if(textBox.Text.Length != 11)
                {
                    izin = false;
                    msj = "T.C Kimlik Numarası 11 Karekter Olmalıdır!";
                }

                else
                {
                    izin = true;
                    msj = string.Empty;
                }
            }

            if (textBox.Name == "TxtKulAdSoyad" || textBox.Name == "TxtGizliSoruCevap" || textBox.Name == "TxtSifreTekrar") 
            {
                if(textBox.ForeColor==Color.DarkGray)
                {
                    izin = false;
                    msj = "Bu alan boş olamaz!";
                }
                else
                {
                    izin = true;
                    msj = string.Empty;
                }
            }
            return izin;
        }

        public bool SadeceRakkam(KeyPressEventArgs e)
        {
            if(e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                izin = false;
            }

            else
            {
                izin = true;
            }
            return izin;
        }

        public bool OzelRakamEngelle(KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                izin = false;
            }

            else
            {
                izin = true;
            }
            return izin;
        }
    }
}
