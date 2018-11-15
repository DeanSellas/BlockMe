using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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

        // assigns right values to checkboxes
        private void settingsForm_Shown(object sender, EventArgs e) {
            blockInFolder.Checked = Settings.Default.blockInFolder;
            blockInSubfolder.Checked = Settings.Default.blockInSubfolder;
            enableOnBuild.Checked = Settings.Default.enableOnBuild;
        }

        //saves settings
        private void buildSettings() {
            Settings.Default.blockInFolder = blockInFolder.Checked;
            Settings.Default.blockInSubfolder = blockInSubfolder.Checked;
            Settings.Default.enableOnBuild = enableOnBuild.Checked;
            Settings.Default.enableUpdates = enableUpdates.Checked;

            mainForm.updateForm();

            Settings.Default.Save();
            checkChanged = false;
        }


        private void okButton_Click(object sender, EventArgs e) {
            buildSettings();
            Close();
        }

        

        private void cancelButton_Click(object sender, EventArgs e) {

            if (checkChanged) {
                DialogResult result = MessageBox.Show("Discard Changes?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes) Close();
            }
            Close();    
        }

        
        private void checkChange_Event(object sender, EventArgs e) {
            checkChanged = false;

            // loops through checkbox
            foreach(Control control in this.Controls) {
                if (control is CheckBox) {
                    CheckBox checkBox = (CheckBox)control;

                    // if setting name is correct and value is different checkChanged = true
                    if (!Settings.Default[checkBox.Name].Equals(checkBox.Checked)) {
                        checkChanged = true;
                        break;
                    }
                }
            }


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
