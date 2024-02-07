namespace Melody
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            PlaylistListBox = new ListBox();
            AddToPlaylistButton = new Button();
            PlayButton = new Button();
            PauseButton = new Button();
            StopButton = new Button();
            NextButton = new Button();
            PreviousButton = new Button();
            AboutButton = new Button();
            SuspendLayout();
            // 
            // PlaylistListBox
            // 
            PlaylistListBox.FormattingEnabled = true;
            PlaylistListBox.ItemHeight = 30;
            PlaylistListBox.Location = new Point(12, 75);
            PlaylistListBox.Name = "PlaylistListBox";
            PlaylistListBox.Size = new Size(789, 424);
            PlaylistListBox.TabIndex = 0;
            // 
            // AddToPlaylistButton
            // 
            AddToPlaylistButton.Location = new Point(12, 8);
            AddToPlaylistButton.Name = "AddToPlaylistButton";
            AddToPlaylistButton.Size = new Size(153, 61);
            AddToPlaylistButton.TabIndex = 1;
            AddToPlaylistButton.Text = "➕";
            AddToPlaylistButton.UseVisualStyleBackColor = true;
            AddToPlaylistButton.Click += AddToPlaylistButton_Click;
            // 
            // PlayButton
            // 
            PlayButton.Location = new Point(330, 517);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(153, 61);
            PlayButton.TabIndex = 2;
            PlayButton.Text = "▶️";
            PlayButton.UseVisualStyleBackColor = true;
            PlayButton.Click += PlayButton_Click;
            // 
            // PauseButton
            // 
            PauseButton.Location = new Point(171, 517);
            PauseButton.Name = "PauseButton";
            PauseButton.Size = new Size(153, 61);
            PauseButton.TabIndex = 3;
            PauseButton.Text = "⏸️";
            PauseButton.UseVisualStyleBackColor = true;
            PauseButton.Click += PauseButton_Click;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(489, 517);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(153, 61);
            StopButton.TabIndex = 4;
            StopButton.Text = "⏹️";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // NextButton
            // 
            NextButton.Location = new Point(648, 517);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(153, 61);
            NextButton.TabIndex = 5;
            NextButton.Text = "⏭️";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // PreviousButton
            // 
            PreviousButton.Location = new Point(12, 517);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new Size(153, 61);
            PreviousButton.TabIndex = 6;
            PreviousButton.Text = "⏮️";
            PreviousButton.UseVisualStyleBackColor = true;
            PreviousButton.Click += PreviousButton_Click;
            // 
            // AboutButton
            // 
            AboutButton.Location = new Point(747, 12);
            AboutButton.Name = "AboutButton";
            AboutButton.Size = new Size(53, 46);
            AboutButton.TabIndex = 7;
            AboutButton.Text = "?";
            AboutButton.UseVisualStyleBackColor = true;
            AboutButton.Click += AboutButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 590);
            Controls.Add(AboutButton);
            Controls.Add(PreviousButton);
            Controls.Add(NextButton);
            Controls.Add(StopButton);
            Controls.Add(PauseButton);
            Controls.Add(PlayButton);
            Controls.Add(AddToPlaylistButton);
            Controls.Add(PlaylistListBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Melody";
            ResumeLayout(false);
        }

        #endregion

        private ListBox PlaylistListBox;
        private Button AddToPlaylistButton;
        private Button PlayButton;
        private Button PauseButton;
        private Button StopButton;
        private Button NextButton;
        private Button PreviousButton;
        private Button AboutButton;
    }
}
