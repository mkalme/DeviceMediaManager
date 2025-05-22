using System;
using CustomDialogs;
using DeviceMediaManager;

namespace DeviceMediaManagerGUI {
    public partial class SchemePanel : ClickablePanel {
        public Scheme Scheme { get; set; }

        public SchemePanel(Scheme scheme) {
            InitializeComponent();

            Scheme = scheme;

            MouseControl = new MouseControl(this);
            MouseControl.Click += OnClick;

            Scheme.Update += OnUpdate;

            LoadPanel();
        }

        private void OnClick(object sender, EventArgs e) {
            CallUserClick(this, EventArgs.Empty);
        }
        private void OnUpdate(object sender, EventArgs e) {
            LoadPanel();
        }

        private void LoadPanel() {
            NameLabel.Text = Scheme.Name;
            OutputDirectoryLabel.Text = string.Join("\n", Scheme.OutputDirectories);
        }
    }
}
