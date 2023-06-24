
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
            this.Playlist = new System.Windows.Forms.PictureBox();
            this.Search = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.SuspendLayout();
            // 
            // Playlist
            // 
            this.Playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
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
            this.Search.ErrorImage = null;
            this.Search.Location = new System.Drawing.Point(178, 446);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(74, 82);
            this.Search.TabIndex = 2;
            this.Search.TabStop = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
            this.Home.ErrorImage = null;
            this.Home.InitialImage = null;
            this.Home.Location = new System.Drawing.Point(20, 451);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(60, 84);
            this.Home.TabIndex = 1;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 519);
            this.Controls.Add(this.Playlist);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Home);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Playlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Home;
        private System.Windows.Forms.PictureBox Search;
        private System.Windows.Forms.PictureBox Playlist;
    }
}

