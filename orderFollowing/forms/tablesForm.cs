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
    public partial class tablesForm : Form
    {
        cTableOperations tableOperation;
        cGetOrdersOfTable getTableOrders;
        cGetDataFromSql getData;
        cInsertUpdateOrder newOrder;
        cBillOperations newBill;
        cGetTotalBill getBillTotal;
        
        List<cCategories> categoryList;

        List<int> lstTableCapacities;

        PictureBox PBoxClicked = new PictureBox();

        Color closeTableColor = Color.Red;
        Color openTableColor = Color.Green;
        
        string staffUserName;
        
        int billId;

        bool isEditedOrInserted = true;
        bool isUpdate1stClick = true;
        bool isRemoveTableClicked;

        public tablesForm()
        {
            InitializeComponent();

            checkIsAdminOnline();

            getTables();
            getExistingTableCapacities();
            fillCBoxCapacity();
        }

        void checkIsAdminOnline()
        {
            staffUserName = loginForm.onlineUserName;
            if (!staffUserName.Equals("admin"))
            {
                btnAddTable.Visible = false;
                btnRemoveTable.Visible = false;
            }
        }

        void getTables()
        {
            getData = new cGetDataFromSql();
            getData.sqlQuery = "select * from tables where tableStatus = 1";
            getData.GetDataFromSql();
        }

        void getExistingTableCapacities()
        {
            lstTableCapacities = new List<int>();
            for (int i = 0; i < getData.dataTable.Rows.Count; i++)
            {
                if (Convert.ToBoolean(getData.dataTable.Rows[i]["tableStatus"]))
                {
                    lstTableCapacities.Add(Convert.ToInt32(getData.dataTable.Rows[i]["tableCapacity"]));
                }
            }
        }

        void fillCBoxCapacity()
        {
            CBoxTableCapacity.Items.Add(2);
            CBoxTableCapacity.Items.Add(3);
            CBoxTableCapacity.Items.Add(4);
            CBoxTableCapacity.Items.Add(5);
        }

        private void tablesForm_Load(object sender, EventArgs e)
        {
            dGridViewSettings();
            createLabelsTables();
            bringCategoriesAndProducts();
        }

        void createLabelsTables()
        {
            int totalRowAmount = detectTotalTableRow();
            int tablesToBeProduced = getData.dataTable.Rows.Count;
            int columnAmountInRow = tablesToBeProduced;// this is for not getting an error at first,
                                                       // if total table amount is smaller than 10
            for (int row = 0; row < totalRowAmount; row++)
            {
                Point constLoc = detectConstLocation(row);
                Point loc = new Point();

                if (tablesToBeProduced > 10)
                {
                    columnAmountInRow = 10;
                }

                for (int column = 0; column < columnAmountInRow; column++)
                {
                    Label label = new Label();
                    labelProperties(label);
                    label.Text = "Table " + ((row * 10) + column + 1).ToString();
                    loc.X = constLoc.X + column * 66;
                    loc.Y = constLoc.Y;
                    label.Location = loc;
                    Controls.Add(label);
                    createTable(column, row, loc);
                }
                tablesToBeProduced -= 10;
                columnAmountInRow = tablesToBeProduced;
            }
        }

        private int detectTotalTableRow()
        {
            decimal tableRowNumber = (decimal)getData.dataTable.Rows.Count / 10;
            tableRowNumber = Math.Ceiling(tableRowNumber);

            return Convert.ToInt32(tableRowNumber);
        }

        private Point detectConstLocation(int rowNumber)
        {
            Point location;

            int constLocX = 45;
            int constLocY = 20 + 100 * rowNumber;
            location = new Point(constLocX, constLocY);

            return location;
        }

        private Label labelProperties(Label lbl)
        {
            lbl.Font = new Font("Monotype Corsiva", 14, FontStyle.Italic);
            lbl.AutoSize = true;
            lbl.BackColor = Color.Transparent;
            lbl.ForeColor = Color.White;
            return lbl;
        }

        void createTable(int column, int row, Point loc)
        {
            PictureBox table;
            table = new PictureBox();
            table.Name = ((row * 10) + column + 1).ToString();
            table.Image = detectTableImage(lstTableCapacities[(row * 10) + column]);
            table.Size = new Size(60, 60);
            table.Location = new Point(loc.X, loc.Y + 25);
            table.SizeMode = PictureBoxSizeMode.StretchImage;
            table.Click += table_Click;
            table.Tag = Convert.ToInt32(getData.dataTable.Rows[column + (10 * row)]["tableId"]);
            table.BackColor = detectTableBackColor(column + (10 * row));
            Controls.Add(table);
        }

        private Image detectTableImage(int capacity)
        {
            Image img = null;
            switch (capacity)
            {
                case 2:
                    img = Properties.Resources._2;
                    break;
                case 3:
                    img = Properties.Resources._3;
                    break;
                case 4:
                    img = Properties.Resources._4;
                    break;
                case 5:
                    img = Properties.Resources._5;
                    break;
                case 6:
                    img = Properties.Resources._6;
                    break;
            }
            return img;
        }

        private Color detectTableBackColor(int tableNo)
        {
            Color tableColor = closeTableColor; 
            if (Convert.ToBoolean(getData.dataTable.Rows[tableNo]["serviceStatus"]))
            {
                tableColor = openTableColor;
            }
            return tableColor;
        }

        void dGridViewSettings()
        {
            dGridView.AllowUserToResizeRows = false;
            dGridView.AllowUserToResizeColumns = false;
            dGridView.ReadOnly = true;
            dGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void bringCategoriesAndProducts()
        {
            getCategories();
            createCategoryList();
            for (int i = 0; i < categoryList.Count; i++)
            {
                createProductListByCategory(i);
            }
        }

        void getCategories()
        {
            getData = new cGetDataFromSql();
            getData.sqlQuery = "select categoryName from CATEGORIES";
            getData.GetDataFromSql();
        }

        void createCategoryList()
        {
            categoryList = new List<cCategories>();

            for (int i = 0; i < getData.dataTable.Rows.Count; i++)
            {
                cCategories category = new cCategories();
                category.categoryId = i;
                category.categoryName = getData.dataTable.Rows[i]["categoryName"].ToString();
                categoryList.Add(category);
                categoryList[i].productList = new List<cProducts>();
                CBoxCategories.Items.Add(category.categoryName);
            }
        }

        void createProductListByCategory(int categoryNo)
        {
            getProductsByCategory(categoryNo + 1);// my categories in database start from 1 not 0
            int productAmount = getData.dataTable.Rows.Count;
            for (int i = 0; i < productAmount; i++)
            {
                cProducts product = new cProducts();

                product.productId = Convert.ToInt32(getData.dataTable.Rows[i]["productID"]);
                product.categoryId = Convert.ToInt32(getData.dataTable.Rows[i]["categoryID"]);
                product.productName = (getData.dataTable.Rows[i]["productName"]).ToString();
                product.explanation = (getData.dataTable.Rows[i]["explanation"]).ToString();
                product.productStatus = Convert.ToBoolean(getData.dataTable.Rows[i]["productStatus"]);
                product.price = Convert.ToDecimal(getData.dataTable.Rows[i]["price"]);

                categoryList[categoryNo].productList.Add(product);
            }
        }

        void getProductsByCategory(int categoryId)
        {
            getData = new cGetDataFromSql();
            getData.sqlQuery = "select * from PRODUCTS where categoryID = " + categoryId.ToString();
            getData.GetDataFromSql();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            if (pnlAddTable.Visible)
            {
                addTable();
                refreshForm();
            }
            pnlAddTable.Visible = true;
            TBoxTableAmount.Text = "1";
        }

        void addTable()
        {
            for (int i = 0; i < Convert.ToInt32(TBoxTableAmount.Text); i++)
            {
                tableOperation = new cTableOperations();
                tableOperation.sqlQuery = "insert into tables (tableCapacity,tableStatus, serviceStatus) "
                + "values (@capacity, @tableStatus, @serviceStatus)";
                tableOperation.capacity = CBoxTableCapacity.Text;
                tableOperation.tableStatus = true;
                tableOperation.serviceStatus = false;
                tableOperation.addNewTable();
            }
        }

        void refreshForm()
        {
            this.Hide();
            forms.tablesForm tablesForm = new forms.tablesForm();
            tablesForm.ShowDialog();
            this.Close();
        }
        private void btnCloseAddPanel_Click(object sender, EventArgs e)
        {
            pnlAddTable.Visible = false;
        }

        private void btnRemoveTable_Click(object sender, EventArgs e)
        {
            isRemoveTableClicked = true;
            string message = "Please choose a table to delete!";
            DialogResult result = MessageBox.Show(message, "Choose table", MessageBoxButtons.OK);
        }

        void table_Click(object sender, EventArgs e)
        {
            PBoxClicked = sender as PictureBox;

            if (!isRemoveTableClicked)
            {
                if (PBoxClicked.BackColor == closeTableColor)
                {
                    string message = "Do you want to open a new account?";
                    DialogResult result = MessageBox.Show(message, "New Account", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        PBoxClicked.BackColor = openTableColor;
                        openTableToService();
                        createNewBill();

                        tidyPnlGeneral();
                        getBillId();
                        loadTableOrders(PBoxClicked.Tag.ToString());
                        lblTotal.Text = "0";
                    }
                }
                else if (PBoxClicked.BackColor == openTableColor)
                {
                    tidyPnlGeneral();
                    getBillId();
                    loadTableOrders(PBoxClicked.Tag.ToString());
                    btnPendingOrders.Visible = !checkUnDeliveredItems();
                    getTotalBill();
                }
            }
            else// when isMinusTableClicked = true
            {
                removeTable();
            }
        }

        void openTableToService()
        {
            tableOperation = new cTableOperations();
            tableOperation.tableId = PBoxClicked.Tag.ToString();
            tableOperation.openNewAccount();
        }
        void createNewBill()
        {
            newBill = new cBillOperations();
            newBill.sqlQuery = "insert into BILLS (tableID, openingTime, billStatus) "
            + "values (@tableId, @openingTime, 1)";
            newBill.tableId = Convert.ToInt32(PBoxClicked.Tag);
            newBill.openingTime = DateTime.Now;
            newBill.insertNewBill();
        }

        void tidyPnlGeneral()
        {
            dGridView.Visible = true;
            pnlGeneral.Visible = true;

            btnNewOrder.Visible = true;
            btnUpdateOrder.Visible = true;
            btnDeleteOrder.Visible = true;
        }

        void getBillId()
        {
            newBill = new cBillOperations();
            newBill.sqlQuery = "select top 1 billID from BILLS where tableID = @tableId order by billID desc";
            newBill.tableId = Convert.ToInt32(PBoxClicked.Tag);
            newBill.getBillId();
            billId = Convert.ToInt32(newBill.dataTable.Rows[0][0]);
        }

        void loadTableOrders(string tableId)
        {
            getTableOrders = new cGetOrdersOfTable();
            getTableOrders.sqlQuery = "select orderID, productName as 'Product', Quantity, tableID as 'Table', orderStatus as 'Is Delivered', "
            + "staffNameSurname as 'Staff' from ORDERS inner join STAFFS on STAFFS.staffID = ORDERS.staffID "
            + "inner join PRODUCTS on PRODUCTS.productID = ORDERS.productID where tableID = @tableId and billId = @billId";
            getTableOrders.tableId = tableId;
            getTableOrders.billId = billId;
            getTableOrders.GetOrdersFromSql();
            dGridView.DataSource = getTableOrders.dataTable;
            dGridView.Columns["orderId"].Visible = false;

            writeTableNumber();
        }
        void writeTableNumber()
        {
            for (int i = 0; i < dGridView.Rows.Count; i++)
            {
                dGridView.Rows[i].Cells["Table"].Value = PBoxClicked.Name;
            }
        }
        private bool checkUnDeliveredItems()
        {
            bool isEverythingDelivered = true;
            for (int row = 0; row < dGridView.Rows.Count - 1; row++)
            {
                if (!Convert.ToBoolean(dGridView.Rows[row].Cells["Is Delivered"].Value))
                {
                    isEverythingDelivered = false;
                }
            }
            return isEverythingDelivered;
        }

        void getTotalBill()
        {
            getBillTotal = new cGetTotalBill();
            getBillTotal.sqlQuery = "select total from BILLS where billID = @billId";
            getBillTotal.billId = billId;
            getBillTotal.getTotalBill();

            decimal cost = Convert.ToDecimal(getBillTotal.dataTable.Rows[0]["total"]);
            lblTotal.Text = String.Format("{0:0.00}", cost);//for 2 digits after comma
        }

        void removeTable()
        {
            string message = "Are you sure you want to delete table " + PBoxClicked.Tag.ToString();
            DialogResult result = MessageBox.Show(message, "Delete Table", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes && PBoxClicked.BackColor == closeTableColor)
            {
                tableOperation = new cTableOperations();
                tableOperation.tableId = PBoxClicked.Tag.ToString();
                tableOperation.deleteTable();

                refreshForm();
                isRemoveTableClicked = false;
            }
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            if (isEditedOrInserted)//at first click, show the product panel and bring categories & products
            {
                isEditedOrInserted = false;
                tidyPnl_btnNewOrder();
            }
            else if (validateAllConditions())//at second click, insert the new order into database
            {
                insertNewOrder();
            }
        }

        void tidyPnl_btnNewOrder()
        {
            dGridView.Visible = false;
            btnDeleteOrder.Visible = false;
            btnUpdateOrder.Visible = false;

            pnlChoseProduct.Visible = true;
        }

        private void CBoxCategories_SelectedValueChanged(object sender, EventArgs e)
        {
            CBoxProducts.Items.Clear();
            if (CBoxCategories.SelectedIndex >= 0)
            {
                addProductsInCBoxProducts(CBoxCategories.SelectedIndex);
            }
        }

        void addProductsInCBoxProducts(int categoryNo)
        {
            for (int i = 0; i < categoryList[categoryNo].productList.Count; i++)
            {
                CBoxProducts.Items.Add(categoryList[categoryNo].productList[i].productName);
            }
        }

        private void CBoxProducts_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CBoxCategories.SelectedIndex >= 0)
            {
                showProductContent();

                if (!checkIfProductExists())
                {
                    MessageBox.Show("This product doesn't exist!");
                }
            }
        }

        void showProductContent()
        {
            string content = categoryList[CBoxCategories.SelectedIndex].productList[CBoxProducts.SelectedIndex].explanation;
            TBoxProductContent.Text = content;
        }

        private bool checkIfProductExists()
        {
            PBoxWarning.Visible = false;
            bool productStatus = categoryList[CBoxCategories.SelectedIndex].productList[CBoxProducts.SelectedIndex].productStatus;
            if (!productStatus)
            {
                PBoxWarning.Visible = true;
            }
            return productStatus;
        }
        
        private bool validateAllConditions()
        {
            bool status = false;
            if (CBoxProductStatus() && amountStatus())
            {
                status = true;
            }
            return status;
        }

        private bool CBoxProductStatus()
        {
            bool status = true;
            if (string.IsNullOrEmpty(CBoxProducts.Text))
            {
                status = false;
                MessageBox.Show("Please choose a product!");
            }

            return status;
        }

        private bool amountStatus()
        {
            bool status = true;
            if (string.IsNullOrEmpty(TBoxProductAmount.Text))
            {
                status = false;
                MessageBox.Show("How many do you want to order?");
            }
            return status;
        }

        void insertNewOrder()
        {
            newOrder = new cInsertUpdateOrder();
            newOrder.sqlQuery = "insert into ORDERS (staffID, productID, tableID, billID, quantity, orderStatus, orderPrice) values "
            + "((select staffID from STAFFS where staffUserName = @userName), "
            + "(select productID from PRODUCTS where productName = @product), @table, @billID, @quantity, @status, @orderPrice)";
            getOrderParameters();
            newOrder.insertOrder();

            clearInputItems();
        }

        void getOrderParameters()
        {
            newOrder.staffUserName = staffUserName;
            newOrder.product = CBoxProducts.SelectedItem.ToString();
            newOrder.tableId = Convert.ToInt32(PBoxClicked.Tag);
            newOrder.quantity = Convert.ToInt32(TBoxProductAmount.Text);
            newOrder.billId = billId;
            newOrder.orderStatus = false;
            decimal price = categoryList[CBoxCategories.SelectedIndex].productList[CBoxProducts.SelectedIndex].price;
            newOrder.orderPrice = newOrder.quantity * price;
        }

        void clearInputItems()
        {
            CBoxCategories.SelectedIndex = -1;
            TBoxProductAmount.Text = "";
            TBoxProductContent.Text = "";
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (dGridView.CurrentRow != null)
            {
                if (!Convert.ToBoolean(dGridView.CurrentRow.Cells["Is Delivered"].Value))
                {
                    if (isUpdate1stClick)
                    {
                        isUpdate1stClick = false;
                        tidyPnl_btnUpdate();
                        clearInputItems();
                    }
                    else if (validateAllConditions())
                    {
                        isUpdate1stClick = true;
                        updateSelectedOrder();
                        pnlChoseProduct.Visible = false;
                        loadTableOrders(PBoxClicked.Tag.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("This order is delivered!");
                }
            }
            else
            {
                MessageBox.Show("Please select an order to update!");
            }
        }

        void tidyPnl_btnUpdate()
        {
            btnNewOrder.Visible = false;
            btnDeleteOrder.Visible = false;

            dGridView.Visible = true;
            pnlChoseProduct.Visible = true;
        }

        void updateSelectedOrder()
        {
            int orderId = Convert.ToInt32(dGridView.CurrentRow.Cells["orderId"].Value);

            newOrder = new cInsertUpdateOrder();
            newOrder.sqlQuery = "update ORDERS set productID = (select productID from PRODUCTS where "
            + "productName = @product), quantity = @quantity, orderStatus = 0, orderPrice = @orderPrice "
            + "where orderID = @orderId";

            newOrder.orderId = orderId;
            newOrder.product = CBoxProducts.SelectedItem.ToString();
            newOrder.quantity = Convert.ToInt32(TBoxProductAmount.Text);
            decimal price = categoryList[CBoxCategories.SelectedIndex].productList[CBoxProducts.SelectedIndex].price;
            newOrder.orderPrice = newOrder.quantity * price;
            newOrder.updateOrder();
        }

        private void btnCloseNewOrderPnl_Click(object sender, EventArgs e)
        {
            isEditedOrInserted = true;
            btnDeleteOrder.Visible = true;
            btnNewOrder.Visible = true;
            tidyPnl_btnCloseNewOrder();

            loadTableOrders(PBoxClicked.Tag.ToString());
        }
        void tidyPnl_btnCloseNewOrder()
        {
            dGridView.Visible = true;
            btnUpdateOrder.Visible = true;
            btnDeleteOrder.Visible = true;
            btnNewOrder.Visible = true;
            pnlChoseProduct.Visible = false;
            isUpdate1stClick = true;
            isEditedOrInserted = true;
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(dGridView.CurrentRow.Cells["Is Delivered"].Value))
            {
                string message = "Are you sure to delete this order?";
                DialogResult result = MessageBox.Show(message, "Delete Order", MessageBoxButtons.OKCancel);
                if (dGridView.CurrentRow != null && result == DialogResult.OK)
                {
                    deleteOrder();
                    loadTableOrders(PBoxClicked.Tag.ToString());
                }
                else
                {
                    MessageBox.Show("Please select an order to delete!");
                }
            }
            else
            {
                MessageBox.Show("This order is delivered!");
            }
        }

        void deleteOrder()
        {
            int orderId = Convert.ToInt32(dGridView.CurrentRow.Cells["orderId"].Value);
            newOrder = new cInsertUpdateOrder();
            newOrder.sqlQuery = "delete from ORDERS where orderID = @orderId";
            newOrder.orderId = orderId;
            newOrder.deleteOrder();
        }

        private void btnPendingOrders_Click(object sender, EventArgs e)
        {
            LViewUndelivered.Items.Clear();
            LViewUndelivered.Visible = true;
            getTableOrders = new cGetOrdersOfTable();
            getTableOrders.sqlQuery = "select orderID, productName, case when orderStatus = 0 then 'Undelivered' else 'Delivered' end "
            + "as 'orderStatus', case when preparationStatus is NULL then 'New Order' when preparationStatus = 0 then 'Preparing' "
            + "else 'Ready' end as 'preparationStatus' from ORDERS inner join PRODUCTS on ORDERS.productID = PRODUCTS.productID "
            + "where orderStatus = 0 and tableID = @tableId and billId = @billId";
            getTableOrders.tableId = PBoxClicked.Tag.ToString();
            getTableOrders.billId = billId;
            getTableOrders.GetOrdersFromSql();

            LViewUndelivered.View = View.Details;
            showUndeliveredOrders();
        }
        void showUndeliveredOrders()
        {
            foreach (DataRow row in getTableOrders.dataTable.Rows)
            {
                ListViewItem listItem = new ListViewItem(row["orderID"].ToString());
                listItem.SubItems.Add(row["productName"].ToString());
                listItem.SubItems.Add(row["orderStatus"].ToString());
                listItem.SubItems.Add(row["preparationStatus"].ToString());
                LViewUndelivered.Items.Add(listItem);
            }
        }

        private void LViewUndelivered_Click(object sender, EventArgs e)
        {
            string message = "Is the order delivered?";
            DialogResult result = MessageBox.Show(message, "Order Delivered", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                updateDeliveredOrder(LViewUndelivered.FocusedItem.SubItems[0].Text);//0 means orderId
                decimal productPrice = detectProductPrice(LViewUndelivered.FocusedItem.SubItems[1].Text);//1 means productName
                int quantity = detectOrderQuantity();
                addPriceToBill(quantity * productPrice);
                getTotalBill();
                deleteDeliveredOrder();
                loadTableOrders(PBoxClicked.Tag.ToString());
                if (checkUnDeliveredItems())
                {
                    btnPendingOrders.Visible = false;
                    LViewUndelivered.Visible = false;
                }
            }
        }

        void updateDeliveredOrder(string orderID)
        {
            newOrder = new cInsertUpdateOrder();
            newOrder.sqlQuery = "update ORDERS set orderStatus = 1 where orderID = @orderId";
            newOrder.orderId = Convert.ToInt32(orderID);
            newOrder.isOrderDelivered();
        }

        private decimal detectProductPrice(string searchedProduct)
        {
            decimal price = 0;
            for (int category = 0; category < categoryList.Count; category++)
            {
                for (int product = 0; product < categoryList[category].productList.Count; product++)
                {
                    if (categoryList[category].productList[product].productName == searchedProduct)
                    {
                        price = categoryList[category].productList[product].price;
                    }
                }
            }
            return price;
        }

        private int detectOrderQuantity()
        {
            int quantity = 0;
            for (int row = 0; row < dGridView.Rows.Count - 1; row++)
            {
                if (Convert.ToInt32(dGridView.Rows[row].Cells["orderId"].Value) == Convert.ToInt32(LViewUndelivered.FocusedItem.SubItems[0].Text))
                {
                    quantity = Convert.ToInt32(dGridView.Rows[row].Cells["quantity"].Value);
                }
            }
            return quantity;
        }

        void addPriceToBill(decimal price)
        {
            newBill = new cBillOperations();
            newBill.sqlQuery = "update BILLS set total = total + @addCost where billID = "
            + "(select top 1 billID from BILLS where tableID = @tableId order by billID desc)";
            newBill.tableId = Convert.ToInt32(PBoxClicked.Tag);
            newBill.billId = billId;
            newBill.additionalCost = price;
            newBill.addPriceToTotal();
        }
        void deleteDeliveredOrder()
        {
            foreach (ListViewItem item in LViewUndelivered.SelectedItems)
            {
                LViewUndelivered.Items.Remove(item);
            }
        }

        private void btnCloseOrderPanel_Click(object sender, EventArgs e)
        {
            pnlGeneral.Visible = false;
            pnlChoseProduct.Visible = false;
            isEditedOrInserted = true;

            LViewUndelivered.Visible = false;
            btnDeleteOrder.Visible = true;
            btnNewOrder.Visible = true;
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
