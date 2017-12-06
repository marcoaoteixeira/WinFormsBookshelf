using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Nameless.Bookshelf.Dto;
using Nameless.Bookshelf.Queries;
using Nameless.WinFormsApplication;
using Nameless.WinFormsApplication.CQRS;
using Nameless.WinFormsApplication.Views;

namespace Nameless.Bookshelf.Views.Books {

    public partial class ListForm : FormBase {

        #region Private Read-Only Fields

        private readonly ICommandQueryDispatcher _commandQueryDispatcher;
        private readonly ViewManager _viewManager;

        #endregion Private Read-Only Fields

        #region Public Constructors

        public ListForm(ICommandQueryDispatcher commandQueryDispatcher, ViewManager viewManager) {
            Prevent.ParameterNull(commandQueryDispatcher, nameof(commandQueryDispatcher));
            Prevent.ParameterNull(viewManager, nameof(viewManager));

            _commandQueryDispatcher = commandQueryDispatcher;
            _viewManager = viewManager;

            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Methods

        private void SetComponentsInitialState() {
            mainDataGridView.AutoGenerateColumns = false;
            mainDataGridView.Columns.OfType<DataGridViewColumn>().Each(_ => _.SortMode = DataGridViewColumnSortMode.Programmatic);
        }

        private void FillMainDataGridView(string filter = null) {
            ExecuteWithWaitCursor(() => {
                var datasource = _commandQueryDispatcher
                    .Query(new ListBooksQuery {
                        Title = filter,
                        ISBN = filter,
                        Publisher = filter,
                        Authors = filter,
                        Languages = filter
                    });
                mainDataGridView.DataSource = datasource;
            });
        }

        private void EditBook(BookDto book) {
        }

        private void RemoveBooks(IEnumerable<BookDto> books) {
        }

        #endregion Private Methods

        #region Components Event-Handlers

        private void ListForm_Load(object sender, EventArgs e) {
            SetComponentsInitialState();
            FillMainDataGridView();
        }

        private void searchForButton_Click(object sender, EventArgs e) {
            FillMainDataGridView(searchForTextBox.Text);
        }

        private void mainDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            var dataGridView = sender as DataGridView;
            if (dataGridView == null) { return; }
            if (e.ColumnIndex < 0) { return; }

            ExecuteWithWaitCursor(() => {
                var column = dataGridView.Columns[e.ColumnIndex];
                var columnName = column.DataPropertyName;
                if (dataGridView.Tag == null) {
                    dataGridView.Tag = DataGridViewSortInformation.Create(columnName);
                }

                var sortInfo = dataGridView.Tag as DataGridViewSortInformation;
                if (sortInfo.ColumnName == columnName) {
                    sortInfo.Order = sortInfo.Order == SortOrder.Ascending
                        ? SortOrder.Descending
                        : SortOrder.Ascending;
                }
                sortInfo.ColumnName = columnName;

                var dataSource = dataGridView.DataSource as BookDto[];
                var newDataSource = sortInfo.Order == SortOrder.Ascending
                    ? dataSource.OrderBy(sortInfo.ColumnName)
                    : dataSource.OrderByDescending(sortInfo.ColumnName);

                column.HeaderCell.SortGlyphDirection = sortInfo.Order;
                dataGridView.DataSource = newDataSource.ToArray();
            });
        }

        private void mainDataGridView_MouseClick(object sender, MouseEventArgs e) {
            var dataGridView = sender as DataGridView;
            if (dataGridView == null) { return; }
            if (e.Button == MouseButtons.Right) {
                var hitTestInfo = dataGridView.HitTest(e.X, e.Y);
                if (hitTestInfo.Type == DataGridViewHitTestType.Cell) {
                    mainContextMenuStrip.Show(Cursor.Position);
                }
            }
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e) {
            if (mainDataGridView.SelectedRows.Count > 1) {
                DisplayAlertMessage("Não é possível editar mais de um livro ao mesmo tempo.");
                return;
            }
            EditBook(mainDataGridView.SelectedRows[0].DataBoundItem as BookDto);
        }

        private void removeBookToolStripMenuItem_Click(object sender, EventArgs e) {
            if (mainDataGridView.SelectedRows.Count == 0) {
                DisplayAlertMessage("Selecione ao menos um livro para ser removido.");
                return;
            }
            var books = mainDataGridView
                .SelectedRows.OfType<DataGridViewRow>()
                .Select(_ => _.DataBoundItem as BookDto)
                .ToArray();
            RemoveBooks(books);
        }

        private void closeButton_Click(object sender, EventArgs e) {
            Close();
        }

        #endregion Components Event-Handlers
    }
}