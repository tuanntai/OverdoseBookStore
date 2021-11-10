using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = "Overdoseee";
            string database = "OverdoseBook";
            return DBSqlUtils.GetDBConnection(datasource, database);
        }
    }
}
