namespace Nameless.Bookshelf.Views.Languages {
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
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.addLanguageButton = new System.Windows.Forms.Button();
            this.languagePanel = new System.Windows.Forms.Panel();
            this.languageDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.languageDescriptionLabel = new System.Windows.Forms.Label();
            this.mainDataGridViewPanel = new System.Windows.Forms.Panel();
            this.separator = new System.Windows.Forms.Label();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.contentPanel.SuspendLayout();
            this.actionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.languagePanel.SuspendLayout();
            this.mainDataGridViewPanel.SuspendLayout();
            this.mainContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Image = global::Nameless.Bookshelf.Properties.Resources.language_64x64;
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // titleLabel
            // 
            this.titleLabel.Text = "Autores";
            // 
            // subTitleLabel
            // 
            this.subTitleLabel.Text = "Lista de linguagens cadastradas";
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.mainDataGridViewPanel);
            this.contentPanel.Controls.Add(this.separator);
            this.contentPanel.Controls.Add(this.languagePanel);
            this.contentPanel.Padding = new System.Windows.Forms.Padding(0);
            // 
            // closeButton
            // 
            this.closeButton.TabIndex = 3;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.AllowUserToAddRows = false;
            this.mainDataGridView.AllowUserToDeleteRows = false;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn});
            this.mainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDataGridView.Location = new System.Drawing.Point(10, 10);
            this.mainDataGridView.MultiSelect = false;
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.RowTemplate.Height = 30;
            this.mainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainDataGridView.Size = new System.Drawing.Size(764, 299);
            this.mainDataGridView.TabIndex = 2;
            this.mainDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainDataGridView_CellEndEdit);
            this.mainDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mainDataGridView_RowHeaderMouseClick);
            // 
            // addLanguageButton
            // 
            this.addLanguageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addLanguageButton.Image = global::Nameless.Bookshelf.Properties.Resources.add_24x24;
            this.addLanguageButton.Location = new System.Drawing.Point(735, 12);
            this.addLanguageButton.Name = "addLanguageButton";
            this.addLanguageButton.Size = new System.Drawing.Size(36, 36);
            this.addLanguageButton.TabIndex = 1;
            this.addLanguageButton.UseVisualStyleBackColor = true;
            this.addLanguageButton.Click += new System.EventHandler(this.addLanguageButton_Click);
            // 
            // languagePanel
            // 
            this.languagePanel.Controls.Add(this.languageDescriptionTextBox);
            this.languagePanel.Controls.Add(this.languageDescriptionLabel);
            this.languagePanel.Controls.Add(this.addLanguageButton);
            this.languagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.languagePanel.Location = new System.Drawing.Point(0, 0);
            this.languagePanel.Margin = new System.Windows.Forms.Padding(0);
            this.languagePanel.Name = "languagePanel";
            this.languagePanel.Padding = new System.Windows.Forms.Padding(10);
            this.languagePanel.Size = new System.Drawing.Size(784, 60);
            this.languagePanel.TabIndex = 1;
            // 
            // languageNameTextBox
            // 
            this.languageDescriptionTextBox.Location = new System.Drawing.Point(72, 16);
            this.languageDescriptionTextBox.Name = "languageDescriptionTextBox";
            this.languageDescriptionTextBox.Size = new System.Drawing.Size(657, 29);
            this.languageDescriptionTextBox.TabIndex = 0;
            // 
            // languageNameLabel
            // 
            this.languageDescriptionLabel.AutoSize = true;
            this.languageDescriptionLabel.Location = new System.Drawing.Point(13, 20);
            this.languageDescriptionLabel.Name = "languageDescriptionLabel";
            this.languageDescriptionLabel.Size = new System.Drawing.Size(53, 21);
            this.languageDescriptionLabel.TabIndex = 2;
            this.languageDescriptionLabel.Text = "Descrição";
            // 
            // mainDataGridViewPanel
            // 
            this.mainDataGridViewPanel.Controls.Add(this.mainDataGridView);
            this.mainDataGridViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDataGridViewPanel.Location = new System.Drawing.Point(0, 62);
            this.mainDataGridViewPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainDataGridViewPanel.Name = "mainDataGridViewPanel";
            this.mainDataGridViewPanel.Padding = new System.Windows.Forms.Padding(10);
            this.mainDataGridViewPanel.Size = new System.Drawing.Size(784, 319);
            this.mainDataGridViewPanel.TabIndex = 2;
            // 
            // separator
            // 
            this.separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.separator.Location = new System.Drawing.Point(0, 60);
            this.separator.Margin = new System.Windows.Forms.Padding(0);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(784, 2);
            this.separator.TabIndex = 3;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
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
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeToolStripMenuItem.Text = "Remover";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "EntryForm";
            this.Text = "Linguagens";
            this.Load += new System.EventHandler(this.EntryForm_Load);
            this.Controls.SetChildIndex(this.titlePanel, 0);
            this.Controls.SetChildIndex(this.topSeparator, 0);
            this.Controls.SetChildIndex(this.actionPanel, 0);
            this.Controls.SetChildIndex(this.bottomSeparator, 0);
            this.Controls.SetChildIndex(this.contentPanel, 0);
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.contentPanel.ResumeLayout(false);
            this.actionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.languagePanel.ResumeLayout(false);
            this.languagePanel.PerformLayout();
            this.mainDataGridViewPanel.ResumeLayout(false);
            this.mainContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.Button addLanguageButton;
        private System.Windows.Forms.Panel mainDataGridViewPanel;
        private System.Windows.Forms.Label separator;
        private System.Windows.Forms.Panel languagePanel;
        private System.Windows.Forms.TextBox languageDescriptionTextBox;
        private System.Windows.Forms.Label languageDescriptionLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip mainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}