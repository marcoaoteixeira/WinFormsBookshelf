using System;
using System.Windows.Forms;

namespace Nameless.Bookshelf.Views {

    public partial class MainForm : Form {

        #region Public Constructors

        public MainForm() {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Methods

        private void SetComponentsInitialState() {
            // Software version label
            softwareVersionToolStripStatusLabel.Text = Internal.SoftwareVersion;
        }

        #endregion

        #region Components Event-Handlers

        private void MainForm_Load(object sender, EventArgs e) {
            SetComponentsInitialState();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void publishersToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void languagesToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        #endregion Components Event-Handlers
    }
}