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
    public partial class Login : Form
    {
        DBSqlUtils con;
        private static SqlConnection sqlConnections;
        private SqlDataAdapter dataAdapter;
        private SqlCommand sqlCommand;
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = Username;
        }

        private void CheckLogin(string Username, string Password)
        {
            DataTable dt = new DataTable();
            LoginFail alertFail = new LoginFail();
            LoginSuccess alertSuccess = new LoginSuccess();
            FormPage formPage = new FormPage();
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-751CRMG1;Initial Catalog= OverdoseBook;User ID=Vinh;Password=1");
            SqlConnection ConnectionString = new SqlConnection(@"Data Source=Overdoseee;Initial Catalog=OverdoseBook;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM usertable WHERE username='" + Username + "' AND password='" + Password + "'", con);
            
            sda.Fill(dt);
            
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                formPage.Show();
            }
            else
                alertFail.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (Username.Text == "")
            {
                MessageBox.Show("Please Enter Your Account !");
            }
            else if (Password.Text == "")
            {
                MessageBox.Show("Please Enter Your Password !");
            }
            else
            {
                CheckLogin(Username.Text,Password.Text);
            }
        }

        private void Password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Username.Text == "")
            {
                MessageBox.Show("Please Enter Your Account !");
            }
            else if (e.KeyCode == Keys.Enter)
            {
                CheckLogin(Username.Text, Password.Text);
            }
        }

        private void Username_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Password.Text=="")
            {
                Password.Focus();
            }
        }


       
    }
}
