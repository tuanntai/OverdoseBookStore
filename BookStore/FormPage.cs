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
    public partial class FormPage : Form
    {
        DBSqlUtils con;
        private static SqlConnection sqlConnections;
        private SqlDataAdapter dataAdapter;
        private SqlCommand sqlCommand;
        public FormPage()
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
            hidebutton();
        }

       

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void DisplayBook()
        {
            con = new DBSqlUtils();
            string query = "select db.bookid,booktitle,authorname,g.genrename,p.publishername,language,image,amount from book db join bookauthor ba on db.bookid = ba.bookid join author a on ba.authorid = a.authorid join publisher p on p.publisherid = db.publisherid join genrebook bg on bg.bookid = db.bookid join genre g on g.genreid = bg.genreid";
            DataTable TableBook = con.RunQuery(query);
            dataGridView1.DataSource = TableBook;
        }
        public void DisplayBookSold()
        {
            con = new DBSqlUtils();
            string query = "select soldid,b.booktitle,bs.amount,datesold,total from booksold bs join book b on bs.bookid=b.bookid";
            DataTable TableBook = con.RunQuery(query);
            dataGridView2.DataSource = TableBook;
        }
        public void DisplayBookRent()
        {
            con = new DBSqlUtils();
            string query = "select rentid,b.booktitle,daterented,datereturn,deposit,br.amount,total from bookrent br join book b on br.bookid = b.bookid";
            DataTable TableBook = con.RunQuery(query);
            dataGridView3.DataSource = TableBook;
        }
        public void DisplayBookAuthor()
        {
            con = new DBSqlUtils();
            string query = "select soldid,b.booktitle,bs.amount,datesold,total from booksold bs join book b on bs.bookid=b.bookid";
            DataTable TableBook = con.RunQuery(query);
            dataGridView4.DataSource = TableBook;
        }
        public void DisplayBookPublisher()
        {
            con = new DBSqlUtils();
            string query = "select * from publisher";
            DataTable TableBook = con.RunQuery(query);
            dataGridView5.DataSource = TableBook;
        }
        public void DisplayBookGenre()
        {
            con = new DBSqlUtils();
            string query = "select * from genre";
            DataTable TableBook = con.RunQuery(query);
            dataGridView6.DataSource = TableBook;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hidebutton();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void hidebutton()
        {
            Change.Hide();
            Change2.Hide();
            Change3.Hide();
            Change4.Hide();
            Change5.Hide();
            Change6.Hide();
        }
        private void girdviewHide()
        {
            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Hide();
            dataGridView5.Hide();
            dataGridView6.Hide();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Book book = new Book();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            hidebutton();
            girdviewHide();
            pictureBox2.Show();

        }
        private void UserButton_Click(object sender, EventArgs e)
        {

            pictureBox2.Hide();
            hidebutton();
            Change.Show();
            girdviewHide();
            dataGridView1.Show();
            DisplayBook();
        }

        private void BookBtn_Click(object sender, EventArgs e)
        {

            pictureBox2.Hide();
            hidebutton();
            Change2.Show();
            girdviewHide();
            dataGridView2.Show();
            DisplayBookSold();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            pictureBox2.Hide();
            hidebutton();
            Change3.Show();
            girdviewHide();
            dataGridView3.Show();
            DisplayBookRent();
        }

        private void AuthorBtn_Click(object sender, EventArgs e)
        {

            pictureBox2.Hide();
            hidebutton();
            Change4.Show();
            girdviewHide();
            dataGridView4.Show();
            DisplayBookAuthor();
        }

        private void PublisherBtn_Click(object sender, EventArgs e)
        {

            pictureBox2.Hide();
            hidebutton();
            Change5.Show();
            girdviewHide();
            dataGridView5.Show();
            DisplayBookPublisher();
        }

        private void GenreBtn_Click(object sender, EventArgs e)
        {

            pictureBox2.Hide();
            hidebutton();
            Change6.Show();
            girdviewHide();
            dataGridView6.Show();
            DisplayBookGenre();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Change2_Click(object sender, EventArgs e)
        {

        }

        private void Change3_Click(object sender, EventArgs e)
        {

        }
        private void Change4_Click(object sender, EventArgs e)
        {

        }

        private void Change5_Click(object sender, EventArgs e)
        {

        }

        private void Change6_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void NhanVienbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
