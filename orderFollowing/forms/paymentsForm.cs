using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orderFollowing.forms
{
    public partial class paymentsForm : Form
    {
        cPaymentOperations payment;
        cPaymentTypeOperations pType;

        public paymentsForm()
        {
            InitializeComponent();
            dGridViewSettings();
        }

        void dGridViewSettings()
        {
            dGridView.AllowUserToResizeRows = false;
            dGridView.AllowUserToResizeColumns = false;
            dGridView.ReadOnly = true;
            dGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnGnrlShowAllPayments_Click(object sender, EventArgs e)
        {
            lblTitle.Visible = true;
            tidyFormForViewingPayments();

            showAllPayments();
        }

        void tidyFormForViewingPayments()
        {
            if (lblTitle.Text != "All Payments")
            {
                lblTitle.Text = "All Payments";
                pnlAddPType.Visible = false;
                changeItemsVisibleStatus();
            }
        }

        void changeItemsVisibleStatus()
        {
            dGridView.Visible = !dGridView.Visible;
            btnAllPayments.Visible = !btnAllPayments.Visible;
            btnOrganizedPayments.Visible = !btnOrganizedPayments.Visible;
        }

        void showAllPayments()
        {
            payment = new cPaymentOperations();
            payment.sqlQuery = "select billID as 'Bill No', rowNumber as 'Table No', paymentTotal as 'Total', Date, "
            + "explanation as 'Payment Type', paymentStatus 'Status' from PAYMENTS inner join PAYMENTTYPE "
            + "on PAYMENTS.paymentType = PAYMENTTYPE.paymentTypeID inner join TABLES on PAYMENTS.tableID = TABLES.tableID "
            + "where date between @startTime and @finishTime order by date";

            payment.paymentStartTime = DateTime.Now.Date;
            payment.paymentFinishTime = DateTime.Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59);

            payment.viewPayments();

            dGridView.DataSource = payment.dataTable;
        }
        
        private void btnGnrlShowAddPanel_Click(object sender, EventArgs e)
        {
            lblTitle.Visible = true;
            tidyFormForAddingNewType();
            listAllPaymentTypes();
        }

        void tidyFormForAddingNewType()
        {
            if (lblTitle.Text != "Adding New Payment Type")
            {
                lblTitle.Text = "Adding New Payment Type";
                pnlAddPType.Visible = true;
                if (dGridView.Visible)
                {
                    changeItemsVisibleStatus();
                }
            }
        }

        void listAllPaymentTypes()
        {
            pType = new cPaymentTypeOperations();
            pType.sqlQuery = "select explanation from PAYMENTTYPE";
            pType.showPaymentTypes();

            fillLView();
        }

        void fillLView()
        {
            LViewPTypes.Items.Clear();
            LViewPTypes.View = View.Details;

            foreach (DataRow row in pType.dataTable.Rows)
            {
                LViewPTypes.Items.Add(row["explanation"].ToString());
            }
        }

        private void btnAllPayments_Click(object sender, EventArgs e)
        {
            if (lblTitle.Text != "All Payments")
            {
                lblTitle.Text = "All Payments";
                showAllPayments();
            }
        }

        private void btnOrganizedPayments_Click(object sender, EventArgs e)
        {
            if (lblTitle.Text != "Organized Payments")
            {
                lblTitle.Text = "Organized Payments";
                showOrganizedPayments();
            }
        }

        void showOrganizedPayments()
        {
            payment = new cPaymentOperations();
            payment.sqlQuery = "select explanation as 'Payment Type', SUM(paymentTotal) as 'Total' from PAYMENTS inner join "
            + "PAYMENTTYPE on PAYMENTS.paymentType = PAYMENTTYPE.paymentTypeID inner join TABLES on "
            + "PAYMENTS.tableID = TABLES.tableID where date between @startTime and @finishTime group by explanation";

            payment.paymentStartTime = DateTime.Now.Date;
            payment.paymentFinishTime = DateTime.Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59);

            payment.viewPayments();

            dGridView.DataSource = payment.dataTable;
        }

        private void btnAddPaymentType_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBoxPType.Text))
            {
                if (checkForSameness())
                {
                    MessageBox.Show("This payment type is already added!");
                }
                else
                {
                    pType = new cPaymentTypeOperations();
                    pType.paymentType = TBoxPType.Text;

                    pType.sqlQuery = "insert into PAYMENTTYPE (explanation) values (@PType)";
                    pType.addNewPType();

                    MessageBox.Show("Payment type is added!");
                    TBoxPType.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please write a payment type!");
            }
        }

        private bool checkForSameness()
        {
            pType = new cPaymentTypeOperations();
            pType.paymentType = TBoxPType.Text;

            pType.sqlQuery = "select explanation from PAYMENTTYPE";

            return pType.checkIsPTypeAlive();      
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm mainForm = new mainForm();
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
