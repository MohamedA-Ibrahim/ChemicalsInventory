using ChemicalsInventory.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChemicalsInventory.UI
{
    public partial class ChemicalsList : Form
    {
        #region Properties

        List<ItemModel> chemicals = new List<ItemModel>();
        int chemicalId;

        List<CategoryModel> category = new List<CategoryModel>();
        int _categoryId;

        #endregion

        #region Constructor

        public ChemicalsList()
        {
            InitializeComponent();

            //Change the colors of the DataGrid
            StyleDataGrid();

            //Load the data into the datagrid
            LoadChemicalsList();
            LoadCategoryList();
        }

        #endregion

        #region Database Operations

        private void LoadChemicalsList()
        {
            chemicals = SqliteDataAccess.LoadItems();
            dgvChemicals.DataSource = chemicals;
        }

        private void LoadCategoryList()
        {
            category = SqliteDataAccess.LoadCategory();
            cbCategory.DataSource = category;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryId";
        }

        private void AddChemical()
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("تأكد من ادخال البيانات بصورة صحيحة");
                return;
            }

            if (cbCategory.SelectedIndex > -1)
                _categoryId = Convert.ToInt32(cbCategory.SelectedValue.ToString());


            ItemModel chemical = new ItemModel
            {
                ItemName = txtName.Text,
                ItemQuantity = Convert.ToInt32(txtQuantity.Text),
                ItemUnit = cbUnit.SelectedItem.ToString(),
                CategoryId= _categoryId
            };

            SqliteDataAccess.AddItem(chemical);

            MessageBox.Show("تم الاضافة بنجاح");
            txtName.Text = "";
            txtQuantity.Text = "";

            LoadChemicalsList();
        }

        private void UpdateChemical()
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("تأكد من ادخال البيانات بصورة صحيحة");
                return;
            }

            if (cbCategory.SelectedIndex > -1)
                _categoryId = Convert.ToInt32(cbCategory.SelectedValue.ToString());


            ItemModel chemical = new ItemModel
            {
                ItemId = chemicalId,
                ItemName = txtName.Text,
                ItemUnit = cbUnit.SelectedItem.ToString(),
                ItemQuantity = Convert.ToInt32(txtQuantity.Text),
                CategoryId = _categoryId
            };

            SqliteDataAccess.UpdateItem(chemical);

            MessageBox.Show("تم التعديل بنجاح");

            btnEdit.Visible = true;
            btnAddChemical.Visible = true;
            btnCancel.Visible = false;
            btnSave.Visible = false;

            LoadChemicalsList();
        }


        #endregion

        #region Datagrid Methods

        /// <summary>
        /// Change the style of the datagridview
        /// </summary>
        private void StyleDataGrid()
        {
            dgvChemicals.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvChemicals.BorderStyle = BorderStyle.None;
            dgvChemicals.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvChemicals.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            dgvChemicals.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvChemicals.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvChemicals.DefaultCellStyle.SelectionForeColor = Color.Black;

            //Hide the empty column that appears before the first column
            dgvChemicals.RowHeadersVisible = false;

            dgvChemicals.BackgroundColor = Color.FromArgb(238, 239, 249);

            dgvChemicals.EnableHeadersVisualStyles = false;
        }

        #endregion

        #region Form Events

        private void btnAddChemical_Click(object sender, EventArgs e)
        {
            AddChemical();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAddChemical.Visible = false;
            btnSave.Visible = true;
            btnEdit.Visible = false;
            btnCancel.Visible = true;

            if (dgvChemicals.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvChemicals.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvChemicals.Rows[selectedrowindex];

                txtName.Text = Convert.ToString(selectedRow.Cells["ItemName"].Value);
                txtQuantity.Text = Convert.ToString(selectedRow.Cells["ItemQuantity"].Value);
                cbUnit.SelectedIndex = cbUnit.FindStringExact(selectedRow.Cells["ItemUnit"].Value.ToString());
                cbCategory.SelectedIndex = cbCategory.FindStringExact(selectedRow.Cells["CategoryName"].Value.ToString());
                chemicalId = Convert.ToInt32(selectedRow.Cells["ItemId"].Value);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateChemical();

            btnAddChemical.Visible = true;
            btnSave.Visible = false;
            btnEdit.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtQuantity.Clear();
            btnSave.Visible = false;
            btnAddChemical.Visible = true;
            btnEdit.Visible = true;
            btnCancel.Visible = false;
        }

        #endregion

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
