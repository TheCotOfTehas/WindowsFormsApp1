using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void Adopted_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdoptedForm adoptedForm = new AdoptedForm();
            adoptedForm.ShowDialog();
        }

        private void InStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            InStockForm inStockForm = new InStockForm();
            inStockForm.ShowDialog();
        }

        private void Sold_Click(object sender, EventArgs e)
        {
            this.Hide();
            SoldForm soldForm = new SoldForm();
            soldForm.ShowDialog();
        }
    }
}
