using System;

namespace JukeBox
{
    partial class Jukebox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jukebox));
            this.label1 = new System.Windows.Forms.Label();
            this.Playlist = new System.Windows.Forms.ListBox();
            this.playingNow = new System.Windows.Forms.TextBox();
            this.SelectGenre = new System.Windows.Forms.HScrollBar();
            this.GenreName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Genrelist = new System.Windows.Forms.ListBox();
            this.ChooseGenre = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(784, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright @ 2018 Shakir Shabbir\r\n";
            // 
            // Playlist
            // 
            this.Playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Playlist.FormattingEnabled = true;
            this.Playlist.ItemHeight = 31;
            this.Playlist.Location = new System.Drawing.Point(392, 746);
            this.Playlist.Margin = new System.Windows.Forms.Padding(6);
            this.Playlist.Name = "Playlist";
            this.Playlist.Size = new System.Drawing.Size(430, 252);
            this.Playlist.TabIndex = 1;
            // 
            // playingNow
            // 
            this.playingNow.BackColor = System.Drawing.Color.Lime;
            this.playingNow.Location = new System.Drawing.Point(366, 680);
            this.playingNow.Margin = new System.Windows.Forms.Padding(6);
            this.playingNow.Name = "playingNow";
            this.playingNow.ReadOnly = true;
            this.playingNow.Size = new System.Drawing.Size(482, 38);
            this.playingNow.TabIndex = 2;
            // 
            // SelectGenre
            // 
            this.SelectGenre.Location = new System.Drawing.Point(366, 585);
            this.SelectGenre.Name = "SelectGenre";
            this.SelectGenre.Size = new System.Drawing.Size(486, 25);
            this.SelectGenre.TabIndex = 3;
            // 
            // GenreName
            // 
            this.GenreName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GenreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreName.Location = new System.Drawing.Point(366, 424);
            this.GenreName.Margin = new System.Windows.Forms.Padding(6);
            this.GenreName.Name = "GenreName";
            this.GenreName.ReadOnly = true;
            this.GenreName.Size = new System.Drawing.Size(482, 37);
            this.GenreName.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(15, 1451);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Setup";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(4, 1451);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1242, 62);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(238, 1451);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 56);
            this.button2.TabIndex = 9;
            this.button2.Text = "About";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(148, 131);
            this.MediaPlayer.Margin = new System.Windows.Forms.Padding(6);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(318, 46);
            this.MediaPlayer.TabIndex = 10;
            this.MediaPlayer.Visible = false;
            this.MediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.MediaPlayer_PlayStateChange);
            this.MediaPlayer.Enter += new System.EventHandler(this.MediaPlayer_Enter);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Genrelist
            // 
            this.Genrelist.FormattingEnabled = true;
            this.Genrelist.ItemHeight = 31;
            this.Genrelist.Location = new System.Drawing.Point(366, 471);
            this.Genrelist.Margin = new System.Windows.Forms.Padding(6);
            this.Genrelist.Name = "Genrelist";
            this.Genrelist.Size = new System.Drawing.Size(482, 159);
            this.Genrelist.TabIndex = 11;
            this.Genrelist.DoubleClick += new System.EventHandler(this.Genrelist_DoubleClick);
            // 
            // ChooseGenre
            // 
            this.ChooseGenre.LargeChange = 20;
            this.ChooseGenre.Location = new System.Drawing.Point(366, 634);
            this.ChooseGenre.Maximum = 60;
            this.ChooseGenre.Name = "ChooseGenre";
            this.ChooseGenre.Size = new System.Drawing.Size(486, 21);
            this.ChooseGenre.TabIndex = 12;
            this.ChooseGenre.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ChooseGenre_Scroll);
            // 
            // Jukebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1252, 1519);
            this.Controls.Add(this.ChooseGenre);
            this.Controls.Add(this.Genrelist);
            this.Controls.Add(this.MediaPlayer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GenreName);
            this.Controls.Add(this.SelectGenre);
            this.Controls.Add(this.playingNow);
            this.Controls.Add(this.Playlist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Jukebox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Juke Box v1.0";
            this.Load += new System.EventHandler(this.Jukebox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Playlist;
        private System.Windows.Forms.TextBox playingNow;
        private System.Windows.Forms.HScrollBar SelectGenre;
       
        private System.Windows.Forms.TextBox GenreName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox Genrelist;
        private System.Windows.Forms.HScrollBar ChooseGenre;
    }
}

