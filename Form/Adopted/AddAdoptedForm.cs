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

namespace WindowsFormsApp1
{
    public partial class AddAdoptedForm : Form
    {
        public AddAdoptedForm()
        {
            InitializeComponent();
        }

        private void GoToStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.ShowDialog();
        }

        private void AddProductAdoptedButon(object sender, EventArgs e)
        {
            string nameTable = "[dbo].[Adopted]";
            string name = nameBox.Text;
            int lengthMy = int.Parse(lengthMyBox.Text);
            int widthMy = int.Parse(widthMyBox.Text);
            int heightMy = int.Parse(heightMyBox.Text);
            string statusMy = "Принят";

            string command = $"INSERT {nameTable} ([Name], [LengthMy], [WidthMy], [HeightMy], [StatusMy])\r\n" +
                                        $"VALUES (N'{name}', {lengthMy}, {widthMy}, {heightMy},  N'{statusMy}')";

            CommonMethods.dataBase.OpenConnecton();
            var sqlConnection = CommonMethods.dataBase.GetConnection();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            CommonMethods.dataBase.CloseConnecton();

            this.Hide();
            AdoptedForm startForm = new AdoptedForm();
            startForm.ShowDialog();
        }
    }
}
