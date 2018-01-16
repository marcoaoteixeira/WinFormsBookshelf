namespace Nameless.Bookshelf.Views.Books {
    partial class EntryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.confirmButton = new System.Windows.Forms.Button();
            this.bookTitleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.editionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.editionLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.authorAutoCompleteTextBox = new Nameless.WinFormsApplication.Controls.AutoComplete.AutoCompleteTextBox(this.components);
            this.authorsListBox = new System.Windows.Forms.ListBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.languageAutoCompleteTextBox = new Nameless.WinFormsApplication.Controls.AutoComplete.AutoCompleteTextBox(this.components);
            this.languagesListBox = new System.Windows.Forms.ListBox();
            this.publisherAutoCompleteTextBox = new Nameless.WinFormsApplication.Controls.AutoComplete.AutoCompleteTextBox(this.components);
            this.lentCheckBox = new System.Windows.Forms.CheckBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.mainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.contentPanel.SuspendLayout();
            this.actionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            this.mainContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.Size = new System.Drawing.Size(844, 96);
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Image = global::Nameless.Bookshelf.Properties.Resources.book_64x64;
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // titleLabel
            // 
            this.titleLabel.Size = new System.Drawing.Size(748, 56);
            this.titleLabel.Text = "Livro";
            // 
            // subTitleLabel
            // 
            this.subTitleLabel.Size = new System.Drawing.Size(748, 40);
            this.subTitleLabel.Text = "Adição ou edição de um título";
            // 
            // topSeparator
            // 
            this.topSeparator.Size = new System.Drawing.Size(844, 2);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.lentCheckBox);
            this.contentPanel.Controls.Add(this.languagesListBox);
            this.contentPanel.Controls.Add(this.authorsListBox);
            this.contentPanel.Controls.Add(this.languageAutoCompleteTextBox);
            this.contentPanel.Controls.Add(this.publisherAutoCompleteTextBox);
            this.contentPanel.Controls.Add(this.authorAutoCompleteTextBox);
            this.contentPanel.Controls.Add(this.yearNumericUpDown);
            this.contentPanel.Controls.Add(this.editionNumericUpDown);
            this.contentPanel.Controls.Add(this.noteTextBox);
            this.contentPanel.Controls.Add(this.isbnTextBox);
            this.contentPanel.Controls.Add(this.titleTextBox);
            this.contentPanel.Controls.Add(this.yearLabel);
            this.contentPanel.Controls.Add(this.editionLabel);
            this.contentPanel.Controls.Add(this.languageLabel);
            this.contentPanel.Controls.Add(this.authorLabel);
            this.contentPanel.Controls.Add(this.publisherLabel);
            this.contentPanel.Controls.Add(this.noteLabel);
            this.contentPanel.Controls.Add(this.isbnLabel);
            this.contentPanel.Controls.Add(this.bookTitleLabel);
            this.contentPanel.Size = new System.Drawing.Size(844, 471);
            // 
            // bottomSeparator
            // 
            this.bottomSeparator.Location = new System.Drawing.Point(0, 569);
            this.bottomSeparator.Size = new System.Drawing.Size(844, 2);
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.confirmButton);
            this.actionPanel.Location = new System.Drawing.Point(0, 571);
            this.actionPanel.Size = new System.Drawing.Size(844, 80);
            this.actionPanel.Controls.SetChildIndex(this.closeButton, 0);
            this.actionPanel.Controls.SetChildIndex(this.confirmButton, 0);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(704, 20);
            this.closeButton.TabIndex = 12;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmButton.Location = new System.Drawing.Point(23, 20);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(120, 40);
            this.confirmButton.TabIndex = 11;
            this.confirmButton.Text = "&Confirmar";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // bookTitleLabel
            // 
            this.bookTitleLabel.AutoSize = true;
            this.bookTitleLabel.Location = new System.Drawing.Point(13, 10);
            this.bookTitleLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.bookTitleLabel.Name = "bookTitleLabel";
            this.bookTitleLabel.Size = new System.Drawing.Size(49, 21);
            this.bookTitleLabel.TabIndex = 0;
            this.bookTitleLabel.Text = "Título";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(17, 39);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 8, 8);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(400, 29);
            this.titleTextBox.TabIndex = 0;
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Location = new System.Drawing.Point(13, 76);
            this.isbnLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(44, 21);
            this.isbnLabel.TabIndex = 0;
            this.isbnLabel.Text = "ISBN";
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(17, 105);
            this.isbnTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 8, 8);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(400, 29);
            this.isbnTextBox.TabIndex = 1;
            // 
            // editionNumericUpDown
            // 
            this.editionNumericUpDown.Location = new System.Drawing.Point(17, 171);
            this.editionNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 3, 8, 8);
            this.editionNumericUpDown.Name = "editionNumericUpDown";
            this.editionNumericUpDown.Size = new System.Drawing.Size(100, 29);
            this.editionNumericUpDown.TabIndex = 2;
            // 
            // editionLabel
            // 
            this.editionLabel.AutoSize = true;
            this.editionLabel.Location = new System.Drawing.Point(13, 142);
            this.editionLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.editionLabel.Name = "editionLabel";
            this.editionLabel.Size = new System.Drawing.Size(55, 21);
            this.editionLabel.TabIndex = 0;
            this.editionLabel.Text = "Edição";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(124, 142);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(38, 21);
            this.yearLabel.TabIndex = 0;
            this.yearLabel.Text = "Ano";
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.Location = new System.Drawing.Point(128, 171);
            this.yearNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 3, 8, 8);
            this.yearNumericUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(100, 29);
            this.yearNumericUpDown.TabIndex = 3;
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(13, 208);
            this.publisherLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(59, 21);
            this.publisherLabel.TabIndex = 0;
            this.publisherLabel.Text = "Editora";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(424, 10);
            this.authorLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(49, 21);
            this.authorLabel.TabIndex = 0;
            this.authorLabel.Text = "Autor";
            // 
            // authorAutoCompleteTextBox
            // 
            this.authorAutoCompleteTextBox.Location = new System.Drawing.Point(428, 39);
            this.authorAutoCompleteTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 8, 8);
            this.authorAutoCompleteTextBox.Name = "authorAutoCompleteTextBox";
            this.authorAutoCompleteTextBox.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authorAutoCompleteTextBox.PopupOffset = new System.Drawing.Point(12, 0);
            this.authorAutoCompleteTextBox.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.authorAutoCompleteTextBox.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.authorAutoCompleteTextBox.PopupWidth = 300;
            this.authorAutoCompleteTextBox.Size = new System.Drawing.Size(400, 29);
            this.authorAutoCompleteTextBox.TabIndex = 6;
            // 
            // authorsListBox
            // 
            this.authorsListBox.FormattingEnabled = true;
            this.authorsListBox.ItemHeight = 21;
            this.authorsListBox.Location = new System.Drawing.Point(428, 79);
            this.authorsListBox.Margin = new System.Windows.Forms.Padding(3, 3, 8, 8);
            this.authorsListBox.Name = "authorsListBox";
            this.authorsListBox.Size = new System.Drawing.Size(400, 88);
            this.authorsListBox.TabIndex = 7;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(424, 175);
            this.languageLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(57, 21);
            this.languageLabel.TabIndex = 0;
            this.languageLabel.Text = "Língua";
            // 
            // languageAutoCompleteTextBox
            // 
            this.languageAutoCompleteTextBox.Location = new System.Drawing.Point(428, 204);
            this.languageAutoCompleteTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 8, 8);
            this.languageAutoCompleteTextBox.Name = "languageAutoCompleteTextBox";
            this.languageAutoCompleteTextBox.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.languageAutoCompleteTextBox.PopupOffset = new System.Drawing.Point(12, 0);
            this.languageAutoCompleteTextBox.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.languageAutoCompleteTextBox.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.languageAutoCompleteTextBox.PopupWidth = 300;
            this.languageAutoCompleteTextBox.Size = new System.Drawing.Size(400, 29);
            this.languageAutoCompleteTextBox.TabIndex = 8;
            // 
            // languagesListBox
            // 
            this.languagesListBox.FormattingEnabled = true;
            this.languagesListBox.ItemHeight = 21;
            this.languagesListBox.Location = new System.Drawing.Point(428, 244);
            this.languagesListBox.Margin = new System.Windows.Forms.Padding(3, 3, 8, 8);
            this.languagesListBox.Name = "languagesListBox";
            this.languagesListBox.Size = new System.Drawing.Size(400, 88);
            this.languagesListBox.TabIndex = 9;
            // 
            // publisherAutoCompleteTextBox
            // 
            this.publisherAutoCompleteTextBox.Location = new System.Drawing.Point(17, 237);
            this.publisherAutoCompleteTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 8, 8);
            this.publisherAutoCompleteTextBox.Name = "publisherAutoCompleteTextBox";
            this.publisherAutoCompleteTextBox.PopupBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.publisherAutoCompleteTextBox.PopupOffset = new System.Drawing.Point(12, 0);
            this.publisherAutoCompleteTextBox.PopupSelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.publisherAutoCompleteTextBox.PopupSelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.publisherAutoCompleteTextBox.PopupWidth = 300;
            this.publisherAutoCompleteTextBox.Size = new System.Drawing.Size(400, 29);
            this.publisherAutoCompleteTextBox.TabIndex = 4;
            // 
            // lentCheckBox
            // 
            this.lentCheckBox.AutoSize = true;
            this.lentCheckBox.Location = new System.Drawing.Point(17, 277);
            this.lentCheckBox.Margin = new System.Windows.Forms.Padding(3, 3, 8, 8);
            this.lentCheckBox.Name = "lentCheckBox";
            this.lentCheckBox.Size = new System.Drawing.Size(119, 25);
            this.lentCheckBox.TabIndex = 5;
            this.lentCheckBox.Text = "Emprestado?";
            this.lentCheckBox.UseVisualStyleBackColor = true;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(13, 340);
            this.noteLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(92, 21);
            this.noteLabel.TabIndex = 0;
            this.noteLabel.Text = "Observação";
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(17, 369);
            this.noteTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 8, 8);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(811, 90);
            this.noteTextBox.TabIndex = 10;
            // 
            // mainContextMenuStrip
            // 
            this.mainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.mainContextMenuStrip.Name = "mainContextMenuStrip";
            this.mainContextMenuStrip.Size = new System.Drawing.Size(122, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.removeToolStripMenuItem.Text = "Remover";
            // 
            // EntryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(844, 651);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EntryForm";
            this.Text = "Livro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EntryForm_FormClosing);
            this.Load += new System.EventHandler(this.EntryForm_Load);
            this.Controls.SetChildIndex(this.titlePanel, 0);
            this.Controls.SetChildIndex(this.topSeparator, 0);
            this.Controls.SetChildIndex(this.actionPanel, 0);
            this.Controls.SetChildIndex(this.bottomSeparator, 0);
            this.Controls.SetChildIndex(this.contentPanel, 0);
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            this.mainContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.Label bookTitleLabel;
        private System.Windows.Forms.NumericUpDown yearNumericUpDown;
        private System.Windows.Forms.NumericUpDown editionNumericUpDown;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label editionLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.ListBox languagesListBox;
        private System.Windows.Forms.ListBox authorsListBox;
        private WinFormsApplication.Controls.AutoComplete.AutoCompleteTextBox languageAutoCompleteTextBox;
        private WinFormsApplication.Controls.AutoComplete.AutoCompleteTextBox authorAutoCompleteTextBox;
        private System.Windows.Forms.Label languageLabel;
        private WinFormsApplication.Controls.AutoComplete.AutoCompleteTextBox publisherAutoCompleteTextBox;
        private System.Windows.Forms.CheckBox lentCheckBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.ContextMenuStrip mainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}