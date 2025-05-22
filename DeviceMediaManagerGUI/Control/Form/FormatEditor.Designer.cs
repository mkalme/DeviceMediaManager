
namespace DeviceMediaManagerGUI {
    partial class FormatEditor {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormatEditor));
            this.FormatTextBox = new CustomDialogs.DarkTextBox();
            this.DoneButton = new CustomDialogs.DarkButton();
            this.FormatLabel = new System.Windows.Forms.Label();
            this.CancelButton = new CustomDialogs.DarkButton();
            this.SkipCharactersUpDown = new System.Windows.Forms.NumericUpDown();
            this.SkipCharactersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SkipCharactersUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // FormatTextBox
            // 
            this.FormatTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FormatTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.FormatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FormatTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormatTextBox.Location = new System.Drawing.Point(102, 8);
            this.FormatTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.FormatTextBox.Name = "FormatTextBox";
            this.FormatTextBox.Padding = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.FormatTextBox.PasswordChar = '\0';
            this.FormatTextBox.ReadOnly = false;
            this.FormatTextBox.Size = new System.Drawing.Size(223, 23);
            this.FormatTextBox.TabIndex = 0;
            this.FormatTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FormatTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormatTextBox.XOffset = 0;
            this.FormatTextBox.YOffset = 0;
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DoneButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DoneButton.Location = new System.Drawing.Point(14, 89);
            this.DoneButton.Margin = new System.Windows.Forms.Padding(0);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 24);
            this.DoneButton.TabIndex = 1;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // FormatLabel
            // 
            this.FormatLabel.AutoSize = true;
            this.FormatLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormatLabel.Location = new System.Drawing.Point(9, 12);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(48, 15);
            this.FormatLabel.TabIndex = 2;
            this.FormatLabel.Text = "Format:";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CancelButton.Location = new System.Drawing.Point(103, 89);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(0);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 24);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SkipCharactersUpDown
            // 
            this.SkipCharactersUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.SkipCharactersUpDown.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SkipCharactersUpDown.Location = new System.Drawing.Point(102, 43);
            this.SkipCharactersUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SkipCharactersUpDown.Name = "SkipCharactersUpDown";
            this.SkipCharactersUpDown.Size = new System.Drawing.Size(78, 23);
            this.SkipCharactersUpDown.TabIndex = 4;
            // 
            // SkipCharactersLabel
            // 
            this.SkipCharactersLabel.AutoSize = true;
            this.SkipCharactersLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SkipCharactersLabel.Location = new System.Drawing.Point(9, 45);
            this.SkipCharactersLabel.Name = "SkipCharactersLabel";
            this.SkipCharactersLabel.Size = new System.Drawing.Size(89, 15);
            this.SkipCharactersLabel.TabIndex = 5;
            this.SkipCharactersLabel.Text = "Skip characters:";
            // 
            // FormatEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(331, 126);
            this.Controls.Add(this.SkipCharactersLabel);
            this.Controls.Add(this.SkipCharactersUpDown);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.FormatLabel);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.FormatTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormatEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Format editor";
            ((System.ComponentModel.ISupportInitialize)(this.SkipCharactersUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDialogs.DarkTextBox FormatTextBox;
        private CustomDialogs.DarkButton DoneButton;
        private System.Windows.Forms.Label FormatLabel;
        private CustomDialogs.DarkButton CancelButton;
        private System.Windows.Forms.NumericUpDown SkipCharactersUpDown;
        private System.Windows.Forms.Label SkipCharactersLabel;
    }
}