﻿using MySqlX.XDevAPI.Relational;
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
        DataBaseSQLServer dataBase;
        public AdoptedForm()
        {
            dataBase = new DataBaseSQLServer();
            InitializeComponent();
            InitializeTable("Adopted");
        }

        private void GoToStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.ShowDialog();
        }

        public void InitializeTable(string name_)
        {
            var boxColumns = CommonMethods.GetTable();
            Table.Columns.AddRange(boxColumns.ToArray());

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

        private void buttoGoAddAdoptedForm(object sender, EventArgs e)
        {
            this.Hide();
            AddAdoptedForm startForm = new AddAdoptedForm();
            startForm.ShowDialog();
        }
    }
}
