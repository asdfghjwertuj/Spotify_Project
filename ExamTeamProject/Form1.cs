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
        // В конструкторе формы или в методе инициализации DataGridView
        
        public Form1()
        {
            InitializeComponent();
            //Устанавливаем минимальный и максимальный размер окна
            this.MaximumSize = new Size(horizontalResolution, verticalResolution);
            this.MinimumSize = new Size(800, 600);
            // Устанавливаем значение SelectionMode - FullRowSelect, чтобы ряд выбирался полностью.
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItem = null;
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
            Playlist newPlaylist = new Playlist("Плейлист " + countPlaylists);
            playlists.Add(newPlaylist);
            listBox1.Items.Add(newPlaylist.Name);
            countPlaylists++;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получение выбранного плейлиста
            string selectedPlaylistName = (string)listBox1.SelectedItem;
            Playlist selectedPlaylist = playlists.FirstOrDefault(p => p.Name == selectedPlaylistName);

            int count = 1;
            // Проверка, что плейлист найден
            if (selectedPlaylist != null)
            {
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
            //Добавление стандартного плейлиста "Избранное", который нельзя будет удалить
            Playlist newPlaylist = new Playlist("Избранное");
            playlists.Add(newPlaylist);
            listBox1.Items.Add(newPlaylist.Name);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem.ToString() == "Избранное")
                    return;
                int removedIndex = listBox1.SelectedIndex;

                // Удаление плейлиста из списка плейлистов
                playlists.RemoveAt(removedIndex);

                // Удаление плейлиста из ListBox
                listBox1.Items.RemoveAt(removedIndex);
                listBox1.SelectedItem = listBox1.Items[0];
            }
            catch(Exception)
            {

            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "Избранное")
                return;
            using (var dialogEditNamePlaylist = new Form())
            {
                dialogEditNamePlaylist.Size = new Size(220, 140);
                dialogEditNamePlaylist.Text = "Новое имя";
                dialogEditNamePlaylist.FormBorderStyle = FormBorderStyle.FixedDialog;
                dialogEditNamePlaylist.MaximizeBox = false;
                dialogEditNamePlaylist.MinimizeBox = false;
                Button buttonCancel = new Button() { Text = "Отмена", Location = new Point(115, 65) };
                Button buttonOK = new Button() { Text = "ОК", Location = new Point(35, 65) };
                Label label = new Label() { Text = "Новое название плейлиста:", Location = new Point(10, 10), Size = new Size(150, 30) };
                TextBox textBox = new TextBox() { Location = new Point(10, 40), Size = new Size(180, 30) };
                void ButtonCancel_Click(object _sender, EventArgs _e)
                {
                    dialogEditNamePlaylist.Close();
                }
                void ButtonOK_Click(object _sender, EventArgs _e)
                {
                    if (textBox.Text == "")
                        return;

                    string newNamePlaylist = textBox.Text;
                    int selectedIndex = listBox1.SelectedIndex; // Сохраняем исходный индекс выбранного плейлиста

                    playlists[selectedIndex].Name = newNamePlaylist;

                    // Обновляем текст элемента ListBox
                    listBox1.Items[selectedIndex] = newNamePlaylist;

                    // Восстанавливаем выбранный элемент ListBox
                    listBox1.SelectedIndex = selectedIndex;

                    dialogEditNamePlaylist.Close();
                }
                buttonCancel.Click += ButtonCancel_Click;
                buttonOK.Click += ButtonOK_Click;
                dialogEditNamePlaylist.Controls.Add(buttonCancel);
                dialogEditNamePlaylist.Controls.Add(buttonOK);
                dialogEditNamePlaylist.Controls.Add(label);
                dialogEditNamePlaylist.Controls.Add(textBox);
                dialogEditNamePlaylist.ShowDialog();
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Left)
                {
                    listBox1.SelectedIndex++;
                }
                if (e.KeyCode == Keys.Right)
                {
                    listBox1.SelectedIndex--;
                }
            }
            catch (Exception)
            {

            }
        }

        private void contextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string selectedPlaylistName = e.ClickedItem.Text; // Получаем выбранный плейлист из контекстного меню
            Playlist selectedPlaylist = playlists.FirstOrDefault(p => p.Name == selectedPlaylistName);

            // Проверка, что плейлист найден
            if (selectedPlaylist != null)
            {
                // Получение выбранного трека из DataGridView
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string trackName = selectedRow.Cells["TrackNameColumn"].Value.ToString();
                string trackDate = selectedRow.Cells["DateAddedColumn"].Value.ToString();
                TimeSpan trackDuration = (TimeSpan)selectedRow.Cells["DurationColumn"].Value;

                // Создание нового трека и добавление его в выбранный плейлист
                Track newTrack = new Track(trackName, DateTime.Now, trackDuration);
                foreach(var playlist in playlists)
                {
                    if(playlist.Name == selectedPlaylistName)
                        playlist.Tracks.Add(newTrack);
                }
            }
        }
    }
}
