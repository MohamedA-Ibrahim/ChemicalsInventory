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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MenuItemLogout_Click(object sender, EventArgs e)
        {
            //Switch the mainform of the application to Home form
            Program.SetMainForm(new Login());
            Program.ShowMainForm();

            this.Close();
        }

        private void MenuItemChemicalsList_Click(object sender, EventArgs e)
        {
            ChemicalsList chemicalList = new ChemicalsList();
            chemicalList.ShowDialog();
        }

        private void MenuItemUsersList_Click(object sender, EventArgs e)
        {
            UserList userList = new UserList();
            userList.ShowDialog();
        }

        private void MenuItemChemicalsAddTake_Click(object sender, EventArgs e)
        {
            ChemicalsAddTake chemicalsAddTake = new ChemicalsAddTake();
            chemicalsAddTake.ShowDialog();
        }

        private void MenuItemCategoryList_Click(object sender, EventArgs e)
        {
            CategoryList categoryList = new CategoryList();
            categoryList.ShowDialog();
        }
    }
}
