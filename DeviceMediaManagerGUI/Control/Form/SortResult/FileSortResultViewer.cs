using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CustomDialogs;
using DeviceMediaManager;

namespace DeviceMediaManagerGUI {
    public partial class FileSortResultViewer : Form {
        public IList<FileCopyResult> Results { get; set; }

        public FileSortResultViewer(IList<FileCopyResult> results) {
            InitializeComponent();

            Results = results;

            GridView.SetDoubleBuffering();
            new DataGridViewSelection(GridView);

            LoadDialog();
        }

        private void FileSortResultViewer_Load(object sender, EventArgs e) {
            GridView.ClearSelection();
        }
        private void LoadDialog() {
            GridView.Rows.Clear();

            for (int i = 0; i < Results.Count; i++) {
                FileCopyResult result = Results[i];

                GridView.Rows.Add(result.OutputPath, result.CopyResult);
                GridView.Rows[i].Tag = result;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
