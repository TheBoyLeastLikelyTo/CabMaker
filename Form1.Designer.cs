namespace CabMaker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonTargetBrowse = new System.Windows.Forms.Button();
            this.TextOutput = new System.Windows.Forms.TextBox();
            this.ButtonRun = new System.Windows.Forms.Button();
            this.LabelOutputFile = new System.Windows.Forms.Label();
            this.TextOutputFile = new System.Windows.Forms.TextBox();
            this.LabelCompressionType = new System.Windows.Forms.Label();
            this.LabelCompressionMemory = new System.Windows.Forms.Label();
            this.DropdownCompressType = new System.Windows.Forms.ComboBox();
            this.DropdownCompressMemory = new System.Windows.Forms.ComboBox();
            this.GroupBoxFiles = new System.Windows.Forms.GroupBox();
            this.FilesListBox = new System.Windows.Forms.CheckedListBox();
            this.SelectAllFiles = new System.Windows.Forms.Button();
            this.ClearFiles = new System.Windows.Forms.Button();
            this.AddFile = new System.Windows.Forms.Button();
            this.AddFolder = new System.Windows.Forms.Button();
            this.GroupBoxCompressor = new System.Windows.Forms.GroupBox();
            this.ButtonBrowseRoot = new System.Windows.Forms.Button();
            this.TextRootDirectory = new System.Windows.Forms.TextBox();
            this.LabelRootDirectory = new System.Windows.Forms.Label();
            this.CheckSaveSettings = new System.Windows.Forms.CheckBox();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonExport = new System.Windows.Forms.Button();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.MainMenu = new System.Windows.Forms.ToolStripSplitButton();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelOutputStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.GroupBoxFiles.SuspendLayout();
            this.GroupBoxCompressor.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonTargetBrowse
            // 
            this.ButtonTargetBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonTargetBrowse.Location = new System.Drawing.Point(688, 25);
            this.ButtonTargetBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonTargetBrowse.Name = "ButtonTargetBrowse";
            this.ButtonTargetBrowse.Size = new System.Drawing.Size(112, 35);
            this.ButtonTargetBrowse.TabIndex = 9;
            this.ButtonTargetBrowse.Text = "Browse...";
            this.ButtonTargetBrowse.UseVisualStyleBackColor = true;
            this.ButtonTargetBrowse.Click += new System.EventHandler(this.ButtonTargetBrowse_Click);
            // 
            // TextOutput
            // 
            this.TextOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextOutput.BackColor = System.Drawing.Color.White;
            this.TextOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextOutput.Location = new System.Drawing.Point(6, 186);
            this.TextOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextOutput.Multiline = true;
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.ReadOnly = true;
            this.TextOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextOutput.Size = new System.Drawing.Size(794, 189);
            this.TextOutput.TabIndex = 21;
            this.TextOutput.WordWrap = false;
            // 
            // ButtonRun
            // 
            this.ButtonRun.Location = new System.Drawing.Point(242, 143);
            this.ButtonRun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonRun.Name = "ButtonRun";
            this.ButtonRun.Size = new System.Drawing.Size(112, 35);
            this.ButtonRun.TabIndex = 19;
            this.ButtonRun.Text = "Make CAB";
            this.ButtonRun.UseVisualStyleBackColor = true;
            this.ButtonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // LabelOutputFile
            // 
            this.LabelOutputFile.AutoSize = true;
            this.LabelOutputFile.Location = new System.Drawing.Point(8, 32);
            this.LabelOutputFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelOutputFile.Name = "LabelOutputFile";
            this.LabelOutputFile.Size = new System.Drawing.Size(91, 20);
            this.LabelOutputFile.TabIndex = 7;
            this.LabelOutputFile.Text = "Output File:";
            // 
            // TextOutputFile
            // 
            this.TextOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextOutputFile.Location = new System.Drawing.Point(108, 28);
            this.TextOutputFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextOutputFile.Name = "TextOutputFile";
            this.TextOutputFile.Size = new System.Drawing.Size(572, 26);
            this.TextOutputFile.TabIndex = 8;
            // 
            // LabelCompressionType
            // 
            this.LabelCompressionType.AutoSize = true;
            this.LabelCompressionType.Location = new System.Drawing.Point(8, 106);
            this.LabelCompressionType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCompressionType.Name = "LabelCompressionType";
            this.LabelCompressionType.Size = new System.Drawing.Size(144, 20);
            this.LabelCompressionType.TabIndex = 13;
            this.LabelCompressionType.Text = "Compression Type:";
            // 
            // LabelCompressionMemory
            // 
            this.LabelCompressionMemory.AutoSize = true;
            this.LabelCompressionMemory.Location = new System.Drawing.Point(334, 106);
            this.LabelCompressionMemory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCompressionMemory.Name = "LabelCompressionMemory";
            this.LabelCompressionMemory.Size = new System.Drawing.Size(166, 20);
            this.LabelCompressionMemory.TabIndex = 15;
            this.LabelCompressionMemory.Text = "Compression Memory:";
            // 
            // DropdownCompressType
            // 
            this.DropdownCompressType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropdownCompressType.FormattingEnabled = true;
            this.DropdownCompressType.Location = new System.Drawing.Point(159, 103);
            this.DropdownCompressType.Name = "DropdownCompressType";
            this.DropdownCompressType.Size = new System.Drawing.Size(164, 28);
            this.DropdownCompressType.TabIndex = 14;
            this.DropdownCompressType.SelectedIndexChanged += new System.EventHandler(this.DropdownCompressType_SelectedIndexChanged);
            // 
            // DropdownCompressMemory
            // 
            this.DropdownCompressMemory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropdownCompressMemory.Enabled = false;
            this.DropdownCompressMemory.FormattingEnabled = true;
            this.DropdownCompressMemory.Location = new System.Drawing.Point(507, 103);
            this.DropdownCompressMemory.Name = "DropdownCompressMemory";
            this.DropdownCompressMemory.Size = new System.Drawing.Size(112, 28);
            this.DropdownCompressMemory.TabIndex = 16;
            // 
            // GroupBoxFiles
            // 
            this.GroupBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxFiles.Controls.Add(this.FilesListBox);
            this.GroupBoxFiles.Controls.Add(this.SelectAllFiles);
            this.GroupBoxFiles.Controls.Add(this.ClearFiles);
            this.GroupBoxFiles.Controls.Add(this.AddFile);
            this.GroupBoxFiles.Controls.Add(this.AddFolder);
            this.GroupBoxFiles.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxFiles.Name = "GroupBoxFiles";
            this.GroupBoxFiles.Size = new System.Drawing.Size(810, 262);
            this.GroupBoxFiles.TabIndex = 0;
            this.GroupBoxFiles.TabStop = false;
            this.GroupBoxFiles.Text = "Files";
            // 
            // FilesListBox
            // 
            this.FilesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.Location = new System.Drawing.Point(6, 66);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.ScrollAlwaysVisible = true;
            this.FilesListBox.Size = new System.Drawing.Size(794, 188);
            this.FilesListBox.TabIndex = 5;
            // 
            // SelectAllFiles
            // 
            this.SelectAllFiles.Location = new System.Drawing.Point(124, 25);
            this.SelectAllFiles.Name = "SelectAllFiles";
            this.SelectAllFiles.Size = new System.Drawing.Size(112, 35);
            this.SelectAllFiles.TabIndex = 2;
            this.SelectAllFiles.Text = "Deselect All";
            this.SelectAllFiles.UseVisualStyleBackColor = true;
            this.SelectAllFiles.Click += new System.EventHandler(this.SelectAllFiles_Click);
            // 
            // ClearFiles
            // 
            this.ClearFiles.Location = new System.Drawing.Point(6, 25);
            this.ClearFiles.Name = "ClearFiles";
            this.ClearFiles.Size = new System.Drawing.Size(112, 35);
            this.ClearFiles.TabIndex = 1;
            this.ClearFiles.Text = "Clear All";
            this.ClearFiles.UseVisualStyleBackColor = true;
            this.ClearFiles.Click += new System.EventHandler(this.ClearFiles_Click);
            // 
            // AddFile
            // 
            this.AddFile.Location = new System.Drawing.Point(360, 25);
            this.AddFile.Name = "AddFile";
            this.AddFile.Size = new System.Drawing.Size(112, 35);
            this.AddFile.TabIndex = 4;
            this.AddFile.Text = "Add File";
            this.AddFile.UseVisualStyleBackColor = true;
            this.AddFile.Click += new System.EventHandler(this.AddFile_Click);
            // 
            // AddFolder
            // 
            this.AddFolder.Location = new System.Drawing.Point(242, 25);
            this.AddFolder.Name = "AddFolder";
            this.AddFolder.Size = new System.Drawing.Size(112, 35);
            this.AddFolder.TabIndex = 3;
            this.AddFolder.Text = "Add Folder";
            this.AddFolder.UseVisualStyleBackColor = true;
            this.AddFolder.Click += new System.EventHandler(this.AddFolder_Click);
            // 
            // GroupBoxCompressor
            // 
            this.GroupBoxCompressor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxCompressor.Controls.Add(this.ButtonBrowseRoot);
            this.GroupBoxCompressor.Controls.Add(this.TextRootDirectory);
            this.GroupBoxCompressor.Controls.Add(this.LabelRootDirectory);
            this.GroupBoxCompressor.Controls.Add(this.CheckSaveSettings);
            this.GroupBoxCompressor.Controls.Add(this.ButtonClear);
            this.GroupBoxCompressor.Controls.Add(this.ButtonExport);
            this.GroupBoxCompressor.Controls.Add(this.DropdownCompressMemory);
            this.GroupBoxCompressor.Controls.Add(this.ButtonTargetBrowse);
            this.GroupBoxCompressor.Controls.Add(this.TextOutput);
            this.GroupBoxCompressor.Controls.Add(this.LabelCompressionMemory);
            this.GroupBoxCompressor.Controls.Add(this.TextOutputFile);
            this.GroupBoxCompressor.Controls.Add(this.DropdownCompressType);
            this.GroupBoxCompressor.Controls.Add(this.LabelOutputFile);
            this.GroupBoxCompressor.Controls.Add(this.ButtonRun);
            this.GroupBoxCompressor.Controls.Add(this.LabelCompressionType);
            this.GroupBoxCompressor.Location = new System.Drawing.Point(12, 280);
            this.GroupBoxCompressor.Name = "GroupBoxCompressor";
            this.GroupBoxCompressor.Size = new System.Drawing.Size(810, 385);
            this.GroupBoxCompressor.TabIndex = 6;
            this.GroupBoxCompressor.TabStop = false;
            this.GroupBoxCompressor.Text = "Compressor";
            // 
            // ButtonBrowseRoot
            // 
            this.ButtonBrowseRoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBrowseRoot.Location = new System.Drawing.Point(688, 63);
            this.ButtonBrowseRoot.Name = "ButtonBrowseRoot";
            this.ButtonBrowseRoot.Size = new System.Drawing.Size(112, 35);
            this.ButtonBrowseRoot.TabIndex = 12;
            this.ButtonBrowseRoot.Text = "Browse...";
            this.ButtonBrowseRoot.UseVisualStyleBackColor = true;
            this.ButtonBrowseRoot.Click += new System.EventHandler(this.ButtonBrowseRoot_Click);
            // 
            // TextRootDirectory
            // 
            this.TextRootDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextRootDirectory.Location = new System.Drawing.Point(132, 66);
            this.TextRootDirectory.Name = "TextRootDirectory";
            this.TextRootDirectory.Size = new System.Drawing.Size(548, 26);
            this.TextRootDirectory.TabIndex = 11;
            // 
            // LabelRootDirectory
            // 
            this.LabelRootDirectory.AutoSize = true;
            this.LabelRootDirectory.Location = new System.Drawing.Point(8, 71);
            this.LabelRootDirectory.Name = "LabelRootDirectory";
            this.LabelRootDirectory.Size = new System.Drawing.Size(118, 20);
            this.LabelRootDirectory.TabIndex = 10;
            this.LabelRootDirectory.Text = "CAB Root DIR:";
            // 
            // CheckSaveSettings
            // 
            this.CheckSaveSettings.AutoSize = true;
            this.CheckSaveSettings.Location = new System.Drawing.Point(360, 149);
            this.CheckSaveSettings.Margin = new System.Windows.Forms.Padding(2);
            this.CheckSaveSettings.Name = "CheckSaveSettings";
            this.CheckSaveSettings.Size = new System.Drawing.Size(123, 24);
            this.CheckSaveSettings.TabIndex = 20;
            this.CheckSaveSettings.Text = "Save on Exit";
            this.CheckSaveSettings.UseVisualStyleBackColor = true;
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(6, 143);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(112, 35);
            this.ButtonClear.TabIndex = 17;
            this.ButtonClear.Text = "Clear Log";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonExport
            // 
            this.ButtonExport.Location = new System.Drawing.Point(124, 143);
            this.ButtonExport.Name = "ButtonExport";
            this.ButtonExport.Size = new System.Drawing.Size(112, 35);
            this.ButtonExport.TabIndex = 18;
            this.ButtonExport.Text = "Export Log";
            this.ButtonExport.UseVisualStyleBackColor = true;
            this.ButtonExport.Click += new System.EventHandler(this.ButtonExport_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu,
            this.LabelVersion,
            this.LabelOutputStatus});
            this.StatusStrip.Location = new System.Drawing.Point(0, 670);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.StatusStrip.Size = new System.Drawing.Size(834, 32);
            this.StatusStrip.TabIndex = 22;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // MainMenu
            // 
            this.MainMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAbout,
            this.MenuHelp,
            this.Separator2,
            this.MenuSave,
            this.Separator1,
            this.Exit});
            this.MainMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(78, 29);
            this.MainMenu.Text = "Menu";
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(270, 34);
            this.MenuAbout.Text = "About";
            this.MenuAbout.Click += new System.EventHandler(this.MenuAbout_Click);
            // 
            // MenuHelp
            // 
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(270, 34);
            this.MenuHelp.Text = "Help";
            this.MenuHelp.Click += new System.EventHandler(this.MenuHelp_Click);
            // 
            // Separator2
            // 
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(217, 6);
            // 
            // MenuSave
            // 
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.Size = new System.Drawing.Size(220, 34);
            this.MenuSave.Text = "Save Settings";
            this.MenuSave.Click += new System.EventHandler(this.MenuSave_Click);
            // 
            // Separator1
            // 
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(217, 6);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(220, 34);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LabelVersion
            // 
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(0, 25);
            // 
            // LabelOutputStatus
            // 
            this.LabelOutputStatus.Name = "LabelOutputStatus";
            this.LabelOutputStatus.Size = new System.Drawing.Size(0, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 702);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.GroupBoxFiles);
            this.Controls.Add(this.GroupBoxCompressor);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(668, 758);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CabMaker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBoxFiles.ResumeLayout(false);
            this.GroupBoxCompressor.ResumeLayout(false);
            this.GroupBoxCompressor.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonTargetBrowse;
        private System.Windows.Forms.TextBox TextOutput;
        private System.Windows.Forms.Button ButtonRun;
        private System.Windows.Forms.Label LabelOutputFile;
        private System.Windows.Forms.TextBox TextOutputFile;
        private System.Windows.Forms.Label LabelCompressionType;
        private System.Windows.Forms.Label LabelCompressionMemory;
        private System.Windows.Forms.ComboBox DropdownCompressType;
        private System.Windows.Forms.ComboBox DropdownCompressMemory;
        private System.Windows.Forms.GroupBox GroupBoxFiles;
        private System.Windows.Forms.Button AddFolder;
        private System.Windows.Forms.Button SelectAllFiles;
        private System.Windows.Forms.Button ClearFiles;
        private System.Windows.Forms.Button AddFile;
        private System.Windows.Forms.GroupBox GroupBoxCompressor;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel LabelOutputStatus;
        private System.Windows.Forms.ToolStripStatusLabel LabelVersion;
        private System.Windows.Forms.CheckedListBox FilesListBox;
        private System.Windows.Forms.Button ButtonExport;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.CheckBox CheckSaveSettings;
        private System.Windows.Forms.Button ButtonBrowseRoot;
        private System.Windows.Forms.TextBox TextRootDirectory;
        private System.Windows.Forms.Label LabelRootDirectory;
        private System.Windows.Forms.ToolStripSplitButton MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripSeparator Separator2;
        private System.Windows.Forms.ToolStripMenuItem MenuSave;
    }
}

