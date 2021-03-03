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
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        readonly UserOgretmenSoruEkme  userOgretmenSoru= new UserOgretmenSoruEkme();

        private void UserEkle(UserControl userControl)
        {
            panelUser.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
            panelUser.Controls.Add(userControl);
        }
        //picturebox hareket
        private void MoveImageSide(object sender)
        {
            Guna2Button button = (Guna2Button)sender;
            ImageSlide.Location = new Point(button.Location.X + 24, button.Location.Y - 25);
            ImageSlide.SendToBack();
        }

        private void FrmOgretmen_Load(object sender, EventArgs e)
        {
            MoveImageSide(BtnSoruEkle) ;
            UserEkle(userOgretmenSoru);
        }


        private void BtnSoruEkle_Click(object sender, EventArgs e)
        {
            UserEkle(userOgretmenSoru);
        }

        private void BtnSoruEkle_CheckedChanged(object sender, EventArgs e)
        {
            MoveImageSide(sender);
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnYenidenBaslat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void BtnSoruOner_Click(object sender, EventArgs e)
        {
            UserSoruOner userSoruOner = new UserSoruOner();
            UserEkle(userSoruOner);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            UserIlkOn userIlkOn = new UserIlkOn();
            UserEkle(userIlkOn);
        }
    }
}
