
namespace ChemicalsInventory.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemCategoryList = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChemicalsAddTake = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChemicalsList = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUsersList = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPrintReport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Frutiger LT Arabic 55 Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemChemicalsAddTake,
            this.MenuItemChemicalsList,
            this.MenuItemCategoryList,
            this.MenuItemUsersList,
            this.MenuItemPrintReport,
            this.MenuItemLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemCategoryList
            // 
            this.MenuItemCategoryList.Name = "MenuItemCategoryList";
            this.MenuItemCategoryList.Size = new System.Drawing.Size(81, 25);
            this.MenuItemCategoryList.Text = "المجموعات";
            this.MenuItemCategoryList.Click += new System.EventHandler(this.MenuItemCategoryList_Click);
            // 
            // MenuItemChemicalsAddTake
            // 
            this.MenuItemChemicalsAddTake.Image = global::ChemicalsInventory.UI.Properties.Resources.add;
            this.MenuItemChemicalsAddTake.Name = "MenuItemChemicalsAddTake";
            this.MenuItemChemicalsAddTake.Size = new System.Drawing.Size(112, 25);
            this.MenuItemChemicalsAddTake.Text = "سحب / اضافة";
            this.MenuItemChemicalsAddTake.Click += new System.EventHandler(this.MenuItemChemicalsAddTake_Click);
            // 
            // MenuItemChemicalsList
            // 
            this.MenuItemChemicalsList.Image = global::ChemicalsInventory.UI.Properties.Resources.chemicals;
            this.MenuItemChemicalsList.Name = "MenuItemChemicalsList";
            this.MenuItemChemicalsList.Size = new System.Drawing.Size(170, 25);
            this.MenuItemChemicalsList.Text = "قائمة المركبات الكيميائية";
            this.MenuItemChemicalsList.Click += new System.EventHandler(this.MenuItemChemicalsList_Click);
            // 
            // MenuItemUsersList
            // 
            this.MenuItemUsersList.Image = global::ChemicalsInventory.UI.Properties.Resources.man;
            this.MenuItemUsersList.Name = "MenuItemUsersList";
            this.MenuItemUsersList.Size = new System.Drawing.Size(141, 25);
            this.MenuItemUsersList.Text = "قائمة المستخدمين";
            this.MenuItemUsersList.Click += new System.EventHandler(this.MenuItemUsersList_Click);
            // 
            // MenuItemPrintReport
            // 
            this.MenuItemPrintReport.Image = global::ChemicalsInventory.UI.Properties.Resources.business_report__1_;
            this.MenuItemPrintReport.Name = "MenuItemPrintReport";
            this.MenuItemPrintReport.Size = new System.Drawing.Size(131, 25);
            this.MenuItemPrintReport.Text = "تقرير طلبات الجرد";
            // 
            // MenuItemLogout
            // 
            this.MenuItemLogout.Image = global::ChemicalsInventory.UI.Properties.Resources.logout__1_;
            this.MenuItemLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MenuItemLogout.Name = "MenuItemLogout";
            this.MenuItemLogout.Size = new System.Drawing.Size(113, 25);
            this.MenuItemLogout.Text = "تسجيل الخروج";
            this.MenuItemLogout.Click += new System.EventHandler(this.MenuItemLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(792, 603);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Frutiger LT Arabic 55 Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة  مخزن المواد الكيميائية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChemicalsList;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUsersList;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLogout;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChemicalsAddTake;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCategoryList;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPrintReport;
    }
}