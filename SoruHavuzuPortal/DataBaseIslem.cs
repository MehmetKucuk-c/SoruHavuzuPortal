using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruHavuzuPortal
{
    class DataBaseIslem
    {
        public int PztSoruSayi = 0;
        public int SalSoruSayi = 0;
        public int CrsSoruSayi = 0;
        public int PrsSoruSayi = 0;
        public int CumSoruSayi = 0;
        public int CmtSoruSayi = 0;
        public int PazSoruSayi = 0;
        public int DenmeSayi = 0;
        public int AylıkCözülenSoru = 0;
        /// 
        /// 
        /// 
        public string Mat = string.Empty;
        public string Geo = string.Empty;
        public string Fiz = string.Empty;
        public string Kim = string.Empty;
        public string Bio = string.Empty;
        public string Edeb = string.Empty;
        public string Cog = string.Empty;
        public string Tar = string.Empty;
        public string Fel = string.Empty;
        public string DilAn = string.Empty;
        /// 
        /// 
        /// 
        public string Kon1 = string.Empty;
        public string Kon2 = string.Empty;
        public string Kon3 = string.Empty;
        public string Kon4 = string.Empty;
        public string Kon5 = string.Empty;
        public string Kon6 = string.Empty;
        ///
        /// 
        /// 
        public ImageList sor = new ImageList();
        public ImageList cevap = new ImageList();
        public List<string> Cevap = new List<string>();
        public List<string> IlkOn = new List<string>();
        public List<string> BuAySoru = new List<string>();
        ///
        /// 
        ///
        private string KullaniciBilgiTut = string.Empty;
        public string KullaniciAd = string.Empty;
        public string IdControl = string.Empty;
        private bool GirisStatus = false;
        private bool KullaniVarlikKontrol = false;
        private bool TcStatus = false;

        private int Bugun = 0;
        readonly DataBase dataBase = new DataBase();
        readonly ForeColorcontrol tarih = new ForeColorcontrol();
        readonly GirisBilgiTut girisBilgi = GirisBilgiTut.GetInstance();

        public void VeriCek()
        {
            if (dataBase.baglanti.State == ConnectionState.Open)
            {
                dataBase.baglanti.Close();
            }

            try
            {
                dataBase.baglanti.Open();
                SqlCommand SoruCek = new SqlCommand("SELECT * FROM OgrGirisSoru where  GirisId=@Girisid ", dataBase.baglanti);
                SoruCek.Parameters.AddWithValue("@Girisid", girisBilgi.IdTut);
                SqlDataReader SoruOku = SoruCek.ExecuteReader();
                while (SoruOku.Read())
                {
                    PztSoruSayi = Convert.ToInt32(SoruOku[2]);
                    SalSoruSayi = Convert.ToInt32(SoruOku[3]);
                    CrsSoruSayi = Convert.ToInt32(SoruOku[4]);
                    PrsSoruSayi = Convert.ToInt32(SoruOku[5]);
                    CumSoruSayi = Convert.ToInt32(SoruOku[6]);
                    CmtSoruSayi = Convert.ToInt32(SoruOku[7]);
                    PazSoruSayi = Convert.ToInt32(SoruOku[8]);
                    AylıkCözülenSoru = Convert.ToInt32(SoruOku[9]);
                    DenmeSayi = Convert.ToInt32(SoruOku[10]);
                }
                SoruOku.Close();
                SoruCek.Dispose();
            }
            catch (Exception hata)
            {
                MessageBox.Show("" + hata);
            }
            finally
            {
                dataBase.baglanti.Close();
            }
        }

        //günlük soru çekme 
        public int BugunSoruCek(string gun)
        {
            gun = gun.Replace("ş", "s").Replace("Ç", "C").Replace("ı", "i");
            if (dataBase.baglanti.State == ConnectionState.Open)
            {
                dataBase.baglanti.Close();
            }

            try
            {
                dataBase.baglanti.Open();
                SqlCommand SoruSayiCek = new SqlCommand("SELECT * FROM OgrGirisSoru where  GirisId=@Girisid", dataBase.baglanti);
                SoruSayiCek.Parameters.AddWithValue("@Girisid", girisBilgi.IdTut);
                SqlDataReader SoruSayiOku = SoruSayiCek.ExecuteReader();
                while (SoruSayiOku.Read())
                {
                    Bugun = Convert.ToInt32(SoruSayiOku[gun]);
                }

                SoruSayiOku.Close();
                SoruSayiCek.Dispose();
            }
            catch (Exception hata)
            {
                MessageBox.Show("" + hata);
            }
            finally
            {
                dataBase.baglanti.Close();
            }
            return Bugun;
        }

        public bool GirisKontrol(string Tc,string sifre,string Tur)
        {
            if (dataBase.baglanti.State ==  ConnectionState.Open)
            {
                dataBase.baglanti.Close();
            }

            try
            {
                dataBase.baglanti.Open();
                SqlCommand loginTC = new SqlCommand("select * from Giris where KullaniciTc=@tc", dataBase.baglanti);
                loginTC.Parameters.AddWithValue("@tc", Tc);
                SqlDataReader TC_oku = loginTC.ExecuteReader();

                if (TC_oku.Read())
                {
                    KullaniciBilgiTut = TC_oku[1].ToString() + TC_oku[2].ToString() + TC_oku[7].ToString();
                    KullaniciAd = TC_oku[6].ToString();
                }

                if (Tc + sifre + Tur == KullaniciBilgiTut) 
                {
                    GirisStatus = true;
                    girisBilgi.IsimTut = TC_oku[6].ToString();
                    girisBilgi.IdTut = Convert.ToInt32(TC_oku[0]);
                }
                loginTC.Dispose();
                TC_oku.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show("" + Hata);
            }
            finally
            {
                dataBase.baglanti.Close();
            }

            return GirisStatus;
        }
        
        private void OgrBilgiOlustur(string Tc,string Sifre,int id,string kisad)
        {
            if (dataBase.baglanti.State == ConnectionState.Open)
            {
                dataBase.baglanti.Close();
            }

            try
            {
                dataBase.baglanti.Open();
                SqlCommand YeniOgrenci = new SqlCommand("insert into OgrGirisSoru values(@KullaniciTc,@Pazartesi,@Sali,@Carsamba,@Persembe,@Cuma,@Cumartesi,@Pazar,@BuAy,@Sinav,@GirisId,@KullaniciSifre,@KisiAd)", dataBase.baglanti);
                YeniOgrenci.Parameters.AddWithValue("@KullaniciTc", Tc);
                YeniOgrenci.Parameters.AddWithValue("@KullaniciSifre", Sifre);
                YeniOgrenci.Parameters.AddWithValue("@Pazartesi", 0);
                YeniOgrenci.Parameters.AddWithValue("@Sali", 0);
                YeniOgrenci.Parameters.AddWithValue("@Carsamba", 0);
                YeniOgrenci.Parameters.AddWithValue("@Persembe", 0);
                YeniOgrenci.Parameters.AddWithValue("@Cuma", 0);
                YeniOgrenci.Parameters.AddWithValue("@Cumartesi", 0);
                YeniOgrenci.Parameters.AddWithValue("@Pazar", 0);
                YeniOgrenci.Parameters.AddWithValue("@BuAy", 0);
                YeniOgrenci.Parameters.AddWithValue("@Sinav", 0);
                YeniOgrenci.Parameters.AddWithValue("@GirisId", id);
                YeniOgrenci.Parameters.AddWithValue("@KisiAd", kisad);
                YeniOgrenci.ExecuteNonQuery();
                YeniOgrenci.Dispose();
            }
            catch (Exception Hata)
            {
                MessageBox.Show("" + Hata);
            }
            finally
            {
                dataBase.baglanti.Close();
            }
        }

        public void Kayitol(string Tc, string Sifre, string GizliSoru, string SoruCevap, string KullaniciMail, string KullaniciAd, string KullaniciTur)
        {
            if (dataBase.baglanti.State == ConnectionState.Open)
            {
                dataBase.baglanti.Close();
            }

            try
            {
                dataBase.baglanti.Open();
                SqlCommand YeniKayit = new SqlCommand("insert into Giris values(@KullaniciTc,@KullaniciSifre,@GizliSoru,@GizliSoruCevap,@KullaniciMail,@KullaniciAd,@KullaniciTur)", dataBase.baglanti);
                YeniKayit.Parameters.AddWithValue("@KullaniciTc", Tc);
                YeniKayit.Parameters.AddWithValue("@KullaniciSifre", Sifre);
                YeniKayit.Parameters.AddWithValue("@GizliSoru", GizliSoru);
                YeniKayit.Parameters.AddWithValue("@GizliSoruCevap", SoruCevap);
                YeniKayit.Parameters.AddWithValue("@KullaniciMail", KullaniciMail.Trim());
                YeniKayit.Parameters.AddWithValue("@KullaniciAd", KullaniciAd);
                YeniKayit.Parameters.AddWithValue("@KullaniciTur", KullaniciTur);
                YeniKayit.ExecuteNonQuery();
                YeniKayit.Dispose();
                KayitKontrol(Tc, KullaniciMail, GizliSoru, SoruCevap, KullaniciAd);
                GirisKontrol(Tc, Sifre, KullaniciTur);
                OgrBilgiOlustur(Tc, Sifre, girisBilgi.IdTut, KullaniciAd);
            }
            catch (Exception Hata)
            {
                MessageBox.Show("" + Hata);
            }
            finally
            {
                dataBase.baglanti.Close();
            }
        }

        public bool TcVarlikKontrol(string Tc)
        {
            if (dataBase.baglanti.State == ConnectionState.Open)
            {
                dataBase.baglanti.Close();
            }

            try
            {
                dataBase.baglanti.Open();
                SqlCommand loginTC = new SqlCommand("select KullaniciTc from Giris where KullaniciTc=@Tc", dataBase.baglanti);
                loginTC.Parameters.AddWithValue("@Tc", Tc);
                SqlDataReader TcOku = loginTC.ExecuteReader();

                if (TcOku.Read())
                {
                    IdControl = TcOku[0].ToString();
                }

                if (IdControl == string.Empty)
                {
                    TcStatus = true;
                }

                else
                {
                    TcStatus = false;
                }

                loginTC.Dispose();
                TcOku.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show("" + Hata);
            }
            finally
            {
                dataBase.baglanti.Close();
                IdControl = string.Empty;
            }

            return TcStatus;
        }

        public bool KayitKontrol(string Tc, string Mail, string GizliSoru, string Cevap, string KulAd)
        {
            if (dataBase.baglanti.State == ConnectionState.Open)
            {
                dataBase.baglanti.Close();
            }

            try
            {
                dataBase.baglanti.Open();
                SqlCommand loginTC = new SqlCommand("select id from Giris where KullaniciTc=@tc and KullaniciMail=@Mail and GizliSoruCevap=@Cevap and GizliSoru=@GizliSoru and KullaniciAd=@KullaniciAd", dataBase.baglanti);
                loginTC.Parameters.AddWithValue("@tc", Tc);
                loginTC.Parameters.AddWithValue("@Mail", Mail);
                loginTC.Parameters.AddWithValue("@Cevap", Cevap);
                loginTC.Parameters.AddWithValue("@GizliSoru", GizliSoru);
                loginTC.Parameters.AddWithValue("@KullaniciAd", KulAd);
                SqlDataReader IdOku = loginTC.ExecuteReader();

                if (IdOku.Read())
                {
                    IdControl = IdOku[0].ToString();
                }

                if(IdControl==string.Empty)
                {
                    KullaniVarlikKontrol = false;
                }

                else
                {
                    KullaniVarlikKontrol = true;
                }

                loginTC.Dispose();
                IdOku.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show("" + Hata);
            }
            finally
            {
                dataBase.baglanti.Close();

            }

            return KullaniVarlikKontrol;
        }

        private void OgrSoruGuncelle(string Sifre)
        {
            if (dataBase.baglanti.State == ConnectionState.Open)
            {
                dataBase.baglanti.Close();
            }

            try
            {
                dataBase.baglanti.Open();
                SqlCommand yeniSifre = new SqlCommand("UPDATE OgrGirisSoru SET KullaniciSifre=@KullaniciSifre WHERE GirisId=@Id", dataBase.baglanti);
                yeniSifre.Parameters.AddWithValue("@Id",girisBilgi.IdTut);
                yeniSifre.Parameters.AddWithValue("@KullaniciSifre", Sifre);
                yeniSifre.ExecuteNonQuery();
                yeniSifre.Dispose();
            }
            catch (Exception Hata)
            {
                MessageBox.Show("" + Hata);
            }
            finally
            {
                dataBase.baglanti.Close();
            }
        }

        public void SifreGüncelle(string Sifre)
        {

            if (dataBase.baglanti.State == ConnectionState.Open)
            {
                dataBase.baglanti.Close();
            }

            try
            {
                dataBase.baglanti.Open();
                SqlCommand yeniSifre = new SqlCommand("UPDATE Giris SET KullaniciSifre=@KullaniciSifre WHERE id=@Id", dataBase.baglanti);
                yeniSifre.Parameters.AddWithValue("@Id", Convert.ToInt32(IdControl));
                yeniSifre.Parameters.AddWithValue("@KullaniciSifre",Sifre);
                yeniSifre.ExecuteNonQuery();
                yeniSifre.Dispose();
                OgrSoruGuncelle(Sifre);
            }
            catch (Exception Hata)
            {
                MessageBox.Show("" + Hata);
            }
            finally
            {
                dataBase.baglanti.Close();
                IdControl = string.Empty;
            }
        }
        public void ComboBoxVeriCekme(string Ders,ComboBox comboBox)
        {
            if (dataBase.baglanti.State == ConnectionState.Open)
            {
                dataBase.baglanti.Close();
            }

            try
            {
                dataBase.baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("select AltBaslik from TblAltBaslik where Ders=@ders ", dataBase.baglanti);
                sqlCommand.Parameters.AddWithValue("@ders", Ders);


                SqlDataReader Verioku = sqlCommand.ExecuteReader();

                while (Verioku.Read())
                {
                    comboBox.Items.Add (Verioku["AltBaslik"].ToString());
                }

                sqlCommand.Dispose();
                Verioku.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show("" + Hata);
            }
            finally
            {
                dataBase.baglanti.Close();
            }

        }

        public void CozulucekSoruCek()
        {
            if (dataBase.baglanti.State == ConnectionState.Open)
            {
                dataBase.baglanti.Close();
            }

            try
            {
                dataBase.baglanti.Open();
                SqlCommand CozSoruCek = new SqlCommand("SELECT * FROM CozulucekSorular", dataBase.baglanti);
                SqlDataReader SoruSayiOku = CozSoruCek.ExecuteReader();
                while (SoruSayiOku.Read())
                {
                    Mat = SoruSayiOku[1].ToString();
                    Geo = SoruSayiOku[2].ToString();
                    Fiz = SoruSayiOku[3].ToString();
                    Kim = SoruSayiOku[4].ToString();
                    Bio = SoruSayiOku[5].ToString();
                    Edeb = SoruSayiOku[6].ToString();
                    Tar = SoruSayiOku[7].ToString();
                    Fel = SoruSayiOku[8].ToString();
                    Cog = SoruSayiOku[9].ToString();
                    DilAn = SoruSayiOku[10].ToString();
                }
                SoruSayiOku.Close();
                CozSoruCek.Dispose();
            }
            catch (Exception hata)
            {
                MessageBox.Show("" + hata);
            }
            finally
            {
                dataBase.baglanti.Close();
            }
        }

        private void SoruGuncelle()
        {
            if (dataBase.baglanti.State == ConnectionState.Open)
            {
                dataBase.baglanti.Close();
            }

            try
            {
                dataBase.baglanti.Open();
                SqlCommand yeniSifre = new SqlCommand("UPDATE OgrGirisSoru SET Pazartesi=@p1, Sali=@p2, Carsamba=@p3, Persembe=@p4, Cuma=@p5, Cumartesi=@p6, Pazar=@p7 WHERE GirisId=@Id", dataBase.baglanti);
                yeniSifre.Parameters.AddWithValue("@Id", girisBilgi.IdTut);
                yeniSifre.Parameters.AddWithValue("@p1", PztSoruSayi);
                yeniSifre.Parameters.AddWithValue("@p2", SalSoruSayi);
                yeniSifre.Parameters.AddWithValue("@p3", CrsSoruSayi);
                yeniSifre.Parameters.AddWithValue("@p4", PrsSoruSayi);
                yeniSifre.Parameters.AddWithValue("@p5", CumSoruSayi);
                yeniSifre.Parameters.AddWithValue("@p6", CmtSoruSayi);
                yeniSifre.Parameters.AddWithValue("@p7", PazSoruSayi);
                yeniSifre.ExecuteNonQuery();
                yeniSifre.Dispose();
            }
            catch (Exception Hata)
            {
                MessageBox.Show("" + Hata);
            }
            finally
            {
                dataBase.baglanti.Close();
            }
        }

        // güne gore veri çekiliyor
        public void OneriKonuCek()
        {
            tarih.TarihIslemleri();
            if (dataBase.baglanti.State == ConnectionState.Open)
            {
                dataBase.baglanti.Close();
            }

            try
            {
                dataBase.baglanti.Open();
                SqlCommand OneriKonCek = new SqlCommand("SELECT * FROM OneriKonu where Gun=@gun", dataBase.baglanti);
                OneriKonCek.Parameters.AddWithValue("@gun", tarih.Bugun);
                SqlDataReader KonuOku = OneriKonCek.ExecuteReader();
                while (KonuOku.Read())
                {
                    Kon1 = KonuOku[1].ToString();
                    Kon2 = KonuOku[2].ToString();
                    Kon3 = KonuOku[3].ToString();
                    Kon4 = KonuOku[4].ToString();
                    Kon5 = KonuOku[5].ToString();
                    Kon6 = KonuOku[6].ToString();
                }
                KonuOku.Close();
                OneriKonCek.Dispose();
            }
            catch (Exception hata)
            {
                MessageBox.Show("" + hata);
            }
            finally
            {
                dataBase.baglanti.Close();
            }
        }
        public void SorulariGuncelle(int SoruSayi)
        {
            VeriCek();
            tarih.TarihIslemleri();

            if (tarih.Bugun == "Pazartesi")
            {
                PztSoruSayi += SoruSayi;
            }        
            else if (tarih.Bugun == "Salı")
            {
                SalSoruSayi += SoruSayi;
            }
            else if (tarih.Bugun == "Çarşamba")
            {
                CrsSoruSayi += SoruSayi;
            }
            else if (tarih.Bugun == "Perşembe")
            {
                PrsSoruSayi += SoruSayi;
            }
            else if (tarih.Bugun == "Cuma")
            {
                CumSoruSayi += SoruSayi;
            }
            else if (tarih.Bugun == "Cumartersi")
            {
                CmtSoruSayi += SoruSayi;
            }
            else
            {
                PazSoruSayi += SoruSayi;
            }
            SoruGuncelle();
        }
        private byte[] ResimDonustur(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            return br.ReadBytes((int)fs.Length);
        }

        public void SoruEkle(string SoruPath, string CevapPath, string Konu, string AltBaslik, string Zorluk, string DogruSık)
        {
            try
            {
                byte[] resim = ResimDonustur(SoruPath);
                byte[] cresim = ResimDonustur(CevapPath);

                dataBase.baglanti.Open();
                // resimleri veri tabanına kayıt et 
                SqlCommand bag = new SqlCommand("insert into ResimliSorular(SoruResim,CevapResim,Konu,AltBaslık,Zorluk,DogruCevap) values( @image,@cimage,@Konu,@AltBaslık,@Zorluk,@DogruCevap)", dataBase.baglanti);
                bag.Parameters.Add("@image", SqlDbType.Image, resim.Length).Value = resim;
                bag.Parameters.Add("@cimage", SqlDbType.Image, cresim.Length).Value = cresim;
                bag.Parameters.AddWithValue("@Konu", Konu);
                bag.Parameters.AddWithValue("@AltBaslık", AltBaslik);
                bag.Parameters.AddWithValue("@Zorluk", Zorluk);
                bag.Parameters.AddWithValue("@DogruCevap", DogruSık);
                bag.ExecuteNonQuery();         
            }
            catch (Exception hata)
            {
                MessageBox.Show("" + hata);
            }
            finally
            {
                dataBase.baglanti.Close();
            }
        }

        public void OneriKonuGuncelle(string p1, string p2, string p3, string p4, string p5, string p6)
        {
            tarih.TarihIslemleri();
            MessageBox.Show(tarih.Bugun);
            if (dataBase.baglanti.State == ConnectionState.Open)
            {
                dataBase.baglanti.Close();
            }

            try
            {
                dataBase.baglanti.Open();
                SqlCommand yeniSifre = new SqlCommand("UPDATE OneriKonu SET Konu1=@p1, Konu2=@p2, Konu3=@p3, Konu4=@p4, Konu5=@p5, Konu6=@p6  WHERE Gun=@Id", dataBase.baglanti);
                yeniSifre.Parameters.AddWithValue("@Id", tarih.Bugun);
                yeniSifre.Parameters.AddWithValue("@p1", p1);
                yeniSifre.Parameters.AddWithValue("@p2", p2);
                yeniSifre.Parameters.AddWithValue("@p3", p3);
                yeniSifre.Parameters.AddWithValue("@p4", p4);
                yeniSifre.Parameters.AddWithValue("@p5", p5);
                yeniSifre.Parameters.AddWithValue("@p6", p6);
                yeniSifre.ExecuteNonQuery();
                yeniSifre.Dispose();
            }
            catch (Exception Hata)
            {
                MessageBox.Show("" + Hata);
            }
            finally
            {
                dataBase.baglanti.Close();
            }
        }

        public void CozulecekSorGuncelle(string Mat, string Geo, string Fiz, string Kim, string Bio, string Edeb, string Tar, string Fel, string Cog, string Dil)
        {
            tarih.TarihIslemleri();
            if (dataBase.baglanti.State == ConnectionState.Open)
            {
                dataBase.baglanti.Close();
            }

            try
            {
                dataBase.baglanti.Open();
                SqlCommand yeniSifre = new SqlCommand("UPDATE CozulucekSorular SET Matematik=@p1, Geometri=@p2, Fizik=@p3, Kimya=@p4, Bioloji=@p5, Edebiyat=@p6, Tarih=@p7, Felsefe=@p8, Cografya=@p9, DilAnlatım=@p10  WHERE id=@Id", dataBase.baglanti);
                yeniSifre.Parameters.AddWithValue("@Id", 1);
                yeniSifre.Parameters.AddWithValue("@p1",  Mat);
                yeniSifre.Parameters.AddWithValue("@p2",  Geo);
                yeniSifre.Parameters.AddWithValue("@p3",  Fiz);
                yeniSifre.Parameters.AddWithValue("@p4",  Kim);
                yeniSifre.Parameters.AddWithValue("@p5",  Bio);
                yeniSifre.Parameters.AddWithValue("@p6", Edeb);
                yeniSifre.Parameters.AddWithValue("@p7",  Tar);
                yeniSifre.Parameters.AddWithValue("@p8",  Fel);
                yeniSifre.Parameters.AddWithValue("@p9",  Cog);
                yeniSifre.Parameters.AddWithValue("@p10", Dil);
                yeniSifre.ExecuteNonQuery();
                yeniSifre.Dispose();
            }
            catch (Exception Hata)
            {
                MessageBox.Show("" + Hata);
            }
            finally
            {
                dataBase.baglanti.Close();
            }
        }

        public void SınavSorusu(string Ders)
        {
            if(dataBase.baglanti.State==ConnectionState.Open)
            {
                dataBase.baglanti.Close();
            }
            try
            {
                sor.ImageSize = new Size(256, 200);
                sor.ColorDepth = ColorDepth.Depth32Bit;
                cevap.ImageSize = new Size(256, 190);
                cevap.ColorDepth = ColorDepth.Depth32Bit;
                dataBase.baglanti.Open();
                // not burayı kullanıcı giricek
                for (int i = 0; i < 20; i++)
                {
                    // resimleri çekiyoruz
                    SqlCommand sorular = new SqlCommand("SELECT TOP 1 * FROM ResimliSorular where Konu=@Konu ORDER BY NEWID()", dataBase.baglanti);
                    sorular.Parameters.AddWithValue("@Konu", Ders);
                    SqlDataReader SoruOku = sorular.ExecuteReader();
                    while (SoruOku.Read())
                    {
                        byte[] ResimliSorular = (byte[])SoruOku[1];//1. indise soru 2. indise cevap kayıt oluyor
                        MemoryStream ms = new MemoryStream();
                        ms.Write(ResimliSorular, 0, ResimliSorular.Length);
                        sor.Images.Add(Image.FromStream(ms));
                        //
                        byte[] ResimliCevap = (byte[])SoruOku[2];
                        MemoryStream mc = new MemoryStream();
                        mc.Write(ResimliCevap, 0, ResimliCevap.Length);
                        cevap.Images.Add(Image.FromStream(mc));

                        Cevap.Add(SoruOku[6].ToString());
                    }
                }
            }
            catch(Exception Hata)
            {
                MessageBox.Show("" + Hata);
            }
            finally
            {
                dataBase.baglanti.Close();
            }
        }


        public void IlkOnKisi()
        {
            if (dataBase.baglanti.State == ConnectionState.Open)
            {
                dataBase.baglanti.Close();
            }
            try
            {
                dataBase.baglanti.Open();
                SqlCommand sorular = new SqlCommand("SELECT TOP 10 KisiAd, BuAy FROM OgrGirisSoru ORDER BY BuAy DESC", dataBase.baglanti);
                SqlDataReader SoruOku = sorular.ExecuteReader();

                while (SoruOku.Read())
                {
                    IlkOn.Add(SoruOku["KisiAd"].ToString());
                    BuAySoru.Add(SoruOku["BuAy"].ToString());
                }
            }
            catch (Exception Hata)
            {
                MessageBox.Show("" + Hata);
            }
            finally
            {
                dataBase.baglanti.Close();
            }
        }
    }
}

