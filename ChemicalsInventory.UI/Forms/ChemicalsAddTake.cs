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
    public partial class ChemicalsAddTake : Form
    {
        #region Properties

        List<ItemModel> items;
        int _itemId;

        List<CategoryModel> category = new List<CategoryModel>();
        int _categoryId;

        #endregion

        #region Constructor

        public ChemicalsAddTake()
        {
            InitializeComponent();

            LoadCategoryList();            
        }

        #endregion

        #region Database Operations

        private void LoadItemsList()
        {
            if (cbCategory.SelectedIndex >0)
            {
                _categoryId = Convert.ToInt32(cbCategory.SelectedValue.ToString());

            }
            else
            {
                _categoryId = 1;
            }


            items = SqliteDataAccess.LoadItemsByCategory(_categoryId);
            cbChemicals.DataSource = null;

            cbChemicals.DataSource = items;
            cbChemicals.ValueMember = "ItemId";
            cbChemicals.DisplayMember = "ItemName";
            _itemId = Convert.ToInt32(cbChemicals.SelectedValue.ToString());
        }

        private void LoadCategoryList()
        {
            category = SqliteDataAccess.LoadCategory();
            cbCategory.DataSource = category;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryId";
        }


        private void UpdateItem()
        {

            foreach(DataGridViewRow row in dgvOrder.Rows)
            {
                _itemId = Convert.ToInt32(row.Cells["ItemId"].Value.ToString());

                var selectedchemical = SqliteDataAccess.GetItemById(_itemId);

                ItemModel Item = new ItemModel();

                int addItem = Convert.ToInt32(row.Cells["AddOrTake"].Value.ToString());

                Item.ItemId = _itemId;

                if (addItem ==1)
                {
                    Item.ItemQuantity = selectedchemical.ItemQuantity + Convert.ToInt32(row.Cells["OrderQuantity"].Value.ToString());
                }
                else
                {
                    Item.ItemQuantity = selectedchemical.ItemQuantity - Convert.ToInt32(row.Cells["OrderQuantity"].Value.ToString());
                }

                SqliteDataAccess.UpdateItem(Item);
            }
            MessageBox.Show("تم التعديل بنجاح");
        }


        #endregion

        #region Form Events


        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateItem();
        }

        #endregion

        private void cbChemicals_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadItemsList();
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            AddItemToOrder();
        }

        private void AddItemToOrder()
        {
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("تأكد من ادخال الكمية بصورة صحيحة");
                return;
            }

            if (radioButtonWithdraw.Checked)
            {

                _itemId = Convert.ToInt32(cbChemicals.SelectedValue.ToString());
                var selectedchemical = SqliteDataAccess.GetItemById(_itemId);

                if (selectedchemical.ItemQuantity < Convert.ToInt32(txtQuantity.Text))
                {
                    MessageBox.Show("المخزن لا يحتوي الكمية المطلوبة");
                    return;
                }
            }

            dgvOrder.Rows.Add(_itemId, cbChemicals.Text,txtQuantity.Text,DateTime.Now.ToString("dd/MM/yyyy"), txtOrderDescription.Text,radioButtonAdd.Checked?1:0);
        }

        /// <summary>
        /// Change the style of the datagridview
        /// </summary>
        private void StyleDataGrid()
        {
            dgvOrder.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvOrder.BorderStyle = BorderStyle.None;
            dgvOrder.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvOrder.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            dgvOrder.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvOrder.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvOrder.DefaultCellStyle.SelectionForeColor = Color.Black;

            //Hide the empty column that appears before the first column
            dgvOrder.RowHeadersVisible = false;

            dgvOrder.BackgroundColor = Color.FromArgb(238, 239, 249);

            dgvOrder.EnableHeadersVisualStyles = false;
        }

        private void ChemicalsAddTake_Load(object sender, EventArgs e)
        {
            StyleDataGrid();
        }
    }
}
