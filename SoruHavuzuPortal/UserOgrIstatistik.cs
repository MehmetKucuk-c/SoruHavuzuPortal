using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace SoruHavuzuPortal
{
    public partial class UserOgrIstatistik : UserControl
    {
        public UserOgrIstatistik()
        {
            InitializeComponent();
        }

        readonly DataBaseIslem baseIslem = new DataBaseIslem();
        readonly ForeColorcontrol foreColorcontrol = new ForeColorcontrol();
        private int Ort = 0;

        private void UserAnaSayfa_Load(object sender, EventArgs e)
        {
            baseIslem.VeriCek();
            //ort
            Ort = (baseIslem.PztSoruSayi + baseIslem.SalSoruSayi + baseIslem.CrsSoruSayi + baseIslem.PrsSoruSayi + baseIslem.CumSoruSayi + baseIslem.CmtSoruSayi + baseIslem.PazSoruSayi) / 7;
            //gün
            LblPzt.ForeColor = foreColorcontrol.Control(baseIslem.PztSoruSayi);
            LblPzt.Text = baseIslem.PztSoruSayi.ToString();
            LblSal.ForeColor= foreColorcontrol.Control(baseIslem.SalSoruSayi);
            LblSal.Text = baseIslem.SalSoruSayi.ToString();
            LblCrs.ForeColor = foreColorcontrol.Control(baseIslem.CrsSoruSayi);
            LblCrs.Text = baseIslem.CrsSoruSayi.ToString();
            LblPrs.ForeColor = foreColorcontrol.Control(baseIslem.PrsSoruSayi);
            LblPrs.Text = baseIslem.PrsSoruSayi.ToString();
            LblCum.ForeColor = foreColorcontrol.Control(baseIslem.CumSoruSayi);
            LblCum.Text = baseIslem.CumSoruSayi.ToString();
            LblCmt.ForeColor = foreColorcontrol.Control(baseIslem.CmtSoruSayi);
            LblCmt.Text = baseIslem.CmtSoruSayi.ToString();
            LblPaz.ForeColor = foreColorcontrol.Control(baseIslem.PazSoruSayi);
            LblPaz.Text = baseIslem.PazSoruSayi.ToString();
            //hafta özet
            LblOrtSoru.ForeColor = foreColorcontrol.HaftalikControl(Ort);
            BtnOrt.FillColor = foreColorcontrol.HaftalikControl(Ort);
            LblOrtSoru.Text = Ort.ToString();
            BtnOrt.CheckedState.FillColor = BtnOrt.FillColor;
            BtnOrt.CheckedState.BorderColor = BtnOrt.FillColor;
            LblIlerleme.Text = foreColorcontrol.Durum;
            LblIlerleme.Location = foreColorcontrol.point;
            LblIlerleme.ForeColor = foreColorcontrol.color;
            BtnIlerleme.FillColor = foreColorcontrol.color;
            BtnIlerleme.CheckedState.BorderColor = foreColorcontrol.color;
            BtnIlerleme.CheckedState.FillColor = foreColorcontrol.color;
            //Deneme
            LblDeneme.Text = baseIslem.DenmeSayi.ToString();
            BtnDenem.FillColor = foreColorcontrol.DenemeRenk(baseIslem.DenmeSayi);
            BtnDenem.CheckedState.FillColor = BtnDenem.FillColor;
            BtnDenem.CheckedState.BorderColor = BtnDenem.BorderColor;
            LblDeneme.ForeColor = BtnDenem.FillColor;
            //Circle Haftalık
            CircleHafta.Value = foreColorcontrol.HaftalikYuzde(Ort);
            CircleHafta.ProgressColor2 = foreColorcontrol.color;
            CircleHafta.ProgressColor = foreColorcontrol.color;
            //AylıkOrtalama
            CircleAy.Value = foreColorcontrol.AylıkYuzde(baseIslem.AylıkCözülenSoru);
            CircleAy.ProgressColor = foreColorcontrol.color;
            CircleAy.ProgressColor2 = foreColorcontrol.color;
            //tarih işlemleri
            LblAyYil.Text = foreColorcontrol.TarihIslemleri()+" "+foreColorcontrol.Yil ;
            LblBugun.Text = foreColorcontrol.Bugun;
            LblDun.Text = foreColorcontrol.Dun;
            //GunYüzde
            ProgressBarBugun.Value= foreColorcontrol.GunYuzde(baseIslem.BugunSoruCek(LblBugun.Text));
            ProgressBarBugun.ProgressColor = foreColorcontrol.color;
            ProgressBarBugun.ProgressColor2 = foreColorcontrol.color;

            ProgressBarDun.Value = foreColorcontrol.GunYuzde(baseIslem.BugunSoruCek(LblDun.Text));
            ProgressBarDun.ProgressColor = foreColorcontrol.color;
            ProgressBarDun.ProgressColor2 = foreColorcontrol.color;
            ///ortalama
            Ort= foreColorcontrol.Toplam / 2; 
            ProgressBarOrt.Value = foreColorcontrol.GunYuzde(Ort);
            ProgressBarOrt.ProgressColor = foreColorcontrol.color;
            ProgressBarOrt.ProgressColor2 = foreColorcontrol.color;
            CircleOrt.Value = ProgressBarOrt.Value;
            CircleOrt.ProgressColor = ProgressBarOrt.ProgressColor;
            CircleOrt.ProgressColor2 = ProgressBarOrt.ProgressColor2;
        }
    }
}
