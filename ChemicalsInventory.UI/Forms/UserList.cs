using ChemicalsInventory.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace ChemicalsInventory.UI
{
    public partial class UserList : Form
    {
        #region Properties

        List<UserModel> users = new List<UserModel>();
        int userId;

        #endregion

        #region Constructor

        public UserList()
        {
            InitializeComponent();

            //Change the colors of the DataGrid
            StyleDataGrid();

            //Load the data into the datagrid
            LoadUsersList();
        }

        #endregion

        #region Database Operations

        private void LoadUsersList()
        {
            users = SqliteDataAccess.LoadUsers();
            dgvUsers.DataSource = users;
        }

        private void AddUser()
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("تأكد من ادخال البيانات بصورة صحيحة");
                return;
            }

            UserModel user = new UserModel
            {
                UserName = txtName.Text,
                UserPassword = txtPassword.Text
            };

            SqliteDataAccess.AddUser(user);

            MessageBox.Show("تم الاضافة بنجاح");
            txtName.Text = "";
            txtPassword.Text = "";

            LoadUsersList();
        }

        private void UpdateUser()
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("تأكد من ادخال البيانات بصورة صحيحة");
                return;
            }

            UserModel user = new UserModel
            {
                UserId = userId,
                UserName = txtName.Text,
                UserPassword = txtPassword.Text
            };

            SqliteDataAccess.UpdateUser(user);

            MessageBox.Show("تم التعديل بنجاح");

            btnEdit.Visible = true;
            btnAddUser.Visible = true;
            btnCancel.Visible = false;
            btnSave.Visible = false;

            LoadUsersList();
        }


        #endregion

        #region Datagrid Methods

        /// <summary>
        /// Change the style of the datagridview
        /// </summary>
        private void StyleDataGrid()
        {
            dgvUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvUsers.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvUsers.DefaultCellStyle.SelectionForeColor = Color.Black;

            //Hide the empty column that appears before the first column
            dgvUsers.RowHeadersVisible = false;

            dgvUsers.BackgroundColor = Color.FromArgb(238, 239, 249);

            dgvUsers.EnableHeadersVisualStyles = false;
        }

        #endregion

        #region Form Events

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAddUser.Visible = false;
            btnSave.Visible = true;
            btnEdit.Visible = false;
            btnCancel.Visible = true;

            if (dgvUsers.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvUsers.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvUsers.Rows[selectedrowindex];
                
                txtName.Text = Convert.ToString(selectedRow.Cells["UserName"].Value);
                txtPassword.Text = Convert.ToString(selectedRow.Cells["UserPassword"].Value);
                userId = Convert.ToInt32(selectedRow.Cells["UserId"].Value);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateUser();

            btnAddUser.Visible = true;
            btnSave.Visible = false;
            btnEdit.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPassword.Clear();
            btnSave.Visible = false;
            btnAddUser.Visible = true;
            btnEdit.Visible = true;
            btnCancel.Visible = false;
        }

        #endregion
    }
}
