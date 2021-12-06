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
namespace BookStore
{
    public partial class SeachForm : Form
    {
        DBSqlUtils con;
        public SeachForm()
        {
            InitializeComponent();
        }

        


        private void inputField_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && inputField.Text == "")
            {
                MessageBox.Show("Please Enter The Input Field !");
            }
            else if (e.KeyCode == Keys.Enter && bookRadio.Checked)
            {
                con = new DBSqlUtils();
                string query = "select * from book where booktitle LIKE N'%" + inputField.Text + "%'";
                DataTable TableBook = con.RunQuery(query);
                dataGridView1.DataSource = TableBook;
            }
            else if (e.KeyCode == Keys.Enter && authorRadio.Checked)
            {
                con = new DBSqlUtils();
                string query = "select * from author where authorname LIKE N'%" + inputField.Text + "%'";
                DataTable TableBook = con.RunQuery(query);
                dataGridView1.DataSource = TableBook;
            }
            else if (e.KeyCode == Keys.Enter && publisherRadio.Checked)
            {
                con = new DBSqlUtils();
                string query = "select * from publisher where publishername LIKE N'%" + inputField.Text + "%'";
                DataTable TableBook = con.RunQuery(query);
                dataGridView1.DataSource = TableBook;
            }
        }
    }
}
