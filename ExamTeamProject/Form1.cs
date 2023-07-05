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
        ToolStripMenuItem addToPlaylistSubItem = new ToolStripMenuItem("Добавить в...");
        //Указываем путь к трекам
        private static string musicFolderPath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Geometry Dash\\Resources";
        private string[] musicFiles = Directory.GetFiles(musicFolderPath, "*.mp3");
        public Form1()
        {
            InitializeComponent();
            // Устанавливаем значение SelectionMode для DataGridView
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            contextMenuStrip2.Items.Add(addToPlaylistSubItem);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItem = null;
            dataGridView1.ContextMenuStrip = contextMenuStrip2;
            dataGridView1.Rows.Clear();

            foreach(var file in musicFiles)
            {
                TagLib.File fileInfo = TagLib.File.Create(file);

                string trackNumber = (dataGridView1.Rows.Count).ToString();
                string trackName = Path.GetFileNameWithoutExtension(fileInfo.Name);
                string artistName = Path.GetFileNameWithoutExtension(fileInfo.Tag.FirstPerformer);
                if (artistName == null)
                    artistName = "None";
                var duration = fileInfo.Properties.Duration;
                dataGridView1.Rows.Add(trackNumber, trackName, artistName, DateTime.Now.ToString("dd.MM.yyyy"), duration.ToString(@"mm\:ss"));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Playlist newPlaylist = new Playlist("Плейлист " + countPlaylists);
            playlists.Add(newPlaylist);
            listBox1.Items.Add(newPlaylist.Name);
            countPlaylists++;
            ToolStripMenuItem playlistItem = new ToolStripMenuItem(newPlaylist.Name);
            playlistItem.Click += contextMenuStrip2_Click;
            addToPlaylistSubItem.DropDownItems.Add(playlistItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.ContextMenuStrip = contextMenuStrip3;
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
                    dataGridView1.Rows.Add(count, track.Name, track.Author, track.DateOfAdd, track.Duration);
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
            ToolStripMenuItem playlistMenuItem = (ToolStripMenuItem)contextMenuStrip2.Items[0];
            ToolStripMenuItem playlistItemF = new ToolStripMenuItem(newPlaylist.Name);
            playlistItemF.Click += contextMenuStrip2_Click;
            playlistMenuItem.DropDownItems.Add(playlistItemF);
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
                // Удаление плейлиста из контекстного меню
                ToolStripMenuItem playlistMenuItem = (ToolStripMenuItem)contextMenuStrip2.Items[0]; 
                playlistMenuItem.DropDownItems.RemoveAt(removedIndex);
            }
            catch(Exception)
            {

            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
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
                        // Сохраняем исходный индекс выбранного плейлиста
                        int selectedIndex = listBox1.SelectedIndex;

                        playlists[selectedIndex].Name = newNamePlaylist;

                        // Обновляем текст элемента ListBox
                        listBox1.Items[selectedIndex] = newNamePlaylist;

                        // Восстанавливаем выбранный элемент ListBox
                        listBox1.SelectedIndex = selectedIndex;

                        // Обновляем текст элемента меню в контекстном меню
                        ToolStripMenuItem playlistMenuItem = (ToolStripMenuItem)contextMenuStrip2.Items[0];
                        ToolStripMenuItem playlistItem = (ToolStripMenuItem)playlistMenuItem.DropDownItems[selectedIndex];
                        playlistItem.Text = newNamePlaylist;
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
            catch(Exception)
            {

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
        private void contextMenuStrip2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
                    string playlistName = toolStripMenuItem.Text;

                    // Получение выбранного трека в DataGridView
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    if (selectedRow == null)
                        return;
                    string trackName = selectedRow.Cells[1].Value.ToString();
                    string trackDurationStr = selectedRow.Cells[4].Value.ToString();
                    string[] timeParts = trackDurationStr.Split(':');

                    int minutes = int.Parse(timeParts[0]);
                    int seconds = int.Parse(timeParts[1]);
                    TimeSpan trackDuration = new TimeSpan(0, minutes, seconds);

                    string artist = selectedRow.Cells[2].Value != null ? selectedRow.Cells[2].Value.ToString() : string.Empty;
                    if (artist == null)
                        artist = "Неизвестен";
                    // Поиск плейлиста по имени
                    Playlist selectedPlaylist = playlists.FirstOrDefault(p => p.Name == playlistName);

                    if (selectedPlaylist != null)
                    {
                        // Добавление трека в плейлист
                        selectedPlaylist.Tracks.Add(new Track(trackName, artist, DateTime.Now, trackDuration));
                    }
                    else
                    {
                        MessageBox.Show("Выбранный плейлист не найден.");
                    }
                }
                else
                {
                    MessageBox.Show("Выберите трек для добавления в плейлист.");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Выберите трек для добавления в плейлист.");
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0 && listBox1.SelectedItem != null)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;

                    // Получаем выбранный плейлист
                    string selectedPlaylistName = listBox1.SelectedItem.ToString();
                    Playlist selectedPlaylist = playlists.FirstOrDefault(p => p.Name == selectedPlaylistName);

                    // Получаем выбранный трек в DataGridView
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string trackName = selectedRow.Cells[1].Value.ToString();

                    if (selectedPlaylist != null && selectedRow != null)
                    {
                        // Ищем трек в выбранном плейлисте и удаляем его
                        Track trackToRemove = selectedPlaylist.Tracks.FirstOrDefault(t => t.Name == trackName);
                        if (trackToRemove.Name != null)
                        {
                            selectedPlaylist.Tracks.Remove(trackToRemove);
                        }
                    }

                    dataGridView1.Rows.Remove(selectedRow);

                    // Обновляем номера треков у оставшихся элементов
                    for (int i = selectedIndex; i < dataGridView1.Rows.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
