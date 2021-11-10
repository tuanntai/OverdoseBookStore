using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            
        }

        private void SignUpAccount(string Username, string Password, string Email, string Phone, string Year)
        {
            SqlConnection conn = DBUtils.GetDBConnection();

            string signUpCommand = "INSERT INTO UserTable (Username,Password,Email,PhoneNumber,BirthYear,UserRole) " +
                "VALUES ('" + Username + "','" + Password + "','" + Email + "','" + Phone + "','" + Year + "','member')";
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = signUpCommand;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!!");
                conn.Close();
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("there was an issue!");
            }
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            SignUpAccount(Username.Text, Password.Text, Email.Text,Phone.Text,dateTimePicker1.Value.Year.ToString());
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmBtn_KeyUp(object sender, KeyEventArgs e)
        {
            if  (e.KeyCode == Keys.Enter)
            {
                SignUpAccount(Username.Text, Password.Text, Email.Text, Phone.Text, dateTimePicker1.Value.Year.ToString());
            }
        }
    }
}
