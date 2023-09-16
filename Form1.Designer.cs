namespace MusicPlayerApplication
{
    partial class MusicPlayerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerApp));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelLogo = new System.Windows.Forms.Label();
            this.ListBoxSongs = new System.Windows.Forms.ListBox();
            this.ButtonSelectSong = new System.Windows.Forms.Button();
            this.LabelFooter = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayerMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopPanel.Controls.Add(this.LabelLogo);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(920, 60);
            this.TopPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(848, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LabelLogo
            // 
            this.LabelLogo.AutoSize = true;
            this.LabelLogo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogo.Location = new System.Drawing.Point(14, 14);
            this.LabelLogo.Name = "LabelLogo";
            this.LabelLogo.Size = new System.Drawing.Size(179, 23);
            this.LabelLogo.TabIndex = 1;
            this.LabelLogo.Text = "Music Player App";
            // 
            // ListBoxSongs
            // 
            this.ListBoxSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxSongs.FormattingEnabled = true;
            this.ListBoxSongs.ItemHeight = 20;
            this.ListBoxSongs.Location = new System.Drawing.Point(675, 83);
            this.ListBoxSongs.Name = "ListBoxSongs";
            this.ListBoxSongs.Size = new System.Drawing.Size(216, 304);
            this.ListBoxSongs.TabIndex = 1;
            this.ListBoxSongs.SelectedIndexChanged += new System.EventHandler(this.ListBoxSongs_SelectedIndexChanged);
            // 
            // ButtonSelectSong
            // 
            this.ButtonSelectSong.BackColor = System.Drawing.Color.Red;
            this.ButtonSelectSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSelectSong.ForeColor = System.Drawing.Color.White;
            this.ButtonSelectSong.Location = new System.Drawing.Point(675, 393);
            this.ButtonSelectSong.Name = "ButtonSelectSong";
            this.ButtonSelectSong.Size = new System.Drawing.Size(216, 57);
            this.ButtonSelectSong.TabIndex = 2;
            this.ButtonSelectSong.Text = "Select Song";
            this.ButtonSelectSong.UseVisualStyleBackColor = false;
            this.ButtonSelectSong.Click += new System.EventHandler(this.ButtonSelectSong_Click);
            // 
            // LabelFooter
            // 
            this.LabelFooter.AutoSize = true;
            this.LabelFooter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelFooter.Location = new System.Drawing.Point(343, 478);
            this.LabelFooter.Name = "LabelFooter";
            this.LabelFooter.Size = new System.Drawing.Size(171, 18);
            this.LabelFooter.TabIndex = 4;
            this.LabelFooter.Text = "Developed By WaRRioR";
            // 
            // axWindowsMediaPlayerMusic
            // 
            this.axWindowsMediaPlayerMusic.Enabled = true;
            this.axWindowsMediaPlayerMusic.Location = new System.Drawing.Point(16, 83);
            this.axWindowsMediaPlayerMusic.Name = "axWindowsMediaPlayerMusic";
            this.axWindowsMediaPlayerMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerMusic.OcxState")));
            this.axWindowsMediaPlayerMusic.Size = new System.Drawing.Size(653, 367);
            this.axWindowsMediaPlayerMusic.TabIndex = 3;
            // 
            // MusicPlayerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 510);
            this.Controls.Add(this.LabelFooter);
            this.Controls.Add(this.axWindowsMediaPlayerMusic);
            this.Controls.Add(this.ButtonSelectSong);
            this.Controls.Add(this.ListBoxSongs);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicPlayerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayerApp";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelLogo;
        private System.Windows.Forms.ListBox ListBoxSongs;
        private System.Windows.Forms.Button ButtonSelectSong;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerMusic;
        private System.Windows.Forms.Label LabelFooter;
    }
}

