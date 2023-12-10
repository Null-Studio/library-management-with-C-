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
    public partial class BookIseeu : Form
    {
        public BookIseeu()
        {
            InitializeComponent();
        }
        
        private void BookIseeu_Load(object sender, EventArgs e)
        {
            ForeColor = Properties.Settings.Default.color;
            Font = Properties.Settings.Default.font;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand("select bName from NewBook1", con);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    comboBox1.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            con.Close();
        }
        int count;
        private void Serch_Click(object sender, EventArgs e)
        {
            if (textBoxserch.Text != null)
            {
                Int64 Na =Int64.Parse(textBoxserch.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent where NationalCode ='" + Na + "'";
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                Da.Fill(DS);

                //-------------------------------------------------------------------------------------------
                //کد دریافت حد اکثر 3 کتاب برای هر دانشجو

                cmd.CommandText = "select count(StdID) from IssuBook where NationalCode =" + Na + " and Book_return_Data is null";
                SqlDataAdapter Da1 = new SqlDataAdapter(cmd);
                DataSet DS1 = new DataSet();
                Da.Fill(DS1);

                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());
                //--------------------------------------------------------------------------------------------
                if (DS.Tables[0].Rows.Count != 0)
                {
                    textBoxNAME.Text = DS.Tables[0].Rows[0][1].ToString();
                    textBoxLASTNAME.Text = DS.Tables[0].Rows[0][2].ToString();
                    textBoxFatherName.Text = DS.Tables[0].Rows[0][3].ToString();
                    textBoxPHONE.Text = DS.Tables[0].Rows[0][4].ToString();
                    FieldofStudy.Text = DS.Tables[0].Rows[0][5].ToString();
                }
                else
                {
                    textBoxNAME.Clear();
                    textBoxLASTNAME.Clear();
                    textBoxFatherName.Clear();
                    textBoxPHONE.Clear();
                    FieldofStudy.Clear();
                    MessageBox.Show("داده نا معتبر است لطفا مقدار صحیح وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Sign_Click(object sender, EventArgs e)
        {
            if (textBoxNAME.Text != "")
            {
                if (comboBox1.SelectedIndex != -1 && count <= 2)
                {
                    string nam = textBoxNAME.Text;
                    string lnam = textBoxLASTNAME.Text;
                    string fanam = textBoxFatherName.Text;
                    string pho =textBoxPHONE.Text;
                    string fild = FieldofStudy.Text;
                    string boname = comboBox1.Text;
                    string date =dateTimePicker1.Text;
                    string Nacode =textBoxserch.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=.;Initial Catalog=library;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "insert into IssuBook (NationalCode,Name,LastName,FatherName,FieldofStudy,phone,BookName,Book_issu_Data) values (N'"+Nacode+"',N'"+nam+"',N'"+lnam+"',N'"+fanam+"',N'"+fild+"',N'"+pho+"',N'"+boname+"',N'"+date+"') ";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("امانت ثبت شد", "ثبت امانت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("کتابی انتخاب نشده یا کاربر به حد اکثر کتاب امانت داده شده رسیده", "کتابی انتخاب نشده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxserch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxserch.Text == "")
            {
                textBoxNAME.Clear();
                textBoxLASTNAME.Clear();
                textBoxFatherName.Clear();
                textBoxPHONE.Clear();
                FieldofStudy.Clear();
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            textBoxserch.Clear();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("قصد خروج دارید؟", "خروج", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void textBoxserch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("لطفا مقدار عددی وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
