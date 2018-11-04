using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockMe {
    public partial class mainForm : Form {

        public bool enableNow = true;

        public string name;

        string prefix = Properties.Resources.prefix.ToString();

        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public string[] exeList;

        public mainForm() {
            InitializeComponent();
        }


        private void checkPath() {
            if (!blockFilesInPath.Checked && File.Exists(pathTextbox.Text))
                buildButton.Enabled = true;
            else if (blockFilesInPath.Checked && Directory.Exists(pathTextbox.Text))
                buildButton.Enabled = true;
            else
                buildButton.Enabled = false;
        }

        private void checkBoxValChange(object sender, EventArgs e) {

            if (blockFilesInPath.Checked)
                blockAllSubfolders.Enabled = true;
            else
                blockAllSubfolders.Enabled = false;

            checkPath();

            Console.WriteLine("BLOCK FOLDER {0}\nBLOCK EVERYTHING {1}", blockFilesInPath.Checked, blockAllSubfolders.Checked);

        }



        private void fileBrowserButton_Click(object sender, EventArgs e) {
            string path;
            if (blockFilesInPath.Checked) {
                folderBrowserDialog1.ShowDialog();
                path = folderBrowserDialog1.SelectedPath;
            }
            else {
                openFileDialog1.ShowDialog();
                path = openFileDialog1.FileName;
            }
            pathTextbox.Text = path;
        }

        private void buildRules(object sender, EventArgs e) {
            if (createList()) {
                nameForm nameForm = new nameForm(this);
                nameForm.ShowDialog();
                if (name != null)
                    createFile();
            }
            
        }

        private bool createList() {
            if (blockFilesInPath.Checked) {

                if (blockAllSubfolders.Checked)
                    exeList = Directory.GetFiles(pathTextbox.Text, "*.exe", SearchOption.AllDirectories);
                else
                    exeList = Directory.GetFiles(pathTextbox.Text, "*.exe", SearchOption.TopDirectoryOnly);
            }

            else
                exeList = new string[] { pathTextbox.Text };


            foreach (string item in exeList) {
                if(File.Exists(item))
                    Console.WriteLine(item);
                else {
                    MessageBox.Show("File no longer exists or has been moved please select a new file", "File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void createFile() {
            var enable = "yes";
            if (!enableNow)
                enable = "no";

            var fileName = String.Format("BlockMe-{0}.bat", name.Replace(" ", ""));

            var filePath = String.Format("{0}\\{1}", desktop, fileName);

            if (File.Exists(filePath)) {
                DialogResult result = MessageBox.Show("Do you want to overwrite the current file?", "File Exists!", MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk);
                if (result == DialogResult.No) return;
            }

            File.WriteAllText(filePath, prefix);
            foreach (string path in exeList) {
                var tmpName = name + " " + path;

                string val = String.Format("netsh advfirewall firewall add rule name=\"{0} {1}\" program=\"{1}\" enable=\"{2}\" protocol=any dir=out action=block",name, path, enable) + Environment.NewLine;

                File.AppendAllText(filePath, val);

                Console.WriteLine(val);
            }
            File.AppendAllText(filePath, "pause");

            MessageBox.Show(String.Format("{0} was created on the desktop. Please open it in Admin Mode", fileName), "File Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private void pathTextbox_TextChanged(object sender, EventArgs e) { checkPath(); }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e) { Process.Start("https://github.com/DeanSellas/BlockMe"); }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) { Close(); }
    }
}
