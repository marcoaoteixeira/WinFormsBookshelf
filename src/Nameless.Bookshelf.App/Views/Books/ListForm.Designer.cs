namespace Nameless.Bookshelf.Views.Books {
    partial class ListForm {
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
            this.filterPanel = new System.Windows.Forms.Panel();
            this.searchForButton = new System.Windows.Forms.Button();
            this.searchForTextBox = new System.Windows.Forms.TextBox();
            this.searchForLabel = new System.Windows.Forms.Label();
            this.separatorLabel = new System.Windows.Forms.Label();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.mainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.removeBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookButton = new System.Windows.Forms.Button();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.contentPanel.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.resultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.mainContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Image = global::Nameless.Bookshelf.Properties.Resources.book_64x64;
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // titleLabel
            // 
            this.titleLabel.Text = "Catálogo de Livros";
            // 
            // subTitleLabel
            // 
            this.subTitleLabel.Text = "Lista todos os livros presentes na estante virtual";
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.resultPanel);
            this.contentPanel.Controls.Add(this.separatorLabel);
            this.contentPanel.Controls.Add(this.filterPanel);
            this.contentPanel.Padding = new System.Windows.Forms.Padding(0);
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.addBookButton);
            this.actionPanel.Controls.SetChildIndex(this.closeButton, 0);
            this.actionPanel.Controls.SetChildIndex(this.addBookButton, 0);
            // 
            // closeButton
            // 
            this.closeButton.TabIndex = 4;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.searchForButton);
            this.filterPanel.Controls.Add(this.searchForTextBox);
            this.filterPanel.Controls.Add(this.searchForLabel);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Margin = new System.Windows.Forms.Padding(0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Padding = new System.Windows.Forms.Padding(10);
            this.filterPanel.Size = new System.Drawing.Size(784, 72);
            this.filterPanel.TabIndex = 0;
            // 
            // searchForButton
            // 
            this.searchForButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchForButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchForButton.Image = global::Nameless.Bookshelf.Properties.Resources.search_20x20;
            this.searchForButton.Location = new System.Drawing.Point(732, 20);
            this.searchForButton.Name = "searchForButton";
            this.searchForButton.Size = new System.Drawing.Size(32, 32);
            this.searchForButton.TabIndex = 1;
            this.searchForButton.UseVisualStyleBackColor = true;
            this.searchForButton.Click += new System.EventHandler(this.searchForButton_Click);
            // 
            // searchForTextBox
            // 
            this.searchForTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchForTextBox.Location = new System.Drawing.Point(117, 22);
            this.searchForTextBox.Name = "searchForTextBox";
            this.searchForTextBox.Size = new System.Drawing.Size(609, 29);
            this.searchForTextBox.TabIndex = 0;
            // 
            // searchForLabel
            // 
            this.searchForLabel.AutoSize = true;
            this.searchForLabel.Location = new System.Drawing.Point(13, 25);
            this.searchForLabel.Name = "searchForLabel";
            this.searchForLabel.Size = new System.Drawing.Size(98, 21);
            this.searchForLabel.TabIndex = 0;
            this.searchForLabel.Text = "Procurar por";
            // 
            // separatorLabel
            // 
            this.separatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separatorLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.separatorLabel.Location = new System.Drawing.Point(0, 72);
            this.separatorLabel.Margin = new System.Windows.Forms.Padding(0);
            this.separatorLabel.Name = "separatorLabel";
            this.separatorLabel.Size = new System.Drawing.Size(784, 2);
            this.separatorLabel.TabIndex = 1;
            // 
            // resultPanel
            // 
            this.resultPanel.Controls.Add(this.mainDataGridView);
            this.resultPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultPanel.Location = new System.Drawing.Point(0, 74);
            this.resultPanel.Margin = new System.Windows.Forms.Padding(0);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Padding = new System.Windows.Forms.Padding(10);
            this.resultPanel.Size = new System.Drawing.Size(784, 307);
            this.resultPanel.TabIndex = 0;
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.AllowUserToAddRows = false;
            this.mainDataGridView.AllowUserToDeleteRows = false;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDataGridView.Location = new System.Drawing.Point(10, 10);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.RowTemplate.Height = 30;
            this.mainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainDataGridView.Size = new System.Drawing.Size(764, 287);
            this.mainDataGridView.TabIndex = 2;
            this.mainDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mainDataGridView_ColumnHeaderMouseClick);
            this.mainDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainDataGridView_MouseClick);
            // 
            // mainContextMenuStrip
            // 
            this.mainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editBookToolStripMenuItem,
            this.firstToolStripSeparator,
            this.removeBookToolStripMenuItem});
            this.mainContextMenuStrip.Name = "mainContextMenuStrip";
            this.mainContextMenuStrip.Size = new System.Drawing.Size(122, 54);
            // 
            // editBookToolStripMenuItem
            // 
            this.editBookToolStripMenuItem.Name = "editBookToolStripMenuItem";
            this.editBookToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.editBookToolStripMenuItem.Text = "&Editar";
            this.editBookToolStripMenuItem.Click += new System.EventHandler(this.editBookToolStripMenuItem_Click);
            // 
            // firstToolStripSeparator
            // 
            this.firstToolStripSeparator.Name = "firstToolStripSeparator";
            this.firstToolStripSeparator.Size = new System.Drawing.Size(118, 6);
            // 
            // removeBookToolStripMenuItem
            // 
            this.removeBookToolStripMenuItem.Name = "removeBookToolStripMenuItem";
            this.removeBookToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.removeBookToolStripMenuItem.Text = "&Remover";
            this.removeBookToolStripMenuItem.Click += new System.EventHandler(this.removeBookToolStripMenuItem_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBookButton.Location = new System.Drawing.Point(23, 20);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(180, 40);
            this.addBookButton.TabIndex = 3;
            this.addBookButton.Text = "&Adicionar novo livro";
            this.addBookButton.UseVisualStyleBackColor = true;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "ListForm";
            this.Text = "Catálogo de Livros";
            this.Load += new System.EventHandler(this.ListForm_Load);
            this.Controls.SetChildIndex(this.titlePanel, 0);
            this.Controls.SetChildIndex(this.topSeparator, 0);
            this.Controls.SetChildIndex(this.actionPanel, 0);
            this.Controls.SetChildIndex(this.bottomSeparator, 0);
            this.Controls.SetChildIndex(this.contentPanel, 0);
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.contentPanel.ResumeLayout(false);
            this.actionPanel.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.resultPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.mainContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label separatorLabel;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Button searchForButton;
        private System.Windows.Forms.TextBox searchForTextBox;
        private System.Windows.Forms.Label searchForLabel;
        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.ContextMenuStrip mainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator firstToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem removeBookToolStripMenuItem;
        private System.Windows.Forms.Button addBookButton;
    }
}