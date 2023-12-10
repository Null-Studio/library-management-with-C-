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
    public partial class bookreturn : Form
    {
        public bookreturn()
        {
            InitializeComponent();
        }

        private void Serch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from IssuBook where NationalCode ='" + Serch_textbox.Text + "' and Book_return_Data IS NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("کد ملی اشتباه است یا کتابی امانت گرفته نشده ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Serch_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("لطفا مقدار عددی وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bookreturn_Load(object sender, EventArgs e)
        {
            ForeColor = Properties.Settings.Default.color;
            Font = Properties.Settings.Default.font;
            panel2.Visible = false;
            Serch_textbox.Clear();
        }
        string bname;
        string bdate;
        Int64 rowid;
        Int64 ncod;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                ncod = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            textBoxBookname.Text = bname;
            textBoxIssue.Text = bdate;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "update IssuBook set Book_return_Data =N'" + dateTimePicker1.Text + "' where NationalCode=" + Serch_textbox.Text + " and StdID=" + rowid + "";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("کتاب باز گردانده شد", "بازگشت موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bookreturn_Load(this, null);
        }

        private void Serch_textbox_TextChanged(object sender, EventArgs e)
        {
            if (Serch_textbox.Text == "")
            {
                panel2.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Serch_textbox.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("خارج می شوید؟ تمام داده های ذخیره نشده از بین خواهد رفت", "تمایل به خروج", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}
