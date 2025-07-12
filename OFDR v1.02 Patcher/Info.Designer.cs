namespace OFDR_v1._02_Patcher
{
    partial class Info
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            closeButton = new PictureBox();
            patcherLogo = new PictureBox();
            titleLabel = new Label();
            aboutText = new Label();
            aboutLabel1 = new Label();
            aboutLabel2 = new Label();
            aboutLabel3 = new Label();
            youtubeButton = new PictureBox();
            discordButton = new PictureBox();
            githubButton = new PictureBox();
            toolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)closeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patcherLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)youtubeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)discordButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)githubButton).BeginInit();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Image = Properties.Resources.close;
            closeButton.Location = new Point(334, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(37, 37);
            closeButton.SizeMode = PictureBoxSizeMode.Zoom;
            closeButton.TabIndex = 14;
            closeButton.TabStop = false;
            closeButton.Click += closeButton_Click;
            closeButton.MouseEnter += closeButton_MouseEnter;
            closeButton.MouseLeave += closeButton_MouseLeave;
            // 
            // patcherLogo
            // 
            patcherLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            patcherLogo.Image = Properties.Resources.OFDRLauncher_01;
            patcherLogo.Location = new Point(141, 49);
            patcherLogo.Name = "patcherLogo";
            patcherLogo.Size = new Size(100, 100);
            patcherLogo.SizeMode = PictureBoxSizeMode.Zoom;
            patcherLogo.TabIndex = 15;
            patcherLogo.TabStop = false;
            toolTip.SetToolTip(patcherLogo, "OFDR Patcher");
            patcherLogo.Click += patcherLogo_Click;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Acumin Pro", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(105, 163);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(172, 32);
            titleLabel.TabIndex = 16;
            titleLabel.Text = "OFDR Patcher";
            toolTip.SetToolTip(titleLabel, "OFDR Patcher");
            titleLabel.Click += titleLabel_Click;
            // 
            // aboutText
            // 
            aboutText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            aboutText.AutoSize = true;
            aboutText.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aboutText.ForeColor = Color.White;
            aboutText.Location = new Point(121, 260);
            aboutText.Name = "aboutText";
            aboutText.Size = new Size(140, 20);
            aboutText.TabIndex = 17;
            aboutText.Text = "© Noah Domingues";
            // 
            // aboutLabel1
            // 
            aboutLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            aboutLabel1.AutoSize = true;
            aboutLabel1.ForeColor = Color.White;
            aboutLabel1.Location = new Point(29, 202);
            aboutLabel1.Name = "aboutLabel1";
            aboutLabel1.Size = new Size(324, 16);
            aboutLabel1.TabIndex = 18;
            aboutLabel1.Text = "OFDR Patcher automatically patches OFP: Dragon Rising";
            // 
            // aboutLabel2
            // 
            aboutLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            aboutLabel2.AutoSize = true;
            aboutLabel2.ForeColor = Color.White;
            aboutLabel2.Location = new Point(46, 219);
            aboutLabel2.Name = "aboutLabel2";
            aboutLabel2.Size = new Size(290, 16);
            aboutLabel2.TabIndex = 19;
            aboutLabel2.Text = "to patched v1.02. This unlocks additional features,";
            // 
            // aboutLabel3
            // 
            aboutLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            aboutLabel3.AutoSize = true;
            aboutLabel3.ForeColor = Color.White;
            aboutLabel3.Location = new Point(49, 236);
            aboutLabel3.Name = "aboutLabel3";
            aboutLabel3.Size = new Size(284, 16);
            aboutLabel3.TabIndex = 20;
            aboutLabel3.Text = "including all screen resolutions and mod support.";
            // 
            // youtubeButton
            // 
            youtubeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            youtubeButton.Cursor = Cursors.Hand;
            youtubeButton.Image = Properties.Resources.youtube;
            youtubeButton.Location = new Point(173, 298);
            youtubeButton.Name = "youtubeButton";
            youtubeButton.Size = new Size(37, 37);
            youtubeButton.SizeMode = PictureBoxSizeMode.Zoom;
            youtubeButton.TabIndex = 21;
            youtubeButton.TabStop = false;
            toolTip.SetToolTip(youtubeButton, "YouTube channel");
            youtubeButton.Click += youtubeButton_Click;
            // 
            // discordButton
            // 
            discordButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            discordButton.Cursor = Cursors.Hand;
            discordButton.Image = Properties.Resources.discord;
            discordButton.Location = new Point(130, 298);
            discordButton.Name = "discordButton";
            discordButton.Size = new Size(37, 37);
            discordButton.SizeMode = PictureBoxSizeMode.Zoom;
            discordButton.TabIndex = 22;
            discordButton.TabStop = false;
            toolTip.SetToolTip(discordButton, "Discord server");
            discordButton.Click += discordButton_Click;
            // 
            // githubButton
            // 
            githubButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            githubButton.Cursor = Cursors.Hand;
            githubButton.Image = Properties.Resources.github;
            githubButton.Location = new Point(216, 298);
            githubButton.Name = "githubButton";
            githubButton.Size = new Size(37, 37);
            githubButton.SizeMode = PictureBoxSizeMode.Zoom;
            githubButton.TabIndex = 23;
            githubButton.TabStop = false;
            toolTip.SetToolTip(githubButton, "GitHub");
            githubButton.Click += githubButton_Click;
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 85, 117);
            ClientSize = new Size(383, 347);
            Controls.Add(githubButton);
            Controls.Add(discordButton);
            Controls.Add(youtubeButton);
            Controls.Add(aboutLabel3);
            Controls.Add(aboutLabel2);
            Controls.Add(aboutLabel1);
            Controls.Add(aboutText);
            Controls.Add(titleLabel);
            Controls.Add(patcherLogo);
            Controls.Add(closeButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Info";
            StartPosition = FormStartPosition.CenterParent;
            Text = "OFDR Patcher - Info";
            ((System.ComponentModel.ISupportInitialize)closeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)patcherLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)youtubeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)discordButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)githubButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox closeButton;
        private PictureBox patcherLogo;
        private Label titleLabel;
        private Label aboutText;
        private Label aboutLabel1;
        private Label aboutLabel2;
        private Label aboutLabel3;
        private PictureBox youtubeButton;
        private PictureBox discordButton;
        private PictureBox githubButton;
        private ToolTip toolTip;
    }
}