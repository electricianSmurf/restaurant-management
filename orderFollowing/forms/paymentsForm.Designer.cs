namespace orderFollowing.forms
{
    partial class paymentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paymentsForm));
            this.btnBack = new System.Windows.Forms.Button();
            this.TBoxPType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAddPType = new System.Windows.Forms.Panel();
            this.btnAddPaymentType = new System.Windows.Forms.Button();
            this.btnGnrlShowAddPanel = new System.Windows.Forms.Button();
            this.btnGnrlShowAllPayments = new System.Windows.Forms.Button();
            this.dGridView = new System.Windows.Forms.DataGridView();
            this.btnOrganizedPayments = new System.Windows.Forms.Button();
            this.btnAllPayments = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.LViewPTypes = new System.Windows.Forms.ListView();
            this.CHexplanation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlAddPType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView)).BeginInit();
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
            // TBoxPType
            // 
            this.TBoxPType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBoxPType.Location = new System.Drawing.Point(98, 28);
            this.TBoxPType.Name = "TBoxPType";
            this.TBoxPType.Size = new System.Drawing.Size(224, 22);
            this.TBoxPType.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Payment Type";
            // 
            // pnlAddPType
            // 
            this.pnlAddPType.BackColor = System.Drawing.Color.Brown;
            this.pnlAddPType.Controls.Add(this.LViewPTypes);
            this.pnlAddPType.Controls.Add(this.btnAddPaymentType);
            this.pnlAddPType.Controls.Add(this.label2);
            this.pnlAddPType.Controls.Add(this.TBoxPType);
            this.pnlAddPType.Location = new System.Drawing.Point(222, 145);
            this.pnlAddPType.Name = "pnlAddPType";
            this.pnlAddPType.Size = new System.Drawing.Size(330, 167);
            this.pnlAddPType.TabIndex = 38;
            this.pnlAddPType.Visible = false;
            // 
            // btnAddPaymentType
            // 
            this.btnAddPaymentType.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddPaymentType.BackgroundImage = global::orderFollowing.Properties.Resources.add_credit_card;
            this.btnAddPaymentType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPaymentType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPaymentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPaymentType.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddPaymentType.Location = new System.Drawing.Point(241, 85);
            this.btnAddPaymentType.Name = "btnAddPaymentType";
            this.btnAddPaymentType.Size = new System.Drawing.Size(89, 82);
            this.btnAddPaymentType.TabIndex = 38;
            this.btnAddPaymentType.UseVisualStyleBackColor = false;
            this.btnAddPaymentType.Click += new System.EventHandler(this.btnAddPaymentType_Click);
            // 
            // btnGnrlShowAddPanel
            // 
            this.btnGnrlShowAddPanel.BackColor = System.Drawing.Color.Brown;
            this.btnGnrlShowAddPanel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGnrlShowAddPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnGnrlShowAddPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnGnrlShowAddPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGnrlShowAddPanel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGnrlShowAddPanel.ForeColor = System.Drawing.Color.White;
            this.btnGnrlShowAddPanel.Location = new System.Drawing.Point(639, 0);
            this.btnGnrlShowAddPanel.Name = "btnGnrlShowAddPanel";
            this.btnGnrlShowAddPanel.Size = new System.Drawing.Size(106, 54);
            this.btnGnrlShowAddPanel.TabIndex = 39;
            this.btnGnrlShowAddPanel.Text = "Add New Payment Type";
            this.btnGnrlShowAddPanel.UseVisualStyleBackColor = false;
            this.btnGnrlShowAddPanel.Click += new System.EventHandler(this.btnGnrlShowAddPanel_Click);
            // 
            // btnGnrlShowAllPayments
            // 
            this.btnGnrlShowAllPayments.BackColor = System.Drawing.Color.Brown;
            this.btnGnrlShowAllPayments.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGnrlShowAllPayments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnGnrlShowAllPayments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnGnrlShowAllPayments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGnrlShowAllPayments.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGnrlShowAllPayments.ForeColor = System.Drawing.Color.White;
            this.btnGnrlShowAllPayments.Location = new System.Drawing.Point(532, 0);
            this.btnGnrlShowAllPayments.Name = "btnGnrlShowAllPayments";
            this.btnGnrlShowAllPayments.Size = new System.Drawing.Size(106, 54);
            this.btnGnrlShowAllPayments.TabIndex = 40;
            this.btnGnrlShowAllPayments.Text = "Show Payments";
            this.btnGnrlShowAllPayments.UseVisualStyleBackColor = false;
            this.btnGnrlShowAllPayments.Click += new System.EventHandler(this.btnGnrlShowAllPayments_Click);
            // 
            // dGridView
            // 
            this.dGridView.BackgroundColor = System.Drawing.Color.Khaki;
            this.dGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.dGridView.Location = new System.Drawing.Point(0, 54);
            this.dGridView.Name = "dGridView";
            this.dGridView.Size = new System.Drawing.Size(745, 321);
            this.dGridView.TabIndex = 41;
            this.dGridView.Visible = false;
            // 
            // btnOrganizedPayments
            // 
            this.btnOrganizedPayments.BackColor = System.Drawing.SystemColors.Control;
            this.btnOrganizedPayments.BackgroundImage = global::orderFollowing.Properties.Resources.organized;
            this.btnOrganizedPayments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrganizedPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrganizedPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrganizedPayments.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrganizedPayments.Location = new System.Drawing.Point(656, 375);
            this.btnOrganizedPayments.Name = "btnOrganizedPayments";
            this.btnOrganizedPayments.Size = new System.Drawing.Size(89, 82);
            this.btnOrganizedPayments.TabIndex = 42;
            this.btnOrganizedPayments.UseVisualStyleBackColor = false;
            this.btnOrganizedPayments.Visible = false;
            this.btnOrganizedPayments.Click += new System.EventHandler(this.btnOrganizedPayments_Click);
            // 
            // btnAllPayments
            // 
            this.btnAllPayments.BackColor = System.Drawing.SystemColors.Control;
            this.btnAllPayments.BackgroundImage = global::orderFollowing.Properties.Resources.all_payments;
            this.btnAllPayments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAllPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllPayments.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAllPayments.Location = new System.Drawing.Point(556, 375);
            this.btnAllPayments.Name = "btnAllPayments";
            this.btnAllPayments.Size = new System.Drawing.Size(89, 82);
            this.btnAllPayments.TabIndex = 43;
            this.btnAllPayments.UseVisualStyleBackColor = false;
            this.btnAllPayments.Visible = false;
            this.btnAllPayments.Click += new System.EventHandler(this.btnAllPayments_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(8, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(99, 39);
            this.lblTitle.TabIndex = 44;
            this.lblTitle.Text = "lblTitle";
            this.lblTitle.Visible = false;
            // 
            // LViewPTypes
            // 
            this.LViewPTypes.BackColor = System.Drawing.Color.Khaki;
            this.LViewPTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHexplanation});
            this.LViewPTypes.FullRowSelect = true;
            this.LViewPTypes.HideSelection = false;
            this.LViewPTypes.Location = new System.Drawing.Point(0, 56);
            this.LViewPTypes.Name = "LViewPTypes";
            this.LViewPTypes.Size = new System.Drawing.Size(124, 111);
            this.LViewPTypes.TabIndex = 39;
            this.LViewPTypes.UseCompatibleStateImageBehavior = false;
            // 
            // CHexplanation
            // 
            this.CHexplanation.Text = "Payment Type";
            this.CHexplanation.Width = 100;
            // 
            // paymentsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::orderFollowing.Properties.Resources.bg_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(745, 457);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAllPayments);
            this.Controls.Add(this.pnlAddPType);
            this.Controls.Add(this.btnOrganizedPayments);
            this.Controls.Add(this.dGridView);
            this.Controls.Add(this.btnGnrlShowAllPayments);
            this.Controls.Add(this.btnGnrlShowAddPanel);
            this.Controls.Add(this.btnBack);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "paymentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payments Form";
            this.pnlAddPType.ResumeLayout(false);
            this.pnlAddPType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox TBoxPType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlAddPType;
        private System.Windows.Forms.Button btnAddPaymentType;
        private System.Windows.Forms.Button btnGnrlShowAddPanel;
        private System.Windows.Forms.Button btnGnrlShowAllPayments;
        private System.Windows.Forms.DataGridView dGridView;
        private System.Windows.Forms.Button btnOrganizedPayments;
        private System.Windows.Forms.Button btnAllPayments;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView LViewPTypes;
        private System.Windows.Forms.ColumnHeader CHexplanation;
    }
}