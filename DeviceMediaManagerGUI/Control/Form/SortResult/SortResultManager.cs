using System;
using System.Windows.Forms;
using System.IO;
using CustomDialogs;
using DeviceMediaManager;

namespace DeviceMediaManagerGUI {
    public partial class SortResultManager : Form {
        public string Directory { get; set; }

        public SortResultManager(string directory) {
            InitializeComponent();

            Directory = directory;

            GridView.SetDoubleBuffering();
            new DataGridViewSelection(GridView);

            LoadDialog();
        }

        private void SortResultManager_Load(object sender, EventArgs e) {
            GridView.ClearSelection();
        }
        private void LoadDialog() {
            GridView.Rows.Clear();

            string[] files = System.IO.Directory.GetFiles(Directory, "*.fcl");

            for (int i = 0; i < files.Length; i++) {
                GridView.Rows.Add(files[i]);
                GridView.Rows[i].Tag = files[i];
            }

            TotalFilesLabel.Text = $"Total files: {files.Length}";
        }

        private void GridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;

            string path = (string)GridView.Rows[e.RowIndex].Tag;
            
            SortResult result = LoadResult(path);
            if (result == null) return;

            SortResultViewer viewer = new SortResultViewer(result);
            viewer.ShowDialog();
        }

        private void LoadFromFileButton_Click(object sender, EventArgs e) {
            InputResult<string> inputResult = CustomDialog.ShowBrowser(BrowseType.OpenFile, "Fcl files|*.fcl;|Json files|*.json");
            if (inputResult.DialogClosed) return;

            SortResult result = LoadResult(inputResult.Value);
            if (result == null) return;

            SortResultViewer viewer = new SortResultViewer(result);
            viewer.ShowDialog();
        }
        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }

        //Functions
        private SortResult LoadResult(string path) {
            try {
                using (FileStream file = File.OpenRead(path)) {
                    SortResult output;

                    switch (Path.GetExtension(path)) {
                        case ".fcl":
                            output = new SortResultStreamDeserializer().Deserialize(file);
                            break;
                        case ".json":
                            output = new SortResultDeserializer().Deserialize(file);
                            break;
                        default:
                            CustomDialog.ShowError("Error", "File format not supported.");
                            return null;
                    }

                    return output;
                }
            } catch {
                CustomDialog.ShowError("Error", "There was a problem loading the file.");
                return null;
            }
        }
    }
}
