using System;
using System.Windows.Forms;
using CustomDialogs;
using DeviceMediaManager;

namespace DeviceMediaManagerGUI {
    public partial class ProgressForm : Form {
        private Progress<ProgressReport> _progress;
        private bool _canClose = false;

        private ProgressPanel _progressPanel;
        
        public ProgressForm(Progress<ProgressReport> progress) {
            InitializeComponent();

            _progressPanel = new ProgressPanel();
            _progressPanel.Location = new System.Drawing.Point(9, 10);
            _progressPanel.Size = new System.Drawing.Size(486, 57);

            Controls.Add(_progressPanel);

            _progress = progress;
            _progress.ProgressChanged += UpdateProgress;
        }

        public void SetText(string text) {
            if (_title.StartsWith(text)) return;

            Text = text;
            _title = text;

            _progressPanel.SetText(Text);
        }

        private void UpdateProgress(object sender, ProgressReport progress) {
            SetText(progress.ActivityType);

            _progressPanel.Update(progress);

            if (progress.Finished) {
                _canClose = true;
                Close();
            }
        }

        private void ProgressForm_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = !_canClose;
        }

        private string _title = "";
        private void UploadingTitleTimer_Tick(object sender, EventArgs e) {
            if (Text.Length - _title.Length < 3) {
                Text += ".";
            } else {
                Text = _title;
            }

            _progressPanel.SetText(Text);
        }
    }
}
