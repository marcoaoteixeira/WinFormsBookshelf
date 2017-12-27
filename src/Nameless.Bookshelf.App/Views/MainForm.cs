using System;
using System.Windows.Forms;
using Nameless.WinFormsApplication;
using Nameless.WinFormsApplication.Views;

namespace Nameless.Bookshelf.Views {

    public partial class MainForm : Form {

        #region Private Properties

        private ViewManager ViewManager { get; }

        #endregion Private Properties

        #region Public Constructors

        public MainForm(ViewManager viewManager) {
            Prevent.ParameterNull(viewManager, nameof(viewManager));

            ViewManager = viewManager;

            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Methods

        private void SetComponentsInitialState() {
            // Software version label
            softwareVersionToolStripStatusLabel.Text = Internal.SoftwareVersion;
        }

        #endregion Private Methods

        #region Components Event-Handlers

        private void MainForm_Load(object sender, EventArgs e) {
            SetComponentsInitialState();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e) {
            ViewManager.Get<Books.ListForm>(
                mdi: this,
                multipleInstance: false
            ).Show();
        }

        private void publishersToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e) {
            ViewManager.Get<Authors.EntryForm>(
                mdi: this,
                multipleInstance: false
            ).Show();
        }

        private void languagesToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        #endregion Components Event-Handlers
    }
}