using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BookStore
{
    public partial class AddEditAuthor : Form
    {
        DBSqlUtils con;
        public AddEditAuthor()
        {
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            FormPage formPage = new FormPage();
            con = new DBSqlUtils();
            string insertQuery = "insert into author (authorname) values (N'" + publisherInput.Text + "')";
            try
            {
                con.RunQuery(insertQuery);
                this.Close();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Insert Error:";
                msg += ex.Message;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
