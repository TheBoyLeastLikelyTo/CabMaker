using CabMaker.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CabMaker
{
    public partial class Form1 : Form
    {
        private const int MAX_LINES_IN_DDF = 1024;
        private const int EXIT_CODE_SUCCESS = 0;

        public Form1()
        {
            InitializeComponent();
        }

        int jobFiles = 0;
        int successFiles = 0;
        string txtTargetDir = "";
        string UserSettingsFile = $"{Application.ProductName}.dat";

        private bool IncludeCompressionWindowSize =>
            !Constants.DefaultCompressionType.ToString().Equals(DropdownCompressType.Items[DropdownCompressType.SelectedIndex]) &&
            !CompressionType.NONE.ToString().Equals(DropdownCompressType.SelectedItem);

        private void ClearFiles_Click(object sender, EventArgs e)
        {
            FilesListBox.Items.Clear();
            ComboRootDir.Items.Clear();
            ErrorProvider.Clear();
            jobFiles = 0;
            LabelOutputStatus.Text = "[JOB] " + jobFiles + " Files Imported";
            GroupBoxFiles.Text = "Files";
        }

        private void SelectAllFiles_Click(object sender, EventArgs e)
        {
            if (FilesListBox.Items.Count > 0)
            {
                bool AllFilesSelected = false;
                if (SelectAllFiles.Text == "Select All")
                {
                    AllFilesSelected = true;
                    SelectAllFiles.Text = "Deselect All";
                }
                else if (SelectAllFiles.Text == "Deselect All")
                {
                    AllFilesSelected = false;
                    SelectAllFiles.Text = "Select All";
                }
                int count = FilesListBox.Items.Count;
                for (int i = 0; i < count; i++)
                    FilesListBox.SetItemChecked(i, AllFilesSelected);
            }
        }

        private void AddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog;
            folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var files = Directory.GetFiles(folderDialog.SelectedPath, "*", SearchOption.AllDirectories);
                    foreach (string fileName in files)
                    {
                        FilesListBox.Items.Add(fileName, true);
                        jobFiles += 1;
                        ComboRootDir.Items.Add(Path.GetDirectoryName(fileName));
                    }
                    CleanComboContents();
                    LabelOutputStatus.Text = "[JOB] " + jobFiles + " Files Imported";
                    GroupBoxFiles.Text = "Files" + " [" + jobFiles + " Imported]";
                }
                catch { }
            }
        }

        private void AddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile;
            openFile = new OpenFileDialog
            {
                Multiselect = true
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFile.FileNames)
                {
                    FilesListBox.Items.Add(fileName, true);
                    jobFiles += 1;
                    ComboRootDir.Items.Add(Path.GetDirectoryName(fileName));
                }
                CleanComboContents();
                LabelOutputStatus.Text = "[JOB] " + jobFiles + " Files Imported";
                GroupBoxFiles.Text = "Files [" + jobFiles + " Files Imported]";
            }
        }

        private void CleanComboContents()
        {
            ComboRootDir.Text = "";
            ComboRootDir.Items.Clear();
            foreach (string item in FilesListBox.CheckedItems)
            {
                DirectoryInfo parent = Directory.GetParent(item);
                while (parent != null)
                {
                    ComboRootDir.Items.Add(parent.FullName);
                    parent = parent.Parent;
                }
            }
            List<string> UniqueContents = ComboRootDir.Items.Cast<string>().Distinct().ToList();
            ComboRootDir.Items.Clear();
            foreach (string item in UniqueContents)
            {
                ComboRootDir.Items.Add(item);
            }
            ComboRootDir.SelectedIndex = 0;
        }

        private void ButtonTargetBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "Cabinet Files|*.cab"
            };
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                TextOutputFile.Text = saveFile.FileName;
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            TextOutput.Clear();
            ComboRootDir.Text = "";
            txtTargetDir = "";
            TextOutputFile.Text = "";
            LabelOutputStatus.Text = "[JOB] " + jobFiles + " Files Imported";
        }

        private void ButtonExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Text Files|*.txt"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, TextOutput.Text);
            }
        }

        private List<DdfFileRow> GetFiles(string RootDir)
        {
            List<DdfFileRow> list = new List<DdfFileRow>();
            foreach (string filename in FilesListBox.CheckedItems)
            {
                list.Add(new DdfFileRow()
                {
                    FullName = filename,
                    Path = filename.Replace(RootDir, "").TrimStart('\\')
                });
            }
            return list;
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            jobFiles = FilesListBox.CheckedItems.Count; // Sets count of checked file list to jobFiles
            LabelOutputStatus.Text = "[JOB] Compressing " + jobFiles + " File(s) to CAB..."; // Sends jobFiles to statusBar
            TextOutput.ForeColor = SystemColors.WindowText;

            if (FilesListBox.CheckedItems.Count == 0)
            {
                // If more no files are checked in the FileListBox
                LabelOutputStatus.Text = "[ERROR] No Files Selected";
                ErrorProvider.SetError(AddFile, "Check the files you wish to be sent to the Cabinet");
            }
            else if (String.IsNullOrWhiteSpace(TextOutputFile.Text))
            {
                // If TextOutputFile is empty
                LabelOutputStatus.Text = "[ERROR] Please Specify the Target File";
                ErrorProvider.SetError(ButtonTargetBrowse, "Specify where your Cabinet should be placed");
            }
            else if (String.IsNullOrEmpty(ComboRootDir.Text))
            {
                // If ComboRootDir does not contain a checked item from FileListBox
                LabelOutputStatus.Text = "[ERROR] Root DIR is Out of Range";
                ErrorProvider.SetError(ComboRootDir, "Root DIR must be a parent of all files");
            }
            else if (String.IsNullOrEmpty(DropdownCompressType.Text))
            {
                // If DropdownCompressType is empty
                LabelOutputStatus.Text = "[ERROR] Please Specify the Compression Type";
            }
            else if (FilesListBox.CheckedItems.Count > MAX_LINES_IN_DDF)
            {
                // If more files than DDF supports are selected
                LabelOutputStatus.Text = "[ERROR] DDF Max Files Limit (" + MAX_LINES_IN_DDF + ") has been reached";
                ErrorProvider.SetError(AddFile, "There must be less than " + MAX_LINES_IN_DDF + " files selected.");
            }
            else
            {
                try
                {
                    string ddfPath = Path.Combine(TextOutputFile.Text + ".ddf");

                    // Build DDF file
                    bool compress = !CompressionType.NONE.ToString().Equals(DropdownCompressType.SelectedItem);
                    string compressValue = compress ? "on" : "off";

                    StringBuilder ddf = new StringBuilder();
                    ddf.AppendLine($@";*** MakeCAB Directive file;
.OPTION EXPLICIT
.Set CabinetNameTemplate={TextOutputFile.Text.EnsureQuoted()}
.Set DiskDirectory1={txtTargetDir.EnsureQuoted()}
.Set MaxDiskSize=0
.Set Cabinet=on
.Set Compress={compressValue}");

                    if (compress)
                    {
                        ddf.AppendLine($".Set CompressionType={DropdownCompressType.SelectedItem ?? Constants.DefaultCompressionType}");
                    }

                    if (IncludeCompressionWindowSize)
                    {
                        ddf.AppendFormat($".Set CompressionMemory={(DropdownCompressMemory.SelectedItem as CompressionWindowSize ?? Constants.DefaultCompressionWindowSize).Exponent}");
                        ddf.AppendLine();
                    }

                    ddf.AppendLine();

                    int ddfHeaderLines = ddf.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).Length;
                    int maxFiles = MAX_LINES_IN_DDF - ddfHeaderLines; // only write enough files to hit the max # of lines allowed in a DDF (blank lines don't count)

                    // Disable form UI elements
                    DisableForm(true);

                    List<DdfFileRow> ddfFiles = GetFiles(ComboRootDir.Text);
                    foreach (var ddfFile in ddfFiles.Take(maxFiles))
                    {
                        if (ddfFile.FullName.Contains(ComboRootDir.Text))
                        {
                            successFiles += 1;
                            ddf.AppendFormat("\"{0}\" \"{1}\"{2}", ddfFile.FullName, ddfFile.Path, Environment.NewLine);
                        }
                        else
                        {
                            ErrorProvider.SetError(ComboRootDir, "Root DIR must be a parent of all selected files, some files were not sent to CAB");
                        }
                    }

                    System.IO.File.WriteAllText(ddfPath, ddf.ToString(), Encoding.Default);
                    string cmd = String.Format("/f {0}", ddfPath.EnsureQuoted());

                    // Run "makecab.exe"
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        CreateNoWindow = true,
                        FileName = "makecab.exe",
                        Arguments = cmd,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false
                    };
                    process.StartInfo = startInfo;

                    process.ErrorDataReceived += Process_ErrorDataReceived;
                    process.OutputDataReceived += Process_OutputDataReceived;

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                    process.WaitForExit();

                    if (process.ExitCode == EXIT_CODE_SUCCESS)
                    {
                        System.IO.File.SetLastWriteTime((TextOutputFile.Text), DateTime.Now);
                        LabelOutputStatus.Text = "[JOB] " + successFiles + " of " + jobFiles + " File(s) Successfully Sent to CAB";
                        if (CheckDeleteSidecars.Checked == true)
                        {
                            System.IO.File.Delete(@".\setup.inf");
                            System.IO.File.Delete(@".\setup.rpt");
                            System.IO.File.Delete(TextOutputFile.Text + ".ddf");
                        }
                    }
                }
                catch (Exception ex)
                {
                    LabelOutputStatus.Text = "[ERROR] Error Creating CAB File. Check the Log";
                    TextOutput.AppendText("Exit Code: " + ex.ToString() + Environment.NewLine);
                    TextOutput.ForeColor = Color.Red;
                }
            }
            // Enable form UI elements
            DisableForm(false);
            successFiles = 0;
        }

        private void DisableForm(bool disable)
        {
            GroupBoxFiles.Enabled = !disable;
            GroupBoxCompressor.Enabled = !disable;
        }

        // capture output from console stdout to output box on form
        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                if (e.Data != null)
                {
                    TextOutput.AppendText(e.Data + Environment.NewLine);
                }
            });
        }

        // capture output from console stdout to output box on form
        private void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                if (e.Data != null)
                {
                    TextOutput.AppendText(e.Data + Environment.NewLine);
                    TextOutput.ForeColor = Color.Red;
                }
            });
        }

        private void SaveSettings(bool save)
        {
            IsolatedStorageFile storage = IsolatedStorageFile.GetStore(
                IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);

            UserSettings settings = new UserSettings()
            {
                OutputFile = (save ? TextOutputFile.Text : ""),
                CompressionType = (save ? DropdownCompressType.SelectedItem : Constants.DefaultCompressionType),
                CompressionWindowSize = (save ? DropdownCompressMemory.SelectedValue : Constants.DefaultCompressionWindowSize.Exponent),
                SaveUserSettings = (save ? CheckSaveSettings.Checked : true),
                DeleteSidecars = (save ? CheckDeleteSidecars.Checked : true)
            };
            storage.SaveObject(settings, UserSettingsFile);
            LabelOutputStatus.Text = "[CabMaker] Compressor Settings Saved to " + UserSettingsFile;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CheckSaveSettings.Checked == true)
            {
                SaveSettings(true);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "CabMaker " + Assembly.GetExecutingAssembly().GetName().Version.ToString(3);
            DropdownCompressType.Items.AddRange(Enum.GetNames(typeof(CompressionType)));
            DropdownCompressType.SelectedIndex = 0;
            DropdownCompressMemory.DataSource = Constants.CompressionWindowSizes;
            DropdownCompressMemory.DisplayMember = "Description";
            DropdownCompressMemory.ValueMember = "Exponent";

            IsolatedStorageFile storage = IsolatedStorageFile.GetStore(
                IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);

            UserSettings settings = storage.LoadObject<UserSettings>(UserSettingsFile);

            if (settings != null)
            {
                TextOutputFile.Text = settings.OutputFile;
                DropdownCompressType.SelectedItem = settings.CompressionType ?? Constants.DefaultCompressionType;
                DropdownCompressMemory.SelectedValue = settings.CompressionWindowSize ?? Constants.DefaultCompressionWindowSize.Exponent;
                CheckSaveSettings.Checked = settings.SaveUserSettings;
                CheckDeleteSidecars.Checked = settings.DeleteSidecars;
            }
            else
            {
                TextOutputFile.Text = "";
                DropdownCompressType.SelectedItem = Constants.DefaultCompressionType;
                DropdownCompressMemory.SelectedValue = Constants.DefaultCompressionWindowSize.Exponent;
                CheckSaveSettings.Checked = false;
                CheckDeleteSidecars.Checked = false;
            }
            LabelOutputStatus.Text = "[JOB] " + jobFiles + " Files Imported";
        }

        private void DropdownCompressType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropdownCompressMemory.Enabled = IncludeCompressionWindowSize;
            DropdownCompressMemory.Visible = IncludeCompressionWindowSize;
            LabelCompressionMemory.Visible = IncludeCompressionWindowSize;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuSettingsSave_Click(object sender, EventArgs e)
        {
            SaveSettings(true);
            
        }

        private void MenuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Based on CabMaker 1.5.2 by GitHub/sapientcoder" + Environment.NewLine + "GUI reworked by GitHub/TheBoyLeastLikelyTo", "About CabMaker " + Assembly.GetExecutingAssembly().GetName().Version.ToString(3), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void MenuHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the 'Add Folder' and 'Add File' buttons in the 'Files' area to add files for your Cabinet into the list box below. When you have added all your input files, go down to the 'Compressor' group, and browse for the location of the 'Output File', where your CAB will be saved. Additionally, If your CAB will contain subfolders, browse for the path of the first folder with 'CAB Root Dir'. When you are ready, select the type of compression the CAB will have (None, MSZIP, or LZX), and click 'Make CAB'. If you wish to save the settings used with the Compressor group, you can check the 'Save on Exit' box, or save the settings manually in the Menu.", "CabMaker " + Assembly.GetExecutingAssembly().GetName().Version.ToString(3) + " Help", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void CheckSaveSettings_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckSaveSettings.Checked == true)
            {
                LabelOutputStatus.Text = "[CabMaker] Compressor Settings Will Save on Exit";
            }
            else if (CheckSaveSettings.Checked == false)
            {
                LabelOutputStatus.Text = "[CabMaker] Compressor Settings Won't Save on Exit";
            }
        }
    }
}
