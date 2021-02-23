using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;// used for extracting the file name from the file path
using System.Data.SqlClient;

namespace orderFollowing.forms
{
    public partial class staffsForm : Form
    {
        bool isStaffWorking;
        bool isCellClickAllowed = false;
        bool isUpdateAllowed = false;
        bool isStaffActClicked = false;

        int indexOfLastStaff;
        Image defaultImage = Properties.Resources.person;
        List<string> sqlUsernames;

        cGetDataFromSql getData;
        cInsUpdStaffIntoSql insUpdStaffIntoSql;
        public staffsForm()
        {
            InitializeComponent();
            PBoxPerson.Image = defaultImage;
        }
        private void staffsForm_Load(object sender, EventArgs e)
        {
            clearTBoxes();
            reloadInfo();
        }
        void reloadInfo()
        {
            getStaffInfo();
            dGridViewSettings();
            addUserNames();
            getDutyNames();
        }
        void clearTBoxes()
        {
            TBoxNameSurname.Text = null;
            TBoxPhotoName.Text = null;
            TBoxUsername.Text = null;
            TBoxPassword.Text = null;
            TBoxPhoneNumber.Text = null;
            radioBtnWorking.Checked = false;
            radioBtnLeft.Checked = false;
            PBoxPerson.Image = defaultImage;
        }
        void getStaffInfo()
        {
            getData = new cGetDataFromSql();
            getData.sqlQuery = "select staffID, staffNameSurname as Name, dutyName as Duty, staffUserName as Username, staffPassword as Password, staffPhoneNumber as Phone, staffStatus as Status, staffPhoto as Photo from STAFFS, DUTIES where DUTIES.dutyID = STAFFS.staffDuty";
            getData.GetDataFromSql();
            dGridView.DataSource = getData.dataTable;
        }
        void dGridViewSettings()
        {
            indexOfLastStaff = dGridView.Rows.Count - 2;// -2 means: first index is 0 and the last row is empty
            this.dGridView.Columns[0].Visible = false;
            dGridView.AllowUserToResizeRows = false;
            dGridView.AllowUserToResizeColumns = false;
            dGridView.ReadOnly = true;
            dGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        void addUserNames()
        {
            sqlUsernames = new List<string>();
            for (int i = 0; i < dGridView.Rows.Count; i++)
            {
                sqlUsernames.Add(Convert.ToString(dGridView.Rows[i].Cells[3].Value));//adding list "usernames column" of datagridview 
            }
        }
        void getDutyNames()
        {
            getData = new cGetDataFromSql();
            getData.sqlQuery = "select dutyName from DUTIES";
            getData.GetDataFromSql();
            CBoxStaffDuty.DataSource = getData.dataTable;
            CBoxStaffDuty.DisplayMember = "dutyName";

            /*for (int row = 0; row < getData.dataTable.Rows.Count; row++)
            {
                CBoxStaffDuty.Items.Add(getData.dataTable.Rows[row][0]);
            }*/
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!isCellClickAllowed)
            {
                this.Hide();
                mainForm mainForm = new mainForm();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                tidyForm();
                clearTBoxes();
                reloadInfo();
            }
        }

        private void PBoxPerson_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png)|*.jpg; *.jpeg; *.bmp; *.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                PBoxPerson.Image = new Bitmap(openFile.FileName);
                string selectedImagePath = openFile.FileName;
                TBoxPhotoName.Text = Path.GetFileNameWithoutExtension(selectedImagePath);
            }
        }
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (validateAllConditions())
            {
                var imageFormat = System.Drawing.Imaging.ImageFormat.Png;
                if (checkIfPhotoExists(TBoxPhotoName.Text))
                {
                    MessageBox.Show("Change photo name");
                }
                else
                {
                    addNewStaff();
                    PBoxPerson.Image.Save(validateFolderPath() + TBoxPhotoName.Text + ".png", imageFormat);
                    clearTBoxes();
                    reloadInfo();
                }
            }
        }

        void addNewStaff()
        {
            insUpdStaffIntoSql = new cInsUpdStaffIntoSql();
            insUpdStaffIntoSql.sqlQuery = "insert into STAFFS(staffNameSurname, staffDuty, staffUserName,"
            + "staffPassword, staffPhoneNumber, staffStatus, staffPhoto)" 
            + "VALUES (@name, @duty, @userName, @password, @phone, @status, @photo)";
            insUpdStaffIntoSqlParameters();
            insUpdStaffIntoSql.insertStaff();
        }

        void insUpdStaffIntoSqlParameters()
        {
            insUpdStaffIntoSql.staffName = TBoxNameSurname.Text;
            insUpdStaffIntoSql.staffDuty = CBoxStaffDuty.SelectedIndex + 1;
            insUpdStaffIntoSql.userName = TBoxUsername.Text;
            insUpdStaffIntoSql.password = TBoxPassword.Text;
            insUpdStaffIntoSql.phoneNumber = TBoxPhoneNumber.Text;
            insUpdStaffIntoSql.isWorking = isStaffWorking;
            insUpdStaffIntoSql.staffPhotoName = TBoxPhotoName.Text;
        }
        private bool checkIfPhotoExists(string photoName)
        {
            string imagePath = validateFolderPath() + photoName + ".png";
            bool status = File.Exists(imagePath);

            return status;
        }
        private string validateFolderPath()
        {
            string myFolderPath = AppDomain.CurrentDomain.BaseDirectory + @"\profile photos\";
            try
            {
                if (!Directory.Exists(myFolderPath))
                {
                    DirectoryInfo directory = Directory.CreateDirectory(myFolderPath);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return myFolderPath;
        }

        private bool validateAllConditions()
        {
            bool status = false;

            if (imageStatus() && TBoxesStatus() && radioBtnStatus())
            {
                status = true;
            }
            return status;
        }
        private bool imageStatus()
        {
            bool isImageDefault = true;
            if (PBoxPerson.Image == defaultImage)
            {
                MessageBox.Show("Please upload a profile photo");
                isImageDefault = false;
            }
            return isImageDefault;
        }
        private bool TBoxesStatus()
        {
            bool TBoxStatus = true;

            if (string.IsNullOrEmpty(CBoxStaffDuty.Text) || string.IsNullOrEmpty(TBoxNameSurname.Text) || string.IsNullOrEmpty(TBoxPassword.Text) || string.IsNullOrEmpty(TBoxPhoneNumber.Text) || string.IsNullOrEmpty(TBoxPhotoName.Text) || string.IsNullOrEmpty(TBoxUsername.Text))
            {
                TBoxStatus = false;
                MessageBox.Show("Please fill the staff info");
            }
            return TBoxStatus;
        }
        private bool radioBtnStatus()
        {
            bool staffStatus = false;
            
            if (radioBtnWorking.Checked || radioBtnLeft.Checked)
            {
                staffStatus = true;
            }
            else
            {
                MessageBox.Show("Is staff currently working?");
            }
            return staffStatus;
        }

        private void TBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBoxUsername.Text))
            {
                if (sqlUsernames.Contains(TBoxUsername.Text))
                {
                    PBoxWarning.Visible = true;
                }
                else
                {
                    PBoxWarning.Visible = false;
                }
            }
        }
        private void radioBtnWorking_Click(object sender, EventArgs e)
        {
            isStaffWorking = true;
        }

        private void radioBtnLeft_Click(object sender, EventArgs e)
        {
            isStaffWorking = false;
        }
        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            if (!isUpdateAllowed)
            {
                tidyForm();
            }
            else
            {
                updateStaffInfo();
                getStaffInfo();
            }
            showSelectedRow(0);
        }
        void tidyForm()
        {
            TBoxUsername.ReadOnly = !TBoxUsername.ReadOnly;
            if (TBoxUsername.ReadOnly)
            {
                TBoxUsername.BackColor = Color.Gray;
                btnUpdateStaff.Text = "Update";
            }
            else
            {
                TBoxUsername.BackColor = DefaultBackColor;
                btnUpdateStaff.Text = "Update Staff";
            }
            isStaffActClicked = false;
            btnAddStaff.Visible = !btnAddStaff.Visible;
            btnShowStaffAct.Visible = !btnShowStaffAct.Visible;
            isCellClickAllowed = !isCellClickAllowed;
            isUpdateAllowed = !isUpdateAllowed;
        }
        void updateStaffInfo()
        {
            insUpdStaffIntoSql = new cInsUpdStaffIntoSql();
            insUpdStaffIntoSql.sqlQuery = "update STAFFS set staffNameSurname = @name, staffDuty = @duty," 
            + "staffUserName = @userName, staffPassword = @password, staffPhoneNumber = @phone, staffStatus = @status,"
            + "staffPhoto = @photo where staffUserName = @userName";
            
            insUpdStaffIntoSqlParameters();
            insUpdStaffIntoSql.insertStaff();
        }

        private void dGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.Value != null && !isStaffActClicked) //hides the password text
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }
        private void dGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isCellClickAllowed) // always true after pushing update Staff button
            {
                if (checkRowIndexBorders(e.RowIndex))
                {
                    showSelectedRow(e.RowIndex);
                }
            }
            if (isStaffActClicked)
            {
                showStaffPhoto(dGridView.Rows[e.RowIndex].Cells["staffPhoto"].Value.ToString());
            }
        }
        private bool checkRowIndexBorders(int rowIndex)
        {
            bool indexValidated = false;
            if (rowIndex >= 0 && rowIndex <= indexOfLastStaff)
            {
                indexValidated = true;
            }
            return indexValidated;
        }
        void showSelectedRow(int rowIndex)
        {
            DataGridViewRow selectedRow = this.dGridView.Rows[rowIndex];

            TBoxNameSurname.Text = selectedRow.Cells[1].Value.ToString();
            CBoxStaffDuty.Text = selectedRow.Cells[2].Value.ToString();
            TBoxUsername.Text = selectedRow.Cells[3].Value.ToString();
            TBoxPassword.Text = selectedRow.Cells[4].Value.ToString();
            TBoxPhoneNumber.Text = selectedRow.Cells[5].Value.ToString();
            radioBtnLeft.Checked = true;
            if (Convert.ToBoolean(selectedRow.Cells[6].Value) == true)
            {
                radioBtnWorking.Checked = true;
            }
            TBoxPhotoName.Text = selectedRow.Cells[7].Value.ToString();
            showStaffPhoto(TBoxPhotoName.Text);
        }

        void showStaffPhoto(string imageName)
        {
            string photoPath = AppDomain.CurrentDomain.BaseDirectory + @"\profile photos\";
            PBoxPerson.Image = defaultImage;
            if (checkIfPhotoExists(imageName))
            {
                PBoxPerson.Image = Image.FromFile(photoPath + imageName + ".png");
            }
        }

        private void btnShowStaffAct_Click(object sender, EventArgs e)
        {
            hideControls();
            isStaffActClicked = true;
            getData = new cGetDataFromSql();
            getData.sqlQuery = "select staffNameSurname, dutyName, staffUserName, staffPhoto, entranceTime, "
            + "exitTime from STAFFS, STAFFACTIVITY, DUTIES where STAFFS.staffID = STAFFACTIVITY.staffID "
            + "and STAFFS.staffDuty = DUTIES.dutyID";
            getData.GetDataFromSql();
            dGridView.DataSource = getData.dataTable;
        }
        void hideControls()
        {
            btnAddStaff.Visible = false;
            btnUpdateStaff.Visible = false;
            btnShowStaffAct.Visible = false;
            PBoxWarning.Visible = false;

            radioBtnLeft.Visible = false;
            radioBtnWorking.Visible = false;

            CBoxStaffDuty.Visible = false;
            foreach (Control item in Controls)
            {
                if (item is TextBox || item is Label)
                {
                    item.Visible = false; 
                }
            }
        }
    }
}
