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
        DataBase dataBase = new DataBase();
        public AdoptedForm()
        {
            InitializeComponent();
            doSom();
        }

        //private void InitializeComponentMy()
        //{
        //    AddViews = new Button();
        //    SuspendLayout();
        //    AddViews.Location = new Point(200, 200);
        //    AddViews.Size = new Size(100, 23);
        //    AddViews.Text = "AddEntry";
        //    AddViews.Name = "Add";
        //    this.AddViews = new System.Windows.Forms.Button();
        //    this.SuspendLayout();
        //}

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
            string command = $"SELECT TOP (1000) [Id]\r\n      ,[Name]\r\n      ,[LengthMy]\r\n      ,[WidthMy]\r\n      ,[HeightMy]\r\n      ,[StatusMy]\r\n  FROM [Warehouse].[dbo].[Customers]";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            var sqlDataReader = sqlCommand.ExecuteReader();

            
            while (sqlDataReader.Read())
            {
                int id = (int)sqlDataReader["Id"];
                string name = (string)sqlDataReader["Name"];
                int lengthMy = (int)sqlDataReader["LengthMy"];
                int widthMy = (int)sqlDataReader["WidthMy"];
                int heightMy = (int)sqlDataReader["HeightMy"];
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

            string command = $"INSERT [{nameTable}] ([Id], [Name], [LengthMy], [WidthMy], [HeightMy], [StatusMy])\r\n" +
                             $"VALUES ({id}, N'{name}', {lengthMy}, {widthMy}, {heightMy},  N'{statusMy}')";

            yield return command;
        }

        private void butto_Add(object sender, EventArgs e)
        {
            string nameTable = "Warehouse].[dbo].[Customers";
            int id = int.Parse( IdBox.Text);
            string name = nameBox.Text;
            int lengthMy = int.Parse(lengthMyBox.Text);
            int widthMy = int.Parse(widthMyBox.Text);
            int heightMy = int.Parse(heightMyBox.Text);
            string statusMy = statusMyBox.Text;

            string command = $"INSERT [{nameTable}] ([Id], [Name], [LengthMy], [WidthMy], [HeightMy], [StatusMy])\r\n" +
                             $"VALUES ({id}, N'{name}', {lengthMy}, {widthMy}, {heightMy},  N'{statusMy}')";

            dataBase.OpenConnecton();
            var sqlConnection = dataBase.GetConnection();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            dataBase.CloseConnecton();
        }
    }
}
