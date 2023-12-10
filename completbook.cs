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
    public partial class completbook : Form
    {
        public completbook()
        {
            InitializeComponent();
        }

        private void completbook_Load(object sender, EventArgs e)
        {
            ForeColor = Properties.Settings.Default.color;
            Font = Properties.Settings.Default.font;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.;Initial Catalog=library;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from IssuBook where Book_issu_Data is not null ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

          
        }
    }
}
