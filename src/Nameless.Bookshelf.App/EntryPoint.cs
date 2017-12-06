using System;
using System.Windows.Forms;
using Nameless.Bookshelf.Views;

namespace Nameless.Bookshelf {

    internal static class EntryPoint {

        #region Internal Static Methods

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        internal static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        #endregion Internal Static Methods
    }
}