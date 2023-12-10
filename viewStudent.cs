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
    public partial class viewStudent : Form
    {
        public viewStudent()
        {
            InitializeComponent();
        }

        Int64 bid;
        Int64 rowid;
        private void viewStudent_Load(object sender, EventArgs e)
        {
            ForeColor = Properties.Settings.Default.color;
            Font = Properties.Settings.Default.font;
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
        }

        private void serch_TextChanged(object sender, EventArgs e)
        {
            if (serch.Text != "")
            {
               

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from NewStudent where Name LIKE '" + serch.Text + "%' ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

            }
            else
            {
                

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from NewStudent";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value !=null)
            {
                bid =Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            panel2.Visible = true;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from NewStudent where NationalCode ='"+bid+"'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            rowid = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());

            textNationalCode.Text = DS.Tables[0].Rows[0][0].ToString();
            textName.Text = DS.Tables[0].Rows[0][1].ToString();
            textLastName.Text = DS.Tables[0].Rows[0][2].ToString();
            textFatherName.Text = DS.Tables[0].Rows[0][3].ToString();
            textphone.Text = DS.Tables[0].Rows[0][4].ToString();
            textFieldofStudy.Text = DS.Tables[0].Rows[0][5].ToString();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Int64 na = Int64.Parse(textNationalCode.Text);
            string name = textName.Text;
            string lname = textLastName.Text;
            string faname = textFatherName.Text;
            Int64 phone = Int64.Parse(textphone.Text);
            string fil = textFieldofStudy.Text;

            if (MessageBox.Show("بروز رسانی اطلاعات را تایید می کنید؟", "تایید بروز رسانی", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update NewStudent set NationalCode=" + na + ",Name=N'" + name + "',LastName=N'" + lname + "',FatherName=N'" + faname + "',phone=" + phone + ",FieldofStudy=N'" + fil + "'where NationalCode=" + rowid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                viewStudent_Load(this, null);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("حذف اطلاعات را تایید می کنید؟", "تایید حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from NewStudent where NationalCode=" + rowid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                viewStudent_Load(this, null);
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            viewStudent_Load(this, null);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" از خروج اطمینان دارید؟ تمام داده های ذخیره نشده از بین خواهد رفت", "تایید خروج", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void textNationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("لطفا مقدار عددی وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void textphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("لطفا مقدار عددی وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
