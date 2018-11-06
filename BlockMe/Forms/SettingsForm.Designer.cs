namespace BlockMe {
    partial class settingsForm {
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.enableOnBuild = new System.Windows.Forms.CheckBox();
            this.blockInFolder = new System.Windows.Forms.CheckBox();
            this.blockInSubfolder = new System.Windows.Forms.CheckBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(16, 157);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(109, 157);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // enableOnBuild
            // 
            this.enableOnBuild.AutoSize = true;
            this.enableOnBuild.Location = new System.Drawing.Point(16, 12);
            this.enableOnBuild.Name = "enableOnBuild";
            this.enableOnBuild.Size = new System.Drawing.Size(102, 17);
            this.enableOnBuild.TabIndex = 2;
            this.enableOnBuild.Text = "Enable On Build";
            this.enableOnBuild.UseVisualStyleBackColor = true;
            this.enableOnBuild.CheckedChanged += new System.EventHandler(this.checkChange_Event);
            // 
            // blockInFolder
            // 
            this.blockInFolder.AutoSize = true;
            this.blockInFolder.Location = new System.Drawing.Point(16, 35);
            this.blockInFolder.Name = "blockInFolder";
            this.blockInFolder.Size = new System.Drawing.Size(121, 17);
            this.blockInFolder.TabIndex = 3;
            this.blockInFolder.Text = "Block Files In Folder";
            this.blockInFolder.UseVisualStyleBackColor = true;
            this.blockInFolder.CheckedChanged += new System.EventHandler(this.checkChange_Event);
            // 
            // blockInSubfolder
            // 
            this.blockInSubfolder.AutoSize = true;
            this.blockInSubfolder.Location = new System.Drawing.Point(16, 58);
            this.blockInSubfolder.Name = "blockInSubfolder";
            this.blockInSubfolder.Size = new System.Drawing.Size(142, 17);
            this.blockInSubfolder.TabIndex = 4;
            this.blockInSubfolder.Text = "Block Files In Subfolders";
            this.blockInSubfolder.UseVisualStyleBackColor = true;
            this.blockInSubfolder.CheckedChanged += new System.EventHandler(this.checkChange_Event);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Enabled = false;
            this.applyButton.Location = new System.Drawing.Point(201, 157);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 192);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.blockInSubfolder);
            this.Controls.Add(this.blockInFolder);
            this.Controls.Add(this.enableOnBuild);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(304, 231);
            this.MinimumSize = new System.Drawing.Size(304, 231);
            this.Name = "settingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settingsForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox enableOnBuild;
        private System.Windows.Forms.CheckBox blockInFolder;
        private System.Windows.Forms.CheckBox blockInSubfolder;
        private System.Windows.Forms.Button applyButton;
    }
}