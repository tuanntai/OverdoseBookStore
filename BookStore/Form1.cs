using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace BookStore
{
    public partial class Form1 : Form
    {
        DBSqlUtils con;
        private static SqlConnection sqlConnections;
        private SqlDataAdapter dataAdapter;
        private SqlCommand sqlCommand;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            login.Focus();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            UserList userList = new UserList();
            userList.Show();
        }

        private void BookBtn_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Display()
        {
            con = new DBSqlUtils();
            string query = "select BookID,BookTitle,Author,Publisher,Language,image,Amount from BookTable";
            DataTable TableBook = con.RunQuery(query);
            dataGridView1.DataSource = TableBook;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display();
        }
    }
}
