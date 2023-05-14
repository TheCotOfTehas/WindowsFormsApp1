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
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class SoldForm : Form
    {
        DataBaseSQLServer dataBase;
        public SoldForm()
        {
            dataBase = new DataBaseSQLServer();
            InitializeComponent();
            InitializeTable("Sold");
        }

        private void GoToStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.ShowDialog();
        }

        public void InitializeTable(string name_)
        {
            CommonMethods.InitializeTable2(name_, Table);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSoldForm startForm = new AddSoldForm();
            startForm.ShowDialog();
        }
    }
}
