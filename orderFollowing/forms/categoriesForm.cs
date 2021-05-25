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
    public partial class categoriesForm : Form
    {
        cCategoryOperations category;

        public categoriesForm()
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

        private void categoriesForm_Load(object sender, EventArgs e)
        {
            bringCategories();
        }
        
        void bringCategories()
        {
            category = new cCategoryOperations();
            category.sqlQuery = "select categoryName as 'Category Name' from CATEGORIES";
            category.getCategoryNames();

            fillCBoxCategories();
        }

        void fillCBoxCategories()
        {
            CBoxCategories.Items.Clear();

            for (int i = 0; i < category.dataTable.Rows.Count; i++)
            {
                CBoxCategories.Items.Add(category.dataTable.Rows[i]["Category Name"]);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (isCategoryNameEntered())
            {
                category = new cCategoryOperations();
                category.categoryName = TBoxNewCategoryName.Text;
                category.sqlQuery = "insert into CATEGORIES(categoryName) values (@cName)";
                category.addNewCategory();

                bringCategories();
            }
        }
        private bool isCategoryNameEntered()
        {
            bool status = true;

            if (string.IsNullOrEmpty(TBoxNewCategoryName.Text))
            {
                MessageBox.Show("Please enter new category name!");
                status = false;
            }
            return status;
        }
    }
}
