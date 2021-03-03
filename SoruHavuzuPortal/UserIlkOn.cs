using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruHavuzuPortal
{
    public partial class UserIlkOn : UserControl
    {
        public UserIlkOn()
        {
            InitializeComponent();
        }

        readonly DataBaseIslem dataBaseIslem = new DataBaseIslem();

        private void UserIlkOn_Load(object sender, EventArgs e)
        {
            dataBaseIslem.IlkOnKisi();
            IlkOnCek(PanelKisiAd);
        }
        private void  IlkOnCek(Panel panel)
        {
            LblBuAy1.Text = dataBaseIslem.BuAySoru[0];
            LblBuAy2.Text = dataBaseIslem.BuAySoru[1];
            LblBuAy3.Text = dataBaseIslem.BuAySoru[2];
            LblBuAy4.Text = dataBaseIslem.BuAySoru[3];
            LblBuAy5.Text = dataBaseIslem.BuAySoru[4];
            LblBuAy6.Text = dataBaseIslem.BuAySoru[5];
            LblBuAy7.Text = dataBaseIslem.BuAySoru[6];
            LblBuAy8.Text = dataBaseIslem.BuAySoru[7];
            LblBuAy9.Text = dataBaseIslem.BuAySoru[8];
            LblBuAy10.Text = dataBaseIslem.BuAySoru[9];
            LblOgrAd1.Text = dataBaseIslem.IlkOn[0];
            LblOgrAd2.Text = dataBaseIslem.IlkOn[1];
            LblOgrAd3.Text = dataBaseIslem.IlkOn[2];
            LblOgrAd4.Text = dataBaseIslem.IlkOn[3];
            LblOgrAd5.Text = dataBaseIslem.IlkOn[4];
            LblOgrAd6.Text = dataBaseIslem.IlkOn[5];
            LblOgrAd7.Text = dataBaseIslem.IlkOn[6];
            LblOgrAd8.Text = dataBaseIslem.IlkOn[7];
            LblOgrAd9.Text = dataBaseIslem.IlkOn[8];
            LblOgrAd10.Text = dataBaseIslem.IlkOn[9];
        }
    }
}
