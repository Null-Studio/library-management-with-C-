using System;
using System.Windows.Forms;
namespace LiberaryManegment.Properties
{
    public partial class dashboard : Form
    {
     
        public dashboard()
        {
            InitializeComponent();

        }
        private void افزودنکتابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook ab = new AddBook();
            ab.Show();
        }

        private void مشاهده_کتابهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewbook vb = new viewbook();
            vb.Show();
        }

        private void افزودندانشجوToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent AS = new AddStudent();
            AS.Show();
        }

        private void مشاهدهدانشجویانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewStudent vs = new viewStudent();
            vs.Show();
        }

        private void بخشامانتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookIseeu bi = new BookIseeu();
            bi.Show();
        }

        private void برگرداندنکتابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookreturn br = new bookreturn();
            br.Show();
        }

        private void اطلاعاتکاملToolStripMenuItem_Click(object sender, EventArgs e)
        {
            completbook cb = new completbook();
            cb.Show();
        }

        private void خروجToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" مطمئن هستید می خواهید خارج شوید ؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

      

        private void تغییر_رمز_عبور_نام_کاربریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Pass_Username ch = new Change_Pass_Username();
            ch.ShowDialog();
        }

        private void تغییرفونتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog()==DialogResult.OK)
            {
                menuStrip1.Font = fontDialog1.Font;
                Properties.Settings.Default.font = fontDialog1.Font;
                Properties.Settings.Default.Save();
            }
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            Font = Properties.Settings.Default.font;
            ForeColor = Properties.Settings.Default.color;
        }

        private void تغییررنگToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                Properties.Settings.Default.color = colorDialog1.Color;
                Properties.Settings.Default.Save();
                menuStrip1.ForeColor = colorDialog1.Color;
            }
        }

        private void پشتیبان_گیریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
