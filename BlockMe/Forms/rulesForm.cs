using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlockMe.Forms;

namespace BlockMe.Forms {
    public partial class rulesForm : Form {
        mainForm main;
        public rulesForm(mainForm mf) {
            InitializeComponent();
            main = mf;
            createListBox();
        }

        // creates list
        private void createListBox() {
            foreach (string key in main.rulesDictionary.Keys)
                rulesListBox.Items.Add(key);
        }
        
        // rebuilds installer
        private void buildButton_Click(object sender, EventArgs e) {
            string key = rulesListBox.SelectedItem.ToString();

            createList(key);

            main.name = key;

            main.createFile();

        }

        private void uninstallButton_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this rule?", "Delete Rule?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.No) return;
            createUninstaller();
        }

        private void createUninstaller() {
            // assigns name from selected item
            string name = rulesListBox.SelectedItem.ToString();

            // adds exe path to master list
            createList(name);

            var fileName = String.Format("UnBlockMe-{0}.bat", name.Replace(" ", ""));

            var filePath = String.Format("{0}\\{1}", main.desktop, fileName);

            // if file exists asks user to overwrite it || should not run but is here just in case
            if (File.Exists(filePath)) {
                DialogResult result = MessageBox.Show("Do you want to overwrite the current file?", "File Exists!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.No) return;
                File.Delete(filePath);
            }

            // text block for uninstaller
            string uninstaller = "";

            // adds prefix.txt to file
            File.WriteAllText(filePath, main.prefix);
            foreach (string path in main.buildList) {
                // deletes firewall rule
                uninstaller += String.Format("netsh advfirewall firewall delete rule name=\"{0} {1}\"", name, path) + Environment.NewLine;
            }
            File.AppendAllText(filePath, uninstaller);

            // ends file with pause so the user can see what passed and failed
            File.AppendAllText(filePath, "pause");

            main.rulesDictionary.Remove(name);
            main.resetValues();
        }



        // creates master list for installer/uninstaller
        private void createList(string key) {
            foreach (string item in main.rulesDictionary[key].Split('\n'))
                main.buildList.Add(item);
        }
    }
}
