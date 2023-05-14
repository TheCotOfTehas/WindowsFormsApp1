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
        public AdoptedForm()
        {
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
           CommonMethods.InitializeTable2(name_, Table);
        }

        private void buttoGoAddAdoptedForm(object sender, EventArgs e)
        {
            this.Hide();
            AddAdoptedForm startForm = new AddAdoptedForm();
            startForm.ShowDialog();
        }
    }
}
