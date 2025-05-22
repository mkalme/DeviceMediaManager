
namespace DeviceMediaManagerGUI {
    partial class SortResultManager {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortResultManager));
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonContainer = new System.Windows.Forms.TableLayoutPanel();
            this.LoadFromFileButton = new CustomDialogs.DarkButton();
            this.CloseButton = new CustomDialogs.DarkButton();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.PathCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalFilesLabel = new System.Windows.Forms.Label();
            this.GlobalContainer.SuspendLayout();
            this.ButtonContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.ButtonContainer, 0, 1);
            this.GlobalContainer.Controls.Add(this.GridView, 0, 0);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(10, 10);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.RowCount = 2;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.Size = new System.Drawing.Size(453, 282);
            this.GlobalContainer.TabIndex = 3;
            // 
            // ButtonContainer
            // 
            this.ButtonContainer.AutoSize = true;
            this.ButtonContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonContainer.ColumnCount = 3;
            this.ButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonContainer.Controls.Add(this.LoadFromFileButton, 1, 0);
            this.ButtonContainer.Controls.Add(this.CloseButton, 0, 0);
            this.ButtonContainer.Controls.Add(this.TotalFilesLabel, 2, 0);
            this.ButtonContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonContainer.Location = new System.Drawing.Point(0, 247);
            this.ButtonContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonContainer.Name = "ButtonContainer";
            this.ButtonContainer.RowCount = 1;
            this.ButtonContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonContainer.Size = new System.Drawing.Size(453, 35);
            this.ButtonContainer.TabIndex = 4;
            // 
            // LoadFromFileButton
            // 
            this.LoadFromFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.LoadFromFileButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.LoadFromFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadFromFileButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LoadFromFileButton.Location = new System.Drawing.Point(85, 10);
            this.LoadFromFileButton.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.LoadFromFileButton.Name = "LoadFromFileButton";
            this.LoadFromFileButton.Size = new System.Drawing.Size(115, 25);
            this.LoadFromFileButton.TabIndex = 3;
            this.LoadFromFileButton.Text = "Load from a file...";
            this.LoadFromFileButton.UseVisualStyleBackColor = false;
            this.LoadFromFileButton.Click += new System.EventHandler(this.LoadFromFileButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseButton.Location = new System.Drawing.Point(0, 10);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 25);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
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
            this.PathCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.GridView.Location = new System.Drawing.Point(0, 0);
            this.GridView.Margin = new System.Windows.Forms.Padding(0);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersVisible = false;
            this.GridView.RowTemplate.Height = 25;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(453, 247);
            this.GridView.TabIndex = 1;
            this.GridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellDoubleClick);
            // 
            // PathCol
            // 
            this.PathCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.PathCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.PathCol.HeaderText = "Paths";
            this.PathCol.Name = "PathCol";
            this.PathCol.ReadOnly = true;
            // 
            // TotalFilesLabel
            // 
            this.TotalFilesLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TotalFilesLabel.AutoSize = true;
            this.TotalFilesLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TotalFilesLabel.Location = new System.Drawing.Point(391, 10);
            this.TotalFilesLabel.Name = "TotalFilesLabel";
            this.TotalFilesLabel.Size = new System.Drawing.Size(59, 15);
            this.TotalFilesLabel.TabIndex = 7;
            this.TotalFilesLabel.Text = "Total files:";
            // 
            // SortResultManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(473, 302);
            this.Controls.Add(this.GlobalContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SortResultManager";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sort result manager";
            this.Load += new System.EventHandler(this.SortResultManager_Load);
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            this.ButtonContainer.ResumeLayout(false);
            this.ButtonContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private CustomDialogs.DarkButton CloseButton;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PathCol;
        private System.Windows.Forms.TableLayoutPanel ButtonContainer;
        private CustomDialogs.DarkButton LoadFromFileButton;
        private System.Windows.Forms.Label TotalFilesLabel;
    }
}