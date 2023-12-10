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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (textbookname.Text != "" && textwhriter.Text != "" && textpobliesher.Text != "" && textbookprice.Text != "" && textbooktype.Text != "")
            {
                string bname = textbookname.Text;
                string bauthor = textwhriter.Text;
                string publish = textpobliesher.Text;
                string pdata = poblishdata1.Text;
                string price = textbookprice.Text;
                string type = textbooktype.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.;Initial Catalog=library;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;


                con.Open();
                cmd.CommandText = "insert into NewBook1 (bName,bAuthor,bPubl,bPDate,bPrice,type)values(N'" + bname + "',N'" + bauthor + "',N'" + publish + "',N'" + pdata + "',N'" + price + "',N'" + type + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("با موفقیت ذخیره شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textbookname.Clear();
                textwhriter.Clear();
                textpobliesher.Clear();
                textbookprice.Clear();
                textbooktype.Clear();
            }
            else
            {
                MessageBox.Show("!نمی توانید فیلد ها را خالی بگذارید", "!توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" این عمل باعث از دست رفتن اطلاعات ذخیره نشده میشود", "مطمِئن هستید؟", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void textbookprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("لطفا مقدار عددی وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            Font = Properties.Settings.Default.font;
            ForeColor = Properties.Settings.Default.color;
        }
    }
  
}
