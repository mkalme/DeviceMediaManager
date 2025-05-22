using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DeviceMediaManager;

namespace DeviceMediaManagerGUI {
    public partial class SortResultSummaryViewer : Form {
        public SortResult Result { get; set; }

        private IList<FileSortResult> _fullCopies = new List<FileSortResult>();
        private IList<FileSortResult> _partialCopies = new List<FileSortResult>();
        private IList<FileSortResult> _noCopies = new List<FileSortResult>();

        public SortResultSummaryViewer(SortResult result) {
            InitializeComponent();

            Result = result;

            LoadDialog();
        }

        private void LoadDialog() {
            foreach (var copy in Result.SortResults) {
                int copies = 0;

                foreach (var sortResult in copy.CopyResults) {
                    if (sortResult.CopyResult == CopyResult.CopyOriginal || sortResult.CopyResult == CopyResult.CopyNameOriginal) {
                        copies++;
                    }
                }

                if (copies == copy.CopyResults.Count) {
                    _fullCopies.Add(copy);
                } else if (copies < copy.CopyResults.Count && copies > 0) {
                    _partialCopies.Add(copy);
                } else if (copies == 0) {
                    _noCopies.Add(copy);
                }
            }

            FullCopiesLink.Text = $"{_fullCopies.Count} copies";
            PartialCopiesLink.Text = $"{_partialCopies.Count} copies";
            NoCopiesLink.Text = $"{_noCopies.Count} copies";
        }

        private void FullCopiesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            OpenFileSortResultViewer(_fullCopies);
        }
        private void PartialCopiesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            OpenFileSortResultViewer(_partialCopies);
        }
        private void NoCopiesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            OpenFileSortResultViewer(_noCopies);
        }

        private static void OpenFileSortResultViewer(IList<FileSortResult> results) {
            List<FileCopyResult> fileCopyResults = new List<FileCopyResult>();
            foreach (var result in results) {
                fileCopyResults.AddRange(result.CopyResults);
            }

            FileSortResultViewer viewer = new FileSortResultViewer(fileCopyResults);
            viewer.ShowDialog();
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
