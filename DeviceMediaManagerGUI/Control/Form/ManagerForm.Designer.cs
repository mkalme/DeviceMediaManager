
namespace DeviceMediaManagerGUI {
    partial class ManagerForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.SchemeContainer = new System.Windows.Forms.TableLayoutPanel();
            this.SchemePanelContainer = new System.Windows.Forms.TableLayoutPanel();
            this.SchemeButtonContainer = new System.Windows.Forms.Panel();
            this.RemoveSchemeButton = new CustomDialogs.DarkButton();
            this.AddSchemeButton = new CustomDialogs.DarkButton();
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.BottomButtonPanel = new System.Windows.Forms.Panel();
            this.OpenSortResultManagerButton = new CustomDialogs.DarkButton();
            this.EditLink = new System.Windows.Forms.LinkLabel();
            this.FileAmountLabel = new System.Windows.Forms.Label();
            this.SortMediaButton = new CustomDialogs.DarkButton();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SchemeContainer.SuspendLayout();
            this.SchemePanelContainer.SuspendLayout();
            this.SchemeButtonContainer.SuspendLayout();
            this.GlobalContainer.SuspendLayout();
            this.BottomButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SchemeContainer
            // 
            this.SchemeContainer.ColumnCount = 2;
            this.SchemeContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 342F));
            this.SchemeContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SchemeContainer.Controls.Add(this.SchemePanelContainer, 0, 0);
            this.SchemeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SchemeContainer.Location = new System.Drawing.Point(0, 0);
            this.SchemeContainer.Margin = new System.Windows.Forms.Padding(0);
            this.SchemeContainer.Name = "SchemeContainer";
            this.SchemeContainer.RowCount = 1;
            this.SchemeContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SchemeContainer.Size = new System.Drawing.Size(861, 431);
            this.SchemeContainer.TabIndex = 0;
            // 
            // SchemePanelContainer
            // 
            this.SchemePanelContainer.ColumnCount = 1;
            this.SchemePanelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SchemePanelContainer.Controls.Add(this.SchemeButtonContainer, 0, 1);
            this.SchemePanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SchemePanelContainer.Location = new System.Drawing.Point(0, 0);
            this.SchemePanelContainer.Margin = new System.Windows.Forms.Padding(0);
            this.SchemePanelContainer.Name = "SchemePanelContainer";
            this.SchemePanelContainer.RowCount = 2;
            this.SchemePanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SchemePanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SchemePanelContainer.Size = new System.Drawing.Size(342, 431);
            this.SchemePanelContainer.TabIndex = 0;
            // 
            // SchemeButtonContainer
            // 
            this.SchemeButtonContainer.AutoSize = true;
            this.SchemeButtonContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SchemeButtonContainer.Controls.Add(this.RemoveSchemeButton);
            this.SchemeButtonContainer.Controls.Add(this.AddSchemeButton);
            this.SchemeButtonContainer.Location = new System.Drawing.Point(0, 8);
            this.SchemeButtonContainer.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.SchemeButtonContainer.Name = "SchemeButtonContainer";
            this.SchemeButtonContainer.Size = new System.Drawing.Size(224, 24);
            this.SchemeButtonContainer.TabIndex = 1;
            // 
            // RemoveSchemeButton
            // 
            this.RemoveSchemeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.RemoveSchemeButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.RemoveSchemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSchemeButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveSchemeButton.Image = global::DeviceMediaManagerGUI.Properties.Resources._16pxTrash;
            this.RemoveSchemeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveSchemeButton.Location = new System.Drawing.Point(103, 0);
            this.RemoveSchemeButton.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.RemoveSchemeButton.Name = "RemoveSchemeButton";
            this.RemoveSchemeButton.Size = new System.Drawing.Size(121, 24);
            this.RemoveSchemeButton.TabIndex = 3;
            this.RemoveSchemeButton.Text = "Remove scheme";
            this.RemoveSchemeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveSchemeButton.UseVisualStyleBackColor = true;
            this.RemoveSchemeButton.Click += new System.EventHandler(this.RemoveSchemeButton_Click);
            // 
            // AddSchemeButton
            // 
            this.AddSchemeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.AddSchemeButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.AddSchemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSchemeButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddSchemeButton.Location = new System.Drawing.Point(0, 0);
            this.AddSchemeButton.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.AddSchemeButton.Name = "AddSchemeButton";
            this.AddSchemeButton.Size = new System.Drawing.Size(90, 24);
            this.AddSchemeButton.TabIndex = 2;
            this.AddSchemeButton.Text = "Add scheme";
            this.AddSchemeButton.UseVisualStyleBackColor = true;
            this.AddSchemeButton.Click += new System.EventHandler(this.AddSchemeButton_Click);
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.SchemeContainer, 0, 0);
            this.GlobalContainer.Controls.Add(this.BottomButtonPanel, 0, 1);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(10, 10);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.RowCount = 2;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.Size = new System.Drawing.Size(861, 465);
            this.GlobalContainer.TabIndex = 1;
            // 
            // BottomButtonPanel
            // 
            this.BottomButtonPanel.AutoSize = true;
            this.BottomButtonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BottomButtonPanel.Controls.Add(this.OpenSortResultManagerButton);
            this.BottomButtonPanel.Controls.Add(this.EditLink);
            this.BottomButtonPanel.Controls.Add(this.FileAmountLabel);
            this.BottomButtonPanel.Controls.Add(this.SortMediaButton);
            this.BottomButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomButtonPanel.Location = new System.Drawing.Point(0, 441);
            this.BottomButtonPanel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.BottomButtonPanel.Name = "BottomButtonPanel";
            this.BottomButtonPanel.Size = new System.Drawing.Size(861, 24);
            this.BottomButtonPanel.TabIndex = 1;
            // 
            // OpenSortResultManagerButton
            // 
            this.OpenSortResultManagerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenSortResultManagerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.OpenSortResultManagerButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.OpenSortResultManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenSortResultManagerButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.OpenSortResultManagerButton.Location = new System.Drawing.Point(699, 0);
            this.OpenSortResultManagerButton.Margin = new System.Windows.Forms.Padding(0);
            this.OpenSortResultManagerButton.Name = "OpenSortResultManagerButton";
            this.OpenSortResultManagerButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.OpenSortResultManagerButton.Size = new System.Drawing.Size(162, 24);
            this.OpenSortResultManagerButton.TabIndex = 6;
            this.OpenSortResultManagerButton.Text = "Open sort result manager";
            this.OpenSortResultManagerButton.UseVisualStyleBackColor = true;
            this.OpenSortResultManagerButton.Click += new System.EventHandler(this.OpenSortResultManagerButton_Click);
            // 
            // EditLink
            // 
            this.EditLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.EditLink.AutoSize = true;
            this.EditLink.DisabledLinkColor = System.Drawing.SystemColors.HighlightText;
            this.EditLink.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.EditLink.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.EditLink.Location = new System.Drawing.Point(107, 5);
            this.EditLink.Name = "EditLink";
            this.EditLink.Size = new System.Drawing.Size(27, 15);
            this.EditLink.TabIndex = 5;
            this.EditLink.TabStop = true;
            this.EditLink.Text = "Edit";
            this.EditLink.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.EditLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EditLink_LinkClicked);
            // 
            // FileAmountLabel
            // 
            this.FileAmountLabel.AutoSize = true;
            this.FileAmountLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FileAmountLabel.Location = new System.Drawing.Point(134, 5);
            this.FileAmountLabel.Name = "FileAmountLabel";
            this.FileAmountLabel.Size = new System.Drawing.Size(138, 15);
            this.FileAmountLabel.TabIndex = 4;
            this.FileAmountLabel.Text = "Amount of files selected:";
            // 
            // SortMediaButton
            // 
            this.SortMediaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SortMediaButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SortMediaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortMediaButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SortMediaButton.Image = global::DeviceMediaManagerGUI.Properties.Resources._16pxStartSort;
            this.SortMediaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SortMediaButton.Location = new System.Drawing.Point(0, 0);
            this.SortMediaButton.Margin = new System.Windows.Forms.Padding(0);
            this.SortMediaButton.Name = "SortMediaButton";
            this.SortMediaButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.SortMediaButton.Size = new System.Drawing.Size(90, 24);
            this.SortMediaButton.TabIndex = 3;
            this.SortMediaButton.Text = "Sort media";
            this.SortMediaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SortMediaButton.UseVisualStyleBackColor = true;
            this.SortMediaButton.Click += new System.EventHandler(this.SortMediaButton_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Multiselect = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(881, 485);
            this.Controls.Add(this.GlobalContainer);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device media manager";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.SchemeContainer.ResumeLayout(false);
            this.SchemePanelContainer.ResumeLayout(false);
            this.SchemePanelContainer.PerformLayout();
            this.SchemeButtonContainer.ResumeLayout(false);
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            this.BottomButtonPanel.ResumeLayout(false);
            this.BottomButtonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel SchemeContainer;
        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private CustomDialogs.DarkButton AddSchemeButton;
        private CustomDialogs.DarkButton SortMediaButton;
        private System.Windows.Forms.TableLayoutPanel SchemePanelContainer;
        private System.Windows.Forms.Panel SchemeButtonContainer;
        private CustomDialogs.DarkButton RemoveSchemeButton;
        private System.Windows.Forms.Panel BottomButtonPanel;
        private System.Windows.Forms.LinkLabel EditLink;
        private System.Windows.Forms.Label FileAmountLabel;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private CustomDialogs.DarkButton OpenSortResultManagerButton;
    }
}

