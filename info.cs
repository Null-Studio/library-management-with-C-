using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace LiberaryManegment.Properties
{
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            login log = new login();
            this.Close();
            log.Show();
        }


        private void info_Load_1(object sender, EventArgs e)
        {
            Timer timer1 = new Timer();
            timer1.Interval = 5000; // 5 second
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }
        int imagecounter=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(imagecounter<imageList1.Images.Count)
            {
                pictureBox2.Image = imageList1.Images[imagecounter];
                imagecounter++;
            }
            else
            {
               imagecounter = 0;
            }
        }
    }
}
