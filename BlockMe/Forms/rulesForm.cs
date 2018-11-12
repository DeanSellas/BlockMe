using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            buildList();
        }
        private void buildList() {

            foreach (string key in main.rulesDictionary.Keys)
                listBox1.Items.Add(key);
        }

        private void buildButton_Click(object sender, EventArgs e) {
            string key = listBox1.SelectedItem.ToString();

            //Console.WriteLine(main.rulesDictionary[key]);

            foreach (string item in main.rulesDictionary[key].Split('\n'))
                main.buildList.Add(item);

            main.name = key;

            main.createFile();

        }

        private void uninstallButton_Click(object sender, EventArgs e) {
            createUninstaller();
        }

        private void createUninstaller() {

        }
    }
}
