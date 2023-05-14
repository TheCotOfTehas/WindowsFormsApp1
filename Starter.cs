using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class Starter
    {
        public static SqlConnection sqlConnection;
        static Starter() 
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
        }
        public static void Run()
        {
             CreateTables();
        }

        public static bool availabilityTables(string name)
        {
            bool result = false;

            sqlConnection.Open();
            var davailabilityTablesCommand = "IF EXISTS (SELECT 1 \r\n " +
                "FROM INFORMATION_SCHEMA.TABLES \r\n " +
                " WHERE TABLE_TYPE='BASE TABLE' \r\n " +
                $"AND TABLE_NAME='{name}')\r\n\t\t " +
                "SELECT 1 AS res ELSE SELECT 0 AS res;";

            SqlCommand sqlCommand = new SqlCommand(davailabilityTablesCommand, sqlConnection);
            var queryResult = sqlCommand.ExecuteReader();
            queryResult.Read();
            var r = queryResult["res"];
            result = Convert.ToBoolean(queryResult["res"]);
            sqlConnection.Close();

            return result;
        }

        public static void CreateTables()
        {
            CreateTable("Adopted");
            CreateTable("InStock");
            CreateTable("Sold");
        }

        public static void CreateTable(string name)
        {
            if (!availabilityTables(name))
            {
                sqlConnection.Open();
                string command1 = $"CREATE TABLE [dbo].[{name}]\r\n(\r\n\t" +
                    "[Id] INT PRIMARY KEY IDENTITY(1,1),\r\n\t" +
                    "[Name] NCHAR(50),\r\n\t" +
                    "[LengthMy] NCHAR(50),\r\n\t" +
                    "[WidthMy] NCHAR(50),\r\n\t" +
                    "[HeightMy] NCHAR(50),\r\n\t" +
                    "[StatusMy] NCHAR(50)\r\n)";

                SqlCommand sqlCommand1 = new SqlCommand(command1, sqlConnection);
                sqlCommand1.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

            //public static void InsertTable()
            //{
            //    sqlConnection.Open();
            //    string command = "INSERT [dbo].[Customers] ([Name], [LengthMy], [WidthMy], [HeightMy], [StatusMy])" +
            //       "VALUES(N'Товар1', 5, 4, 5, N'Adopted'),"+
            //       "(N'Товар 2', 5, 4, 5,  N'Adopted'),"+
            //       "(N'Товар 3', 5, 4, 5,  N'SoldForm'),"+
            //       "(N'Товар 4', 5, 4, 5,  N'Adopted'),"+
            //       "(N'Товар 5', 5, 4, 5,  N'InStockForm'),"+
            //       "(N'Товар 6', 5, 4, 5,  N'SoldForm'),"+
            //       "(N'Товар 7', 5, 4, 5,  N'SoldForm'),"+
            //       "(N'Товар 8', 5, 4, 5,  N'InStockForm');";

            //    SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            //    sqlCommand.ExecuteNonQuery();
            //    sqlConnection.Close();
            //}
    }
}
