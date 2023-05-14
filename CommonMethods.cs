using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class CommonMethods
    {
        private static DataBaseSQLServer dataBase = new DataBaseSQLServer();

        public static List<DataGridViewTextBoxColumn> GetTable()
        {
            var result = new List<DataGridViewTextBoxColumn>();
            DataGridViewTextBoxColumn columnId = new DataGridViewTextBoxColumn();
            columnId.Name = "Id";
            columnId.HeaderText = "Id";
            result.Add(columnId);

            DataGridViewTextBoxColumn columnName = new DataGridViewTextBoxColumn();
            columnName.Name = "Name";
            columnName.HeaderText = "Name";
            result.Add(columnName);

            DataGridViewTextBoxColumn columnLengthMy = new DataGridViewTextBoxColumn();
            columnLengthMy.Name = "LengthMy";
            columnLengthMy.HeaderText = "LengthMy";
            result.Add(columnLengthMy);

            DataGridViewTextBoxColumn columnWidthMy = new DataGridViewTextBoxColumn();
            columnWidthMy.Name = "WidthMy";
            columnWidthMy.HeaderText = "WidthMy";
            result.Add(columnWidthMy);

            DataGridViewTextBoxColumn columnHeightMy = new DataGridViewTextBoxColumn();
            columnHeightMy.Name = "HeightMy";
            columnHeightMy.HeaderText = "HeightMy";
            result.Add(columnHeightMy);

            DataGridViewTextBoxColumn columnStatusMy = new DataGridViewTextBoxColumn();
            columnStatusMy.Name = "StatusMy";
            columnStatusMy.HeaderText = "StatusMy";
            result.Add(columnStatusMy);

            return result;
        }

        public static void InitializeTable2(string name_, DataGridView DataGridView)
        {
            var boxColumns = CommonMethods.GetTable();
            DataGridView.Columns.AddRange(boxColumns.ToArray());

            dataBase.OpenConnecton();
            var sqlConnection = dataBase.GetConnection();
            string command = $"SELECT TOP (1000) [Id]\r\n ,[Name]\r\n ,[LengthMy]\r\n ,[WidthMy]\r\n ,[HeightMy]\r\n ,[StatusMy]\r\n  FROM [dbo].[{name_}]";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            var sqlDataReader = sqlCommand.ExecuteReader();


            while (sqlDataReader.Read())
            {
                int id = Convert.ToInt32(sqlDataReader["Id"]);
                string name = (string)sqlDataReader["Name"];
                int lengthMy = Convert.ToInt32(sqlDataReader["LengthMy"]);
                int widthMy = Convert.ToInt32(sqlDataReader["WidthMy"]);
                int heightMy = Convert.ToInt32(sqlDataReader["HeightMy"]);
                string statusMy = (string)sqlDataReader["StatusMy"];

                var Id = new DataGridViewTextBoxCell() { Value = id };
                var Name = new DataGridViewTextBoxCell() { Value = name };
                var LengthMy = new DataGridViewTextBoxCell() { Value = lengthMy };
                var WidthMy = new DataGridViewTextBoxCell() { Value = widthMy };
                var HeightMy = new DataGridViewTextBoxCell() { Value = heightMy };
                var StatusMy = new DataGridViewTextBoxCell() { Value = statusMy };

                DataGridViewRow rowCurrent = new DataGridViewRow();
                rowCurrent.Cells.AddRange(Id, Name, LengthMy, WidthMy, HeightMy, StatusMy);

                DataGridView.Rows.Add(rowCurrent);
            }

            dataBase.CloseConnecton();
        }
    }
}
