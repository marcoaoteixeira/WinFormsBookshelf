using System;
using System.Linq;
using System.Windows.Forms;
using Nameless.Bookshelf.Commands;
using Nameless.Bookshelf.Dto;
using Nameless.Bookshelf.Queries;
using Nameless.WinFormsApplication;
using Nameless.WinFormsApplication.CQRS;
using Nameless.WinFormsApplication.Views;

namespace Nameless.Bookshelf.Views.Languages {

    public partial class EntryForm : FormBase {

        #region Private Properties

        private ICommandQueryDispatcher CommandQueryDispatcher { get; }

        #endregion Private Properties

        #region Public Constructors

        public EntryForm(ICommandQueryDispatcher commandQueryDispatcher) {
            Prevent.ParameterNull(commandQueryDispatcher, nameof(commandQueryDispatcher));

            CommandQueryDispatcher = commandQueryDispatcher;

            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Methods

        private void SetComponentsInitialState() {
            mainDataGridView.AutoGenerateColumns = false;
        }

        private void FillMainDataGridView() {
            var Languages = CommandQueryDispatcher.Query(new ListLanguagesQuery());

            mainDataGridView.DataSource = Languages.ToList();
        }

        private bool ValidateView() {
            if (string.IsNullOrWhiteSpace(languageDescriptionTextBox.Text)) {
                DisplayAlertMessage("O campo Descrição é obrigatório.");
                return false;
            }

            return true;
        }

        private void SaveLanguage(LanguageDto language) {
            ExecuteWithWaitCursor(() => {
                CommandQueryDispatcher.Command(new SaveLanguageCommand {
                    ID = language.ID,
                    Description = language.Description
                });
                FillMainDataGridView();
            });
        }

        private void DeleteLanguage(LanguageDto language) {
            if (DisplayConfirmMessage($"Deseja realmente remover a língua \"{language.Description}\"?") == DialogResult.Yes) {
                ExecuteWithWaitCursor(() => {
                    CommandQueryDispatcher.Command(new DeleteLanguageCommand {
                        ID = language.ID
                    });
                    FillMainDataGridView();
                });
            }
        }

        #endregion Private Methods

        #region Components Event-Handlers

        private void EntryForm_Load(object sender, EventArgs e) {
            SetComponentsInitialState();
            FillMainDataGridView();
        }

        private void addLanguageButton_Click(object sender, EventArgs e) {
            if (!ValidateView()) { return; }
            SaveLanguage(new LanguageDto {
                Description = languageDescriptionTextBox.Text
            });
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e) {
            var row = mainDataGridView.SelectedRows.OfType<DataGridViewRow>().SingleOrDefault();
            if (row == null) { return; }

            var language = row.DataBoundItem as LanguageDto;
            if (language == null) { return; }

            DeleteLanguage(language);
        }

        private void mainDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            var dataGridView = sender as DataGridView;
            if (dataGridView == null) { return; }
            
            if (DisplayQuestionMessage("Deseja salvar as alterações?") == DialogResult.No) { return; }

            var row = dataGridView.Rows[e.RowIndex];
            var language = (row.DataBoundItem as LanguageDto) ?? new LanguageDto {
                ID = Guid.NewGuid(),
                Description = (string)row.Cells[e.ColumnIndex].Value
            };
            if (string.IsNullOrWhiteSpace(language.Description)) {
                DisplayAlertMessage("A descrição da linguagem não pode ficar em branco.");
                return;
            }
            SaveLanguage(language);
        }

        private void mainDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            var dataGridView = sender as DataGridView;
            if (dataGridView == null) { return; }
            if (e.Button != MouseButtons.Right) { return; }

            mainContextMenuStrip.Show(dataGridView, e.Location);
        }

        private void closeButton_Click(object sender, EventArgs e) {
            Close();
        }

        #endregion Components Event-Handlers
    }
}