
namespace DeviceMediaManagerGUI {
    partial class SortResultSummaryViewer {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortResultSummaryViewer));
            this.LableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.PartialCopiesLink = new System.Windows.Forms.LinkLabel();
            this.NoCopiesLink = new System.Windows.Forms.LinkLabel();
            this.FullCopiesLink = new System.Windows.Forms.LinkLabel();
            this.FullCopiesLabel = new System.Windows.Forms.Label();
            this.PartialCopiesLabel = new System.Windows.Forms.Label();
            this.NoCopiesLabel = new System.Windows.Forms.Label();
            this.GlobalContainer = new System.Windows.Forms.Panel();
            this.CloseButton = new CustomDialogs.DarkButton();
            this.LableContainer.SuspendLayout();
            this.GlobalContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // LableContainer
            // 
            this.LableContainer.AutoSize = true;
            this.LableContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LableContainer.ColumnCount = 2;
            this.LableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LableContainer.Controls.Add(this.PartialCopiesLink, 1, 1);
            this.LableContainer.Controls.Add(this.NoCopiesLink, 1, 2);
            this.LableContainer.Controls.Add(this.FullCopiesLink, 1, 0);
            this.LableContainer.Controls.Add(this.FullCopiesLabel, 0, 0);
            this.LableContainer.Controls.Add(this.PartialCopiesLabel, 0, 1);
            this.LableContainer.Controls.Add(this.NoCopiesLabel, 0, 2);
            this.LableContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.LableContainer.Location = new System.Drawing.Point(0, 0);
            this.LableContainer.Name = "LableContainer";
            this.LableContainer.RowCount = 3;
            this.LableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LableContainer.Size = new System.Drawing.Size(234, 63);
            this.LableContainer.TabIndex = 0;
            // 
            // PartialCopiesLink
            // 
            this.PartialCopiesLink.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.PartialCopiesLink.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PartialCopiesLink.AutoSize = true;
            this.PartialCopiesLink.DisabledLinkColor = System.Drawing.SystemColors.HighlightText;
            this.PartialCopiesLink.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.PartialCopiesLink.Location = new System.Drawing.Point(181, 24);
            this.PartialCopiesLink.Name = "PartialCopiesLink";
            this.PartialCopiesLink.Size = new System.Drawing.Size(50, 15);
            this.PartialCopiesLink.TabIndex = 8;
            this.PartialCopiesLink.TabStop = true;
            this.PartialCopiesLink.Text = "0 copies";
            this.PartialCopiesLink.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.PartialCopiesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PartialCopiesLink_LinkClicked);
            // 
            // NoCopiesLink
            // 
            this.NoCopiesLink.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.NoCopiesLink.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NoCopiesLink.AutoSize = true;
            this.NoCopiesLink.DisabledLinkColor = System.Drawing.SystemColors.HighlightText;
            this.NoCopiesLink.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.NoCopiesLink.Location = new System.Drawing.Point(181, 45);
            this.NoCopiesLink.Name = "NoCopiesLink";
            this.NoCopiesLink.Size = new System.Drawing.Size(50, 15);
            this.NoCopiesLink.TabIndex = 8;
            this.NoCopiesLink.TabStop = true;
            this.NoCopiesLink.Text = "0 copies";
            this.NoCopiesLink.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.NoCopiesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NoCopiesLink_LinkClicked);
            // 
            // FullCopiesLink
            // 
            this.FullCopiesLink.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.FullCopiesLink.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FullCopiesLink.AutoSize = true;
            this.FullCopiesLink.DisabledLinkColor = System.Drawing.SystemColors.HighlightText;
            this.FullCopiesLink.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.FullCopiesLink.Location = new System.Drawing.Point(181, 3);
            this.FullCopiesLink.Name = "FullCopiesLink";
            this.FullCopiesLink.Size = new System.Drawing.Size(50, 15);
            this.FullCopiesLink.TabIndex = 8;
            this.FullCopiesLink.TabStop = true;
            this.FullCopiesLink.Text = "0 copies";
            this.FullCopiesLink.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.FullCopiesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FullCopiesLink_LinkClicked);
            // 
            // FullCopiesLabel
            // 
            this.FullCopiesLabel.AutoSize = true;
            this.FullCopiesLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FullCopiesLabel.Location = new System.Drawing.Point(3, 3);
            this.FullCopiesLabel.Margin = new System.Windows.Forms.Padding(3);
            this.FullCopiesLabel.Name = "FullCopiesLabel";
            this.FullCopiesLabel.Size = new System.Drawing.Size(85, 15);
            this.FullCopiesLabel.TabIndex = 0;
            this.FullCopiesLabel.Text = "Full file copies:";
            // 
            // PartialCopiesLabel
            // 
            this.PartialCopiesLabel.AutoSize = true;
            this.PartialCopiesLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PartialCopiesLabel.Location = new System.Drawing.Point(3, 24);
            this.PartialCopiesLabel.Margin = new System.Windows.Forms.Padding(3);
            this.PartialCopiesLabel.Name = "PartialCopiesLabel";
            this.PartialCopiesLabel.Size = new System.Drawing.Size(99, 15);
            this.PartialCopiesLabel.TabIndex = 1;
            this.PartialCopiesLabel.Text = "Partial file copies:";
            // 
            // NoCopiesLabel
            // 
            this.NoCopiesLabel.AutoSize = true;
            this.NoCopiesLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NoCopiesLabel.Location = new System.Drawing.Point(3, 45);
            this.NoCopiesLabel.Margin = new System.Windows.Forms.Padding(3);
            this.NoCopiesLabel.Name = "NoCopiesLabel";
            this.NoCopiesLabel.Size = new System.Drawing.Size(82, 15);
            this.NoCopiesLabel.TabIndex = 2;
            this.NoCopiesLabel.Text = "No file copies:";
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.Controls.Add(this.LableContainer);
            this.GlobalContainer.Location = new System.Drawing.Point(12, 12);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.Size = new System.Drawing.Size(234, 84);
            this.GlobalContainer.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseButton.Location = new System.Drawing.Point(13, 108);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 25);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SortResultSummaryViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(257, 148);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.GlobalContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SortResultSummaryViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Summary";
            this.LableContainer.ResumeLayout(false);
            this.LableContainer.PerformLayout();
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LableContainer;
        private System.Windows.Forms.Label FullCopiesLabel;
        private System.Windows.Forms.Label PartialCopiesLabel;
        private System.Windows.Forms.Label NoCopiesLabel;
        private System.Windows.Forms.Panel GlobalContainer;
        private CustomDialogs.DarkButton CloseButton;
        private System.Windows.Forms.LinkLabel PartialCopiesLink;
        private System.Windows.Forms.LinkLabel NoCopiesLink;
        private System.Windows.Forms.LinkLabel FullCopiesLink;
    }
}