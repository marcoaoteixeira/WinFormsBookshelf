namespace Nameless.Bookshelf.Views.Authors {
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
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.authorPanel = new System.Windows.Forms.Panel();
            this.authorNameTextBox = new System.Windows.Forms.TextBox();
            this.authorNameLabel = new System.Windows.Forms.Label();
            this.mainDataGridViewPanel = new System.Windows.Forms.Panel();
            this.separator = new System.Windows.Forms.Label();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.contentPanel.SuspendLayout();
            this.actionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.authorPanel.SuspendLayout();
            this.mainDataGridViewPanel.SuspendLayout();
            this.mainContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Image = global::Nameless.Bookshelf.Properties.Resources.author_64x64;
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // titleLabel
            // 
            this.titleLabel.Text = "Autores";
            // 
            // subTitleLabel
            // 
            this.subTitleLabel.Text = "Lista de autores cadastrados";
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.mainDataGridViewPanel);
            this.contentPanel.Controls.Add(this.separator);
            this.contentPanel.Controls.Add(this.authorPanel);
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
            this.nameDataGridViewTextBoxColumn});
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
            // addAuthorButton
            // 
            this.addAuthorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAuthorButton.Image = global::Nameless.Bookshelf.Properties.Resources.add_24x24;
            this.addAuthorButton.Location = new System.Drawing.Point(735, 12);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(36, 36);
            this.addAuthorButton.TabIndex = 1;
            this.addAuthorButton.UseVisualStyleBackColor = true;
            this.addAuthorButton.Click += new System.EventHandler(this.addAuthorButton_Click);
            // 
            // authorPanel
            // 
            this.authorPanel.Controls.Add(this.authorNameTextBox);
            this.authorPanel.Controls.Add(this.authorNameLabel);
            this.authorPanel.Controls.Add(this.addAuthorButton);
            this.authorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.authorPanel.Location = new System.Drawing.Point(0, 0);
            this.authorPanel.Margin = new System.Windows.Forms.Padding(0);
            this.authorPanel.Name = "authorPanel";
            this.authorPanel.Padding = new System.Windows.Forms.Padding(10);
            this.authorPanel.Size = new System.Drawing.Size(784, 60);
            this.authorPanel.TabIndex = 1;
            // 
            // authorNameTextBox
            // 
            this.authorNameTextBox.Location = new System.Drawing.Point(72, 16);
            this.authorNameTextBox.Name = "authorNameTextBox";
            this.authorNameTextBox.Size = new System.Drawing.Size(657, 29);
            this.authorNameTextBox.TabIndex = 0;
            // 
            // authorNameLabel
            // 
            this.authorNameLabel.AutoSize = true;
            this.authorNameLabel.Location = new System.Drawing.Point(13, 20);
            this.authorNameLabel.Name = "authorNameLabel";
            this.authorNameLabel.Size = new System.Drawing.Size(53, 21);
            this.authorNameLabel.TabIndex = 2;
            this.authorNameLabel.Text = "Nome";
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
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
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
            this.Text = "Autores";
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
            this.authorPanel.ResumeLayout(false);
            this.authorPanel.PerformLayout();
            this.mainDataGridViewPanel.ResumeLayout(false);
            this.mainContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.Button addAuthorButton;
        private System.Windows.Forms.Panel mainDataGridViewPanel;
        private System.Windows.Forms.Label separator;
        private System.Windows.Forms.Panel authorPanel;
        private System.Windows.Forms.TextBox authorNameTextBox;
        private System.Windows.Forms.Label authorNameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip mainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}