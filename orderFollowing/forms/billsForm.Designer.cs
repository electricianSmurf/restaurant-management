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
            this.label1 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "label1";
            // 
            // billsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::orderFollowing.Properties.Resources.bg_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(745, 457);
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dGridView;
        private System.Windows.Forms.Button btnClosedBills;
        private System.Windows.Forms.Button btnOpenBills;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
    }
}