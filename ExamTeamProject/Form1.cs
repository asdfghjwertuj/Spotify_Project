using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

        }
    }
}
