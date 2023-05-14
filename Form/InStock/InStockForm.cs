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
    public partial class InStockForm : Form
    {
        DataBaseSQLServer dataBase;
        public InStockForm()
        {
            dataBase = new DataBaseSQLServer();
            InitializeComponent();
            InitializeTable("InStock");
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
            AddInStockForm startForm = new AddInStockForm();
            startForm.ShowDialog();
        }
    }
}
