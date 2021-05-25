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
    public partial class productsForm : Form
    {
        cCategoryOperations category;
        cGetDataFromSql getData;
        cUpdateProduct product;

        bool productStatus;
        bool cellClickAllowed;


        public productsForm()
        {
            InitializeComponent();
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm mainForm = new mainForm();
            mainForm.ShowDialog();
            this.Close();
        }

        void tidyFormForAdding()
        {
            CBoxCategoryName.DropDownStyle = ComboBoxStyle.DropDownList;
            TBoxProductName.Text = "";
            RTBoxContent.Text = "";
            TBoxPrice.Text = "";
            radioBtnAvailable.Checked = false;
            radioBtnAbsent.Checked = false;

            btnAddProduct.Visible = true;
            pnlAddProduct.Visible = true;

            btnUpdateProduct.Visible = false;
            dGridView.Visible = false;
            cellClickAllowed = false;
        }
        private void btnGnrlAdd_Click(object sender, EventArgs e)
        {
            tidyFormForAdding();

            bringCategories();
        }

        void bringCategories()
        {
            category = new cCategoryOperations();
            category.sqlQuery = "select categoryName from CATEGORIES";
            category.getCategoryNames();

            fillCBoxCategoryName();
        }

        void fillCBoxCategoryName()
        {
            CBoxCategoryName.Items.Clear();

            for (int i = 0; i < category.dataTable.Rows.Count; i++)
            {
                CBoxCategoryName.Items.Add(category.dataTable.Rows[i]["categoryName"].ToString());
            }
        }

        private void btnGnrlShow_Click(object sender, EventArgs e)
        {
            tidyFormForShowing();

            showAllProducts();
        }

        void tidyFormForShowing()
        {
            dGridView.Visible = true;
            pnlAddProduct.Visible = true;
            CBoxCategoryName.DropDownStyle = ComboBoxStyle.Simple;
            CBoxCategoryName.Items.Clear();

            btnAddProduct.Visible = false;
            btnUpdateProduct.Visible = false;

            cellClickAllowed = true;
        }

        void showAllProducts()
        {
            getData = new cGetDataFromSql();
            getData.sqlQuery = "select categoryName as 'Category', productName as 'Product', Explanation, "
            + "case when productStatus = 1 then 'Available' else 'Absent' end as 'Status', Price "
            + "from PRODUCTS inner join CATEGORIES on PRODUCTS.categoryID = CATEGORIES.categoryID";
            getData.GetDataFromSql();
            dGridView.DataSource = getData.dataTable;
        }

        private void btnGnrlUpdate_Click(object sender, EventArgs e)
        {
            tidyFormForUpdating();

            showAllProducts();
        }

        void tidyFormForUpdating()
        {
            CBoxCategoryName.Items.Clear();
            CBoxCategoryName.DropDownStyle = ComboBoxStyle.Simple;
            btnAddProduct.Visible = false;

            btnUpdateProduct.Visible = true;
            pnlAddProduct.Visible = true;
            dGridView.Visible = true;
            cellClickAllowed = true;
        }

        void updateProduct()
        {
            product = new cUpdateProduct();

            product.sqlQuery = "update PRODUCTS set explanation = @content, productStatus = @status, "
            + "price = @price where productName = @product";

            product.productName = TBoxProductName.Text;
            product.content = RTBoxContent.Text;
            product.price = Convert.ToDecimal(TBoxPrice.Text);
            product.status = productStatus;

            product.updateProductInfo();
        }

        private void radioBtnAvailable_Click(object sender, EventArgs e)
        {
            productStatus = true;
        }

        private void radioBtnAbsent_Click(object sender, EventArgs e)
        {
            productStatus = false;
        }

        private void productsForm_Load(object sender, EventArgs e)
        {
            dGridViewSettings();
        }

        void dGridViewSettings()
        {
            dGridView.AllowUserToResizeRows = false;
            dGridView.AllowUserToResizeColumns = false;
            dGridView.ReadOnly = true;
            dGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cellClickAllowed)
            {
                CBoxCategoryName.Items.Clear();
                CBoxCategoryName.Text= dGridView.CurrentRow.Cells["Category"].Value.ToString();
                TBoxProductName.Text = dGridView.CurrentRow.Cells["Product"].Value.ToString();
                RTBoxContent.Text = dGridView.CurrentRow.Cells["Explanation"].Value.ToString();
                TBoxPrice.Text = dGridView.CurrentRow.Cells["Price"].Value.ToString();

                productStatus = false;
                if (dGridView.CurrentRow.Cells["Status"].Value.ToString() == "Available")
                {
                    productStatus = true;
                }
                radioBtnAvailable.Checked = productStatus;
                radioBtnAbsent.Checked = !productStatus;
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            updateProduct();

            showAllProducts();
        }
    }
}
