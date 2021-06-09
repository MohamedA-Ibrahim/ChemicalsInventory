using ChemicalsInventory.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChemicalsInventory
{
    public partial class CategoryList : Form
    {

        #region Properties

        List<CategoryModel> category = new List<CategoryModel>();
        int catId;

        #endregion

        #region Constructor

        public CategoryList()
        {
            InitializeComponent();

            //Change the colors of the DataGrid
            StyleDataGrid();

            //Load the data into the datagrid
            LoadCategoryList();
        }

        #endregion

        #region Database Operations

        private void LoadCategoryList()
        {
            category = SqliteDataAccess.LoadCategory();
            dgvCategory.DataSource = category;
        }

        private void AddCategory()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("تأكد من ادخال البيانات بصورة صحيحة");
                return;
            }

            CategoryModel categoryModel = new CategoryModel
            {
                CategoryName = txtName.Text
            };

            SqliteDataAccess.AddCategory(categoryModel);

            MessageBox.Show("تم الاضافة بنجاح");
            txtName.Text = "";

            LoadCategoryList();
        }

        private void UpdateCategory()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("تأكد من ادخال البيانات بصورة صحيحة");
                return;
            }

            CategoryModel categoryModel = new CategoryModel
            {
                CategoryId = catId,
                CategoryName = txtName.Text
            };

            SqliteDataAccess.UpdateCategory(categoryModel);

            MessageBox.Show("تم التعديل بنجاح");

            btnEdit.Visible = true;
            btnAdd.Visible = true;
            btnCancel.Visible = false;
            btnSave.Visible = false;

            LoadCategoryList();
        }


        #endregion

        #region Datagrid Methods

        /// <summary>
        /// Change the style of the datagridview
        /// </summary>
        private void StyleDataGrid()
        {
            dgvCategory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvCategory.BorderStyle = BorderStyle.None;
            dgvCategory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvCategory.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            dgvCategory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvCategory.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvCategory.DefaultCellStyle.SelectionForeColor = Color.Black;

            //Hide the empty column that appears before the first column
            dgvCategory.RowHeadersVisible = false;

            dgvCategory.BackgroundColor = Color.FromArgb(238, 239, 249);

            dgvCategory.EnableHeadersVisualStyles = false;
        }

        #endregion

        #region Form Events


        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            btnSave.Visible = true;
            btnEdit.Visible = false;
            btnCancel.Visible = true;

            if (dgvCategory.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvCategory.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvCategory.Rows[selectedrowindex];

                txtName.Text = Convert.ToString(selectedRow.Cells["CategoryName"].Value);
                catId = Convert.ToInt32(selectedRow.Cells["CategoryId"].Value);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateCategory();

            btnAdd.Visible = true;
            btnSave.Visible = false;
            btnEdit.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            btnSave.Visible = false;
            btnAdd.Visible = true;
            btnEdit.Visible = true;
            btnCancel.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCategory();
        }
        #endregion


    }
}
