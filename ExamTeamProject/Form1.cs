using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ExamTeamProject {
    public partial class Form1 : Form
    {
        //Количество плейлистов 
        private int countPlaylists = 1;
        //Плейлисты с треками
        private List<Playlist> playlists = new List<Playlist>();
        //Указываем путь к трекам
        private static string musicFolderPath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Geometry Dash\\Resources";
        private string[] musicFiles = Directory.GetFiles(musicFolderPath, "*.mp3");
        // Получаем максимального горизонтального и вертикального размера монитора
        int horizontalResolution = Screen.PrimaryScreen.Bounds.Width;
        int verticalResolution = Screen.PrimaryScreen.Bounds.Height;
        public Form1()
        {
            InitializeComponent();
            //Устанавливаем минимальный и максимальный размер окна
            this.MaximumSize = new Size(horizontalResolution, verticalResolution);
            this.MinimumSize = new Size(800, 600);
        }

        private void button2_Click(object sender, EventArgs e)
        {
               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            foreach(var file in musicFiles)
            {
                TagLib.File fileInfo = TagLib.File.Create(file);

                string trackNumber = (dataGridView1.Rows.Count).ToString();
                string trackName = Path.GetFileNameWithoutExtension(fileInfo.Name);

                var duration = fileInfo.Properties.Duration;
                dataGridView1.Rows.Add(trackNumber, trackName, DateTime.Now.ToString("dd.MM.yyyy"), duration.ToString(@"mm\:ss"));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playlists.Add(new Playlist("Плейлист " + countPlaylists));
            listBox1.Items.Add("Плейлист " + countPlaylists);
            countPlaylists++;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получение выбранного плейлиста
            string selectedPlaylistName = listBox1.SelectedItem.ToString();
            Playlist selectedPlaylist = playlists.FirstOrDefault(p => p.Name == selectedPlaylistName);

            int count = 1;
            // Проверка, что плейлист найден
            if (selectedPlaylist != null)
            {
                // Очистка DataGridView перед отображением новых треков
                dataGridView1.Rows.Clear();

                // Добавление треков плейлиста в DataGridView
                foreach (Track track in selectedPlaylist.Tracks)
                {
                    dataGridView1.Rows.Add(count, track.Name, track.DateOfAdd, track.Duration);
                    count++;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playlists.Add(new Playlist("Избранное"));
            playlists[0].Tracks.Add(new Track("test15", DateTime.Now, TimeSpan.MaxValue));
            playlists[0].Tracks.Add(new Track("test14", DateTime.Now, TimeSpan.MaxValue));
            playlists[0].Tracks.Add(new Track("test164", DateTime.Now, TimeSpan.MaxValue));
            playlists[0].Tracks.Add(new Track("test1412", DateTime.Now, TimeSpan.MaxValue));
            playlists[0].Tracks.Add(new Track("test144", DateTime.Now, TimeSpan.MaxValue));
            playlists[0].Tracks.Add(new Track("test14612", DateTime.Now, TimeSpan.MaxValue));
            playlists[0].Tracks.Add(new Track("test145412", DateTime.Now, TimeSpan.MaxValue));
            playlists[0].Tracks.Add(new Track("test1554", DateTime.Now, TimeSpan.MaxValue));
            listBox1.Items.Add(playlists[0].Name);
        }
    }
}
