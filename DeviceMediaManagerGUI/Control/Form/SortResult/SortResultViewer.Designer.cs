
namespace DeviceMediaManagerGUI {
    partial class SortResultViewer {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortResultViewer));
            this.GridView = new System.Windows.Forms.DataGridView();
            this.OriginalFileCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewFileNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectoriesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonContainer = new System.Windows.Forms.TableLayoutPanel();
            this.LabelContainer = new System.Windows.Forms.TableLayoutPanel();
            this.TotalFilesLabel = new System.Windows.Forms.Label();
            this.SortStartedLabel = new System.Windows.Forms.Label();
            this.ExportAsJsonButton = new CustomDialogs.DarkButton();
            this.CloseButton = new CustomDialogs.DarkButton();
            this.SeeSummaryLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.GlobalContainer.SuspendLayout();
            this.ButtonContainer.SuspendLayout();
            this.LabelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OriginalFileCol,
            this.CreationDateCol,
            this.NewFileNameCol,
            this.DirectoriesCol});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.GridView.Location = new System.Drawing.Point(0, 0);
            this.GridView.Margin = new System.Windows.Forms.Padding(0);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersVisible = false;
            this.GridView.RowTemplate.Height = 25;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(780, 395);
            this.GridView.TabIndex = 0;
            this.GridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellDoubleClick);
            // 
            // OriginalFileCol
            // 
            this.OriginalFileCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.OriginalFileCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.OriginalFileCol.HeaderText = "Original file path";
            this.OriginalFileCol.Name = "OriginalFileCol";
            this.OriginalFileCol.ReadOnly = true;
            // 
            // CreationDateCol
            // 
            this.CreationDateCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.CreationDateCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.CreationDateCol.HeaderText = "Extracted creation date";
            this.CreationDateCol.MinimumWidth = 155;
            this.CreationDateCol.Name = "CreationDateCol";
            this.CreationDateCol.ReadOnly = true;
            this.CreationDateCol.Width = 155;
            // 
            // NewFileNameCol
            // 
            this.NewFileNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.NewFileNameCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.NewFileNameCol.HeaderText = "New file name";
            this.NewFileNameCol.MinimumWidth = 120;
            this.NewFileNameCol.Name = "NewFileNameCol";
            this.NewFileNameCol.ReadOnly = true;
            this.NewFileNameCol.Width = 120;
            // 
            // DirectoriesCol
            // 
            this.DirectoriesCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.DirectoriesCol.DefaultCellStyle = dataGridViewCellStyle5;
            this.DirectoriesCol.HeaderText = "Directories";
            this.DirectoriesCol.Name = "DirectoriesCol";
            this.DirectoriesCol.ReadOnly = true;
            this.DirectoriesCol.Width = 87;
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.GridView, 0, 0);
            this.GlobalContainer.Controls.Add(this.ButtonContainer, 0, 1);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(10, 10);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.RowCount = 2;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.Size = new System.Drawing.Size(780, 440);
            this.GlobalContainer.TabIndex = 1;
            // 
            // ButtonContainer
            // 
            this.ButtonContainer.AutoSize = true;
            this.ButtonContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonContainer.ColumnCount = 3;
            this.ButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonContainer.Controls.Add(this.LabelContainer, 2, 0);
            this.ButtonContainer.Controls.Add(this.ExportAsJsonButton, 1, 0);
            this.ButtonContainer.Controls.Add(this.CloseButton, 0, 0);
            this.ButtonContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonContainer.Location = new System.Drawing.Point(0, 395);
            this.ButtonContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonContainer.Name = "ButtonContainer";
            this.ButtonContainer.RowCount = 1;
            this.ButtonContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonContainer.Size = new System.Drawing.Size(780, 45);
            this.ButtonContainer.TabIndex = 1;
            // 
            // LabelContainer
            // 
            this.LabelContainer.AutoSize = true;
            this.LabelContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LabelContainer.ColumnCount = 2;
            this.LabelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LabelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LabelContainer.Controls.Add(this.TotalFilesLabel, 1, 1);
            this.LabelContainer.Controls.Add(this.SortStartedLabel, 1, 0);
            this.LabelContainer.Controls.Add(this.SeeSummaryLink, 0, 0);
            this.LabelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.LabelContainer.Location = new System.Drawing.Point(603, 5);
            this.LabelContainer.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.LabelContainer.Name = "LabelContainer";
            this.LabelContainer.RowCount = 2;
            this.LabelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LabelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LabelContainer.Size = new System.Drawing.Size(177, 35);
            this.LabelContainer.TabIndex = 6;
            // 
            // TotalFilesLabel
            // 
            this.TotalFilesLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TotalFilesLabel.AutoSize = true;
            this.TotalFilesLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TotalFilesLabel.Location = new System.Drawing.Point(115, 18);
            this.TotalFilesLabel.Name = "TotalFilesLabel";
            this.TotalFilesLabel.Size = new System.Drawing.Size(59, 15);
            this.TotalFilesLabel.TabIndex = 6;
            this.TotalFilesLabel.Text = "Total files:";
            // 
            // SortStartedLabel
            // 
            this.SortStartedLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SortStartedLabel.AutoSize = true;
            this.SortStartedLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SortStartedLabel.Location = new System.Drawing.Point(87, 1);
            this.SortStartedLabel.Name = "SortStartedLabel";
            this.SortStartedLabel.Size = new System.Drawing.Size(87, 15);
            this.SortStartedLabel.TabIndex = 5;
            this.SortStartedLabel.Text = "Sorting started:";
            // 
            // ExportAsJsonButton
            // 
            this.ExportAsJsonButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ExportAsJsonButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ExportAsJsonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportAsJsonButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExportAsJsonButton.Location = new System.Drawing.Point(85, 10);
            this.ExportAsJsonButton.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.ExportAsJsonButton.Name = "ExportAsJsonButton";
            this.ExportAsJsonButton.Size = new System.Drawing.Size(117, 25);
            this.ExportAsJsonButton.TabIndex = 2;
            this.ExportAsJsonButton.Text = "Export as json...";
            this.ExportAsJsonButton.UseVisualStyleBackColor = false;
            this.ExportAsJsonButton.Click += new System.EventHandler(this.ExportAsJsonButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseButton.Location = new System.Drawing.Point(0, 10);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 25);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SeeSummaryLink
            // 
            this.SeeSummaryLink.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.SeeSummaryLink.AutoSize = true;
            this.SeeSummaryLink.DisabledLinkColor = System.Drawing.SystemColors.HighlightText;
            this.SeeSummaryLink.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.SeeSummaryLink.Location = new System.Drawing.Point(3, 0);
            this.SeeSummaryLink.Name = "SeeSummaryLink";
            this.SeeSummaryLink.Size = new System.Drawing.Size(78, 15);
            this.SeeSummaryLink.TabIndex = 7;
            this.SeeSummaryLink.TabStop = true;
            this.SeeSummaryLink.Text = "See summary";
            this.SeeSummaryLink.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.SeeSummaryLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SeeSummaryLink_LinkClicked);
            // 
            // SortResultViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GlobalContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SortResultViewer";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sort results";
            this.Load += new System.EventHandler(this.SortResultViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            this.ButtonContainer.ResumeLayout(false);
            this.ButtonContainer.PerformLayout();
            this.LabelContainer.ResumeLayout(false);
            this.LabelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private CustomDialogs.DarkButton CloseButton;
        private System.Windows.Forms.TableLayoutPanel ButtonContainer;
        private CustomDialogs.DarkButton ExportAsJsonButton;
        private System.Windows.Forms.Label SortStartedLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalFileCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewFileNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectoriesCol;
        private System.Windows.Forms.TableLayoutPanel LabelContainer;
        private System.Windows.Forms.Label TotalFilesLabel;
        private System.Windows.Forms.LinkLabel SeeSummaryLink;
    }
}