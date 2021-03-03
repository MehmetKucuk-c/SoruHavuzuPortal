using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace SoruHavuzuPortal
{
    class Watermark
    {
        public void TexboxGiris(object sender)
        {
            GunaLineTextBox textBox = (GunaLineTextBox)sender;
            if (textBox.ForeColor == Color.DarkGray)
            {
                textBox.Text = string.Empty;
            }
            textBox.ForeColor = Color.FromArgb(53, 41, 123);
        }

        public void TexboxCikis(string mesaj, GunaLineTextBox textBox)
        {
            if (textBox.Text == string.Empty)
            {
                textBox.Text = mesaj;
                textBox.ForeColor = Color.DarkGray;
            }
        }

        public void ForDongu(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                item.Text = string.Empty;
                if (item is GunaLineTextBox textBox)
                {
                    TexboxCikis(item.Tag.ToString(), textBox);
                }
            }
        }

        //sigre göster

        public void SifreGöster(GunaLineTextBox textBox, PictureBox pictureBox)
        {
            if (textBox.ForeColor != Color.DarkGray) 
            {
                textBox.PasswordChar = '\0';
                pictureBox.Image = Properties.Resources.icons8_hide_50px_1; 
            }
        }

        public void SifreGizle(GunaLineTextBox textBox, PictureBox pictureBox)
        {
            if (textBox.ForeColor != Color.DarkGray) 
            {
                textBox.PasswordChar = '*';
                pictureBox.Image = Properties.Resources.icons8_eye_50px_1; 
            }
        }
    }
}
