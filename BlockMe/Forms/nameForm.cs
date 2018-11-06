using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlockMe.Properties;

namespace BlockMe {
    public partial class nameForm : Form {

        mainForm mainForm;
        public nameForm(mainForm main) {
            InitializeComponent();

            foundLabel.Text = String.Format("Found {0} Files to Block", main.exeList.Length);

            mainForm = main;

            enableCheckbox.Checked = mainForm.enableNow;

            chooseExes();

            enableCheckbox.Checked = Settings.Default.enableOnBuild;
        }

        private void chooseExes() {
            foreach(string item in mainForm.exeList) {
                exeCheckbox.Items.Add(item, true);
            }
            mainForm.exeList = new string[mainForm.exeList.Length];
        }


        private void assignValues(object sender, EventArgs e) {

            if (textBox1.Text != "" && exeCheckbox.CheckedItems.Count > 0) {
                mainForm.name = textBox1.Text;

                // adds all checked items to 
                foreach (string item in exeCheckbox.CheckedItems)
                    mainForm.buildList.Add(item);

                Close();
            }
            else
                MessageBox.Show("Please enter a name and make sure at least 1 item is checked", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void nameForm_FormClosing(object sender, FormClosingEventArgs e) {
            mainForm.enableNow = enableCheckbox.Checked;
        }

    }
}
