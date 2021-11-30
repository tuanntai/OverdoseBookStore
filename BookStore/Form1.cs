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
using System.IO;

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
            string query = "select db.bookid,booktitle,authorname,publisherid,language,image,amount from book db join bookauthor ba on db.bookid=ba.bookid join author a on ba.authorid=a.authorid";
            DataTable TableBook = con.RunQuery(query);
            TableBook.Columns.Add("Pic", Type.GetType("System.Byte[]"));
            foreach(DataRow dataRow in TableBook.Rows){
                dataRow["Pic"] = File.ReadAllBytes(dataRow["image"].ToString());
            }
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
