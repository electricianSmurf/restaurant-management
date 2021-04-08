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
        cBillOperations bill;
        cTableOperations table;

        public billsForm()
        {
            InitializeComponent();
        }

        private void billsForm_Load(object sender, EventArgs e)
        {
            dGridViewSettings();
            showOpenBills();
        }

        void dGridViewSettings()
        {
            dGridView.AllowUserToResizeRows = false;
            dGridView.AllowUserToResizeColumns = false;
            dGridView.ReadOnly = true;
            dGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void showOpenBills()
        {
            bill = new cBillOperations();
            bill.sqlQuery = "select billID as 'Bill No', tableID as 'Table No', Total, openingTime as 'Opening Time', "
            + "case when closingTime is NULL then '---' end as 'Closing Time' from BILLS where billStatus = 1 and "
            + "closingTime is NULL and openingTime between @open and @closed order by billID asc";

            bill.openingTime = DateTime.Now.Date;
            bill.closingTime = DateTime.Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            bill.getAllBills();
            dGridView.DataSource = bill.dataTable;
        }

        private void btnOpenBills_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Open Bills";
            showOpenBills();
        }

        private void btnClosedBills_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Closed Bills";
            showClosedBills();
        }

        void showClosedBills()
        {
            bill = new cBillOperations();
            bill.sqlQuery = "select billID as 'Bill No', tableID as 'Table No', Total, openingTime as 'Opening Time', "
            + "closingTime as 'Closing Time' from BILLS where billStatus = 0 and openingTime between "
            + "@open and @closed order by billID desc";

            bill.openingTime = DateTime.Now.Date;
            bill.closingTime = DateTime.Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            bill.getAllBills();
            dGridView.DataSource = bill.dataTable;
        }

        private void dGridView_DoubleClick(object sender, EventArgs e)
        {
            if (lblTitle.Text == "Open Bills")
            {
                DialogResult result = MessageBox.Show("Are you sure to close this account?", "Close Account", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    closeTableBill();
                    closeTableAccount();
                    showOpenBills();
                }
            }
        }

        void closeTableBill()
        {
            bill = new cBillOperations();
            bill.sqlQuery = "update BILLS set closingTime = @closingTime, billStatus = 0 where billID = @billId";
            bill.closingTime = DateTime.Now;
            bill.billId = Convert.ToInt32(dGridView.CurrentRow.Cells["Bill No"].Value);
            label1.Text = bill.billId.ToString();
            bill.closeBill();
        }

        void closeTableAccount()
        {
            table = new cTableOperations();
            table.tableId = dGridView.CurrentRow.Cells["Table No"].Value.ToString();
            table.closeAccount();
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
