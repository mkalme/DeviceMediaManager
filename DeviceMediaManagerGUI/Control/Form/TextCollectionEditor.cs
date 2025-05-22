using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CustomDialogs;

namespace DeviceMediaManagerGUI {
    public partial class TextCollectionEditor : Form {
        public ISet<string> Values { get; set; }
        public string ValueName { get; set; }

        public Func<IEnumerable<string>> AddFunction { get; set; }

        public TextCollectionEditor(ISet<string> values, string valueName) {
            InitializeComponent();

            Values = values;
            ValueName = valueName;

            GridView.SetDoubleBuffering();
            new DataGridViewSelection(GridView);

            Text = ValueName;
            GridViewColumn.HeaderText = ValueName;
        }

        private void TextCollectionEditor_Load(object sender, EventArgs e) {
            LoadGridView();
        }

        private void LoadGridView() {
            GridView.Rows.Clear();

            foreach (string value in Values) {
                GridView.Rows.Add(value);
            }

            GridView.ClearSelection();
        }

        private void DoneButton_Click(object sender, EventArgs e) {
            Close();
        }
        private void AddButton_Click(object sender, EventArgs e) {
            IEnumerable<string> values = AddFunction();
            Values.UnionWith(values);

            LoadGridView();
        }

        private void RemoveLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            foreach (DataGridViewRow folder in GridView.SelectedRows) {
                Values.Remove((string)folder.Cells[0].Value);
            }

            LoadGridView();
        }
    }
}
