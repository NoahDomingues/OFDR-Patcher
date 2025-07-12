using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace OFDR_v1._02_Patcher
{
    public partial class OFDRPatcher : Form
    {
        public OFDRPatcher()
        {
            InitializeComponent();
        }

        private void OFDRPatcher_Load(object sender, EventArgs e)
        {
            background.SendToBack();
            githubLink.BackColor = Color.Transparent;
            githubLink.Parent = background;
            discordLink.BackColor = Color.Transparent;
            discordLink.Parent = background;
            patchButton.BackColor = Color.Transparent;
            patchButton.Parent = background;
            unpatchButton.BackColor = Color.Transparent;
            unpatchButton.Parent = background;
            manualPatchButton.BackColor = Color.Transparent;
            manualPatchButton.Parent = background;
            manualUnpatchButton.BackColor = Color.Transparent;
            manualUnpatchButton.Parent = background;
            infoButton.BackColor = Color.Transparent;
            infoButton.Parent = background;
            patcherLogo.BackColor = Color.Transparent;
            patcherLogo.Parent = background;
        }

        // Patch game
        public void PatchGame(string inputDirectory)
        {
            string targetFile = Path.Combine(inputDirectory, "OFDR.exe");
            string backupFile = Path.Combine(inputDirectory, "OFDR.exe.bak");

            // Step 0: Starting
            UpdateStatus(0, "Starting patch process...");

            // Check if OFDR.exe exists
            if (!File.Exists(targetFile))
            {
                UpdateStatus(0, "Error: OFDR.exe not found in the selected directory.");
                MessageBox.Show("Error: OFDR.exe not found in the selected directory.", "Patch Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Step 1: Backup
                File.Move(targetFile, backupFile);
                UpdateStatus(30, "Original file backed up as OFDR.exe.bak.");

                // Step 2: Write embedded OFDR.exe
                var assembly = Assembly.GetExecutingAssembly();
                using (Stream resourceStream = assembly.GetManifestResourceStream("OFDR_v1._02_Patcher.Resources.OFDR.exe"))
                {
                    if (resourceStream == null)
                    {
                        UpdateStatus(40, "Error: Embedded resource not found.");
                        throw new FileNotFoundException("Embedded resource not found.");
                    }

                    using (FileStream fileStream = new FileStream(targetFile, FileMode.Create, FileAccess.Write))
                    {
                        resourceStream.CopyTo(fileStream);
                    }
                }

                // Step 3: Complete
                UpdateStatus(100, "Game patched successfully!");
                MessageBox.Show("Game patched successfully!", "Patch Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PromptToJoinDiscord();
            }
            catch (Exception ex)
            {
                UpdateStatus(0, $"An error occurred while patching: {ex.Message}");
                MessageBox.Show($"An error occurred while patching:\n{ex.Message}", "Patch Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PromptToJoinDiscord();
            }
        }

        // Unpatch game
        public void UnpatchGame(string inputDirectory)
        {
            string patchedFile = Path.Combine(inputDirectory, "OFDR.exe");
            string backupFile = Path.Combine(inputDirectory, "OFDR.exe.bak");

            // Step 0: Starting
            UpdateStatus(0, "Starting unpatch process...");

            // Check if backup file exists
            if (!File.Exists(backupFile))
            {
                UpdateStatus(0, "Error: No backup found. Cannot unpatch.");
                MessageBox.Show("Error: No backup found. Cannot unpatch.", "Unpatch Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Step 1: Delete patched file
                if (File.Exists(patchedFile))
                {
                    File.Delete(patchedFile);
                    UpdateStatus(40, "Patched file OFDR.exe removed.");
                }

                // Step 2: Restore backup
                File.Move(backupFile, patchedFile);
                UpdateStatus(100, "Game unpatched successfully!");

                MessageBox.Show("Game unpatched successfully!", "Unpatch Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PromptToJoinDiscord();
            }
            catch (Exception ex)
            {
                UpdateStatus(0, $"An error occurred while unpatching: {ex.Message}");
                MessageBox.Show($"An error occurred while unpatching:\n{ex.Message}", "Unpatch Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PromptToJoinDiscord();
            }
        }

        // Link labels for Discord and GitHub
        private void discordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://discord.gg/Z88NnTgpWU",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link: " + ex.Message);
            }
        }

        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com/NoahDomingues/OFDR-Patcher",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link: " + ex.Message);
            }
        }

        private void manualPatchButton_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select your game installation directory";
                folderDialog.ShowNewFolderButton = false;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;
                    PatchGame(selectedPath);
                }
                else
                {
                    UpdateStatus(0, "Patch canceled: no directory selected.");
                }
            }
        }

        private void patcherLogo_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://discord.gg/Z88NnTgpWU",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link: " + ex.Message);
            }
        }

        // Helper method to update status
        private void UpdateStatus(int progressValue, string logMessage)
        {
            // Clamp progress value between 0 and 100
            progressValue = Math.Min(100, Math.Max(0, progressValue));

            // Update progress bar safely
            progressBar.Value = progressValue;

            // Append timestamped message to the log box
            logBox.AppendText($"[{DateTime.Now:HH:mm:ss}] {logMessage}{Environment.NewLine}");

            // Optional: auto-scroll to the latest message
            logBox.SelectionStart = logBox.Text.Length;
            logBox.ScrollToCaret();
        }


        // Button hover effects

        private void manualPatchButton_MouseEnter(object sender, EventArgs e)
        {
            manualPatchButton.Image = Properties.Resources.folder_hover;
        }

        private void manualPatchButton_MouseLeave(object sender, EventArgs e)
        {
            manualPatchButton.Image = Properties.Resources.folder;
        }

        private void manualUnpatchButton_MouseEnter(object sender, EventArgs e)
        {
            manualUnpatchButton.Image = Properties.Resources.folder_hover;
        }

        private void manualUnpatchButton_MouseLeave(object sender, EventArgs e)
        {
            manualUnpatchButton.Image = Properties.Resources.folder;
        }

        private void patchButton_MouseEnter(object sender, EventArgs e)
        {
            patchButton.BackColor = Color.FromArgb(253, 239, 64);
        }

        private void patchButton_MouseLeave(object sender, EventArgs e)
        {
            patchButton.BackColor = Color.Transparent;
        }

        private void unpatchButton_MouseEnter(object sender, EventArgs e)
        {
            unpatchButton.BackColor = Color.FromArgb(253, 239, 64);
        }

        private void unpatchButton_MouseLeave(object sender, EventArgs e)
        {
            unpatchButton.BackColor = Color.Transparent;
        }

        private void infoButton_MouseEnter(object sender, EventArgs e)
        {
            infoButton.Image = Properties.Resources.info_hover;
        }

        private void infoButton_MouseLeave(object sender, EventArgs e)
        {
            infoButton.Image = Properties.Resources.info;
        }

        // MOVE FROM HERE

        private void PromptToJoinDiscord()
        {
            DialogResult result = MessageBox.Show(
                "Join the official Operation Flashpoint Discord — squad up, strategize, and join epic battles with fellow OFP players!",
                "Join our Discord community",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    System.Diagnostics.Process.Start(new ProcessStartInfo
                    {
                        FileName = "https://discord.gg/Z88NnTgpWU",
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open link: " + ex.Message);
                }
            }
        }


        private void patchButton_Click(object sender, EventArgs e)
        {
            // Potential default install locations
            string[] installPaths =
            {
        @"C:\Program Files (x86)\Steam\steamapps\common\Operation Flashpoint Dragon Rising",
        @"C:\Program Files\Codemasters\Operation Flashpoint Dragon Rising",
        @"C:\Program Files (x86)\Codemasters\Operation Flashpoint Dragon Rising"
    };

            string detectedPath = null;

            // Try each location until OFDR.exe is found
            foreach (string path in installPaths)
            {
                if (File.Exists(Path.Combine(path, "OFDR.exe")))
                {
                    detectedPath = path;
                    break;
                }
            }

            if (detectedPath != null)
            {
                PatchGame(detectedPath);
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "Could not auto-detect the game installation directory.\n\nWould you like to manually locate it?",
                    "Game Not Found",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    manualPatchButton_Click(manualPatchButton, EventArgs.Empty); // Trigger manual patch logic
                }
                else
                {
                    UpdateStatus(0, "Patch canceled: game directory not found.");
                }
            }
        }

        private void manualUnpatchButton_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select your game installation directory";
                folderDialog.ShowNewFolderButton = false;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;
                    UnpatchGame(selectedPath); // Call the unpatch method with the selected folder
                }
                else
                {
                    UpdateStatus(0, "Unpatch canceled: no directory selected.");
                }
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            using (var info = new Info())
            {
                info.ShowDialog(this); // opens the Info form modally, centered on parent
            }
        }

        private void unpatchButton_Click(object sender, EventArgs e)
        {
            // Common install locations to check
            string[] installPaths =
            {
                @"C:\Program Files (x86)\Steam\steamapps\common\Operation Flashpoint Dragon Rising",
                @"C:\Program Files\Codemasters\Operation Flashpoint Dragon Rising",
                @"C:\Program Files (x86)\Codemasters\Operation Flashpoint Dragon Rising"
            };

            string detectedPath = null;

            // Try to find OFDR.exe.bak (since that's needed for unpatch)
            foreach (string path in installPaths)
            {
                if (File.Exists(Path.Combine(path, "OFDR.exe.bak")))
                {
                    detectedPath = path;
                    break;
                }
            }

            if (detectedPath != null)
            {
                UnpatchGame(detectedPath);
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "Could not auto-detect the game installation directory.\n\nWould you like to manually locate your game folder?",
                    "Unpatch Source Not Found",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    manualUnpatchButton_Click(manualUnpatchButton, EventArgs.Empty);
                }
                else
                {
                    UpdateStatus(0, "Unpatch canceled: no valid backup found.");
                }
            }
        }
    }
}
