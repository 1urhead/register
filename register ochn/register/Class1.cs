using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace register
{
    internal class Class1
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-U1U3DFA;Initial Catalog = Molbase;Integrated Security = True");


        public void openConnection() 
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) { sqlConnection.Open(); }
        }
        public void closeConnection()
        { 
            if (sqlConnection.State == System.Data.ConnectionState.Open) { sqlConnection.Close(); }
        }
        public SqlConnection GetConnection() { return sqlConnection; }
    }
}
