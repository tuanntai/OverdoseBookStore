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
    public partial class UserList : Form
    {
        DBSqlUtils con;
        private SqlConnection sqlConnection;
        private SqlDataAdapter sqlDataAdapter;
        private SqlCommand sqlCommand;
        public UserList()
        {
            InitializeComponent();
        }

        public void Display()
        {
            con = new DBSqlUtils();
            String query = "select UserID,FullName,Dob,Sex,Email,Address,PhoneNumber form UserTable";
            DataTable dataTable = con.RunQuery(query);
            UserListGridView.DataSource = dataTable;
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void UserListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
