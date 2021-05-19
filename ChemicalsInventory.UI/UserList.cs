using ChemicalsInventory.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChemicalsInventory.UI
{
    public partial class UserList : Form
    {
        List<UserModel> users = new List<UserModel>();

        public UserList()
        {
            InitializeComponent();

            LoadUsersList();
        }

        private void LoadUsersList()
        {
            users = SqliteDataAccess.LoadUsers();

            WireUpUsersList();
        }

        private void WireUpUsersList()
        {
            listUserListBox.DataSource = null;
            listUserListBox.DataSource = users;
            listUserListBox.DisplayMember = "UserName";
        }
        private void AddUser()
        {
            UserModel user = new UserModel();

            user.UserName = txtName.Text;
            user.UserPassword = txtPassword.Text;

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
        }


        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void listUserListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAddUser.Visible = false;
            btnSave.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateUser();

            btnAddUser.Visible = true;
            btnSave.Visible = false;
            btnEdit.Visible = false;
        }
    }
}
