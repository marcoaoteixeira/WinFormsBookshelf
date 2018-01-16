using System;
using System.Linq;
using System.Windows.Forms;
using Nameless.Bookshelf.Commands;
using Nameless.Bookshelf.Dto;
using Nameless.Bookshelf.Queries;
using Nameless.WinFormsApplication;
using Nameless.WinFormsApplication.Controls.AutoComplete.Impl;
using Nameless.WinFormsApplication.CQRS;
using Nameless.WinFormsApplication.Views;

namespace Nameless.Bookshelf.Views.Books {

    public partial class EntryForm : FormBase {

        #region Private Properties

        private ICommandQueryDispatcher CommandQueryDispatcher { get; }

        private BookDto CurrentBook {
            get {
                if (Tag == null) { Tag = new BookDto(); }
                return (BookDto)Tag;
            }
        }

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
            yearNumericUpDown.Value = DateTime.Now.Year;

            authorAutoCompleteTextBox.ItemSelected += (sender, e) => PushAuthorIntoListBox(e.Item);
            authorAutoCompleteTextBox.KeyDown += (sender, e) => {
                if (e.KeyCode == Keys.Enter) { PushAuthorIntoListBox(((TextBox)sender).Text); }
            };
            languageAutoCompleteTextBox.ItemSelected += (sender, e) => PushLanguageIntoListBox(e.Item);
            languageAutoCompleteTextBox.KeyDown += (sender, e) => {
                if (e.KeyCode == Keys.Enter) { PushLanguageIntoListBox(((TextBox)sender).Text); }
            };
        }

        private void PopulateView() {
            FillPublishersAutoComplete();
            FillAuthorsAutoComplete();
            FillLanguagesAutoComplete();

            titleTextBox.Text = CurrentBook.Title;
            isbnTextBox.Text = CurrentBook.ISBN;
            editionNumericUpDown.Value = CurrentBook.Edition;
            yearNumericUpDown.Value = CurrentBook.Year;
            publisherAutoCompleteTextBox.Text = CurrentBook.Publisher;
            publisherAutoCompleteTextBox.SelectedText = CurrentBook.Publisher;
            CurrentBook.Authors.Each(_ => authorsListBox.Items.Add(_));
            CurrentBook.Languages.Each(_ => languagesListBox.Items.Add(_));
            lentCheckBox.Checked = CurrentBook.Lent;
            noteTextBox.Text = CurrentBook.Note;
        }

        private void FillPublishersAutoComplete() {
            publisherAutoCompleteTextBox.Items.Clear();
            var publishers = CommandQueryDispatcher.Query(new ListPublishersQuery());
            publishers.Each(_ => publisherAutoCompleteTextBox.Items.Add(new AutoCompleteEntry(_, new[] { _ })));
        }

        private void FillAuthorsAutoComplete() {
            authorAutoCompleteTextBox.Items.Clear();
            var authors = CommandQueryDispatcher.Query(new ListAuthorsQuery());
            authors.Each(_ => authorAutoCompleteTextBox.Items.Add(new AutoCompleteEntry(_, new[] { _ })));
        }

        private void PushAuthorIntoListBox(string author) {
            if (!authorsListBox.Items.Contains(author)) {
                authorsListBox.Items.Add(author);
            }
        }

        private void FillLanguagesAutoComplete() {
            languageAutoCompleteTextBox.Items.Clear();
            var languages = CommandQueryDispatcher.Query(new ListLanguagesQuery());
            languages.Each(_ => languageAutoCompleteTextBox.Items.Add(new AutoCompleteEntry(_, new[] { _ })));
        }

        private void PushLanguageIntoListBox(string language) {
            if (!languagesListBox.Items.Contains(language)) {
                languagesListBox.Items.Add(language);
            }
        }

        private bool ValidateView() {
            if (string.IsNullOrWhiteSpace(titleTextBox.Text)) {
                DisplayErrorMessage($"O campo {titleLabel.Text} deve ser preenchido.");
                return false;
            }
            return true;
        }

        private bool SaveBook() {
            var result = false;
            ExecuteWithWaitCursor(() => {
                try {
                    CommandQueryDispatcher.Command(new SaveBookCommand {
                        ID = CurrentBook.ID,
                        Title = titleTextBox.Text,
                        ISBN = isbnTextBox.Text,
                        Edition = Convert.ToInt32(editionNumericUpDown.Value),
                        Year = Convert.ToInt32(yearNumericUpDown.Value),
                        Publisher = publisherAutoCompleteTextBox.Text,
                        Authors = authorsListBox.Items.OfType<string>().ToArray(),
                        Languages = languagesListBox.Items.OfType<string>().ToArray(),
                        Note = noteTextBox.Text,
                        Lent = lentCheckBox.Checked
                    });
                    result = true;
                } catch (Exception ex) { DisplayErrorMessage(ex.Message); }
            });
            return result;
        }

        #endregion Private Methods

        #region Components Event-Handlers

        private void EntryForm_Load(object sender, EventArgs e) {
            SetComponentsInitialState();
            PopulateView();
        }

        private void EntryForm_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = DialogResult == DialogResult.Abort;
        }

        private void confirmButton_Click(object sender, EventArgs e) {
            if (!ValidateView()) { DialogResult = DialogResult.Abort; return; }
            if (!SaveBook()) { DialogResult = DialogResult.Abort; return; }
        }

        private void closeButton_Click(object sender, EventArgs e) {
            Close();
        }

        #endregion Components Event-Handlers
    }
}