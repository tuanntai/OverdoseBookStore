using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace BookStore
{
    class DBSqlUtils
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter dataAdapter;
        public DBSqlUtils()
        {
        }
        public static SqlConnection
            GetDBConnection(string datasource, string database)
        {
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
        string conStr = @"Data Source=LAPTOP-751CRMG1;Initial Catalog= OverdoseBook;User ID=Vinh;Password=1";
        public bool Open()
        {
            try
            {
                sqlConnection = new SqlConnection(conStr);
                sqlConnection.Open();
            return true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error " + ex.Number.ToString());
                sqlConnection = null;
                return false;
            }
        }
        public DataTable RunQuery(string QueryString)
        {
            DataTable myDataTable = new DataTable();
            dataAdapter = new SqlDataAdapter();
            sqlConnection = new SqlConnection(conStr);
            sqlConnection.Open();
            try
            {
                dataAdapter = new SqlDataAdapter(QueryString, sqlConnection);
                SqlCommandBuilder mySqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(myDataTable);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error " + ex.Number.ToString());
                return null;
            }
            return myDataTable;
        }
        public void Update(DataTable myDataTable)
        {
            try
            {
                dataAdapter.Update(myDataTable);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error " + ex.Number.ToString());
            }
        }
        public void ExecuteNonQuery(string cmdString)
        {
            SqlCommand mySqlCommand = new SqlCommand(cmdString, sqlConnection);
            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error " + ex.Number.ToString());
            }
        }
    }

}
