using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp1
{
    internal class DataBaseSQLServer
    {
        SqlConnection sqlConnection;
        public DataBaseSQLServer() 
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
        }

        //строка подключения ка моему SQL Server на компе
        //SqlConnection conn = new SqlConnection(@"Data Source=THECOTOFTEHAS; Database=Warehouse; Persist Security Info=false; User ID='sa'; Password='1h23O4567fd'; MultipleActiveResultSets=True; Trusted_Connection=False;");
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tsebr\source\repos\WindowsFormsApp1\Database.mdf;Integrated Security=True");
        public void OpenConnecton()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
        }

        public void CloseConnecton()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
                sqlConnection.Close();
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
