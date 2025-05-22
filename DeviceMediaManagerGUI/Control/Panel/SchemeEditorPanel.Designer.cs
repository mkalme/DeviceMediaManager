
namespace DeviceMediaManagerGUI {
    partial class SchemeEditorPanel {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.FormatCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkipCharactersCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.OutputDirectoryGridView = new System.Windows.Forms.DataGridView();
            this.PathCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonContainer = new System.Windows.Forms.TableLayoutPanel();
            this.MoveDownButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.MoveUpButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.OutputDirectoryButtonContainer = new System.Windows.Forms.TableLayoutPanel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new CustomDialogs.DarkTextBox();
            this.RemoveDirectoryButton = new System.Windows.Forms.Button();
            this.AddDirectoryButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OutputFormatTextBox = new CustomDialogs.DarkTextBox();
            this.OutputFormatLabel = new System.Windows.Forms.Label();
            this.SaveButton = new CustomDialogs.DarkButton();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.GlobalContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputDirectoryGridView)).BeginInit();
            this.ButtonContainer.SuspendLayout();
            this.OutputDirectoryButtonContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToOrderColumns = true;
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
            this.FormatCol,
            this.SkipCharactersCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
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
            this.GridView.ReadOnly = true;
            this.GridView.RowHeadersVisible = false;
            this.GridView.RowTemplate.Height = 25;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(420, 148);
            this.GridView.TabIndex = 0;
            this.GridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellDoubleClick);
            this.GridView.SelectionChanged += new System.EventHandler(this.GridView_SelectionChanged);
            // 
            // FormatCol
            // 
            this.FormatCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.FormatCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.FormatCol.HeaderText = "Format";
            this.FormatCol.Name = "FormatCol";
            this.FormatCol.ReadOnly = true;
            // 
            // SkipCharactersCol
            // 
            this.SkipCharactersCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SkipCharactersCol.HeaderText = "Skip characters";
            this.SkipCharactersCol.Name = "SkipCharactersCol";
            this.SkipCharactersCol.ReadOnly = true;
            this.SkipCharactersCol.Width = 110;
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.OutputDirectoryGridView, 0, 2);
            this.GlobalContainer.Controls.Add(this.GridView, 0, 0);
            this.GlobalContainer.Controls.Add(this.ButtonContainer, 0, 1);
            this.GlobalContainer.Controls.Add(this.OutputDirectoryButtonContainer, 0, 3);
            this.GlobalContainer.Controls.Add(this.tableLayoutPanel1, 0, 4);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(0, 0);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.RowCount = 5;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.GlobalContainer.Size = new System.Drawing.Size(420, 359);
            this.GlobalContainer.TabIndex = 1;
            // 
            // OutputDirectoryGridView
            // 
            this.OutputDirectoryGridView.AllowUserToAddRows = false;
            this.OutputDirectoryGridView.AllowUserToDeleteRows = false;
            this.OutputDirectoryGridView.AllowUserToOrderColumns = true;
            this.OutputDirectoryGridView.AllowUserToResizeRows = false;
            this.OutputDirectoryGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.OutputDirectoryGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputDirectoryGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.OutputDirectoryGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OutputDirectoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.OutputDirectoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutputDirectoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PathCol});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OutputDirectoryGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.OutputDirectoryGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputDirectoryGridView.EnableHeadersVisualStyles = false;
            this.OutputDirectoryGridView.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.OutputDirectoryGridView.Location = new System.Drawing.Point(0, 194);
            this.OutputDirectoryGridView.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.OutputDirectoryGridView.Name = "OutputDirectoryGridView";
            this.OutputDirectoryGridView.ReadOnly = true;
            this.OutputDirectoryGridView.RowHeadersVisible = false;
            this.OutputDirectoryGridView.RowTemplate.Height = 25;
            this.OutputDirectoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OutputDirectoryGridView.Size = new System.Drawing.Size(420, 88);
            this.OutputDirectoryGridView.TabIndex = 3;
            // 
            // PathCol
            // 
            this.PathCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.PathCol.DefaultCellStyle = dataGridViewCellStyle5;
            this.PathCol.HeaderText = "Output directories";
            this.PathCol.Name = "PathCol";
            this.PathCol.ReadOnly = true;
            // 
            // ButtonContainer
            // 
            this.ButtonContainer.AutoSize = true;
            this.ButtonContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonContainer.ColumnCount = 4;
            this.ButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonContainer.Controls.Add(this.MoveDownButton, 1, 0);
            this.ButtonContainer.Controls.Add(this.RemoveButton, 3, 0);
            this.ButtonContainer.Controls.Add(this.MoveUpButton, 0, 0);
            this.ButtonContainer.Controls.Add(this.AddButton, 2, 0);
            this.ButtonContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonContainer.Location = new System.Drawing.Point(297, 153);
            this.ButtonContainer.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ButtonContainer.Name = "ButtonContainer";
            this.ButtonContainer.RowCount = 1;
            this.ButtonContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonContainer.Size = new System.Drawing.Size(123, 31);
            this.ButtonContainer.TabIndex = 1;
            // 
            // MoveDownButton
            // 
            this.MoveDownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MoveDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveDownButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MoveDownButton.Image = global::DeviceMediaManagerGUI.Properties.Resources._16pxMoveDown;
            this.MoveDownButton.Location = new System.Drawing.Point(34, 3);
            this.MoveDownButton.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.MoveDownButton.Name = "MoveDownButton";
            this.MoveDownButton.Size = new System.Drawing.Size(25, 25);
            this.MoveDownButton.TabIndex = 1;
            this.MoveDownButton.UseVisualStyleBackColor = false;
            this.MoveDownButton.Click += new System.EventHandler(this.MoveDownButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RemoveButton.Image = global::DeviceMediaManagerGUI.Properties.Resources._16pxTrash;
            this.RemoveButton.Location = new System.Drawing.Point(98, 3);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(25, 25);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // MoveUpButton
            // 
            this.MoveUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MoveUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveUpButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MoveUpButton.Image = global::DeviceMediaManagerGUI.Properties.Resources._16pxMoveUp;
            this.MoveUpButton.Location = new System.Drawing.Point(3, 3);
            this.MoveUpButton.Name = "MoveUpButton";
            this.MoveUpButton.Size = new System.Drawing.Size(25, 25);
            this.MoveUpButton.TabIndex = 0;
            this.MoveUpButton.UseVisualStyleBackColor = false;
            this.MoveUpButton.Click += new System.EventHandler(this.MoveUpButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.AddButton.Image = global::DeviceMediaManagerGUI.Properties.Resources._16pxAdd;
            this.AddButton.Location = new System.Drawing.Point(67, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(25, 25);
            this.AddButton.TabIndex = 3;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OutputDirectoryButtonContainer
            // 
            this.OutputDirectoryButtonContainer.AutoSize = true;
            this.OutputDirectoryButtonContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OutputDirectoryButtonContainer.ColumnCount = 4;
            this.OutputDirectoryButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.OutputDirectoryButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OutputDirectoryButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.OutputDirectoryButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.OutputDirectoryButtonContainer.Controls.Add(this.NameLabel, 0, 0);
            this.OutputDirectoryButtonContainer.Controls.Add(this.NameTextBox, 1, 0);
            this.OutputDirectoryButtonContainer.Controls.Add(this.RemoveDirectoryButton, 2, 0);
            this.OutputDirectoryButtonContainer.Controls.Add(this.AddDirectoryButton, 2, 0);
            this.OutputDirectoryButtonContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputDirectoryButtonContainer.Location = new System.Drawing.Point(0, 287);
            this.OutputDirectoryButtonContainer.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.OutputDirectoryButtonContainer.Name = "OutputDirectoryButtonContainer";
            this.OutputDirectoryButtonContainer.RowCount = 1;
            this.OutputDirectoryButtonContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OutputDirectoryButtonContainer.Size = new System.Drawing.Size(420, 31);
            this.OutputDirectoryButtonContainer.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameLabel.Location = new System.Drawing.Point(0, 8);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(42, 15);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.Location = new System.Drawing.Point(44, 3);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 10, 0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.ReadOnly = false;
            this.NameTextBox.Size = new System.Drawing.Size(307, 25);
            this.NameTextBox.TabIndex = 5;
            this.NameTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBox.XOffset = 0;
            this.NameTextBox.YOffset = 0;
            // 
            // RemoveDirectoryButton
            // 
            this.RemoveDirectoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RemoveDirectoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveDirectoryButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RemoveDirectoryButton.Image = global::DeviceMediaManagerGUI.Properties.Resources._16pxTrash;
            this.RemoveDirectoryButton.Location = new System.Drawing.Point(395, 3);
            this.RemoveDirectoryButton.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.RemoveDirectoryButton.Name = "RemoveDirectoryButton";
            this.RemoveDirectoryButton.Size = new System.Drawing.Size(25, 25);
            this.RemoveDirectoryButton.TabIndex = 5;
            this.RemoveDirectoryButton.UseVisualStyleBackColor = false;
            this.RemoveDirectoryButton.Click += new System.EventHandler(this.RemoveDirectoryButton_Click);
            // 
            // AddDirectoryButton
            // 
            this.AddDirectoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AddDirectoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDirectoryButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.AddDirectoryButton.Image = global::DeviceMediaManagerGUI.Properties.Resources._16pxAdd;
            this.AddDirectoryButton.Location = new System.Drawing.Point(364, 3);
            this.AddDirectoryButton.Name = "AddDirectoryButton";
            this.AddDirectoryButton.Size = new System.Drawing.Size(25, 25);
            this.AddDirectoryButton.TabIndex = 4;
            this.AddDirectoryButton.UseVisualStyleBackColor = false;
            this.AddDirectoryButton.Click += new System.EventHandler(this.AddDirectoryButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.OutputFormatTextBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.OutputFormatLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SaveButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 318);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(420, 41);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // OutputFormatTextBox
            // 
            this.OutputFormatTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OutputFormatTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.OutputFormatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputFormatTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OutputFormatTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.OutputFormatTextBox.Location = new System.Drawing.Point(172, 16);
            this.OutputFormatTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.OutputFormatTextBox.Name = "OutputFormatTextBox";
            this.OutputFormatTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.OutputFormatTextBox.PasswordChar = '\0';
            this.OutputFormatTextBox.ReadOnly = false;
            this.OutputFormatTextBox.Size = new System.Drawing.Size(248, 25);
            this.OutputFormatTextBox.TabIndex = 6;
            this.OutputFormatTextBox.TextBoxBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputFormatTextBox.TextForeColor = System.Drawing.SystemColors.HighlightText;
            this.OutputFormatTextBox.XOffset = 0;
            this.OutputFormatTextBox.YOffset = 0;
            // 
            // OutputFormatLabel
            // 
            this.OutputFormatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OutputFormatLabel.AutoSize = true;
            this.OutputFormatLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.OutputFormatLabel.Location = new System.Drawing.Point(83, 20);
            this.OutputFormatLabel.Margin = new System.Windows.Forms.Padding(8, 0, 2, 6);
            this.OutputFormatLabel.Name = "OutputFormatLabel";
            this.OutputFormatLabel.Size = new System.Drawing.Size(87, 15);
            this.OutputFormatLabel.TabIndex = 5;
            this.OutputFormatLabel.Text = "Output format:";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SaveButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveButton.Image = global::DeviceMediaManagerGUI.Properties.Resources._16pxSave;
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.Location = new System.Drawing.Point(0, 15);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Padding = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.SaveButton.Size = new System.Drawing.Size(75, 24);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SchemeEditorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.GlobalContainer);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SchemeEditorPanel";
            this.Size = new System.Drawing.Size(420, 359);
            this.Load += new System.EventHandler(this.SchemeEditorPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputDirectoryGridView)).EndInit();
            this.ButtonContainer.ResumeLayout(false);
            this.OutputDirectoryButtonContainer.ResumeLayout(false);
            this.OutputDirectoryButtonContainer.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private System.Windows.Forms.TableLayoutPanel ButtonContainer;
        private System.Windows.Forms.Button MoveUpButton;
        private System.Windows.Forms.Button MoveDownButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormatCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkipCharactersCol;
        private System.Windows.Forms.Label NameLabel;
        private CustomDialogs.DarkTextBox NameTextBox;
        private CustomDialogs.DarkButton SaveButton;
        private System.Windows.Forms.DataGridView OutputDirectoryGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PathCol;
        private System.Windows.Forms.TableLayoutPanel OutputDirectoryButtonContainer;
        private System.Windows.Forms.Button RemoveDirectoryButton;
        private System.Windows.Forms.Button AddDirectoryButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomDialogs.DarkTextBox OutputFormatTextBox;
        private System.Windows.Forms.Label OutputFormatLabel;
    }
}
