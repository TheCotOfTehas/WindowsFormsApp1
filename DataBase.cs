using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal class DataBase
    {
        //строка подключения ка моему SQL Server на компе
        SqlConnection conn = new SqlConnection(@"Data Source=THECOTOFTEHAS; Database=Warehouse; Persist Security Info=false; User ID='sa'; Password='1h23O4567fd'; MultipleActiveResultSets=True; Trusted_Connection=False;");
        public void OpenConnecton()
        {
            if (conn.State == System.Data.ConnectionState.Closed) 
                conn.Open();
        }

        public void CloseConnecton()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }

        public SqlConnection GetConnection()
        {
            return conn;
        }
    }
}
