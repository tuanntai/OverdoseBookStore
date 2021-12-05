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
    public partial class AddEditPublisher : Form
    {
        DBSqlUtils con;
       
        public AddEditPublisher()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            FormPage formPage = new FormPage();
            con = new DBSqlUtils();
            string insertQuery = "insert into publisher (publishername) values (N'" + publisherInput.Text + "')";
            try { 
                con.RunQuery(insertQuery);
                this.Close();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Insert Error:";
                msg += ex.Message;
            }
        }
    }
}
