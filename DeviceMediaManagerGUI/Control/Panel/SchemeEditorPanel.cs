using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CustomDialogs;
using DeviceMediaManager;

namespace DeviceMediaManagerGUI {
    public partial class SchemeEditorPanel : UserControl {
        public Scheme Scheme { get; set; }
        private Scheme _clone;

        private HashSet<string> _directories = new HashSet<string>();

        public ApplicationManager ApplicationManager { get; set; }

        public SchemeEditorPanel(Scheme scheme, ApplicationManager applicationManager) {
            InitializeComponent();

            GridView.SetDoubleBuffering();
            new DataGridViewSelection(GridView);

            OutputDirectoryGridView.SetDoubleBuffering();
            new DataGridViewSelection(OutputDirectoryGridView);

            Scheme = scheme;
            ApplicationManager = applicationManager;

            _clone = Scheme.Clone() as Scheme;
            _directories.UnionWith(Scheme.OutputDirectories);
        }

        private void SchemeEditorPanel_Load(object sender, EventArgs e) {
            LoadDialog();
        }

        //Load Dialog
        private void LoadDialog() {
            LoadGrid();
            LoadDirectoryGrid();

            GridView.ClearSelection();
            OutputDirectoryGridView.ClearSelection();

            NameTextBox.Text = _clone.Name;
            OutputFormatTextBox.Text = _clone.OutputFormat;
        }

        private void LoadGrid() {
            GridView.Rows.Clear();
            for (int i = 0; i < _clone.Formats.Count; i++) {
                Format format = _clone.Formats[i];

                GridView.Rows.Add(format.DateFormat, format.SkipFirstCharacters);
                GridView.Rows[i].Tag = format;
            }

            SetButtonStates();
        }
        private void LoadDirectoryGrid() {
            OutputDirectoryGridView.Rows.Clear();
            foreach (var directory in _directories) {
                OutputDirectoryGridView.Rows.Add(directory);
                OutputDirectoryGridView.Rows[OutputDirectoryGridView.Rows.Count - 1].Tag = directory;
            }
        }

        private void GridView_SelectionChanged(object sender, EventArgs e) {
            SetButtonStates();
        }
        private void GridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;

            EditFormat(GridView.Rows[e.RowIndex].Tag as Format);
        }

        private void SetButtonStates() {
            MoveUpButton.Enabled = GridView.SelectedRows.Count == 1 && GridView.SelectedRows[0].Index > 0;
            MoveDownButton.Enabled = GridView.SelectedRows.Count == 1 && GridView.SelectedRows[0].Index < GridView.RowCount - 1;

            RemoveButton.Enabled = GridView.SelectedRows.Count > 0;
        }

        //Buttons
        private void MoveUpButton_Click(object sender, EventArgs e) {
            Format format = GridView.SelectedRows[0].Tag as Format;
            Format toFormat = GridView.Rows[GridView.SelectedRows[0].Index - 1].Tag as Format;

            Swap(format, toFormat);
            LoadGrid();
        }
        private void MoveDownButton_Click(object sender, EventArgs e) {
            Format format = GridView.SelectedRows[0].Tag as Format;
            Format toFormat = GridView.Rows[GridView.SelectedRows[0].Index + 1].Tag as Format;

            Swap(format, toFormat);
            LoadGrid();
        }

        private void AddButton_Click(object sender, EventArgs e) {
            Format format = new Format() { 
                DateFormat = "",
                SkipFirstCharacters = 0
            };

            _clone.Formats.Add(format);

            LoadGrid();
            EditFormat(format);
        }
        private void RemoveButton_Click(object sender, EventArgs e) {
            string result = CustomDialog.ShowMessage("Remove", "Are you sure you want to remove this?",
                Properties.Resources._64pxTrash, System.Media.SystemSounds.Hand, "Remove", "Cancel");

            if (result == "Remove") {
                _clone.Formats.Remove(GridView.SelectedRows[0].Tag as Format);

                LoadGrid();
            }
        }

        private void AddDirectoryButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog.ShowDialog();
            _directories.Add(FolderBrowserDialog.SelectedPath);

            LoadDirectoryGrid();
        }
        private void RemoveDirectoryButton_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow row in OutputDirectoryGridView.SelectedRows) {
                _directories.Remove((string)row.Tag);
            }

            LoadDirectoryGrid();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            Scheme.Formats = _clone.Formats;
            Scheme.Name = NameTextBox.Text;
            Scheme.OutputDirectories = _directories.ToArray();
            Scheme.OutputFormat = OutputFormatTextBox.Text;

            ApplicationManager.Save();
        }

        //Functions
        private void Swap(Format format, Format toFormat) {
            int index = _clone.Formats.IndexOf(format);
            int toIndex = _clone.Formats.IndexOf(toFormat);

            _clone.Formats[index] = toFormat;
            _clone.Formats[toIndex] = format;
        }
        private void EditFormat(Format format) {
            FormatEditor editor = new FormatEditor(format);
            editor.ShowDialog();

            if (editor.DialogClosed) return;

            LoadGrid();
        }
    }
}
