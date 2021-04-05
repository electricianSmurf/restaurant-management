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

        public ordersForm()
        {
            InitializeComponent();
        }

        private void ordersForm_Load(object sender, EventArgs e)
        {
            dGridViewSettings();
            showDeliveredOrders();
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
            showOrder.sqlQuery = "select staffNameSurname as 'Staff', productName as 'Product', ORDERS.tableID as 'Table No', ORDERS.billID as 'Bill No', "
            + "Quantity, orderStatus as 'Is Delivered', openingTime as 'Bill Time' from ORDERS inner join STAFFS on ORDERS.staffID = STAFFS.staffID "
            + "inner join PRODUCTS on ORDERS.productID = PRODUCTS.productID inner join BILLS on ORDERS.billID = BILLS.billID "
            + "where orderStatus = 1 and openingTime between  @startTime and @finishTime";
            
            showOrder.billStartTime = DateTime.Now.Date;
            showOrder.billFinishTime = DateTime.Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            showOrder.showDeliveredOrders();

            dGridView.DataSource = showOrder.dataTable;
        }
       
        private void btnNewOrders_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "New Orders";
            showNewOrders();
        }
        void showNewOrders()
        {
            showOrder = new cOrderOperations();

            showOrder.sqlQuery = "select staffNameSurname as 'Staff', productName as 'Product', ORDERS.tableID as 'Table No', Quantity, "
            + "case when orderStatus = 1 then 'Delivered' else 'Undelivered' end as 'Delivery Status', "
            + "case when preparationStatus is null then 'New Order' when preparationStatus = 1 then 'Ready' else 'Preparing' end as 'Preparation Status' "
            + "from ORDERS inner join STAFFS on ORDERS.staffID = STAFFS.staffID inner join "
            + "PRODUCTS on ORDERS.productID = PRODUCTS.productID where orderStatus = 0 and preparationStatus is NULL";

            showOrder.showNewOrders();
            
            dGridView.DataSource = showOrder.dataTable;
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
            showDeliveredOrders();
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
