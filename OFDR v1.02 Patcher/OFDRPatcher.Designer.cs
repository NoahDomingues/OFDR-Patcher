namespace OFDR_v1._02_Patcher
{
    partial class OFDRPatcher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OFDRPatcher));
            discordLink = new LinkLabel();
            githubLink = new LinkLabel();
            backgroundImage = new PictureBox();
            patchButton = new Button();
            unpatchButton = new Button();
            background = new Panel();
            infoButton = new PictureBox();
            manualUnpatchButton = new PictureBox();
            logBox = new TextBox();
            patcherLogo = new PictureBox();
            manualPatchButton = new PictureBox();
            progressBar = new ProgressBar();
            toolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)backgroundImage).BeginInit();
            background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)infoButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)manualUnpatchButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patcherLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)manualPatchButton).BeginInit();
            SuspendLayout();
            // 
            // discordLink
            // 
            discordLink.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            discordLink.AutoSize = true;
            discordLink.LinkColor = Color.White;
            discordLink.Location = new Point(12, 486);
            discordLink.Name = "discordLink";
            discordLink.Size = new Size(89, 16);
            discordLink.TabIndex = 5;
            discordLink.TabStop = true;
            discordLink.Text = "Discord Server";
            discordLink.TextAlign = ContentAlignment.MiddleLeft;
            toolTip.SetToolTip(discordLink, "Join our Discord community");
            discordLink.Click += discordLink_Click;
            // 
            // githubLink
            // 
            githubLink.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            githubLink.AutoSize = true;
            githubLink.LinkColor = Color.White;
            githubLink.Location = new Point(742, 486);
            githubLink.Name = "githubLink";
            githubLink.Size = new Size(46, 16);
            githubLink.TabIndex = 4;
            githubLink.TabStop = true;
            githubLink.Text = "GitHub";
            githubLink.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(githubLink, "View OFDR Patcher on GitHub");
            githubLink.LinkClicked += githubLink_LinkClicked;
            // 
            // backgroundImage
            // 
            backgroundImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            backgroundImage.BackgroundImageLayout = ImageLayout.Zoom;
            backgroundImage.Image = Properties.Resources.Patcher_bg;
            backgroundImage.Location = new Point(-13, -6);
            backgroundImage.Margin = new Padding(0);
            backgroundImage.Name = "backgroundImage";
            backgroundImage.Size = new Size(0, 0);
            backgroundImage.SizeMode = PictureBoxSizeMode.Zoom;
            backgroundImage.TabIndex = 3;
            backgroundImage.TabStop = false;
            // 
            // patchButton
            // 
            patchButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            patchButton.BackColor = Color.FromArgb(253, 239, 64);
            patchButton.BackgroundImage = Properties.Resources.transparent;
            patchButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patchButton.Location = new Point(243, 287);
            patchButton.Name = "patchButton";
            patchButton.Size = new Size(154, 37);
            patchButton.TabIndex = 6;
            patchButton.Text = "Patch OFDR";
            toolTip.SetToolTip(patchButton, "Upgrade OFDR to v1.02 patched");
            patchButton.UseVisualStyleBackColor = false;
            patchButton.Click += patchButton_Click;
            patchButton.MouseEnter += patchButton_MouseEnter;
            patchButton.MouseLeave += patchButton_MouseLeave;
            // 
            // unpatchButton
            // 
            unpatchButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            unpatchButton.BackColor = Color.FromArgb(253, 239, 64);
            unpatchButton.BackgroundImage = Properties.Resources.transparent;
            unpatchButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            unpatchButton.Location = new Point(403, 287);
            unpatchButton.Name = "unpatchButton";
            unpatchButton.Size = new Size(154, 37);
            unpatchButton.TabIndex = 7;
            unpatchButton.Text = "Unpatch OFDR";
            toolTip.SetToolTip(unpatchButton, "Restore patched OFDR to its original state");
            unpatchButton.UseVisualStyleBackColor = false;
            unpatchButton.Click += unpatchButton_Click;
            unpatchButton.MouseEnter += unpatchButton_MouseEnter;
            unpatchButton.MouseLeave += unpatchButton_MouseLeave;
            // 
            // background
            // 
            background.BackgroundImage = Properties.Resources.patcher_background;
            background.BackgroundImageLayout = ImageLayout.Zoom;
            background.Controls.Add(infoButton);
            background.Controls.Add(manualUnpatchButton);
            background.Controls.Add(logBox);
            background.Controls.Add(patcherLogo);
            background.Controls.Add(manualPatchButton);
            background.Controls.Add(progressBar);
            background.Controls.Add(patchButton);
            background.Controls.Add(unpatchButton);
            background.Location = new Point(-1, -4);
            background.Name = "background";
            background.Size = new Size(803, 523);
            background.TabIndex = 8;
            // 
            // infoButton
            // 
            infoButton.Cursor = Cursors.Hand;
            infoButton.Image = Properties.Resources.info;
            infoButton.Location = new Point(13, 16);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(37, 37);
            infoButton.SizeMode = PictureBoxSizeMode.Zoom;
            infoButton.TabIndex = 13;
            infoButton.TabStop = false;
            toolTip.SetToolTip(infoButton, "Info");
            infoButton.Click += infoButton_Click;
            infoButton.MouseEnter += infoButton_MouseEnter;
            infoButton.MouseLeave += infoButton_MouseLeave;
            // 
            // manualUnpatchButton
            // 
            manualUnpatchButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            manualUnpatchButton.Cursor = Cursors.Hand;
            manualUnpatchButton.Image = Properties.Resources.folder;
            manualUnpatchButton.Location = new Point(563, 287);
            manualUnpatchButton.Name = "manualUnpatchButton";
            manualUnpatchButton.Size = new Size(37, 37);
            manualUnpatchButton.SizeMode = PictureBoxSizeMode.Zoom;
            manualUnpatchButton.TabIndex = 12;
            manualUnpatchButton.TabStop = false;
            toolTip.SetToolTip(manualUnpatchButton, "Manually select your game installation directory for unpatching");
            manualUnpatchButton.Click += manualUnpatchButton_Click;
            manualUnpatchButton.MouseEnter += manualUnpatchButton_MouseEnter;
            manualUnpatchButton.MouseLeave += manualUnpatchButton_MouseLeave;
            // 
            // logBox
            // 
            logBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logBox.Location = new Point(244, 360);
            logBox.Multiline = true;
            logBox.Name = "logBox";
            logBox.ReadOnly = true;
            logBox.ScrollBars = ScrollBars.Vertical;
            logBox.Size = new Size(314, 61);
            logBox.TabIndex = 11;
            toolTip.SetToolTip(logBox, "Logs");
            // 
            // patcherLogo
            // 
            patcherLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            patcherLogo.BackgroundImageLayout = ImageLayout.Zoom;
            patcherLogo.Cursor = Cursors.Hand;
            patcherLogo.Image = Properties.Resources.OFDRLauncher_01;
            patcherLogo.Location = new Point(333, 102);
            patcherLogo.Margin = new Padding(5);
            patcherLogo.Name = "patcherLogo";
            patcherLogo.Padding = new Padding(5);
            patcherLogo.Size = new Size(136, 130);
            patcherLogo.SizeMode = PictureBoxSizeMode.Zoom;
            patcherLogo.TabIndex = 10;
            patcherLogo.TabStop = false;
            toolTip.SetToolTip(patcherLogo, "OFDR Patcher");
            patcherLogo.Click += patcherLogo_Click;
            // 
            // manualPatchButton
            // 
            manualPatchButton.Cursor = Cursors.Hand;
            manualPatchButton.Image = Properties.Resources.folder;
            manualPatchButton.Location = new Point(200, 287);
            manualPatchButton.Name = "manualPatchButton";
            manualPatchButton.Size = new Size(37, 37);
            manualPatchButton.SizeMode = PictureBoxSizeMode.Zoom;
            manualPatchButton.TabIndex = 9;
            manualPatchButton.TabStop = false;
            toolTip.SetToolTip(manualPatchButton, "Manually select your game installation directory for patching");
            manualPatchButton.Click += manualPatchButton_Click;
            manualPatchButton.MouseEnter += manualPatchButton_MouseEnter;
            manualPatchButton.MouseLeave += manualPatchButton_MouseLeave;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(243, 330);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(314, 23);
            progressBar.TabIndex = 8;
            toolTip.SetToolTip(progressBar, "Progress bar");
            // 
            // OFDRPatcher
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(800, 511);
            Controls.Add(background);
            Controls.Add(discordLink);
            Controls.Add(githubLink);
            Controls.Add(backgroundImage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "OFDRPatcher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OFDR Patcher";
            Load += OFDRPatcher_Load;
            ((System.ComponentModel.ISupportInitialize)backgroundImage).EndInit();
            background.ResumeLayout(false);
            background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)infoButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)manualUnpatchButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)patcherLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)manualPatchButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel discordLink;
        private LinkLabel githubLink;
        private PictureBox backgroundImage;
        private Button patchButton;
        private Button unpatchButton;
        private Panel background;
        private ProgressBar progressBar;
        private PictureBox manualPatchButton;
        private PictureBox patcherLogo;
        private TextBox logBox;
        private PictureBox manualUnpatchButton;
        private PictureBox infoButton;
        private ToolTip toolTip;
    }
}
