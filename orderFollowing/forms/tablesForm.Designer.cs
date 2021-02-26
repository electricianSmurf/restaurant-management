namespace orderFollowing.forms
{
    partial class tablesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tablesForm));
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LViewUndelivered = new System.Windows.Forms.ListView();
            this.CHorderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHproduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHstatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPendingOrders = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.pnlChoseProduct = new System.Windows.Forms.Panel();
            this.PBoxWarning = new System.Windows.Forms.PictureBox();
            this.btnCloseNewOrderPnl = new System.Windows.Forms.Button();
            this.TBoxProductContent = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBoxProductAmount = new System.Windows.Forms.TextBox();
            this.CBoxProducts = new System.Windows.Forms.ComboBox();
            this.CBoxCategories = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dGridView = new System.Windows.Forms.DataGridView();
            this.btnCloseGeneralPanel = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnCloseAccount = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.pnlAddMinusTable = new System.Windows.Forms.Panel();
            this.CBoxTableCapacity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBoxTableAmount = new System.Windows.Forms.TextBox();
            this.btnCloseAddPanel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinusTable = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlGeneral.SuspendLayout();
            this.pnlChoseProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView)).BeginInit();
            this.pnlAddMinusTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.BackColor = System.Drawing.Color.Khaki;
            this.pnlGeneral.Controls.Add(this.lblTotal);
            this.pnlGeneral.Controls.Add(this.label9);
            this.pnlGeneral.Controls.Add(this.LViewUndelivered);
            this.pnlGeneral.Controls.Add(this.btnPendingOrders);
            this.pnlGeneral.Controls.Add(this.btnDeleteOrder);
            this.pnlGeneral.Controls.Add(this.btnUpdateOrder);
            this.pnlGeneral.Controls.Add(this.pnlChoseProduct);
            this.pnlGeneral.Controls.Add(this.dGridView);
            this.pnlGeneral.Controls.Add(this.btnCloseGeneralPanel);
            this.pnlGeneral.Controls.Add(this.btnNewOrder);
            this.pnlGeneral.Controls.Add(this.btnCloseAccount);
            this.pnlGeneral.Location = new System.Drawing.Point(112, 93);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(526, 271);
            this.pnlGeneral.TabIndex = 20;
            this.pnlGeneral.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Crimson;
            this.lblTotal.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotal.Location = new System.Drawing.Point(300, 235);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(18, 22);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Crimson;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(249, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 22);
            this.label9.TabIndex = 26;
            this.label9.Text = "Total";
            // 
            // LViewUndelivered
            // 
            this.LViewUndelivered.BackColor = System.Drawing.Color.Khaki;
            this.LViewUndelivered.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHorderId,
            this.CHproduct,
            this.CHstatus});
            this.LViewUndelivered.FullRowSelect = true;
            this.LViewUndelivered.HideSelection = false;
            this.LViewUndelivered.Location = new System.Drawing.Point(315, 122);
            this.LViewUndelivered.Name = "LViewUndelivered";
            this.LViewUndelivered.Size = new System.Drawing.Size(181, 100);
            this.LViewUndelivered.TabIndex = 25;
            this.LViewUndelivered.UseCompatibleStateImageBehavior = false;
            this.LViewUndelivered.Visible = false;
            this.LViewUndelivered.Click += new System.EventHandler(this.LViewUndelivered_Click);
            // 
            // CHorderId
            // 
            this.CHorderId.Text = "OrderID";
            this.CHorderId.Width = 0;
            // 
            // CHproduct
            // 
            this.CHproduct.Text = "Product";
            this.CHproduct.Width = 80;
            // 
            // CHstatus
            // 
            this.CHstatus.Text = "Status";
            this.CHstatus.Width = 80;
            // 
            // btnPendingOrders
            // 
            this.btnPendingOrders.BackColor = System.Drawing.SystemColors.Control;
            this.btnPendingOrders.BackgroundImage = global::orderFollowing.Properties.Resources.order_notice;
            this.btnPendingOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPendingOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPendingOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendingOrders.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPendingOrders.Location = new System.Drawing.Point(371, 221);
            this.btnPendingOrders.Name = "btnPendingOrders";
            this.btnPendingOrders.Size = new System.Drawing.Size(66, 50);
            this.btnPendingOrders.TabIndex = 25;
            this.btnPendingOrders.UseVisualStyleBackColor = false;
            this.btnPendingOrders.Visible = false;
            this.btnPendingOrders.Click += new System.EventHandler(this.btnPendingOrders_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.Red;
            this.btnDeleteOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteOrder.Location = new System.Drawing.Point(178, 221);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(66, 50);
            this.btnDeleteOrder.TabIndex = 25;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateOrder.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateOrder.Location = new System.Drawing.Point(89, 221);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(66, 50);
            this.btnUpdateOrder.TabIndex = 25;
            this.btnUpdateOrder.Text = "Update Order";
            this.btnUpdateOrder.UseVisualStyleBackColor = false;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // pnlChoseProduct
            // 
            this.pnlChoseProduct.BackColor = System.Drawing.Color.DarkKhaki;
            this.pnlChoseProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChoseProduct.Controls.Add(this.PBoxWarning);
            this.pnlChoseProduct.Controls.Add(this.btnCloseNewOrderPnl);
            this.pnlChoseProduct.Controls.Add(this.TBoxProductContent);
            this.pnlChoseProduct.Controls.Add(this.label6);
            this.pnlChoseProduct.Controls.Add(this.label5);
            this.pnlChoseProduct.Controls.Add(this.TBoxProductAmount);
            this.pnlChoseProduct.Controls.Add(this.CBoxProducts);
            this.pnlChoseProduct.Controls.Add(this.CBoxCategories);
            this.pnlChoseProduct.Controls.Add(this.label4);
            this.pnlChoseProduct.Controls.Add(this.label3);
            this.pnlChoseProduct.Location = new System.Drawing.Point(0, 22);
            this.pnlChoseProduct.Name = "pnlChoseProduct";
            this.pnlChoseProduct.Size = new System.Drawing.Size(244, 199);
            this.pnlChoseProduct.TabIndex = 25;
            this.pnlChoseProduct.Visible = false;
            // 
            // PBoxWarning
            // 
            this.PBoxWarning.BackColor = System.Drawing.Color.Transparent;
            this.PBoxWarning.BackgroundImage = global::orderFollowing.Properties.Resources.exclamation_mark;
            this.PBoxWarning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBoxWarning.Location = new System.Drawing.Point(218, 34);
            this.PBoxWarning.Name = "PBoxWarning";
            this.PBoxWarning.Size = new System.Drawing.Size(22, 22);
            this.PBoxWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxWarning.TabIndex = 26;
            this.PBoxWarning.TabStop = false;
            this.PBoxWarning.Visible = false;
            // 
            // btnCloseNewOrderPnl
            // 
            this.btnCloseNewOrderPnl.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseNewOrderPnl.BackgroundImage = global::orderFollowing.Properties.Resources.x1;
            this.btnCloseNewOrderPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseNewOrderPnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseNewOrderPnl.Location = new System.Drawing.Point(222, 0);
            this.btnCloseNewOrderPnl.Name = "btnCloseNewOrderPnl";
            this.btnCloseNewOrderPnl.Size = new System.Drawing.Size(22, 22);
            this.btnCloseNewOrderPnl.TabIndex = 25;
            this.btnCloseNewOrderPnl.UseVisualStyleBackColor = false;
            this.btnCloseNewOrderPnl.Click += new System.EventHandler(this.btnCloseNewOrderPnl_Click);
            // 
            // TBoxProductContent
            // 
            this.TBoxProductContent.Location = new System.Drawing.Point(93, 91);
            this.TBoxProductContent.Name = "TBoxProductContent";
            this.TBoxProductContent.ReadOnly = true;
            this.TBoxProductContent.Size = new System.Drawing.Size(124, 103);
            this.TBoxProductContent.TabIndex = 28;
            this.TBoxProductContent.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 22);
            this.label6.TabIndex = 26;
            this.label6.Text = "Content";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "Amount";
            // 
            // TBoxProductAmount
            // 
            this.TBoxProductAmount.Location = new System.Drawing.Point(93, 63);
            this.TBoxProductAmount.Name = "TBoxProductAmount";
            this.TBoxProductAmount.Size = new System.Drawing.Size(124, 20);
            this.TBoxProductAmount.TabIndex = 24;
            // 
            // CBoxProducts
            // 
            this.CBoxProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxProducts.FormattingEnabled = true;
            this.CBoxProducts.Location = new System.Drawing.Point(93, 35);
            this.CBoxProducts.Name = "CBoxProducts";
            this.CBoxProducts.Size = new System.Drawing.Size(124, 21);
            this.CBoxProducts.TabIndex = 27;
            this.CBoxProducts.SelectedValueChanged += new System.EventHandler(this.CBoxProducts_SelectedValueChanged);
            // 
            // CBoxCategories
            // 
            this.CBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxCategories.FormattingEnabled = true;
            this.CBoxCategories.Location = new System.Drawing.Point(93, 7);
            this.CBoxCategories.Name = "CBoxCategories";
            this.CBoxCategories.Size = new System.Drawing.Size(124, 21);
            this.CBoxCategories.TabIndex = 25;
            this.CBoxCategories.SelectedValueChanged += new System.EventHandler(this.CBoxCategories_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Categories";
            // 
            // dGridView
            // 
            this.dGridView.BackgroundColor = System.Drawing.Color.Khaki;
            this.dGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridView.Location = new System.Drawing.Point(0, 22);
            this.dGridView.Name = "dGridView";
            this.dGridView.Size = new System.Drawing.Size(526, 200);
            this.dGridView.TabIndex = 1;
            // 
            // btnCloseGeneralPanel
            // 
            this.btnCloseGeneralPanel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseGeneralPanel.BackgroundImage = global::orderFollowing.Properties.Resources.x1;
            this.btnCloseGeneralPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseGeneralPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseGeneralPanel.Location = new System.Drawing.Point(504, 0);
            this.btnCloseGeneralPanel.Name = "btnCloseGeneralPanel";
            this.btnCloseGeneralPanel.Size = new System.Drawing.Size(22, 22);
            this.btnCloseGeneralPanel.TabIndex = 24;
            this.btnCloseGeneralPanel.UseVisualStyleBackColor = false;
            this.btnCloseGeneralPanel.Click += new System.EventHandler(this.btnCloseOrderPanel_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.BackColor = System.Drawing.Color.GreenYellow;
            this.btnNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewOrder.Location = new System.Drawing.Point(0, 221);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(66, 50);
            this.btnNewOrder.TabIndex = 2;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = false;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnCloseAccount
            // 
            this.btnCloseAccount.BackColor = System.Drawing.Color.Cyan;
            this.btnCloseAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAccount.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCloseAccount.Location = new System.Drawing.Point(460, 221);
            this.btnCloseAccount.Name = "btnCloseAccount";
            this.btnCloseAccount.Size = new System.Drawing.Size(66, 50);
            this.btnCloseAccount.TabIndex = 0;
            this.btnCloseAccount.Text = "Close Account";
            this.btnCloseAccount.UseVisualStyleBackColor = false;
            this.btnCloseAccount.Click += new System.EventHandler(this.btnCloseAccount_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Location = new System.Drawing.Point(40, 380);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 64);
            this.btnBack.TabIndex = 17;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.BackColor = System.Drawing.Color.Black;
            this.btnAddTable.BackgroundImage = global::orderFollowing.Properties.Resources.plus;
            this.btnAddTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddTable.Location = new System.Drawing.Point(650, 380);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(67, 64);
            this.btnAddTable.TabIndex = 21;
            this.btnAddTable.UseVisualStyleBackColor = false;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // pnlAddMinusTable
            // 
            this.pnlAddMinusTable.BackColor = System.Drawing.Color.Khaki;
            this.pnlAddMinusTable.Controls.Add(this.CBoxTableCapacity);
            this.pnlAddMinusTable.Controls.Add(this.label2);
            this.pnlAddMinusTable.Controls.Add(this.TBoxTableAmount);
            this.pnlAddMinusTable.Controls.Add(this.btnCloseAddPanel);
            this.pnlAddMinusTable.Controls.Add(this.label1);
            this.pnlAddMinusTable.Location = new System.Drawing.Point(262, 180);
            this.pnlAddMinusTable.Name = "pnlAddMinusTable";
            this.pnlAddMinusTable.Size = new System.Drawing.Size(235, 85);
            this.pnlAddMinusTable.TabIndex = 22;
            this.pnlAddMinusTable.Visible = false;
            // 
            // CBoxTableCapacity
            // 
            this.CBoxTableCapacity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxTableCapacity.FormattingEnabled = true;
            this.CBoxTableCapacity.Location = new System.Drawing.Point(88, 18);
            this.CBoxTableCapacity.Name = "CBoxTableCapacity";
            this.CBoxTableCapacity.Size = new System.Drawing.Size(100, 21);
            this.CBoxTableCapacity.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount";
            // 
            // TBoxTableAmount
            // 
            this.TBoxTableAmount.Location = new System.Drawing.Point(88, 48);
            this.TBoxTableAmount.Name = "TBoxTableAmount";
            this.TBoxTableAmount.Size = new System.Drawing.Size(100, 20);
            this.TBoxTableAmount.TabIndex = 3;
            // 
            // btnCloseAddPanel
            // 
            this.btnCloseAddPanel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseAddPanel.BackgroundImage = global::orderFollowing.Properties.Resources.x1;
            this.btnCloseAddPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseAddPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAddPanel.Location = new System.Drawing.Point(212, 1);
            this.btnCloseAddPanel.Name = "btnCloseAddPanel";
            this.btnCloseAddPanel.Size = new System.Drawing.Size(22, 22);
            this.btnCloseAddPanel.TabIndex = 2;
            this.btnCloseAddPanel.UseVisualStyleBackColor = false;
            this.btnCloseAddPanel.Click += new System.EventHandler(this.btnClosePanel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Capacity";
            // 
            // btnMinusTable
            // 
            this.btnMinusTable.BackColor = System.Drawing.Color.Black;
            this.btnMinusTable.BackgroundImage = global::orderFollowing.Properties.Resources.minus;
            this.btnMinusTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinusTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinusTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinusTable.Location = new System.Drawing.Point(577, 380);
            this.btnMinusTable.Name = "btnMinusTable";
            this.btnMinusTable.Size = new System.Drawing.Size(67, 64);
            this.btnMinusTable.TabIndex = 23;
            this.btnMinusTable.UseVisualStyleBackColor = false;
            this.btnMinusTable.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "label ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "label ";
            // 
            // tablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::orderFollowing.Properties.Resources.bg_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(745, 457);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnMinusTable);
            this.Controls.Add(this.pnlAddMinusTable);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tablesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tablesForm";
            this.Load += new System.EventHandler(this.tablesForm_Load);
            this.pnlGeneral.ResumeLayout(false);
            this.pnlGeneral.PerformLayout();
            this.pnlChoseProduct.ResumeLayout(false);
            this.pnlChoseProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView)).EndInit();
            this.pnlAddMinusTable.ResumeLayout(false);
            this.pnlAddMinusTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.Button btnCloseAccount;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dGridView;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Panel pnlAddMinusTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBoxTableAmount;
        private System.Windows.Forms.Button btnCloseAddPanel;
        private System.Windows.Forms.ComboBox CBoxTableCapacity;
        private System.Windows.Forms.Button btnMinusTable;
        private System.Windows.Forms.Button btnCloseGeneralPanel;
        private System.Windows.Forms.Panel pnlChoseProduct;
        private System.Windows.Forms.RichTextBox TBoxProductContent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBoxProductAmount;
        private System.Windows.Forms.ComboBox CBoxProducts;
        private System.Windows.Forms.ComboBox CBoxCategories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCloseNewOrderPnl;
        private System.Windows.Forms.PictureBox PBoxWarning;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnPendingOrders;
        private System.Windows.Forms.ListView LViewUndelivered;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader CHorderId;
        private System.Windows.Forms.ColumnHeader CHproduct;
        private System.Windows.Forms.ColumnHeader CHstatus;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label9;
    }
}