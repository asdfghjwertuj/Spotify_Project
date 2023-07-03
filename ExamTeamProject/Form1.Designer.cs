
namespace ExamTeamProject
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
            this.Home = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.RemainingTimeLabel = new System.Windows.Forms.Label();
            this.ArtistName = new System.Windows.Forms.Label();
            this.SongName = new System.Windows.Forms.Label();
            this.ThemeButton = new System.Windows.Forms.PictureBox();
            this.Favorite = new System.Windows.Forms.PictureBox();
            this.SongPlayingInterface = new System.Windows.Forms.PictureBox();
            this.KPop = new System.Windows.Forms.PictureBox();
            this.PunkRock = new System.Windows.Forms.PictureBox();
            this.Country = new System.Windows.Forms.PictureBox();
            this.Latino = new System.Windows.Forms.PictureBox();
            this.RnB = new System.Windows.Forms.PictureBox();
            this.Electro = new System.Windows.Forms.PictureBox();
            this.HipHop = new System.Windows.Forms.PictureBox();
            this.Rock = new System.Windows.Forms.PictureBox();
            this.Pop = new System.Windows.Forms.PictureBox();
            this.Playlist = new System.Windows.Forms.PictureBox();
            this.Search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThemeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Favorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SongPlayingInterface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KPop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PunkRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Country)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Latino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RnB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Electro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HipHop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).BeginInit();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.ErrorImage = null;
            this.Home.InitialImage = null;
            this.Home.Location = new System.Drawing.Point(20, 451);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(60, 84);
            this.Home.TabIndex = 1;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(69, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(347, 364);
            this.listBox1.TabIndex = 13;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // NextButton
            // 
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.Location = new System.Drawing.Point(369, 392);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(27, 23);
            this.NextButton.TabIndex = 53;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopButton.Location = new System.Drawing.Point(263, 392);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(46, 23);
            this.StopButton.TabIndex = 51;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PauseButton.Location = new System.Drawing.Point(160, 392);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(46, 23);
            this.PauseButton.TabIndex = 50;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousButton.Location = new System.Drawing.Point(78, 392);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(27, 23);
            this.PreviousButton.TabIndex = 52;
            this.PreviousButton.Text = "<";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar1.Enabled = false;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar1.Location = new System.Drawing.Point(4, 376);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(483, 10);
            this.progressBar1.TabIndex = 49;
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
            this.DurationLabel.Enabled = false;
            this.DurationLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DurationLabel.ForeColor = System.Drawing.Color.White;
            this.DurationLabel.Location = new System.Drawing.Point(450, 392);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(37, 12);
            this.DurationLabel.TabIndex = 55;
            this.DurationLabel.Text = "00:00";
            this.DurationLabel.Visible = false;
            // 
            // RemainingTimeLabel
            // 
            this.RemainingTimeLabel.AutoSize = true;
            this.RemainingTimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
            this.RemainingTimeLabel.Enabled = false;
            this.RemainingTimeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemainingTimeLabel.ForeColor = System.Drawing.Color.White;
            this.RemainingTimeLabel.Location = new System.Drawing.Point(4, 389);
            this.RemainingTimeLabel.Name = "RemainingTimeLabel";
            this.RemainingTimeLabel.Size = new System.Drawing.Size(37, 12);
            this.RemainingTimeLabel.TabIndex = 54;
            this.RemainingTimeLabel.Text = "00:00";
            this.RemainingTimeLabel.Visible = false;
            // 
            // ArtistName
            // 
            this.ArtistName.AutoSize = true;
            this.ArtistName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
            this.ArtistName.Enabled = false;
            this.ArtistName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArtistName.ForeColor = System.Drawing.Color.White;
            this.ArtistName.Location = new System.Drawing.Point(3, 321);
            this.ArtistName.Name = "ArtistName";
            this.ArtistName.Size = new System.Drawing.Size(43, 16);
            this.ArtistName.TabIndex = 48;
            this.ArtistName.Text = "artist";
            this.ArtistName.Visible = false;
            // 
            // SongName
            // 
            this.SongName.AutoSize = true;
            this.SongName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
            this.SongName.Enabled = false;
            this.SongName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SongName.ForeColor = System.Drawing.Color.White;
            this.SongName.Location = new System.Drawing.Point(3, 299);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(54, 22);
            this.SongName.TabIndex = 47;
            this.SongName.Text = "Song";
            this.SongName.Visible = false;
            // 
            // ThemeButton
            // 
            this.ThemeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(216)))), ((int)(((byte)(101)))));
            this.ThemeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThemeButton.Image = global::ExamTeamProject.Properties.Resources.Theme;
            this.ThemeButton.Location = new System.Drawing.Point(452, -2);
            this.ThemeButton.Name = "ThemeButton";
            this.ThemeButton.Size = new System.Drawing.Size(26, 22);
            this.ThemeButton.TabIndex = 57;
            this.ThemeButton.TabStop = false;
            this.ThemeButton.Click += new System.EventHandler(this.ThemeButton_Click);
            // 
            // Favorite
            // 
            this.Favorite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
            this.Favorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Favorite.Image = global::ExamTeamProject.Properties.Resources.FavoriteIcon;
            this.Favorite.Location = new System.Drawing.Point(452, 348);
            this.Favorite.Name = "Favorite";
            this.Favorite.Size = new System.Drawing.Size(26, 22);
            this.Favorite.TabIndex = 56;
            this.Favorite.TabStop = false;
            this.Favorite.Click += new System.EventHandler(this.Favorite_Click);
            // 
            // SongPlayingInterface
            // 
            this.SongPlayingInterface.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(216)))), ((int)(((byte)(101)))));
            this.SongPlayingInterface.Cursor = System.Windows.Forms.Cursors.Default;
            this.SongPlayingInterface.Enabled = false;
            this.SongPlayingInterface.Image = global::ExamTeamProject.Properties.Resources.SongPlayingInterface;
            this.SongPlayingInterface.Location = new System.Drawing.Point(0, 296);
            this.SongPlayingInterface.Name = "SongPlayingInterface";
            this.SongPlayingInterface.Size = new System.Drawing.Size(490, 132);
            this.SongPlayingInterface.TabIndex = 46;
            this.SongPlayingInterface.TabStop = false;
            this.SongPlayingInterface.Visible = false;
            // 
            // KPop
            // 
            this.KPop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KPop.Image = global::ExamTeamProject.Properties.Resources.KPopIcon;
            this.KPop.Location = new System.Drawing.Point(377, 327);
            this.KPop.Name = "KPop";
            this.KPop.Size = new System.Drawing.Size(71, 71);
            this.KPop.TabIndex = 12;
            this.KPop.TabStop = false;
            this.KPop.Click += new System.EventHandler(this.KPop_Click);
            // 
            // PunkRock
            // 
            this.PunkRock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PunkRock.Image = global::ExamTeamProject.Properties.Resources.PunkRockIcon;
            this.PunkRock.Location = new System.Drawing.Point(206, 327);
            this.PunkRock.Name = "PunkRock";
            this.PunkRock.Size = new System.Drawing.Size(71, 71);
            this.PunkRock.TabIndex = 11;
            this.PunkRock.TabStop = false;
            this.PunkRock.Click += new System.EventHandler(this.PunkRock_Click);
            // 
            // Country
            // 
            this.Country.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Country.Image = global::ExamTeamProject.Properties.Resources.CountryIcon;
            this.Country.Location = new System.Drawing.Point(42, 327);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(71, 71);
            this.Country.TabIndex = 10;
            this.Country.TabStop = false;
            this.Country.Click += new System.EventHandler(this.Country_Click);
            // 
            // Latino
            // 
            this.Latino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Latino.Image = global::ExamTeamProject.Properties.Resources.LatinoIcon;
            this.Latino.Location = new System.Drawing.Point(377, 224);
            this.Latino.Name = "Latino";
            this.Latino.Size = new System.Drawing.Size(71, 71);
            this.Latino.TabIndex = 9;
            this.Latino.TabStop = false;
            this.Latino.Click += new System.EventHandler(this.Latino_Click);
            // 
            // RnB
            // 
            this.RnB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RnB.Image = global::ExamTeamProject.Properties.Resources.RnBIcon;
            this.RnB.Location = new System.Drawing.Point(206, 224);
            this.RnB.Name = "RnB";
            this.RnB.Size = new System.Drawing.Size(71, 71);
            this.RnB.TabIndex = 8;
            this.RnB.TabStop = false;
            this.RnB.Click += new System.EventHandler(this.RnB_Click);
            // 
            // Electro
            // 
            this.Electro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Electro.Image = global::ExamTeamProject.Properties.Resources.ElectroIcon;
            this.Electro.Location = new System.Drawing.Point(42, 224);
            this.Electro.Name = "Electro";
            this.Electro.Size = new System.Drawing.Size(71, 71);
            this.Electro.TabIndex = 7;
            this.Electro.TabStop = false;
            this.Electro.Click += new System.EventHandler(this.Electro_Click);
            // 
            // HipHop
            // 
            this.HipHop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HipHop.Image = global::ExamTeamProject.Properties.Resources.HipHopIcon;
            this.HipHop.Location = new System.Drawing.Point(377, 117);
            this.HipHop.Name = "HipHop";
            this.HipHop.Size = new System.Drawing.Size(71, 71);
            this.HipHop.TabIndex = 6;
            this.HipHop.TabStop = false;
            this.HipHop.Click += new System.EventHandler(this.HipHop_Click);
            // 
            // Rock
            // 
            this.Rock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rock.Image = global::ExamTeamProject.Properties.Resources.RockIcon;
            this.Rock.Location = new System.Drawing.Point(206, 117);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(71, 71);
            this.Rock.TabIndex = 5;
            this.Rock.TabStop = false;
            this.Rock.Click += new System.EventHandler(this.Rock_Click);
            // 
            // Pop
            // 
            this.Pop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pop.Image = global::ExamTeamProject.Properties.Resources.PopIcon;
            this.Pop.Location = new System.Drawing.Point(42, 117);
            this.Pop.Name = "Pop";
            this.Pop.Size = new System.Drawing.Size(71, 71);
            this.Pop.TabIndex = 4;
            this.Pop.TabStop = false;
            this.Pop.Click += new System.EventHandler(this.Pop_Click);
            // 
            // Playlist
            // 
            this.Playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
            this.Playlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Playlist.ErrorImage = null;
            this.Playlist.Location = new System.Drawing.Point(329, 442);
            this.Playlist.Name = "Playlist";
            this.Playlist.Size = new System.Drawing.Size(152, 78);
            this.Playlist.TabIndex = 3;
            this.Playlist.TabStop = false;
            this.Playlist.Click += new System.EventHandler(this.Playlist_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.ErrorImage = null;
            this.Search.Location = new System.Drawing.Point(178, 446);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(74, 82);
            this.Search.TabIndex = 2;
            this.Search.TabStop = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 519);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Favorite);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.RemainingTimeLabel);
            this.Controls.Add(this.ArtistName);
            this.Controls.Add(this.SongName);
            this.Controls.Add(this.SongPlayingInterface);
            this.Controls.Add(this.ThemeButton);
            this.Controls.Add(this.KPop);
            this.Controls.Add(this.PunkRock);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.Latino);
            this.Controls.Add(this.RnB);
            this.Controls.Add(this.Electro);
            this.Controls.Add(this.HipHop);
            this.Controls.Add(this.Rock);
            this.Controls.Add(this.Pop);
            this.Controls.Add(this.Playlist);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThemeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Favorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SongPlayingInterface)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KPop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PunkRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Country)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Latino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RnB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Electro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HipHop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Home;
        private System.Windows.Forms.PictureBox Search;
        private System.Windows.Forms.PictureBox Playlist;
        private System.Windows.Forms.PictureBox Pop;
        private System.Windows.Forms.PictureBox Rock;
        private System.Windows.Forms.PictureBox HipHop;
        private System.Windows.Forms.PictureBox Latino;
        private System.Windows.Forms.PictureBox RnB;
        private System.Windows.Forms.PictureBox Electro;
        private System.Windows.Forms.PictureBox KPop;
        private System.Windows.Forms.PictureBox PunkRock;
        private System.Windows.Forms.PictureBox Country;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox ThemeButton;
        private System.Windows.Forms.PictureBox Favorite;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label RemainingTimeLabel;
        private System.Windows.Forms.Label ArtistName;
        private System.Windows.Forms.Label SongName;
        private System.Windows.Forms.PictureBox SongPlayingInterface;
    }
}

