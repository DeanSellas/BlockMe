using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockMe {
    public partial class nameForm : Form {

        mainForm mainForm;
        public nameForm(mainForm main) {
            InitializeComponent();

            mainForm = main;

            enableCheckbox.Checked = mainForm.enableNow;
        }

        private void button1_Click(object sender, EventArgs e) {

            if (textBox1.Text != "") {
                mainForm.name = textBox1.Text;
                Close();
            }
                
            else
                MessageBox.Show("Please Enter A Proper Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void nameForm_FormClosing(object sender, FormClosingEventArgs e) {
            mainForm.enableNow = enableCheckbox.Checked;
        }
    }
}
