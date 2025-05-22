using System;
using System.IO;
using System.Windows.Forms;
using CustomDialogs;
using DeviceMediaManager;

namespace DeviceMediaManagerGUI {
    public partial class SortResultViewer : Form {
        public SortResult SortResults { get; set; }

        public SortResultViewer(SortResult sortResults) {
            InitializeComponent();

            SortResults = sortResults;

            GridView.SetDoubleBuffering();
            new DataGridViewSelection(GridView);

            LoadDialog();
        }

        private void SortResultViewer_Load(object sender, EventArgs e) {
            GridView.ClearSelection();
        }
        private void LoadDialog() {
            GridView.Rows.Clear();

            for (int i = 0; i < SortResults.SortResults.Count; i++) {
                FileSortResult result = SortResults.SortResults[i];
                
                GridView.Rows.Add(result.FilePath, result.Date, result.NewFileName, result.CopyResults.Count);
                GridView.Rows[i].Tag = result;
            }

            SortStartedLabel.Text = $"Sorting started: {SortResults.SortStarted}";
            TotalFilesLabel.Text = $"Total files: {SortResults.SortResults.Count}";
        }

        private void GridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;

            FileSortResultViewer viewer = new FileSortResultViewer((GridView.Rows[e.RowIndex].Tag as FileSortResult).CopyResults);
            viewer.ShowDialog();
        }

        private void SeeSummaryLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            SortResultSummaryViewer viewer = new SortResultSummaryViewer(SortResults);
            viewer.ShowDialog();
        }

        private void ExportAsJsonButton_Click(object sender, EventArgs e) {
            InputResult<string> result = CustomDialog.ShowBrowser(BrowseType.SaveFile, "Json files | *.json");
            if (result.DialogClosed) return;

            using (FileStream file = File.Create(result.Value)) {
                new SortResultSerializer().Serialize(SortResults, file);
            }
        }
        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
