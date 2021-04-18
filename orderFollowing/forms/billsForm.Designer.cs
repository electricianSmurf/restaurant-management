namespace orderFollowing.forms
{
    partial class billsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(billsForm));
            this.btnBack = new System.Windows.Forms.Button();
            this.dGridView = new System.Windows.Forms.DataGridView();
            this.btnClosedBills = new System.Windows.Forms.Button();
            this.btnOpenBills = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlConfirmPayment = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxPType = new System.Windows.Forms.ComboBox();
            this.LViewOrders = new System.Windows.Forms.ListView();
            this.CHProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseConfirmPPanel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CHQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dGridView)).BeginInit();
            this.pnlConfirmPayment.SuspendLayout();
            this.SuspendLayout();
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
            this.btnBack.TabIndex = 33;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dGridView
            // 
            this.dGridView.BackgroundColor = System.Drawing.Color.Khaki;
            this.dGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.dGridView.Location = new System.Drawing.Point(10, 70);
            this.dGridView.Name = "dGridView";
            this.dGridView.Size = new System.Drawing.Size(725, 304);
            this.dGridView.TabIndex = 34;
            this.dGridView.DoubleClick += new System.EventHandler(this.dGridView_DoubleClick);
            // 
            // btnClosedBills
            // 
            this.btnClosedBills.BackColor = System.Drawing.SystemColors.Control;
            this.btnClosedBills.BackgroundImage = global::orderFollowing.Properties.Resources.closed_bill;
            this.btnClosedBills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClosedBills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosedBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosedBills.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClosedBills.Location = new System.Drawing.Point(646, 374);
            this.btnClosedBills.Name = "btnClosedBills";
            this.btnClosedBills.Size = new System.Drawing.Size(89, 82);
            this.btnClosedBills.TabIndex = 35;
            this.btnClosedBills.UseVisualStyleBackColor = false;
            this.btnClosedBills.Click += new System.EventHandler(this.btnClosedBills_Click);
            // 
            // btnOpenBills
            // 
            this.btnOpenBills.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenBills.BackgroundImage = global::orderFollowing.Properties.Resources.open_bill;
            this.btnOpenBills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenBills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenBills.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOpenBills.Location = new System.Drawing.Point(546, 374);
            this.btnOpenBills.Name = "btnOpenBills";
            this.btnOpenBills.Size = new System.Drawing.Size(89, 82);
            this.btnOpenBills.TabIndex = 36;
            this.btnOpenBills.UseVisualStyleBackColor = false;
            this.btnOpenBills.Click += new System.EventHandler(this.btnOpenBills_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(8, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(136, 39);
            this.lblTitle.TabIndex = 37;
            this.lblTitle.Text = "Open Bills";
            // 
            // pnlConfirmPayment
            // 
            this.pnlConfirmPayment.BackColor = System.Drawing.Color.Brown;
            this.pnlConfirmPayment.Controls.Add(this.label3);
            this.pnlConfirmPayment.Controls.Add(this.btnCloseConfirmPPanel);
            this.pnlConfirmPayment.Controls.Add(this.label1);
            this.pnlConfirmPayment.Controls.Add(this.CBoxPType);
            this.pnlConfirmPayment.Controls.Add(this.LViewOrders);
            this.pnlConfirmPayment.Controls.Add(this.btnConfirmPayment);
            this.pnlConfirmPayment.Controls.Add(this.label2);
            this.pnlConfirmPayment.Location = new System.Drawing.Point(142, 45);
            this.pnlConfirmPayment.Name = "pnlConfirmPayment";
            this.pnlConfirmPayment.Size = new System.Drawing.Size(468, 350);
            this.pnlConfirmPayment.TabIndex = 39;
            this.pnlConfirmPayment.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Orders";
            // 
            // CBoxPType
            // 
            this.CBoxPType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxPType.Location = new System.Drawing.Point(120, 6);
            this.CBoxPType.Name = "CBoxPType";
            this.CBoxPType.Size = new System.Drawing.Size(177, 21);
            this.CBoxPType.TabIndex = 40;
            // 
            // LViewOrders
            // 
            this.LViewOrders.BackColor = System.Drawing.Color.Khaki;
            this.LViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHProduct,
            this.CHQuantity});
            this.LViewOrders.FullRowSelect = true;
            this.LViewOrders.HideSelection = false;
            this.LViewOrders.Location = new System.Drawing.Point(0, 59);
            this.LViewOrders.Name = "LViewOrders";
            this.LViewOrders.Size = new System.Drawing.Size(468, 209);
            this.LViewOrders.TabIndex = 39;
            this.LViewOrders.UseCompatibleStateImageBehavior = false;
            // 
            // CHProduct
            // 
            this.CHProduct.Text = "Product";
            this.CHProduct.Width = 100;
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.BackColor = System.Drawing.Color.Brown;
            this.btnConfirmPayment.BackgroundImage = global::orderFollowing.Properties.Resources.confirm_payment1;
            this.btnConfirmPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPayment.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConfirmPayment.Location = new System.Drawing.Point(378, 268);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(89, 82);
            this.btnConfirmPayment.TabIndex = 38;
            this.btnConfirmPayment.UseVisualStyleBackColor = false;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Payment Type";
            // 
            // btnCloseConfirmPPanel
            // 
            this.btnCloseConfirmPPanel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseConfirmPPanel.BackgroundImage = global::orderFollowing.Properties.Resources.x1;
            this.btnCloseConfirmPPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseConfirmPPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseConfirmPPanel.Location = new System.Drawing.Point(445, 0);
            this.btnCloseConfirmPPanel.Name = "btnCloseConfirmPPanel";
            this.btnCloseConfirmPPanel.Size = new System.Drawing.Size(22, 22);
            this.btnCloseConfirmPPanel.TabIndex = 42;
            this.btnCloseConfirmPPanel.UseVisualStyleBackColor = false;
            this.btnCloseConfirmPPanel.Click += new System.EventHandler(this.btnCloseConfirmPPanel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Orders";
            // 
            // CHQuantity
            // 
            this.CHQuantity.Text = "Quantity";
            this.CHQuantity.Width = 100;
            // 
            // billsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::orderFollowing.Properties.Resources.bg_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(745, 457);
            this.Controls.Add(this.pnlConfirmPayment);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnOpenBills);
            this.Controls.Add(this.btnClosedBills);
            this.Controls.Add(this.dGridView);
            this.Controls.Add(this.btnBack);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "billsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "billsForm";
            this.Load += new System.EventHandler(this.billsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridView)).EndInit();
            this.pnlConfirmPayment.ResumeLayout(false);
            this.pnlConfirmPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dGridView;
        private System.Windows.Forms.Button btnClosedBills;
        private System.Windows.Forms.Button btnOpenBills;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlConfirmPayment;
        private System.Windows.Forms.ListView LViewOrders;
        private System.Windows.Forms.ColumnHeader CHProduct;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBoxPType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseConfirmPPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader CHQuantity;
    }
}