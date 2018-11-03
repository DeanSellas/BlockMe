namespace BlockMe {
    partial class mainForm {
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
            this.pathTextbox = new System.Windows.Forms.TextBox();
            this.fileBrowserButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.blockFilesInPath = new System.Windows.Forms.CheckBox();
            this.blockAllSubfolders = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buildButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pathTextbox
            // 
            this.pathTextbox.Location = new System.Drawing.Point(12, 50);
            this.pathTextbox.Name = "pathTextbox";
            this.pathTextbox.Size = new System.Drawing.Size(226, 20);
            this.pathTextbox.TabIndex = 0;
            this.pathTextbox.TextChanged += new System.EventHandler(this.pathTextbox_TextChanged);
            // 
            // fileBrowserButton
            // 
            this.fileBrowserButton.Location = new System.Drawing.Point(244, 50);
            this.fileBrowserButton.Name = "fileBrowserButton";
            this.fileBrowserButton.Size = new System.Drawing.Size(37, 20);
            this.fileBrowserButton.TabIndex = 1;
            this.fileBrowserButton.Text = "...";
            this.fileBrowserButton.UseVisualStyleBackColor = true;
            this.fileBrowserButton.Click += new System.EventHandler(this.fileBrowserButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Applications|*.exe";
            // 
            // blockFilesInPath
            // 
            this.blockFilesInPath.AutoSize = true;
            this.blockFilesInPath.Location = new System.Drawing.Point(12, 76);
            this.blockFilesInPath.Name = "blockFilesInPath";
            this.blockFilesInPath.Size = new System.Drawing.Size(128, 17);
            this.blockFilesInPath.TabIndex = 2;
            this.blockFilesInPath.Text = "Block All Files In Path";
            this.blockFilesInPath.UseVisualStyleBackColor = true;
            this.blockFilesInPath.CheckedChanged += new System.EventHandler(this.checkBoxValChange);
            // 
            // blockAllSubfolders
            // 
            this.blockAllSubfolders.AutoSize = true;
            this.blockAllSubfolders.Enabled = false;
            this.blockAllSubfolders.Location = new System.Drawing.Point(12, 99);
            this.blockAllSubfolders.Name = "blockAllSubfolders";
            this.blockAllSubfolders.Size = new System.Drawing.Size(156, 17);
            this.blockAllSubfolders.TabIndex = 3;
            this.blockAllSubfolders.Text = "Block All Files In Subfolders";
            this.blockAllSubfolders.UseVisualStyleBackColor = true;
            this.blockAllSubfolders.CheckedChanged += new System.EventHandler(this.checkBoxValChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select File To Block";
            // 
            // buildButton
            // 
            this.buildButton.Enabled = false;
            this.buildButton.Location = new System.Drawing.Point(12, 128);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(269, 23);
            this.buildButton.TabIndex = 5;
            this.buildButton.Text = "Block Me!";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildRules);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.githubToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(293, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.githubToolStripMenuItem.Text = "Github";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 163);
            this.Controls.Add(this.buildButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blockAllSubfolders);
            this.Controls.Add(this.blockFilesInPath);
            this.Controls.Add(this.fileBrowserButton);
            this.Controls.Add(this.pathTextbox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "Block Me!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathTextbox;
        private System.Windows.Forms.Button fileBrowserButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox blockFilesInPath;
        private System.Windows.Forms.CheckBox blockAllSubfolders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
    }
}

