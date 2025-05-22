using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using CustomDialogs;
using DeviceMediaManager;

namespace DeviceMediaManagerGUI {
    public partial class ManagerForm : Form {
        public ApplicationManager Manager { get; set; }
        public IEnumerable<string> Files { get; set; }

        public Scheme SelectedScheme { get; private set; }

        private ClickablePanelContainer _schemeContainer;
        private SchemeEditorPanel _schemeEditorPanel;

        public ManagerForm(IEnumerable<string> files, ApplicationManager manager) {
            InitializeComponent();

            Files = files;
            Manager = manager;

            _schemeContainer = new ClickablePanelContainer(CreateSchemePanels());
            _schemeContainer.Dock = DockStyle.Top;

            SchemePanelContainer.Controls.Add(_schemeContainer, 0, 0);

            DisplayAmountLabel();
        }

        private void ManagerForm_Load(object sender, EventArgs e) {
            Activate();
        }

        private IEnumerable<SchemePanel> CreateSchemePanels() {
            List<SchemePanel> panels = new List<SchemePanel>(Manager.Schemes.Count);

            foreach (Scheme scheme in Manager.Schemes) {
                panels.Add(CreateSchemePanel(scheme));
            }

            return panels;
        }
        private SchemePanel CreateSchemePanel(Scheme scheme) {
            SchemePanel panel = new SchemePanel(scheme) {
                BackColor = Color.FromArgb(45, 45, 45),
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Margin = new Padding(0, 3, 0, 0)
            };
            panel.UserClick += SchemeClick;

            return panel;
        }

        private void SchemeClick(object sender, EventArgs e) {
            SelectPanel(sender as SchemePanel);
        }
        private void SelectPanel(SchemePanel panel) {
            SelectedScheme = panel.Scheme;
            _schemeContainer.SelectPanel(panel);

            SchemeContainer.Controls.Remove(SchemeContainer.GetControlFromPosition(1, 0));

            _schemeEditorPanel = new SchemeEditorPanel(SelectedScheme, Manager) {
                Margin = new Padding(5, 3, 0, 0),
                Dock = DockStyle.Fill
            };
            SchemeContainer.Controls.Add(_schemeEditorPanel, 1, 0);
        }

        private void DisplayAmountLabel() {
            FileAmountLabel.Text = $"|  Amount of files selected: {Files.Count()}";
        }

        private void AddSchemeButton_Click(object sender, EventArgs e) {
            Scheme scheme = new Scheme(Manager) { 
                Name = "New scheme",
                OutputDirectories = new string[0]
            };

            Manager.Schemes.Add(scheme);
            Manager.Save();

            _schemeContainer.AddPanel(CreateSchemePanel(scheme));
            SelectPanel(_schemeContainer.CustomPanels.Last() as SchemePanel);
        }
        private void RemoveSchemeButton_Click(object sender, EventArgs e) {
            if (SelectedScheme == null) return;

            string result = CustomDialog.ShowMessage("Remove", "Are you sure you want to remove this?",
                Properties.Resources._64pxTrash, System.Media.SystemSounds.Hand, "Remove", "Cancel");

            if (result == "Remove") {
                Manager.Schemes.Remove(SelectedScheme);
                Manager.Save();

                _schemeContainer = new ClickablePanelContainer(CreateSchemePanels());
                _schemeContainer.Dock = DockStyle.Top;

                SchemePanelContainer.Controls.Remove(SchemePanelContainer.GetControlFromPosition(0, 0));
                SchemePanelContainer.Controls.Add(_schemeContainer, 0, 0);
            }
        }

        private void SortMediaButton_Click(object sender, EventArgs e) {
            if (SelectedScheme == null) return;

            if (Manager == null) {
                CustomDialog.ShowError("Error", "Scheme has not been selected.");
                return;
            }

            Progress<ProgressReport> progress = new Progress<ProgressReport>();

            SortResult result = null;

            Thread thread = new Thread(() => {
                result = SelectedScheme.SortMedia(Files, progress);
            });
            thread.Start();

            ProgressForm progressForm = new ProgressForm(progress);
            progressForm.Icon = ImageToIconConverter.Convert(Properties.Resources._16pxStartSort, 16, 16);
            progressForm.SetText("Creating archive");
            progressForm.ShowDialog();

            SortResultViewer viewer = new SortResultViewer(result);
            viewer.ShowDialog();
        }
        private void EditLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            TextCollectionEditor editor = new TextCollectionEditor(new HashSet<string>(Files), "Files");
            editor.AddFunction = () => {
                OpenFileDialog.ShowDialog();

                List<string> fileNames = new List<string>(OpenFileDialog.FileNames.Length);
                foreach (var file in OpenFileDialog.FileNames) {
                    if (File.Exists(file)) fileNames.Add(file);
                }

                return fileNames;
            };
            editor.Icon = Icon;
            editor.ShowDialog();

            Files = editor.Values;
            DisplayAmountLabel();
        }

        private void OpenSortResultManagerButton_Click(object sender, EventArgs e) {
            SortResultManager manager = new SortResultManager(Manager.SortResultDirectory);
            manager.ShowDialog();
        }
    }
}
