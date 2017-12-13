using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nameless.WinFormsApplication;
using Nameless.WinFormsApplication.CQRS;
using Nameless.WinFormsApplication.Views;

namespace Nameless.Bookshelf.Views.Books {
    public partial class EntryForm : FormBase {
        #region Private Properties

        private ICommandQueryDispatcher CommandQueryDispatcher { get; }

        #endregion

        #region Public Constructors
        public EntryForm(ICommandQueryDispatcher commandQueryDispatcher) {
            Prevent.ParameterNull(commandQueryDispatcher, nameof(commandQueryDispatcher));

            CommandQueryDispatcher = commandQueryDispatcher;

            InitializeComponent();
        }
        #endregion

        #region Private Methods

        private void SetComponentsInitialState() {
            yearNumericUpDown.Value = DateTime.Now.Year;
        }

        private void FillView() {

        }

        private void FillPublishersAutoComplete() {

        }

        private void FillAuthorsAutoComplete() {

        }

        private void FillLanguagesAutoComplete() {

        }

        private bool ValidateView() {
            throw new NotImplementedException();
        }

        private bool SaveBook() {
            throw new NotImplementedException();
        }

        #endregion

        #region Components Event-Handlers
        private void EntryForm_Load(object sender, EventArgs e) {

        }
private void EntryForm_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = DialogResult == DialogResult.Abort;
        }
        private void confirmButton_Click(object sender, EventArgs e) {
            if (!ValidateView()) { DialogResult = DialogResult.Abort; return; }
            if (!SaveBook()) { DialogResult = DialogResult.Abort; return; }
        }

        #endregion

        
    }
}
