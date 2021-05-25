namespace orderFollowing.forms
{
    partial class productsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productsForm));
            this.TBoxProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RTBoxContent = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBoxPrice = new System.Windows.Forms.TextBox();
            this.radioBtnAvailable = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radioBtnAbsent = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.CBoxCategoryName = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dGridView = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlAddProduct = new System.Windows.Forms.Panel();
            this.btnGnrlShow = new System.Windows.Forms.Button();
            this.btnGnrlAdd = new System.Windows.Forms.Button();
            this.btnGnrlUpdate = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView)).BeginInit();
            this.pnlAddProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBoxProductName
            // 
            this.TBoxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBoxProductName.Location = new System.Drawing.Point(124, 35);
            this.TBoxProductName.Name = "TBoxProductName";
            this.TBoxProductName.Size = new System.Drawing.Size(205, 22);
            this.TBoxProductName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product Name";
            // 
            // RTBoxContent
            // 
            this.RTBoxContent.Location = new System.Drawing.Point(124, 61);
            this.RTBoxContent.Name = "RTBoxContent";
            this.RTBoxContent.Size = new System.Drawing.Size(205, 84);
            this.RTBoxContent.TabIndex = 8;
            this.RTBoxContent.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Product Content";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Product Price";
            // 
            // TBoxPrice
            // 
            this.TBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBoxPrice.Location = new System.Drawing.Point(124, 150);
            this.TBoxPrice.Name = "TBoxPrice";
            this.TBoxPrice.Size = new System.Drawing.Size(205, 22);
            this.TBoxPrice.TabIndex = 11;
            // 
            // radioBtnAvailable
            // 
            this.radioBtnAvailable.AutoSize = true;
            this.radioBtnAvailable.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnAvailable.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnAvailable.ForeColor = System.Drawing.Color.White;
            this.radioBtnAvailable.Location = new System.Drawing.Point(127, 180);
            this.radioBtnAvailable.Name = "radioBtnAvailable";
            this.radioBtnAvailable.Size = new System.Drawing.Size(94, 26);
            this.radioBtnAvailable.TabIndex = 12;
            this.radioBtnAvailable.TabStop = true;
            this.radioBtnAvailable.Text = "Available";
            this.radioBtnAvailable.UseVisualStyleBackColor = false;
            this.radioBtnAvailable.Click += new System.EventHandler(this.radioBtnAvailable_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Product Status";
            // 
            // radioBtnAbsent
            // 
            this.radioBtnAbsent.AutoSize = true;
            this.radioBtnAbsent.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnAbsent.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnAbsent.ForeColor = System.Drawing.Color.White;
            this.radioBtnAbsent.Location = new System.Drawing.Point(232, 180);
            this.radioBtnAbsent.Name = "radioBtnAbsent";
            this.radioBtnAbsent.Size = new System.Drawing.Size(76, 26);
            this.radioBtnAbsent.TabIndex = 14;
            this.radioBtnAbsent.TabStop = true;
            this.radioBtnAbsent.Text = "Absent";
            this.radioBtnAbsent.UseVisualStyleBackColor = false;
            this.radioBtnAbsent.Click += new System.EventHandler(this.radioBtnAbsent_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Category Name";
            // 
            // CBoxCategoryName
            // 
            this.CBoxCategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxCategoryName.FormattingEnabled = true;
            this.CBoxCategoryName.Location = new System.Drawing.Point(124, 10);
            this.CBoxCategoryName.Name = "CBoxCategoryName";
            this.CBoxCategoryName.Size = new System.Drawing.Size(207, 21);
            this.CBoxCategoryName.TabIndex = 17;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Black;
            this.btnAddProduct.BackgroundImage = global::orderFollowing.Properties.Resources.plus;
            this.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddProduct.Location = new System.Drawing.Point(650, 380);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(67, 64);
            this.btnAddProduct.TabIndex = 24;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Visible = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dGridView
            // 
            this.dGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridView.Location = new System.Drawing.Point(48, 230);
            this.dGridView.Name = "dGridView";
            this.dGridView.Size = new System.Drawing.Size(649, 145);
            this.dGridView.TabIndex = 26;
            this.dGridView.Visible = false;
            this.dGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridView_CellClick);
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
            this.btnBack.TabIndex = 27;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlAddProduct
            // 
            this.pnlAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.pnlAddProduct.Controls.Add(this.label5);
            this.pnlAddProduct.Controls.Add(this.label1);
            this.pnlAddProduct.Controls.Add(this.TBoxProductName);
            this.pnlAddProduct.Controls.Add(this.RTBoxContent);
            this.pnlAddProduct.Controls.Add(this.label2);
            this.pnlAddProduct.Controls.Add(this.radioBtnAbsent);
            this.pnlAddProduct.Controls.Add(this.CBoxCategoryName);
            this.pnlAddProduct.Controls.Add(this.label4);
            this.pnlAddProduct.Controls.Add(this.radioBtnAvailable);
            this.pnlAddProduct.Controls.Add(this.label3);
            this.pnlAddProduct.Controls.Add(this.TBoxPrice);
            this.pnlAddProduct.Location = new System.Drawing.Point(8, 9);
            this.pnlAddProduct.Name = "pnlAddProduct";
            this.pnlAddProduct.Size = new System.Drawing.Size(337, 209);
            this.pnlAddProduct.TabIndex = 28;
            this.pnlAddProduct.Visible = false;
            // 
            // btnGnrlShow
            // 
            this.btnGnrlShow.BackColor = System.Drawing.Color.Brown;
            this.btnGnrlShow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGnrlShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnGnrlShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnGnrlShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGnrlShow.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGnrlShow.ForeColor = System.Drawing.Color.White;
            this.btnGnrlShow.Location = new System.Drawing.Point(425, 0);
            this.btnGnrlShow.Name = "btnGnrlShow";
            this.btnGnrlShow.Size = new System.Drawing.Size(106, 54);
            this.btnGnrlShow.TabIndex = 42;
            this.btnGnrlShow.Text = "Show Products";
            this.btnGnrlShow.UseVisualStyleBackColor = false;
            this.btnGnrlShow.Click += new System.EventHandler(this.btnGnrlShow_Click);
            // 
            // btnGnrlAdd
            // 
            this.btnGnrlAdd.BackColor = System.Drawing.Color.Brown;
            this.btnGnrlAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGnrlAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnGnrlAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnGnrlAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGnrlAdd.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGnrlAdd.ForeColor = System.Drawing.Color.White;
            this.btnGnrlAdd.Location = new System.Drawing.Point(639, 0);
            this.btnGnrlAdd.Name = "btnGnrlAdd";
            this.btnGnrlAdd.Size = new System.Drawing.Size(106, 54);
            this.btnGnrlAdd.TabIndex = 41;
            this.btnGnrlAdd.Text = "Add New Product";
            this.btnGnrlAdd.UseVisualStyleBackColor = false;
            this.btnGnrlAdd.Click += new System.EventHandler(this.btnGnrlAdd_Click);
            // 
            // btnGnrlUpdate
            // 
            this.btnGnrlUpdate.BackColor = System.Drawing.Color.Brown;
            this.btnGnrlUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGnrlUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnGnrlUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnGnrlUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGnrlUpdate.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGnrlUpdate.ForeColor = System.Drawing.Color.White;
            this.btnGnrlUpdate.Location = new System.Drawing.Point(532, 0);
            this.btnGnrlUpdate.Name = "btnGnrlUpdate";
            this.btnGnrlUpdate.Size = new System.Drawing.Size(106, 54);
            this.btnGnrlUpdate.TabIndex = 43;
            this.btnGnrlUpdate.Text = "Update Products";
            this.btnGnrlUpdate.UseVisualStyleBackColor = false;
            this.btnGnrlUpdate.Click += new System.EventHandler(this.btnGnrlUpdate_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.Black;
            this.btnUpdateProduct.BackgroundImage = global::orderFollowing.Properties.Resources.update1;
            this.btnUpdateProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateProduct.Location = new System.Drawing.Point(577, 380);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(67, 64);
            this.btnUpdateProduct.TabIndex = 44;
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Visible = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // productsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::orderFollowing.Properties.Resources.bg_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(745, 457);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnGnrlUpdate);
            this.Controls.Add(this.btnGnrlShow);
            this.Controls.Add(this.btnGnrlAdd);
            this.Controls.Add(this.pnlAddProduct);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dGridView);
            this.Controls.Add(this.btnAddProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "productsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "productsForm";
            this.Load += new System.EventHandler(this.productsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridView)).EndInit();
            this.pnlAddProduct.ResumeLayout(false);
            this.pnlAddProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TBoxProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RTBoxContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBoxPrice;
        private System.Windows.Forms.RadioButton radioBtnAvailable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioBtnAbsent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBoxCategoryName;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dGridView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlAddProduct;
        private System.Windows.Forms.Button btnGnrlShow;
        private System.Windows.Forms.Button btnGnrlAdd;
        private System.Windows.Forms.Button btnGnrlUpdate;
        private System.Windows.Forms.Button btnUpdateProduct;
    }
}