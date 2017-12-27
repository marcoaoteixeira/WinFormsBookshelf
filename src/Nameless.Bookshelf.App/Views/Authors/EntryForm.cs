using System;
using System.Linq;
using System.Windows.Forms;
using Nameless.Bookshelf.Commands;
using Nameless.Bookshelf.Dto;
using Nameless.Bookshelf.Queries;
using Nameless.WinFormsApplication;
using Nameless.WinFormsApplication.CQRS;
using Nameless.WinFormsApplication.Views;

namespace Nameless.Bookshelf.Views.Authors {

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
            var authors = CommandQueryDispatcher.Query(new ListAuthorsQuery());

            mainDataGridView.DataSource = authors.ToList();
        }

        private bool ValidateView() {
            if (string.IsNullOrWhiteSpace(authorNameTextBox.Text)) {
                DisplayAlertMessage("O campo Nome é obrigatório.");
                return false;
            }

            return true;
        }

        private void SaveAuthor(AuthorDto author) {
            ExecuteWithWaitCursor(() => {
                CommandQueryDispatcher.Command(new SaveAuthorCommand {
                    ID = author.ID,
                    Name = author.Name
                });
                FillMainDataGridView();
            });
        }

        private void DeleteAuthor(AuthorDto author) {
            if (DisplayConfirmMessage($"Deseja realmente remover o autor \"{author.Name}\"?") == DialogResult.Yes) {
                ExecuteWithWaitCursor(() => {
                    CommandQueryDispatcher.Command(new DeleteAuthorCommand {
                        ID = author.ID
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

        private void addAuthorButton_Click(object sender, EventArgs e) {
            if (!ValidateView()) { return; }
            SaveAuthor(new AuthorDto {
                Name = authorNameTextBox.Text
            });
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e) {
            var row = mainDataGridView.SelectedRows.OfType<DataGridViewRow>().SingleOrDefault();
            if (row == null) { return; }

            var author = row.DataBoundItem as AuthorDto;
            if (author == null) { return; }

            DeleteAuthor(author);
        }

        private void mainDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            var dataGridView = sender as DataGridView;
            if (dataGridView == null) { return; }
            
            if (DisplayQuestionMessage("Deseja salvar as alterações?") == DialogResult.No) { return; }

            var row = dataGridView.Rows[e.RowIndex];
            var author = (row.DataBoundItem as AuthorDto) ?? new AuthorDto {
                ID = Guid.NewGuid(),
                Name = (string)row.Cells[e.ColumnIndex].Value
            };
            if (string.IsNullOrWhiteSpace(author.Name)) {
                DisplayAlertMessage("O nome do autor não poder ficar em branco.");
                return;
            }
            SaveAuthor(author);
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