
namespace DeviceMediaManagerGUI {
    partial class SchemePanel {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.OutputDirectoryLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GlobalContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.AutoSize = true;
            this.GlobalContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.OutputDirectoryLabel, 0, 1);
            this.GlobalContainer.Controls.Add(this.NameLabel, 0, 0);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.GlobalContainer.Location = new System.Drawing.Point(0, 0);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.RowCount = 2;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Size = new System.Drawing.Size(228, 45);
            this.GlobalContainer.TabIndex = 0;
            // 
            // OutputDirectoryLabel
            // 
            this.OutputDirectoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OutputDirectoryLabel.AutoSize = true;
            this.OutputDirectoryLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputDirectoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.OutputDirectoryLabel.Location = new System.Drawing.Point(5, 27);
            this.OutputDirectoryLabel.Margin = new System.Windows.Forms.Padding(5, 2, 3, 5);
            this.OutputDirectoryLabel.Name = "OutputDirectoryLabel";
            this.OutputDirectoryLabel.Size = new System.Drawing.Size(97, 13);
            this.OutputDirectoryLabel.TabIndex = 1;
            this.OutputDirectoryLabel.Text = "Output dirtectory";
            this.OutputDirectoryLabel.UseMnemonic = false;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameLabel.Location = new System.Drawing.Point(3, 5);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            this.NameLabel.UseMnemonic = false;
            // 
            // SchemePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.GlobalContainer);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SchemePanel";
            this.Size = new System.Drawing.Size(228, 47);
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private System.Windows.Forms.Label OutputDirectoryLabel;
        private System.Windows.Forms.Label NameLabel;
    }
}
