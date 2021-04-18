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
        cPaymentTypeOperations pType;
        cGetOrdersOfTable ordersOfTable;
        cPaymentOperations payment;

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
            bill.sqlQuery = "select billID as 'Bill No', BILLS.tableID, rowNumber as 'Table No', Total, openingTime as 'Opening Time', "
            + "case when closingTime is NULL then '---' end as 'Closing Time' from BILLS inner join TABLES on "
            + "BILLS.tableID = TABLES.tableID where billStatus = 1 and closingTime is NULL "
            + "and openingTime between @open and @closed order by billID asc";

            bill.openingTime = DateTime.Now.Date;
            bill.closingTime = DateTime.Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            bill.getAllBills();
            dGridView.DataSource = bill.dataTable;
            dGridView.Columns["tableID"].Visible = false;
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
            bill.sqlQuery = "select billID as 'Bill No', BILLS.tableID, rowNumber as 'Table No', Total, openingTime as 'Opening Time', "
            + "closingTime as 'Closing Time' from BILLS inner join TABLES on BILLS.tableID = TABLES.tableID where billStatus = 0 "
            + "and openingTime between @open and @closed order by billID desc";

            bill.openingTime = DateTime.Now.Date;
            bill.closingTime = DateTime.Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            bill.getAllBills();
            dGridView.DataSource = bill.dataTable;
            dGridView.Columns["tableID"].Visible = false;
        }

        private void dGridView_DoubleClick(object sender, EventArgs e)
        {
            if (lblTitle.Text == "Open Bills")
            {
                pnlConfirmPayment.Visible = true;

                fillCBoxPType();
                showTablesOrders();
            }
        }

        void fillCBoxPType()
        {
            pType = new cPaymentTypeOperations();
            pType.sqlQuery = "select explanation as 'Payment Type' from PAYMENTTYPE";
            pType.showPaymentTypes();

            CBoxPType.DataSource = pType.dataTable;
            CBoxPType.DisplayMember = "Payment Type";
        }

        void showTablesOrders()
        {
            ordersOfTable = new cGetOrdersOfTable();
            ordersOfTable.sqlQuery = "select productName as 'Product', SUM(Quantity) as 'Quantity' from ORDERS inner join "
            + "PRODUCTS on PRODUCTS.productID = ORDERS.productID where tableID = @tableId and billId = @billId group by productName";

            ordersOfTable.tableId = dGridView.CurrentRow.Cells["Table No"].Value.ToString();
            ordersOfTable.billId = Convert.ToInt32(dGridView.CurrentRow.Cells["Bill No"].Value);
            ordersOfTable.GetOrdersFromSql();

            fillLViewOrders();
        }

        void fillLViewOrders()
        {
            LViewOrders.Items.Clear();
            LViewOrders.View = View.Details;
            CHProduct.Width = LViewOrders.Width / 2;
            CHQuantity.Width = CHProduct.Width;

            foreach (DataRow row in ordersOfTable.dataTable.Rows)
            {
                ListViewItem listItem = new ListViewItem(row["Product"].ToString());
                listItem.SubItems.Add(row["Quantity"].ToString());
                LViewOrders.Items.Add(listItem);
            }
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            confirmClosingBill();
        }

        void confirmClosingBill()
        {
            DialogResult result = MessageBox.Show("Are you sure to close this account?", "Close Account", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                closeTableAccount();
                closeTableBill();
                executePayment();
                showOpenBills();
                pnlConfirmPayment.Visible = false;
            }
        }

        void closeTableAccount()
        {
            table = new cTableOperations();
            table.tableId = dGridView.CurrentRow.Cells["tableID"].Value.ToString();
            table.closeAccount();
        }

        void closeTableBill()
        {
            bill = new cBillOperations();
            bill.sqlQuery = "update BILLS set closingTime = @closingTime, billStatus = 0 where billID = @billId";
            bill.closingTime = DateTime.Now;
            bill.billId = Convert.ToInt32(dGridView.CurrentRow.Cells["Bill No"].Value);
            bill.closeBill();
        }

        void executePayment()
        {
            payment = new cPaymentOperations();
            payment.sqlQuery = "update PAYMENTS set paymentTotal = @total, date = @payTime, paymentType = @pType, "
            + "paymentStatus = 1 where billID = @billId and tableID = @tableId";
            payment.billId = Convert.ToInt32(dGridView.CurrentRow.Cells["Bill No"].Value);
            payment.tableId = Convert.ToInt32(dGridView.CurrentRow.Cells["tableID"].Value);
            payment.total = Convert.ToInt32(dGridView.CurrentRow.Cells["Total"].Value);
            payment.paymentTime = DateTime.Now;
            payment.paymentType = (CBoxPType.SelectedIndex) + 1;

            label3.Text = "bill " + payment.billId.ToString() + " table " + payment.tableId.ToString() + " total " + payment.total.ToString()
            + " time " + payment.paymentTime.ToString() + " pType " + payment.paymentType.ToString();
            payment.closePayment();
        }

        private void btnCloseConfirmPPanel_Click(object sender, EventArgs e)
        {
            pnlConfirmPayment.Visible = false;
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
