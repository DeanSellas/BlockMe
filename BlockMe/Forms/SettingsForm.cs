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
    public partial class settingsForm : Form {

        mainForm mainForm;

        bool checkChanged = false;


        public settingsForm(mainForm main) {
            InitializeComponent();

            mainForm = main;
        }

        private void buildSettings() {
            Settings.Default.blockInFolderDefault = blockInFolder.Checked;
            Settings.Default.blockInSubfolderDefault = blockInSubfolder.Checked;
            Settings.Default.enableOnBuild = enableOnBuild.Checked;

            mainForm.updateForm();

            Settings.Default.Save();
        }


        private void okButton_Click(object sender, EventArgs e) {
            buildSettings();
            Close();
        }

        private void settingsForm_Shown(object sender, EventArgs e) {
            blockInFolder.Checked = Settings.Default.blockInFolderDefault;
            blockInSubfolder.Checked = Settings.Default.blockInSubfolderDefault;
            enableOnBuild.Checked = Settings.Default.enableOnBuild;
        }

        private void cancelButton_Click(object sender, EventArgs e) {

            if (checkChanged) {
                DialogResult result = MessageBox.Show("Discard Changes?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes) Close();
            }
            Close();    
        }

        
        private void checkChange_Event(object sender, EventArgs e) {
            if (blockInFolder.Checked != Settings.Default.blockInFolderDefault ||
            blockInSubfolder.Checked != Settings.Default.blockInSubfolderDefault ||
            enableOnBuild.Checked != Settings.Default.enableOnBuild)
                checkChanged = true;
            else
                checkChanged = false;

            if (checkChanged)
                applyButton.Enabled = true;
            else
                applyButton.Enabled = false;
        }

        private void applyButton_Click(object sender, EventArgs e) {
            buildSettings();
            applyButton.Enabled = false;
        }
        
    }
}
