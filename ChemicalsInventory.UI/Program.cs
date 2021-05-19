using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChemicalsInventory.UI
{
    static class Program
    {
        //Make an Applicationcontext to switch the main form of the application
        static ApplicationContext MainContext = new ApplicationContext();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Set the mainform of the maincontext to the login page
            //MainContext.MainForm = new UserLogin();
            MainContext.MainForm = new Login();
            Application.Run(MainContext);
        }

        /// <summary>
        /// Set the currentmainform of the application that when the user closes it, closes the application
        /// </summary>
        /// <param name="MainForm"></param>
        public static void SetMainForm(Form MainForm)
        {
            MainContext.MainForm = MainForm;
        }

        /// <summary>
        /// Show the MainForm
        /// </summary>
        public static void ShowMainForm()
        {
            MainContext.MainForm.Show();
        }
    }
}
