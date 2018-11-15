using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlockMe.Properties;

namespace BlockMe.Classes {
    class updateHandler {


        WebClient webClient = new WebClient();
        string currentVersion = Application.ProductVersion;
        string onlineVersion;

        public updateHandler() {
            
            checkForUpdates();
        }


        private void checkForUpdates() {
            // reads version from github
            StreamReader reader;
            // Checks to see if dev builds are enabled
            reader = new StreamReader(webClient.OpenRead("https://raw.githubusercontent.com/DeanSellas/BlockMe/master/version.txt"));
            
            onlineVersion = reader.ReadLine();

            bool updateAvalible = false;

            for (int i = 0; i < currentVersion.Length; i++) {
                try {
                    if (currentVersion[i] != '.' && Convert.ToInt32(currentVersion[i]) > Convert.ToInt32(onlineVersion[i]))
                        break;
                    else if (currentVersion[i] != '.' && currentVersion[i] != onlineVersion[i]) {
                        updateAvalible = true;
                        break;
                    }  
                }
                catch {
                    // do nothing
                }
            }

            // prompt user if update is avalible
            if (updateAvalible) {
                DialogResult dialogResult = MessageBox.Show("Would you like to update BlockMe to: " + onlineVersion + "?", "Update Spectrum", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes) {
                    System.Diagnostics.Process.Start("https://github.com/DeanSellas/BlockMe/releases");
                }
            }

        }



    }
}
