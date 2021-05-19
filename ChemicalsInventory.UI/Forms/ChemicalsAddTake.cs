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

        List<ChemicalModel> chemicals = new List<ChemicalModel>();
        int chemicalId;

        #endregion

        #region Constructor

        public ChemicalsAddTake()
        {
            InitializeComponent();

            LoadChemicalList();
        }

        #endregion

        #region Database Operations

        private void LoadChemicalList()
        {
            chemicals = SqliteDataAccess.LoadChemicals();
            cbChemicals.DataSource = chemicals;
            cbChemicals.ValueMember = "ChemicalId";
            cbChemicals.DisplayMember = "ChemicalName";
        }


        private void UpdateChemical()
        {
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("تأكد من ادخال البيانات بصورة صحيحة");
                return;
            }

            chemicalId = Convert.ToInt32(cbChemicals.SelectedValue.ToString());
            var selectedchemical = SqliteDataAccess.GetChemicalById(chemicalId);

            ChemicalModel chemical = new ChemicalModel();


            if (radioButtonWithdraw.Checked)
            {
                if (selectedchemical.ChemicalQuantity < Convert.ToInt32(txtQuantity.Text))
                {
                    MessageBox.Show("المخزن لا يحتوي الكمية المطلوبة");
                    return;
                }

                chemical.ChemicalId = chemicalId;
                chemical.ChemicalQuantity = selectedchemical.ChemicalQuantity - Convert.ToInt32(txtQuantity.Text);
            }
            else
            {
                chemical.ChemicalId = chemicalId;
                chemical.ChemicalQuantity = selectedchemical.ChemicalQuantity + Convert.ToInt32(txtQuantity.Text);
            }

            SqliteDataAccess.UpdateChemical(chemical);

            MessageBox.Show("تم التعديل بنجاح");
        }


        #endregion

        #region Form Events


        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateChemical();
        }

        #endregion

        private void cbChemicals_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
