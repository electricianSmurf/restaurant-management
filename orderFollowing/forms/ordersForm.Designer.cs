namespace orderFollowing.forms
{
    partial class ordersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ordersForm));
            this.btnDeliveredOrders = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnReadyOrders = new System.Windows.Forms.Button();
            this.btnNewOrders = new System.Windows.Forms.Button();
            this.btnPreparingOrders = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeliveredOrders
            // 
            this.btnDeliveredOrders.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeliveredOrders.BackgroundImage = global::orderFollowing.Properties.Resources.delivered;
            this.btnDeliveredOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeliveredOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeliveredOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeliveredOrders.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeliveredOrders.Location = new System.Drawing.Point(646, 374);
            this.btnDeliveredOrders.Name = "btnDeliveredOrders";
            this.btnDeliveredOrders.Size = new System.Drawing.Size(89, 82);
            this.btnDeliveredOrders.TabIndex = 26;
            this.btnDeliveredOrders.UseVisualStyleBackColor = false;
            this.btnDeliveredOrders.Click += new System.EventHandler(this.btnDeliveredOrders_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(725, 304);
            this.dataGridView1.TabIndex = 27;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(8, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(207, 39);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Delivered Orders";
            // 
            // btnReadyOrders
            // 
            this.btnReadyOrders.BackColor = System.Drawing.SystemColors.Control;
            this.btnReadyOrders.BackgroundImage = global::orderFollowing.Properties.Resources.ready;
            this.btnReadyOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReadyOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReadyOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadyOrders.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReadyOrders.Location = new System.Drawing.Point(546, 374);
            this.btnReadyOrders.Name = "btnReadyOrders";
            this.btnReadyOrders.Size = new System.Drawing.Size(89, 82);
            this.btnReadyOrders.TabIndex = 29;
            this.btnReadyOrders.UseVisualStyleBackColor = false;
            this.btnReadyOrders.Click += new System.EventHandler(this.btnReadyOrders_Click);
            // 
            // btnNewOrders
            // 
            this.btnNewOrders.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewOrders.BackgroundImage = global::orderFollowing.Properties.Resources.new_order1;
            this.btnNewOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrders.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewOrders.Location = new System.Drawing.Point(346, 374);
            this.btnNewOrders.Name = "btnNewOrders";
            this.btnNewOrders.Size = new System.Drawing.Size(89, 82);
            this.btnNewOrders.TabIndex = 30;
            this.btnNewOrders.UseVisualStyleBackColor = false;
            this.btnNewOrders.Click += new System.EventHandler(this.btnNewOrders_Click);
            // 
            // btnPreparingOrders
            // 
            this.btnPreparingOrders.BackColor = System.Drawing.SystemColors.Control;
            this.btnPreparingOrders.BackgroundImage = global::orderFollowing.Properties.Resources.preparing;
            this.btnPreparingOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPreparingOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreparingOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreparingOrders.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPreparingOrders.Location = new System.Drawing.Point(446, 374);
            this.btnPreparingOrders.Name = "btnPreparingOrders";
            this.btnPreparingOrders.Size = new System.Drawing.Size(89, 82);
            this.btnPreparingOrders.TabIndex = 31;
            this.btnPreparingOrders.UseVisualStyleBackColor = false;
            this.btnPreparingOrders.Click += new System.EventHandler(this.btnPreparingOrders_Click);
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
            this.btnBack.TabIndex = 32;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ordersForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::orderFollowing.Properties.Resources.bg_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(745, 457);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPreparingOrders);
            this.Controls.Add(this.btnNewOrders);
            this.Controls.Add(this.btnReadyOrders);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeliveredOrders);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ordersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeliveredOrders;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnReadyOrders;
        private System.Windows.Forms.Button btnNewOrders;
        private System.Windows.Forms.Button btnPreparingOrders;
        private System.Windows.Forms.Button btnBack;
    }
}