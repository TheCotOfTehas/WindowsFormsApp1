using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
    public partial class AdoptedForm : Form
    {
        DataBaseSQLServer dataBase = new DataBaseSQLServer();
        public AdoptedForm()
        {
            InitializeComponent();
            doSom();
        }

        private void GoToStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.ShowDialog();
        }

        public void doSom()
        {
            DataGridViewTextBoxColumn columnId = new DataGridViewTextBoxColumn();
            columnId.Name = "Id";
            columnId.HeaderText = "Id";

            DataGridViewTextBoxColumn columnName = new DataGridViewTextBoxColumn();
            columnName.Name = "Name";
            columnName.HeaderText = "Name";

            DataGridViewTextBoxColumn columnLengthMy = new DataGridViewTextBoxColumn();
            columnLengthMy.Name = "LengthMy";
            columnLengthMy.HeaderText = "LengthMy";

            DataGridViewTextBoxColumn columnWidthMy = new DataGridViewTextBoxColumn();
            columnWidthMy.Name = "WidthMy";
            columnWidthMy.HeaderText = "WidthMy";

            DataGridViewTextBoxColumn columnHeightMy = new DataGridViewTextBoxColumn();
            columnHeightMy.Name = "HeightMy";
            columnHeightMy.HeaderText = "HeightMy";

            DataGridViewTextBoxColumn columnStatusMy = new DataGridViewTextBoxColumn();
            columnStatusMy.Name = "StatusMy";
            columnStatusMy.HeaderText = "StatusMy";

            Table.Columns.AddRange(columnId, columnName, columnLengthMy, columnWidthMy, columnHeightMy, columnStatusMy);
            dataBase.OpenConnecton();
            var sqlConnection = dataBase.GetConnection();
            string command = $"SELECT TOP (1000) [Id]\r\n      ,[Name]\r\n      ,[LengthMy]\r\n      ,[WidthMy]\r\n      ,[HeightMy]\r\n      ,[StatusMy]\r\n  FROM [dbo].[Customers]";
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

                DataGridViewCell Id = new DataGridViewTextBoxCell();
                DataGridViewCell Name = new DataGridViewTextBoxCell();
                DataGridViewCell LengthMy = new DataGridViewTextBoxCell();
                DataGridViewCell WidthMy = new DataGridViewTextBoxCell();
                DataGridViewCell HeightMy = new DataGridViewTextBoxCell();
                DataGridViewCell StatusMy = new DataGridViewTextBoxCell();

                Id.Value = id;
                Name.Value = name;
                LengthMy.Value = lengthMy;
                WidthMy.Value = widthMy;
                HeightMy.Value = heightMy;
                StatusMy.Value = statusMy;

                DataGridViewRow rowCurrent = new DataGridViewRow();
                rowCurrent.Cells.AddRange(Id, Name, LengthMy, WidthMy, HeightMy, StatusMy);

                Table.Rows.Add(rowCurrent);
            }

            dataBase.CloseConnecton();
        }

        public IEnumerable<string> GetCommandInsert(string nameTable)
        {
            int id = 1;
            string name = "";
            int lengthMy = 1;
            int widthMy = 1;
            int heightMy = 1;
            string statusMy = "";

            string command = $"INSERT [{nameTable}] ([Name], [LengthMy], [WidthMy], [HeightMy], [StatusMy])\r\n" +
                             $"VALUES (N'{name}', {lengthMy}, {widthMy}, {heightMy},  N'{statusMy}')";

            yield return command;
        }

        private void butto_Add(object sender, EventArgs e)
        {
            string nameTable = "[dbo].[Customers]";
            string name = nameBox.Text;
            int lengthMy = int.Parse(lengthMyBox.Text);
            int widthMy = int.Parse(widthMyBox.Text);
            int heightMy = int.Parse(heightMyBox.Text);
            string statusMy = statusMyBox.Text;

            string command = $"INSERT {nameTable} ([Name], [LengthMy], [WidthMy], [HeightMy], [StatusMy])\r\n" +
                                        $"VALUES (N'{name}', {lengthMy}, {widthMy}, {heightMy},  N'{statusMy}')";

            dataBase.OpenConnecton();
            var sqlConnection = dataBase.GetConnection();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            dataBase.CloseConnecton();
        }
    }
}
