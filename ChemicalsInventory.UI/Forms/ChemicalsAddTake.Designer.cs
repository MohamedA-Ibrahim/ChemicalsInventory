
namespace ChemicalsInventory.UI
{
    partial class ChemicalsAddTake
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonWithdraw = new System.Windows.Forms.RadioButton();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.txtOrderDescription = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbChemicals = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddOrTake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOrder);
            this.groupBox1.Controls.Add(this.btnAddToOrder);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtOrderDescription);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.cbCategory);
            this.groupBox1.Controls.Add(this.cbChemicals);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 338);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AllowUserToResizeColumns = false;
            this.dgvOrder.AllowUserToResizeRows = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemId,
            this.ItemName,
            this.OrderQuantity,
            this.OrderDate,
            this.OrderDescription,
            this.AddOrTake});
            this.dgvOrder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOrder.Location = new System.Drawing.Point(3, 31);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(434, 261);
            this.dgvOrder.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonWithdraw);
            this.groupBox2.Controls.Add(this.radioButtonAdd);
            this.groupBox2.Location = new System.Drawing.Point(681, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(75, 87);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // radioButtonWithdraw
            // 
            this.radioButtonWithdraw.AutoSize = true;
            this.radioButtonWithdraw.Checked = true;
            this.radioButtonWithdraw.Location = new System.Drawing.Point(6, 19);
            this.radioButtonWithdraw.Name = "radioButtonWithdraw";
            this.radioButtonWithdraw.Size = new System.Drawing.Size(60, 20);
            this.radioButtonWithdraw.TabIndex = 0;
            this.radioButtonWithdraw.TabStop = true;
            this.radioButtonWithdraw.Text = "سحب";
            this.radioButtonWithdraw.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(5, 55);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(55, 20);
            this.radioButtonAdd.TabIndex = 1;
            this.radioButtonAdd.Text = "اضافة";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            // 
            // txtOrderDescription
            // 
            this.txtOrderDescription.Location = new System.Drawing.Point(549, 162);
            this.txtOrderDescription.Multiline = true;
            this.txtOrderDescription.Name = "txtOrderDescription";
            this.txtOrderDescription.Size = new System.Drawing.Size(207, 71);
            this.txtOrderDescription.TabIndex = 1;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(651, 111);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(105, 23);
            this.txtQuantity.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(549, 31);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(207, 24);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // cbChemicals
            // 
            this.cbChemicals.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbChemicals.FormattingEnabled = true;
            this.cbChemicals.Location = new System.Drawing.Point(549, 76);
            this.cbChemicals.Name = "cbChemicals";
            this.cbChemicals.Size = new System.Drawing.Size(207, 24);
            this.cbChemicals.TabIndex = 0;
            this.cbChemicals.SelectedIndexChanged += new System.EventHandler(this.cbChemicals_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(791, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "ملاحظات الطلب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(762, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "قم باختيار  المجموعة :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(846, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "الكمية";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(779, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "قم باختيار المركب :";
            // 
            // ItemId
            // 
            this.ItemId.DataPropertyName = "ItemId";
            this.ItemId.HeaderText = "gridItemId";
            this.ItemId.Name = "ItemId";
            this.ItemId.Visible = false;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "اسم المركب";
            this.ItemName.Name = "ItemName";
            // 
            // OrderQuantity
            // 
            this.OrderQuantity.HeaderText = "الكمية المطلوبة";
            this.OrderQuantity.Name = "OrderQuantity";
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "تاريخ الطلب";
            this.OrderDate.Name = "OrderDate";
            // 
            // OrderDescription
            // 
            this.OrderDescription.HeaderText = "تفاصيل الطلب";
            this.OrderDescription.Name = "OrderDescription";
            // 
            // AddOrTake
            // 
            this.AddOrTake.HeaderText = "AddOrTake";
            this.AddOrTake.Name = "AddOrTake";
            this.AddOrTake.Visible = false;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Image = global::ChemicalsInventory.UI.Properties.Resources.diskette;
            this.btnAddToOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddToOrder.Location = new System.Drawing.Point(549, 285);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(75, 42);
            this.btnAddToOrder.TabIndex = 2;
            this.btnAddToOrder.Text = "اضافة";
            this.btnAddToOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::ChemicalsInventory.UI.Properties.Resources.diskette;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(6, 293);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 42);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ChemicalsAddTake
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(901, 338);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChemicalsAddTake";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سحب / اضافة مركب من المخزن";
            this.Load += new System.EventHandler(this.ChemicalsAddTake_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonWithdraw;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cbChemicals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.TextBox txtOrderDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddOrTake;
    }
}