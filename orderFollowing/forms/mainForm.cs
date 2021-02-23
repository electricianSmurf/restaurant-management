using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orderFollowing
{
    public partial class mainForm : Form
    {
        string userName;
        public mainForm()
        {
            InitializeComponent();
            userName = loginForm.onlineUserName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            saveStaffExitTime();
            this.Close();
        }
        void saveStaffExitTime()
        {
            cStaffActivities staffActivity = new cStaffActivities();
            staffActivity.sqlQuery = "update STAFFACTIVITY set exitTime = @exit "
            + "where STAFFACTIVITY.staffID = (select top 1 STAFFACTIVITY.staffID from STAFFACTIVITY inner join "
            + "STAFFS on STAFFS.staffID = STAFFACTIVITY.staffID where staffUserName = @userName) and "
            + "entranceTime = (select top 1 entranceTime from STAFFACTIVITY inner join STAFFS on "
            + "STAFFS.staffID = STAFFACTIVITY.staffID where staffUserName = @userName order by entranceTime desc)";
            staffActivity.exitTime = DateTime.Now;
            staffActivity.userName = userName;
            staffActivity.updateStaffActivity();
            
        }
        private void btnStaffs_Click(object sender, EventArgs e)
        {
            this.Hide();
            forms.staffsForm staffsForm = new forms.staffsForm();
            staffsForm.ShowDialog();
            this.Close();
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            this.Hide();
            forms.tablesForm tablesForm = new forms.tablesForm();
            tablesForm.ShowDialog();
            this.Close();
        }
    }
}
