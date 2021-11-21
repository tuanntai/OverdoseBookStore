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
            SqlConnection ConnectionString = new SqlConnection(@"Data Source=Overdoseee;Initial Catalog=OverdoseBook;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM UserTable WHERE Username='" + Username + "' AND password='" + Password + "'", ConnectionString);
            
            sda.Fill(dt);
            
            if (dt.Rows[0][0].ToString() == "1")
            {
                alertSuccess.Show();
                this.Close();
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

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

       
    }
}
