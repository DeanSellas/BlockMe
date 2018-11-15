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
using BlockMe.Properties;
using BlockMe.Forms;
using BlockMe.Classes;

namespace BlockMe {
    public partial class mainForm : Form {

        nameForm nameForm;
        settingsForm settingsForm;

        public Dictionary<string, string> rulesDictionary;

        updateHandler update;


        public bool enableNow = true;

        public string name;

        public string prefix = Resources.prefix.ToString();

        public string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public string[] exeList;
        // final list of items
        public List<string> buildList = new List<string>();

        public mainForm() {
            InitializeComponent();
            //Settings.Default.Reset();
            //Console.WriteLine(Settings.Default.removeRules);
            if (Settings.Default.enableUpdates) {
                update = new updateHandler();
            }

            rulesDictionary = convertString(Settings.Default.rules);

            foreach(string key in rulesDictionary.Keys) {
                Console.WriteLine("Key {0} Val {1}", key, rulesDictionary[key]);
            }
        }

        // on form close
        #pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        private void Closing(object sender, FormClosingEventArgs e) {
        #pragma warning restore CS0108 // Member hides inherited member; missing new keyword
            saveUninstallerRules();
        }

        // saves uninstaller rules
        private void saveUninstallerRules() {
            string settings = convertDictionary(rulesDictionary);
            Console.WriteLine(settings);
            Settings.Default.rules = settings;
            Settings.Default.Save();
        }


        // converts a string to a dictionary
        private Dictionary<string,string> convertString(string input) {
            Dictionary<string, string> tmp = new Dictionary<string, string>();
            // adds keys to dictionary
            foreach(string line in input.Split('*')) {
                // splits key and value items
                string[] arr = line.Split('@');
                try { tmp[arr[0]] = arr[1]; } catch { }
            }

            return tmp;
        }

        // converts dictionary to string
        private string convertDictionary(Dictionary<string, string> input) {
            string tmpString = "";
            foreach (string key in rulesDictionary.Keys) {
                tmpString += String.Format("{0}@{1}*", key, rulesDictionary[key]);
            }
            return tmpString;
        }


        
        // updates forms checkboxes
        public void updateForm() {
            blockFilesInPath.Checked = Settings.Default.blockInFolder;
            blockAllSubfolders.Checked = Settings.Default.blockInSubfolder;
        }


        // makes sure path exists
        private void checkPath() {
            // if single file make sure it exists
            if (!blockFilesInPath.Checked && File.Exists(pathTextbox.Text))
                buildButton.Enabled = true;
            // if directory exists
            else if (blockFilesInPath.Checked && Directory.Exists(pathTextbox.Text))
                buildButton.Enabled = true;
            else
                buildButton.Enabled = false;
        }

        // when checkboxes change
        private void checkBoxValChange(object sender, EventArgs e) {

            // enables subfolder check if folder check is checked
            if (blockFilesInPath.Checked)
                blockAllSubfolders.Enabled = true;
            else
                blockAllSubfolders.Enabled = false;

            checkPath();

            // Meant for debugging
            // Console.WriteLine("BLOCK FOLDER {0}\nBLOCK EVERYTHING {1}", blockFilesInPath.Checked, blockAllSubfolders.Checked);
        }

        // opens file browser
        private void fileBrowserButton_Click(object sender, EventArgs e) {
            string path;
            // opens folder browser if user chooses to look in folders
            if (blockFilesInPath.Checked) {
                folderBrowserDialog1.ShowDialog();
                path = folderBrowserDialog1.SelectedPath;
            }
            // opens file browser
            else {
                openFileDialog1.ShowDialog();
                path = openFileDialog1.FileName;
            }
            pathTextbox.Text = path;
        }

        private void buildRules(object sender, EventArgs e) {
            if (createList()) {
                nameForm = new nameForm(this);
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

        public void createFile() {
            var enable = "yes";
            if (!enableNow)
                enable = "no";

            var fileName = String.Format("BlockMe-{0}.bat", name.Replace(" ", ""));

            var filePath = String.Format("{0}\\{1}", desktop, fileName);

            // if file exists asks user to overwrite it
            if (File.Exists(filePath)) {
                DialogResult result = MessageBox.Show("Do you want to overwrite the current file?", "File Exists!", MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk);
                if (result == DialogResult.No) return;
                File.Delete(filePath);
            }

            string installer = "", exes = "";

            // adds prefix.txt to file
            File.WriteAllText(filePath, prefix);
            foreach (string path in buildList) {

                // adds firewall rule
                installer += String.Format("netsh advfirewall firewall add rule name=\"{0} {1}\" program=\"{1}\" enable=\"{2}\" protocol=any dir=out action=block",name, path, enable) + Environment.NewLine;

                exes += path;

                // Console.WriteLine(val);
            }
            File.AppendAllText(filePath, installer);
            // ends file with pause so the user can see what passed and failed
            File.AppendAllText(filePath, "pause");

            rulesDictionary[name] = exes;
            //Settings.Default.Rules.Add()

            MessageBox.Show(String.Format("{0} was created on the desktop. Please open it in Admin Mode", fileName), "File Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // resets values

            resetValues();
        }

        public void resetValues() {
            buildList.Clear();
            exeList = new string[0] { };
            name = null;
        }

        private void pathTextbox_TextChanged(object sender, EventArgs e) { checkPath(); }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e) { Process.Start("https://github.com/DeanSellas/BlockMe"); }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) { Close(); }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e) {
            settingsForm = new settingsForm(this);
            settingsForm.ShowDialog();
            
        }
        
        private void uninstallerToolStripMenuItem_Click(object sender, EventArgs e) {
            rulesForm rules = new rulesForm(this);
            rules.ShowDialog();
        }
    }
}
