namespace orderFollowing.forms
{
    partial class staffsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffsForm));
            this.TBoxNameSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioBtnWorking = new System.Windows.Forms.RadioButton();
            this.radioBtnLeft = new System.Windows.Forms.RadioButton();
            this.PBoxPerson = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.dGridView = new System.Windows.Forms.DataGridView();
            this.TBoxPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.TBoxPhotoName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PBoxWarning = new System.Windows.Forms.PictureBox();
            this.CBoxStaffDuty = new System.Windows.Forms.ComboBox();
            this.btnShowStaffAct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // TBoxNameSurname
            // 
            this.TBoxNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBoxNameSurname.Location = new System.Drawing.Point(132, 41);
            this.TBoxNameSurname.Name = "TBoxNameSurname";
            this.TBoxNameSurname.Size = new System.Drawing.Size(205, 22);
            this.TBoxNameSurname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name Surname";
            // 
            // TBoxUsername
            // 
            this.TBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBoxUsername.Location = new System.Drawing.Point(132, 119);
            this.TBoxUsername.Name = "TBoxUsername";
            this.TBoxUsername.Size = new System.Drawing.Size(205, 22);
            this.TBoxUsername.TabIndex = 7;
            this.TBoxUsername.TextChanged += new System.EventHandler(this.TBoxUsername_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Duty";
            // 
            // TBoxPhoneNumber
            // 
            this.TBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBoxPhoneNumber.Location = new System.Drawing.Point(132, 171);
            this.TBoxPhoneNumber.Name = "TBoxPhoneNumber";
            this.TBoxPhoneNumber.Size = new System.Drawing.Size(205, 22);
            this.TBoxPhoneNumber.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Status";
            // 
            // radioBtnWorking
            // 
            this.radioBtnWorking.AutoSize = true;
            this.radioBtnWorking.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnWorking.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnWorking.ForeColor = System.Drawing.Color.White;
            this.radioBtnWorking.Location = new System.Drawing.Point(132, 197);
            this.radioBtnWorking.Name = "radioBtnWorking";
            this.radioBtnWorking.Size = new System.Drawing.Size(89, 26);
            this.radioBtnWorking.TabIndex = 13;
            this.radioBtnWorking.TabStop = true;
            this.radioBtnWorking.Text = "Working";
            this.radioBtnWorking.UseVisualStyleBackColor = false;
            this.radioBtnWorking.Click += new System.EventHandler(this.radioBtnWorking_Click);
            // 
            // radioBtnLeft
            // 
            this.radioBtnLeft.AutoSize = true;
            this.radioBtnLeft.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnLeft.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnLeft.ForeColor = System.Drawing.Color.White;
            this.radioBtnLeft.Location = new System.Drawing.Point(237, 197);
            this.radioBtnLeft.Name = "radioBtnLeft";
            this.radioBtnLeft.Size = new System.Drawing.Size(57, 26);
            this.radioBtnLeft.TabIndex = 14;
            this.radioBtnLeft.TabStop = true;
            this.radioBtnLeft.Text = "Left";
            this.radioBtnLeft.UseVisualStyleBackColor = false;
            this.radioBtnLeft.Click += new System.EventHandler(this.radioBtnLeft_Click);
            // 
            // PBoxPerson
            // 
            this.PBoxPerson.Location = new System.Drawing.Point(549, 41);
            this.PBoxPerson.Name = "PBoxPerson";
            this.PBoxPerson.Size = new System.Drawing.Size(130, 150);
            this.PBoxPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxPerson.TabIndex = 15;
            this.PBoxPerson.TabStop = false;
            this.PBoxPerson.Click += new System.EventHandler(this.PBoxPerson_Click);
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
            this.btnBack.TabIndex = 16;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddStaff.Location = new System.Drawing.Point(456, 40);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(75, 50);
            this.btnAddStaff.TabIndex = 17;
            this.btnAddStaff.Text = "Add New Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // dGridView
            // 
            this.dGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridView.Location = new System.Drawing.Point(48, 229);
            this.dGridView.Name = "dGridView";
            this.dGridView.Size = new System.Drawing.Size(649, 145);
            this.dGridView.TabIndex = 18;
            this.dGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridView_CellClick);
            this.dGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dGridView_CellFormatting);
            // 
            // TBoxPassword
            // 
            this.TBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBoxPassword.Location = new System.Drawing.Point(132, 145);
            this.TBoxPassword.Name = "TBoxPassword";
            this.TBoxPassword.PasswordChar = '*';
            this.TBoxPassword.Size = new System.Drawing.Size(205, 22);
            this.TBoxPassword.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Password";
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateStaff.Location = new System.Drawing.Point(456, 90);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(75, 50);
            this.btnUpdateStaff.TabIndex = 22;
            this.btnUpdateStaff.Text = "Update Staff";
            this.btnUpdateStaff.UseVisualStyleBackColor = true;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // TBoxPhotoName
            // 
            this.TBoxPhotoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBoxPhotoName.Location = new System.Drawing.Point(132, 67);
            this.TBoxPhotoName.Name = "TBoxPhotoName";
            this.TBoxPhotoName.Size = new System.Drawing.Size(205, 22);
            this.TBoxPhotoName.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Photo Name";
            // 
            // PBoxWarning
            // 
            this.PBoxWarning.BackColor = System.Drawing.Color.Transparent;
            this.PBoxWarning.BackgroundImage = global::orderFollowing.Properties.Resources.exclamation_mark;
            this.PBoxWarning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBoxWarning.Location = new System.Drawing.Point(341, 119);
            this.PBoxWarning.Name = "PBoxWarning";
            this.PBoxWarning.Size = new System.Drawing.Size(22, 22);
            this.PBoxWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxWarning.TabIndex = 25;
            this.PBoxWarning.TabStop = false;
            this.PBoxWarning.Visible = false;
            // 
            // CBoxStaffDuty
            // 
            this.CBoxStaffDuty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxStaffDuty.Location = new System.Drawing.Point(132, 93);
            this.CBoxStaffDuty.Name = "CBoxStaffDuty";
            this.CBoxStaffDuty.Size = new System.Drawing.Size(205, 21);
            this.CBoxStaffDuty.TabIndex = 0;
            // 
            // btnShowStaffAct
            // 
            this.btnShowStaffAct.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowStaffAct.Location = new System.Drawing.Point(456, 140);
            this.btnShowStaffAct.Name = "btnShowStaffAct";
            this.btnShowStaffAct.Size = new System.Drawing.Size(75, 50);
            this.btnShowStaffAct.TabIndex = 26;
            this.btnShowStaffAct.Text = "Show Staff Acts";
            this.btnShowStaffAct.UseVisualStyleBackColor = true;
            this.btnShowStaffAct.Click += new System.EventHandler(this.btnShowStaffAct_Click);
            // 
            // staffsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(745, 457);
            this.Controls.Add(this.btnShowStaffAct);
            this.Controls.Add(this.CBoxStaffDuty);
            this.Controls.Add(this.PBoxWarning);
            this.Controls.Add(this.TBoxPhotoName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnUpdateStaff);
            this.Controls.Add(this.TBoxPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dGridView);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.PBoxPerson);
            this.Controls.Add(this.radioBtnLeft);
            this.Controls.Add(this.radioBtnWorking);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBoxPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBoxUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBoxNameSurname);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staffsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "staffsForm";
            this.Load += new System.EventHandler(this.staffsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBoxNameSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBoxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBoxPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioBtnWorking;
        private System.Windows.Forms.RadioButton radioBtnLeft;
        private System.Windows.Forms.PictureBox PBoxPerson;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.DataGridView dGridView;
        private System.Windows.Forms.TextBox TBoxPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.TextBox TBoxPhotoName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox PBoxWarning;
        private System.Windows.Forms.ComboBox CBoxStaffDuty;
        private System.Windows.Forms.Button btnShowStaffAct;

    }
}