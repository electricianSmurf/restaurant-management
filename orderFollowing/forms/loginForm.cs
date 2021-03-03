using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace orderFollowing
{
    public partial class loginForm : Form
    {
        cGetDataFromSql getData = new cGetDataFromSql();
        cStaffActivities staffActivity;
        public static string onlineUserName;

        public loginForm()
        {
            InitializeComponent();
        }
        private void loginForm_Load(object sender, EventArgs e)
        {
            getData.sqlQuery = "select staffNameSurname, staffUserName, staffPassword FROM STAFFS where staffStatus = 1";
            getData.GetDataFromSql();
            dataGridView1.DataSource = getData.dataTable;
            for (int row = 0; row < getData.dataTable.Rows.Count; row++)
            {
                CBoxUserNames.Items.Add(getData.dataTable.Rows[row]["staffUserName"]);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isUserEnteredInfo())
            {
                if (isInfoCorrect())
                {
                    onlineUserName = CBoxUserNames.SelectedItem.ToString();
                    saveStaffEntranceTime();
                    this.Hide();
                    mainForm mainForm = new mainForm();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password!");
                }
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!");
            }
        }
        private bool isUserEnteredInfo()
        {
            bool blanksFilled = false;
            if (!string.IsNullOrEmpty(TBoxPassword.Text) && !string.IsNullOrEmpty(CBoxUserNames.Text))
            {
                blanksFilled = true;
            }
            return blanksFilled;
        }
        private bool isInfoCorrect()
        {
            bool infoCorrect = false;
            if (TBoxPassword.Text == getData.dataTable.Rows[CBoxUserNames.SelectedIndex]["staffPassword"].ToString())
            {
                infoCorrect = true;
            }
            return infoCorrect;
        }
        void saveStaffEntranceTime()
        {
            staffActivity = new cStaffActivities();
            staffActivity.sqlQuery = "insert into STAFFACTIVITY (staffID, entranceTime, exitTime)"
            + " values ((select staffID from STAFFS where STAFFS.staffUserName = @userName), @entrance, @exit)";

            staffActivity.userName = CBoxUserNames.SelectedItem.ToString();
            staffActivity.entranceTime = DateTime.Now;
            staffActivity.exitTime = DateTime.Now;

            staffActivity.insertStaffActivity();
        }
        
        private void CBoxUserNames_SelectedValueChanged(object sender, EventArgs e)
        {
            TBoxPassword.Text = "";
        }

        /*select staffNameSurname, dutyName, staffUserName, staffPhoto, entranceTime, exitTime from STAFFS, STAFFACTIVITY, DUTIES
where STAFFS.staffID = STAFFACTIVITY.staffID and STAFFS.staffDuty = DUTIES.dutyID*/

    }
}
