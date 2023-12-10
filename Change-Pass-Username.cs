using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LiberaryManegment.Properties
{
    public partial class Change_Pass_Username : Form
    {
        public Change_Pass_Username()
        {
            InitializeComponent();
        }

        private void new_username_MouseClick(object sender, MouseEventArgs e)
        {
            if (new_username.Text == "نام کاربری جدید")
            {
                new_username.Text = "";
            }
        }

        private void new_password_MouseClick(object sender, MouseEventArgs e)
        {
            if (new_password.Text == "رمز عبور جدید")
            {
                new_password.Text = "";
            }
        }

        private void repet_password_MouseClick(object sender, MouseEventArgs e)
        {
            if(repet_password.Text=="تکرار رمز عبور")
            {
                repet_password.Text = "";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("این عمل موجب از دست رفتن اطلاعات ذخیره نشده میشود","توجه",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (new_password.Text == repet_password.Text && new_username.Text != "" && new_username.Text != "نام کاربری جدید" && new_password.Text !="رمز عبور جدید")
            {
                Properties.Settings.Default.password = new_password.Text;
                Properties.Settings.Default.username = new_username.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("نام کاربری و رمز عبور با موفقیت تغییر کرد", "موفقیت آمیز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new_username.Clear();
                new_password.Clear();
                repet_password.Clear();
            }
            else
                MessageBox.Show(" فیلد ها خالی هستند یا رمز عبور و تکرار آن مطابفت ندارند", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Change_Pass_Username_Load (this,null);
        }

        private void Change_Pass_Username_Load(object sender, EventArgs e)
        {
            username.Text = Properties.Settings.Default.username;
            password.Text = Properties.Settings.Default.password;
        }
    }
}
