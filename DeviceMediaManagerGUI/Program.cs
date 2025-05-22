using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using DeviceMediaManager;

namespace DeviceMediaManagerGUI {
    static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Stopwatch watch = new Stopwatch();
            watch.Start();

            Directory.CreateDirectory("Storage\\SortResults");

            ApplicationManager manager = new ApplicationManager("Storage\\Schemes.bof");
            manager.Load();

            IEnumerable<string> files;
            if (args.Length < 1) {
                OpenFileDialog fileDialog = new OpenFileDialog() { 
                    Multiselect = true
                };
                fileDialog.ShowDialog();

                files = fileDialog.FileNames;
            } else {
                files = GetFiles(args);
            }

            Application.Run(new ManagerForm(files, manager));
        }

        private static IEnumerable<string> GetFiles(string[] args) {
            List<string> files = new List<string>(args.Length);

            foreach (var path in args) {
                bool isFile = Path.HasExtension(path);

                if (isFile) {
                    isFile = File.Exists(path);
                } else {
                    isFile = !Directory.Exists(path);
                }

                if (isFile) {
                    files.Add(path);
                } else {
                    files.AddRange(Directory.GetFiles(path, "*", SearchOption.AllDirectories));
                }
            }

            return files;
        }
    }
}
