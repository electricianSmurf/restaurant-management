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
        cOrderOperations showOrder;
        cUpdatePreparationStatus updateOrderStatus;

        Button btnClickedButton;

        public ordersForm()
        {
            InitializeComponent();
        }

        private void ordersForm_Load(object sender, EventArgs e)
        {
            dGridViewSettings();
            showDeliveredOrders();
            btnClickedButton = btnDeliveredOrders;
        }

        void dGridViewSettings()
        {
            dGridView.AllowUserToResizeRows = false;
            dGridView.AllowUserToResizeColumns = false;
            dGridView.ReadOnly = true;
            dGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void showDeliveredOrders()
        {
            showOrder = new cOrderOperations();
            showOrder.sqlQuery = "select staffNameSurname as 'Staff', productName as 'Product', ORDERS.tableID as 'Table No', "
            + "ORDERS.billID as 'Bill No', Quantity, openingTime as 'Bill Time' from ORDERS inner join STAFFS on "
            + "ORDERS.staffID = STAFFS.staffID inner join PRODUCTS on ORDERS.productID = PRODUCTS.productID "
            + "inner join BILLS on ORDERS.billID = BILLS.billID where orderStatus = 1 and openingTime between @startTime and @finishTime";
            
            showOrder.billStartTime = DateTime.Now.Date;
            showOrder.billFinishTime = DateTime.Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            showOrder.getDataFromOrders();

            dGridView.DataSource = showOrder.dataTable;
        }

        private void btnDeliveredOrders_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Delivered Orders";
            btnClickedButton = btnDeliveredOrders;
            showDeliveredOrders();
        }

        private void btnNewOrders_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "New Orders";
            btnClickedButton = btnNewOrders;
            showNewOrders();
        }

        void showNewOrders()
        {
            showOrder = new cOrderOperations();

            showOrder.sqlQuery = "select orderID, staffNameSurname as 'Staff', productName as 'Product', ORDERS.tableID as 'Table No', Quantity, "
            + "case when orderStatus = 1 then 'Delivered' else 'Undelivered' end as 'Delivery Status', "
            + "case when preparationStatus is null then 'New Order' when preparationStatus = 1 then 'Ready' else 'Preparing' end as 'Preparation Status', "
            + "billID from ORDERS inner join STAFFS on ORDERS.staffID = STAFFS.staffID inner join "
            + "PRODUCTS on ORDERS.productID = PRODUCTS.productID where orderStatus = 0 and preparationStatus is NULL";

            showOrder.showNewOrders();
            
            dGridView.DataSource = showOrder.dataTable;
            hideDGridViewColumns();
        }
        void hideDGridViewColumns()
        {
            dGridView.Columns["billID"].Visible = false;
            dGridView.Columns["orderID"].Visible = false;
        }

        private void btnPreparingOrders_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Orders In Making";
            btnClickedButton = btnPreparingOrders;
            showPreparingOrders();
        }

        void showPreparingOrders()
        {
            showOrder = new cOrderOperations();

            showOrder.sqlQuery = "select orderID, staffNameSurname as 'Staff', productName as 'Product', Quantity, "
            + "case when preparationStatus is NULL then 'New Order' when preparationStatus = 1 then 'Ready' else 'Preparing' end "
            + "as 'Preparation Status', ORDERS.tableID as 'Table No', ORDERS.billID from ORDERS inner join STAFFS on "
            + "ORDERS.staffID = STAFFS.staffID inner join PRODUCTS on ORDERS.productID = PRODUCTS.productID inner join "
            + "BILLS on ORDERS.billID = BILLS.billID where orderStatus = 0 and preparationStatus = 0 and "
            + " openingTime between @startTime and @finishTime";

            showOrder.billStartTime = DateTime.Now.Date;
            showOrder.billFinishTime = DateTime.Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            showOrder.getDataFromOrders();

            dGridView.DataSource = showOrder.dataTable;
            hideDGridViewColumns();
        }

        private void btnReadyOrders_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Ready Orders";
            btnClickedButton = btnReadyOrders;
            showReadyOrders();
        }

        void showReadyOrders()
        {
            showOrder = new cOrderOperations();
            showOrder.sqlQuery = "select orderID, staffNameSurname as 'Staff', productName as 'Product', Quantity, "
            + "case when preparationStatus is NULL then 'New Order' when preparationStatus = 1 then 'Ready' else 'Preparing' end "
            + "as 'Preparation Status', ORDERS.tableID as 'Table No', ORDERS.billID from ORDERS inner join STAFFS on ORDERS.staffID = STAFFS.staffID "
            + "inner join PRODUCTS on ORDERS.productID = PRODUCTS.productID inner join BILLS on ORDERS.billID = BILLS.billID "
            + "where orderStatus = 0 and preparationStatus = 1 and openingTime between @startTime and @finishTime";

            showOrder.billStartTime = DateTime.Now.Date;
            showOrder.billFinishTime = DateTime.Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            showOrder.getDataFromOrders();

            dGridView.DataSource = showOrder.dataTable;
            hideDGridViewColumns();
        }

        private void dGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.RowIndex >= 0 && e.RowIndex < dGridView.Rows.Count - 1) && btnClickedButton != btnDeliveredOrders && btnClickedButton != btnReadyOrders)
            {
                DialogResult result = MessageBox.Show(setMessageToBeShown(), "Order Status", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    int billID = Convert.ToInt32(dGridView.CurrentRow.Cells["billID"].Value);
                    int orderID = Convert.ToInt32(dGridView.CurrentRow.Cells["orderID"].Value);
                    commitUpdate(billID, orderID);
                }
            }            
        }

        private string setMessageToBeShown()
        {
            string message = "";
            if (btnClickedButton == btnNewOrders)
            {
                message = "Are you sure to prepare this order?";
            }
            else if (btnClickedButton == btnPreparingOrders)
            {
                message = "Is this order ready?";
            }
            return message;
        }

        void commitUpdate(int billID, int orderID)
        {
            updateOrderStatus = new cUpdatePreparationStatus();
            updateOrderStatus.billID = billID;
            updateOrderStatus.orderID = orderID;

            if (btnClickedButton == btnNewOrders)
            {
                updateOrderStatus.sqlQuery = "update ORDERS set preparationStatus = 0 where billID = @billID and orderID = @orderID";
                updateOrderStatus.updatePreparationStatus();

                showNewOrders();
            }
            else if (btnClickedButton == btnPreparingOrders)
            {
                updateOrderStatus.sqlQuery = "update ORDERS set preparationStatus = 1 where billID = @billID and orderID = @orderID";
                updateOrderStatus.updatePreparationStatus();

                showPreparingOrders();
            }
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
