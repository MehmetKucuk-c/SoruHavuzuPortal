using Guna.UI2.WinForms;
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
    public partial class FrmOgr : Form
    {
        public FrmOgr()
        {
            InitializeComponent();
        }

        readonly UserOgrAnasayfa userOgrAnasayfa = new UserOgrAnasayfa();
        GirisBilgiTut girisBilgi = GirisBilgiTut.GetInstance();
        //picturebox hareket
        private void MoveImageSide(object sender)
        {
            Guna2Button button = (Guna2Button)sender;
            ImageSlide.Location = new Point(button.Location.X + 24, button.Location.Y - 25);
            ImageSlide.SendToBack();
        }

        private void BtnAnasayfa_CheckedChanged(object sender, EventArgs e)
        {
            MoveImageSide(sender);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserEkle(userOgrAnasayfa);
            label1.Text = girisBilgi.IsimTut;
            MoveImageSide(BtnAnasayfa);
        }

        //usercontroler ekleme
        private void UserEkle(UserControl userControl)
        {
            panelUser.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
            panelUser.Controls.Add(userControl);
        }

        private void BtnAnasayfa_Click(object sender, EventArgs e)
        {
            UserEkle(userOgrAnasayfa);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnYenidenBaslat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void BtnIstatistik_Click(object sender, EventArgs e)
        {
            UserOgrIstatistik userOgrIstat = new UserOgrIstatistik();
            UserEkle(userOgrIstat);
        }

        private void BtnExam_Click(object sender, EventArgs e)
        {
            UserOgrSinav userOgrSinav = new UserOgrSinav();
            UserEkle(userOgrSinav);
        }
    }
}
