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
    public partial class ordersForm : Form
    {
        public ordersForm()
        {
            InitializeComponent();
        }

        private void btnNewOrders_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "New Orders";
        }

        private void btnPreparingOrders_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Orders In Making";
        }

        private void btnReadyOrders_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Ready Orders";
        }

        private void btnDeliveredOrders_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Delivered Orders";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm mainForm = new mainForm();
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
