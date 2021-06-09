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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = SqliteDataAccess.GetUserByUserName(txtUserName.Text);

            if(user == null)
            {
                MessageBox.Show("المستخدم غير موجود");
                return;
            }

            if(user.UserPassword == txtUserPassword.Text)
            {
                //Switch the mainform of the application to Home form
                Program.SetMainForm(new MainForm());
                Program.ShowMainForm();

                this.Close();
            }
            else
            {
                MessageBox.Show("كلمة المرور خاطئة");
                return;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
