namespace BlockMe {
    partial class nameForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.enableCheckbox = new System.Windows.Forms.CheckBox();
            this.exeCheckbox = new System.Windows.Forms.CheckedListBox();
            this.foundLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(11, 260);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 20);
            this.textBox1.TabIndex = 0;
            // 
            // doneButton
            // 
            this.doneButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doneButton.Location = new System.Drawing.Point(11, 315);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(379, 23);
            this.doneButton.TabIndex = 1;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.assignValues);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(8, 244);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(123, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name Your Firewall Rule";
            // 
            // enableCheckbox
            // 
            this.enableCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.enableCheckbox.AutoSize = true;
            this.enableCheckbox.Checked = true;
            this.enableCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableCheckbox.Location = new System.Drawing.Point(11, 286);
            this.enableCheckbox.Name = "enableCheckbox";
            this.enableCheckbox.Size = new System.Drawing.Size(102, 17);
            this.enableCheckbox.TabIndex = 3;
            this.enableCheckbox.Text = "Enable On Build";
            this.enableCheckbox.UseVisualStyleBackColor = true;
            // 
            // exeCheckbox
            // 
            this.exeCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exeCheckbox.FormattingEnabled = true;
            this.exeCheckbox.Location = new System.Drawing.Point(11, 27);
            this.exeCheckbox.Name = "exeCheckbox";
            this.exeCheckbox.Size = new System.Drawing.Size(379, 214);
            this.exeCheckbox.TabIndex = 4;
            // 
            // foundLabel
            // 
            this.foundLabel.AutoSize = true;
            this.foundLabel.Location = new System.Drawing.Point(8, 9);
            this.foundLabel.Name = "foundLabel";
            this.foundLabel.Size = new System.Drawing.Size(118, 13);
            this.foundLabel.TabIndex = 5;
            this.foundLabel.Text = "Found __ Files to Block";
            // 
            // nameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 351);
            this.Controls.Add(this.foundLabel);
            this.Controls.Add(this.exeCheckbox);
            this.Controls.Add(this.enableCheckbox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(418, 337);
            this.Name = "nameForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Rule Name";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.nameForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.CheckBox enableCheckbox;
        private System.Windows.Forms.CheckedListBox exeCheckbox;
        private System.Windows.Forms.Label foundLabel;
    }
}