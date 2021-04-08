using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orderFollowing.forms
{
    public partial class billsForm : Form
    {
        public billsForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm mainForm = new mainForm();
            mainForm.ShowDialog();
            this.Close();
        }

        private void btnOpenBills_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Open Bills";
        }

        private void btnClosedBills_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Closed Bills";
        }

        private void dGridView_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
