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
    public partial class viewbook : Form
    {
        public viewbook()
        {
            InitializeComponent();
        }

        Int64 rowid;
        int bid;
        private void viewbook_Load(object sender, EventArgs e)
        {
            ForeColor = Properties.Settings.Default.color;
            Font = Properties.Settings.Default.font;
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewBook1";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewBook1 where bid=" + bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            Bookname.Text = ds.Tables[0].Rows[0][1].ToString();

            Whriter.Text = ds.Tables[0].Rows[0][2].ToString();

            publisher.Text = ds.Tables[0].Rows[0][3].ToString();

            publishdate.Text = ds.Tables[0].Rows[0][4].ToString();

            Price.Text = ds.Tables[0].Rows[0][5].ToString();

            Type.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void cansel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void textBookname_TextChanged(object sender, EventArgs e)
        {
            if (textBookname.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewBook1 where bName LIKE '" + textBookname.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewBook1";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            viewbook_Load(this, null);
            textBookname.Clear();
            panel2.Visible = false;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("بروز کردن اطلاعات را تایید می کنید؟", "موفقیت آمیز", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string bname = Bookname.Text;
                string bauthor = Whriter.Text;
                string publication = publisher.Text;
                string pdate = publishdate.Text;
                Int64 price = Int64.Parse(Price.Text);
                string type = Type.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update NewBook1 set bName = N'" + bname + "', bAuthor=N'" + bauthor + "',bPubl=N'" + publication + "',bPDate=N'" + pdate + "',bPrice=N" + price + ",type=N'" + type + "' where bid=N" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                viewbook_Load(this, null);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("حذف اطلاعت را تایید می کنید؟", "تایید حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewBook1 where bid=" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                viewbook_Load(this, null);
            }
        }
    }
}
