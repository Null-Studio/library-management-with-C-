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

namespace LiberaryManegment.Properties
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("می خواهید خارج شوید ؟", "توجه", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            NationalCode.Clear();
            fristname.Clear();
            lastname.Clear();
            FatherName.Clear();
            phone.Clear();
            FieldofStudy.Clear();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (NationalCode.Text != "" && fristname.Text != "" && lastname.Text != "" && FatherName.Text != "" && phone.Text != "" && FieldofStudy.Text != "")
            {
                Int64 ncod = Int64.Parse(NationalCode.Text);
                string name = fristname.Text;
                string lname = lastname.Text;
                string faname = FatherName.Text;
                Int64 tel = Int64.Parse(phone.Text);
                string filds = FieldofStudy.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewStudent (NationalCode,Name,Lastname,FatherName,phone,FieldofStudy) values (" + ncod + ",N'" + name + "',N'" + lname + "',N'" + faname + "'," + tel + ",N'" + filds + "')";

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("اطلاعات ذخیره شد", "موفقیت آمیز", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لطفا فیلد های خالی را پر کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("لطفا مقدار عددی وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("لطفا مقدار عددی وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void setpersianInputlanguage()//<==============تابع برای تغییر زبان ورودی به فارسی
        {
            InputLanguage persian = InputLanguage.FromCulture(new System.Globalization.CultureInfo("fa_IR"));//<--------------گرفتن زبان فارسی از لیست زبان های نصب شده
            InputLanguage.CurrentInputLanguage = persian;
        }
        private void ResetInputLanguag()
        {
            InputLanguage defaultlang = InputLanguage.DefaultInputLanguage;//<==============گرفتن زبان پیش فرض سیستم
            InputLanguage.CurrentInputLanguage = defaultlang;//<================تغییر زبان ورودی سیستم به پیش فرض
        }

        private void FatherName_Enter(object sender, EventArgs e)
        {
            setpersianInputlanguage();
        }

        private void FatherName_Leave(object sender, EventArgs e)
        {
            ResetInputLanguag();
        }

        private void FieldofStudy_Enter(object sender, EventArgs e)
        {
            setpersianInputlanguage();
        }
          private void FieldofStudy_Leave(object sender, EventArgs e)
        {
            ResetInputLanguag();
        }

          private void fristname_Enter(object sender, EventArgs e)
          {
              setpersianInputlanguage();
          }

          private void fristname_Leave(object sender, EventArgs e)
          {
              ResetInputLanguag();
          }

          private void lastname_Enter(object sender, EventArgs e)
          {
              setpersianInputlanguage();
          }

          private void lastname_Leave(object sender, EventArgs e)
          {
              ResetInputLanguag();
          }

          private void AddStudent_Load(object sender, EventArgs e)
          {
              Font = Properties.Settings.Default.font;
            ForeColor = Properties.Settings.Default.color;
        }
    }
}
