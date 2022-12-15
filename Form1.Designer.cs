using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
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
            this.ComboRootDir = new System.Windows.Forms.ComboBox();
            this.CheckDeleteSidecars = new System.Windows.Forms.CheckBox();
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
            this.LabelOutputStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.GroupBoxFiles.SuspendLayout();
            this.GroupBoxCompressor.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonTargetBrowse
            // 
            this.ButtonTargetBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonTargetBrowse.Location = new System.Drawing.Point(335, 16);
            this.ButtonTargetBrowse.Name = "ButtonTargetBrowse";
            this.ButtonTargetBrowse.Size = new System.Drawing.Size(75, 23);
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
            this.TextOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextOutput.Location = new System.Drawing.Point(4, 121);
            this.TextOutput.Multiline = true;
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.ReadOnly = true;
            this.TextOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextOutput.Size = new System.Drawing.Size(426, 124);
            this.TextOutput.TabIndex = 22;
            this.TextOutput.WordWrap = false;
            // 
            // ButtonRun
            // 
            this.ButtonRun.Location = new System.Drawing.Point(161, 93);
            this.ButtonRun.Name = "ButtonRun";
            this.ButtonRun.Size = new System.Drawing.Size(75, 23);
            this.ButtonRun.TabIndex = 19;
            this.ButtonRun.Text = "Make CAB";
            this.ToolTip.SetToolTip(this.ButtonRun, "Create a Cabinet with the above specifications");
            this.ButtonRun.UseVisualStyleBackColor = true;
            this.ButtonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // LabelOutputFile
            // 
            this.LabelOutputFile.AutoSize = true;
            this.LabelOutputFile.Location = new System.Drawing.Point(5, 21);
            this.LabelOutputFile.Name = "LabelOutputFile";
            this.LabelOutputFile.Size = new System.Drawing.Size(61, 13);
            this.LabelOutputFile.TabIndex = 7;
            this.LabelOutputFile.Text = "Output File:";
            this.ToolTip.SetToolTip(this.LabelOutputFile, "The location where the Cabinet will be placed");
            // 
            // TextOutputFile
            // 
            this.TextOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextOutputFile.Location = new System.Drawing.Point(72, 18);
            this.TextOutputFile.Name = "TextOutputFile";
            this.TextOutputFile.Size = new System.Drawing.Size(257, 20);
            this.TextOutputFile.TabIndex = 8;
            // 
            // LabelCompressionType
            // 
            this.LabelCompressionType.AutoSize = true;
            this.LabelCompressionType.Location = new System.Drawing.Point(5, 70);
            this.LabelCompressionType.Name = "LabelCompressionType";
            this.LabelCompressionType.Size = new System.Drawing.Size(97, 13);
            this.LabelCompressionType.TabIndex = 13;
            this.LabelCompressionType.Text = "Compression Type:";
            // 
            // LabelCompressionMemory
            // 
            this.LabelCompressionMemory.AutoSize = true;
            this.LabelCompressionMemory.Location = new System.Drawing.Point(186, 70);
            this.LabelCompressionMemory.Name = "LabelCompressionMemory";
            this.LabelCompressionMemory.Size = new System.Drawing.Size(110, 13);
            this.LabelCompressionMemory.TabIndex = 15;
            this.LabelCompressionMemory.Text = "Compression Memory:";
            // 
            // DropdownCompressType
            // 
            this.DropdownCompressType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropdownCompressType.FormattingEnabled = true;
            this.DropdownCompressType.Location = new System.Drawing.Point(106, 67);
            this.DropdownCompressType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DropdownCompressType.Name = "DropdownCompressType";
            this.DropdownCompressType.Size = new System.Drawing.Size(75, 21);
            this.DropdownCompressType.TabIndex = 14;
            this.ToolTip.SetToolTip(this.DropdownCompressType, "Compression Algorithm used for the Cabinet");
            this.DropdownCompressType.SelectedIndexChanged += new System.EventHandler(this.DropdownCompressType_SelectedIndexChanged);
            // 
            // DropdownCompressMemory
            // 
            this.DropdownCompressMemory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropdownCompressMemory.Enabled = false;
            this.DropdownCompressMemory.FormattingEnabled = true;
            this.DropdownCompressMemory.Location = new System.Drawing.Point(301, 67);
            this.DropdownCompressMemory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DropdownCompressMemory.Name = "DropdownCompressMemory";
            this.DropdownCompressMemory.Size = new System.Drawing.Size(75, 21);
            this.DropdownCompressMemory.TabIndex = 16;
            this.ToolTip.SetToolTip(this.DropdownCompressMemory, "Memory Chunk Units for the LZX Cabinet");
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
            this.GroupBoxFiles.Location = new System.Drawing.Point(8, 8);
            this.GroupBoxFiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBoxFiles.Name = "GroupBoxFiles";
            this.GroupBoxFiles.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBoxFiles.Size = new System.Drawing.Size(433, 170);
            this.GroupBoxFiles.TabIndex = 0;
            this.GroupBoxFiles.TabStop = false;
            this.GroupBoxFiles.Text = "Files";
            // 
            // FilesListBox
            // 
            this.FilesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.Location = new System.Drawing.Point(4, 43);
            this.FilesListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.ScrollAlwaysVisible = true;
            this.FilesListBox.Size = new System.Drawing.Size(426, 122);
            this.FilesListBox.TabIndex = 5;
            this.ToolTip.SetToolTip(this.FilesListBox, "Checked items in the File List will be added to your Cabinet");
            // 
            // SelectAllFiles
            // 
            this.SelectAllFiles.Location = new System.Drawing.Point(83, 16);
            this.SelectAllFiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectAllFiles.Name = "SelectAllFiles";
            this.SelectAllFiles.Size = new System.Drawing.Size(75, 23);
            this.SelectAllFiles.TabIndex = 2;
            this.SelectAllFiles.Text = "Deselect All";
            this.ToolTip.SetToolTip(this.SelectAllFiles, "Batch select/deselect the contents of the File List");
            this.SelectAllFiles.UseVisualStyleBackColor = true;
            this.SelectAllFiles.Click += new System.EventHandler(this.SelectAllFiles_Click);
            // 
            // ClearFiles
            // 
            this.ClearFiles.Location = new System.Drawing.Point(4, 16);
            this.ClearFiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearFiles.Name = "ClearFiles";
            this.ClearFiles.Size = new System.Drawing.Size(75, 23);
            this.ClearFiles.TabIndex = 1;
            this.ClearFiles.Text = "Clear All";
            this.ToolTip.SetToolTip(this.ClearFiles, "Clear the contents of the File List");
            this.ClearFiles.UseVisualStyleBackColor = true;
            this.ClearFiles.Click += new System.EventHandler(this.ClearFiles_Click);
            // 
            // AddFile
            // 
            this.AddFile.Location = new System.Drawing.Point(240, 16);
            this.AddFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddFile.Name = "AddFile";
            this.AddFile.Size = new System.Drawing.Size(75, 23);
            this.AddFile.TabIndex = 4;
            this.AddFile.Text = "Add Files";
            this.ToolTip.SetToolTip(this.AddFile, "Add specific file(s) to the File List");
            this.AddFile.UseVisualStyleBackColor = true;
            this.AddFile.Click += new System.EventHandler(this.AddFile_Click);
            // 
            // AddFolder
            // 
            this.AddFolder.Location = new System.Drawing.Point(161, 16);
            this.AddFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddFolder.Name = "AddFolder";
            this.AddFolder.Size = new System.Drawing.Size(75, 23);
            this.AddFolder.TabIndex = 3;
            this.AddFolder.Text = "Add Folder";
            this.ToolTip.SetToolTip(this.AddFolder, "Add a folder and its contents to the File List");
            this.AddFolder.UseVisualStyleBackColor = true;
            this.AddFolder.Click += new System.EventHandler(this.AddFolder_Click);
            // 
            // GroupBoxCompressor
            // 
            this.GroupBoxCompressor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxCompressor.Controls.Add(this.ComboRootDir);
            this.GroupBoxCompressor.Controls.Add(this.CheckDeleteSidecars);
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
            this.GroupBoxCompressor.Location = new System.Drawing.Point(8, 182);
            this.GroupBoxCompressor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBoxCompressor.Name = "GroupBoxCompressor";
            this.GroupBoxCompressor.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBoxCompressor.Size = new System.Drawing.Size(433, 250);
            this.GroupBoxCompressor.TabIndex = 6;
            this.GroupBoxCompressor.TabStop = false;
            this.GroupBoxCompressor.Text = "Compressor";
            // 
            // ComboRootDir
            // 
            this.ComboRootDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboRootDir.FormattingEnabled = true;
            this.ComboRootDir.Location = new System.Drawing.Point(72, 40);
            this.ComboRootDir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboRootDir.Name = "ComboRootDir";
            this.ComboRootDir.Size = new System.Drawing.Size(337, 21);
            this.ComboRootDir.TabIndex = 23;
            // 
            // CheckDeleteSidecars
            // 
            this.CheckDeleteSidecars.AutoSize = true;
            this.CheckDeleteSidecars.Location = new System.Drawing.Point(325, 97);
            this.CheckDeleteSidecars.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckDeleteSidecars.Name = "CheckDeleteSidecars";
            this.CheckDeleteSidecars.Size = new System.Drawing.Size(101, 17);
            this.CheckDeleteSidecars.TabIndex = 21;
            this.CheckDeleteSidecars.Text = "Delete Sidecars";
            this.ToolTip.SetToolTip(this.CheckDeleteSidecars, "Deletes temporary files after job");
            this.CheckDeleteSidecars.UseVisualStyleBackColor = true;
            // 
            // LabelRootDirectory
            // 
            this.LabelRootDirectory.AutoSize = true;
            this.LabelRootDirectory.Location = new System.Drawing.Point(5, 42);
            this.LabelRootDirectory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelRootDirectory.Name = "LabelRootDirectory";
            this.LabelRootDirectory.Size = new System.Drawing.Size(55, 13);
            this.LabelRootDirectory.TabIndex = 10;
            this.LabelRootDirectory.Text = "Root DIR:";
            this.ToolTip.SetToolTip(this.LabelRootDirectory, "The location of the first directory of the Cabinet");
            // 
            // CheckSaveSettings
            // 
            this.CheckSaveSettings.AutoSize = true;
            this.CheckSaveSettings.Location = new System.Drawing.Point(240, 97);
            this.CheckSaveSettings.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CheckSaveSettings.Name = "CheckSaveSettings";
            this.CheckSaveSettings.Size = new System.Drawing.Size(86, 17);
            this.CheckSaveSettings.TabIndex = 20;
            this.CheckSaveSettings.Text = "Save on Exit";
            this.ToolTip.SetToolTip(this.CheckSaveSettings, "Saves CabMaker User Settings on Exit");
            this.CheckSaveSettings.UseVisualStyleBackColor = true;
            this.CheckSaveSettings.CheckedChanged += new System.EventHandler(this.CheckSaveSettings_CheckedChanged);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(4, 93);
            this.ButtonClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(75, 23);
            this.ButtonClear.TabIndex = 17;
            this.ButtonClear.Text = "Clear";
            this.ToolTip.SetToolTip(this.ButtonClear, "Clear the contents of all settings");
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonExport
            // 
            this.ButtonExport.Location = new System.Drawing.Point(83, 93);
            this.ButtonExport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonExport.Name = "ButtonExport";
            this.ButtonExport.Size = new System.Drawing.Size(75, 23);
            this.ButtonExport.TabIndex = 18;
            this.ButtonExport.Text = "Export Log";
            this.ToolTip.SetToolTip(this.ButtonExport, "Export the contents of the Log Box to a file");
            this.ButtonExport.UseVisualStyleBackColor = true;
            this.ButtonExport.Click += new System.EventHandler(this.ButtonExport_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu,
            this.LabelOutputStatus});
            this.StatusStrip.Location = new System.Drawing.Point(0, 434);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.StatusStrip.Size = new System.Drawing.Size(449, 22);
            this.StatusStrip.TabIndex = 23;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // MainMenu
            // 
            this.MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            this.MainMenu.Size = new System.Drawing.Size(54, 20);
            this.MainMenu.Text = "Menu";
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(143, 22);
            this.MenuAbout.Text = "About";
            this.MenuAbout.Click += new System.EventHandler(this.MenuAbout_Click);
            // 
            // MenuHelp
            // 
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(143, 22);
            this.MenuHelp.Text = "Help";
            this.MenuHelp.Click += new System.EventHandler(this.MenuHelp_Click);
            // 
            // Separator2
            // 
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(140, 6);
            // 
            // MenuSave
            // 
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.Size = new System.Drawing.Size(143, 22);
            this.MenuSave.Text = "Save Settings";
            this.MenuSave.ToolTipText = "Manually save CabMaker User Settings";
            this.MenuSave.Click += new System.EventHandler(this.MenuSave_Click);
            // 
            // Separator1
            // 
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(140, 6);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(143, 22);
            this.Exit.Text = "Exit";
            this.Exit.ToolTipText = "Exit CabMaker";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LabelOutputStatus
            // 
            this.LabelOutputStatus.Name = "LabelOutputStatus";
            this.LabelOutputStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkRate = 500;
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.ErrorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 456);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.GroupBoxFiles);
            this.Controls.Add(this.GroupBoxCompressor);
            this.MinimumSize = new System.Drawing.Size(463, 448);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBoxFiles.ResumeLayout(false);
            this.GroupBoxCompressor.ResumeLayout(false);
            this.GroupBoxCompressor.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
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
        private System.Windows.Forms.CheckedListBox FilesListBox;
        private System.Windows.Forms.Button ButtonExport;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.CheckBox CheckSaveSettings;
        private System.Windows.Forms.Label LabelRootDirectory;
        private System.Windows.Forms.ToolStripSplitButton MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripSeparator Separator2;
        private System.Windows.Forms.ToolStripMenuItem MenuSave;
        private CheckBox CheckDeleteSidecars;
        private ToolTip ToolTip;
        private ErrorProvider ErrorProvider;
        private ComboBox ComboRootDir;
    }
}

