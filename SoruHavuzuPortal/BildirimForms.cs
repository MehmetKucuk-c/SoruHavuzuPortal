using SoruHavuzuPortal.Properties;
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
    public partial class BildirimForms : Form
    {
        public BildirimForms()
        {
            InitializeComponent();
        }
        public enum EnmAction
        {
            wait,
            start,
            close
        }
        public enum EnmType
        {
            Success,
            Warning,
            Error
        }
        private EnmAction action;
        private int x, y;

        private void Zamanlayici_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case EnmAction.wait:
                    Zamanlayici.Interval = 5000;
                    action = EnmAction.close;
                    break;
                case EnmAction.start:
                    Zamanlayici.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = EnmAction.wait;

                        }
                    }
                    break;
                case EnmAction.close:
                    Zamanlayici.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void Picture_Kapatma_Click(object sender, EventArgs e)
        {
            Zamanlayici.Interval = 1;
            action = EnmAction.close;
        }

        private void Picture_Kapatma_Click_1(object sender, EventArgs e)
        {
            Zamanlayici.Interval = 1;
            action = EnmAction.close;
        }

        public void ShowAlert(string msg, EnmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;
            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                BildirimForms bildirimcs = (BildirimForms)Application.OpenForms[fname];
                if (bildirimcs == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            switch (type)
            {
                case EnmType.Success:
                    this.pictureBox1.Image = Resources.tick;
                    this.BackColor = Color.Green;
                    break;
                case EnmType.Error:
                    this.pictureBox1.Image = Resources.error;
                    this.BackColor = Color.DarkRed;
                    break;
                case EnmType.Warning:
                    this.pictureBox1.Image = Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    break;
            }

            this.LblMsg.Text = msg;
            this.Show();
            this.action = EnmAction.start;
            this.Zamanlayici.Interval = 1;
            Zamanlayici.Start();
        }
    }
}
