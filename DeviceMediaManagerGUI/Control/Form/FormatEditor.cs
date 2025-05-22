using System;
using System.Windows.Forms;
using DeviceMediaManager;

namespace DeviceMediaManagerGUI {
    public partial class FormatEditor : Form {
        public Format Format { get; private set; }
        public bool DialogClosed { get; private set; } = true;

        public FormatEditor(Format format) {
            InitializeComponent();

            Format = format;

            FormatTextBox.Text = Format.DateFormat;
            SkipCharactersUpDown.Value = Format.SkipFirstCharacters;
        }

        private void DoneButton_Click(object sender, EventArgs e) {
            DialogClosed = false;

            Format.DateFormat = FormatTextBox.Text;
            Format.SkipFirstCharacters = (int)SkipCharactersUpDown.Value;

            Close();
        }
        private void CancelButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
