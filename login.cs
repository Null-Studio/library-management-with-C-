using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LiberaryManegment.Properties;

namespace WindowsFormsApplication1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard dsh = new dashboard();
            if (textusername.Text == LiberaryManegment.Properties.Properties.Settings.Default.username && textpassword.Text == LiberaryManegment.Properties.Properties.Settings.Default.password)
            {
                dsh.Show();
                this.Hide();
                MessageBox.Show(" (نرم افزار مدیریت کتابخانه دانشگاه فنی و حرفه ای گلپایگان(شهدا", "خوش آمدید", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("! رمز عبور یا نام کاربری اشتباه است", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void telegram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/Largepotatoes");
        }

        private void instagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://instagram.com/memes._angel?igshid=MzRIODBiNWFIZA==");
        }

        private void textusername_MouseClick(object sender, MouseEventArgs e)
        {
            if (textusername.Text == "نام کاربری")
                textusername.Clear();
        }

        private void textpassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (textpassword.Text == "رمز عبور")
                textpassword.Clear();
            textpassword.PasswordChar = '*';
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            info inf = new info();
            Hide();
            inf.Show();
        }
    }
}
