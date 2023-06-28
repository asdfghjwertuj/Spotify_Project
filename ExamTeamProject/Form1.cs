using System;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NAudio.Wave;

namespace ExamTeamProject {
    public partial class Form1 : Form {
        private PictureBox pbBackground;

        private WaveOutEvent waveOut;
        private string musicFolderPath = "C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Music";

        public Form1() {
            InitializeComponent();

            InitializeBackgroundImage();
            Text = "EchoJukebox";
            Icon = new Icon("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\Icon.ico");
            Home.Image = Image.FromFile("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\HomeIcon.png");
            Search.Image = Image.FromFile("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\SearchIcon.png");
            Playlist.Image = Image.FromFile("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\PlayIcon.png");
            listBox1.Visible = false;
            listBox1.Enabled = false;
        }

        // Изменение фона идет через PictureBox т.к. он более гибкий плане изменений

        private void InitializeBackgroundImage() {

            pbBackground = new PictureBox(); // создаем новый PictureBox
            pbBackground.SizeMode = PictureBoxSizeMode.StretchImage; // увеличение PictureBox пропорционально
            pbBackground.Dock = DockStyle.Fill; // растягиваем его на весь экран
            pbBackground.BackColor = Color.Transparent;

            this.Controls.Add(pbBackground);
            this.SendToBack(); // добавляем его на экран

            SetBackgroundImage("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\MainPageBg.jpg");
        }

        private void SetBackgroundImage(string imagePath) {
            pbBackground.Image = Image.FromFile(imagePath);
        }

        private void SetButtonsVisibility(bool isVisible) {
            Pop.Visible = isVisible;
            Pop.Enabled = isVisible;
            Rock.Visible = isVisible;
            Rock.Enabled = isVisible;
            HipHop.Visible = isVisible;
            HipHop.Enabled = isVisible;
            Electro.Visible = isVisible;
            Electro.Enabled = isVisible;
            RnB.Visible = isVisible;
            RnB.Enabled = isVisible;
            Latino.Visible = isVisible;
            Latino.Enabled = isVisible;
            Country.Visible = isVisible;
            Country.Enabled = isVisible;
            PunkRock.Visible = isVisible;
            PunkRock.Enabled = isVisible;
            KPop.Visible = isVisible;
            KPop.Enabled = isVisible;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e) {
            string selectedSong = listBox1.SelectedItem.ToString();
            string musicFilePath = musicFolderPath + "\\" + selectedSong + ".mp3";

            // Остановка и освобождение ресурсов предыдущего воспроизведения
            if (waveOut != null && waveOut.PlaybackState == PlaybackState.Playing) {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }

            try {
                // Создание нового экземпляра AudioFileReader для чтения аудиофайла
                AudioFileReader audioFileReader = new AudioFileReader(musicFilePath);

                // Подключение AudioFileReader к WaveOutEvent для воспроизведения
                waveOut = new WaveOutEvent();
                waveOut.Init(audioFileReader);

                // Воспроизведение песни
                waveOut.Play();
            }
            catch (Exception ex) {
                // Обработка возникшей ошибки
                MessageBox.Show("Ошибка при воспроизведении музыки: " + ex.Message);
            }
        }


        private void Home_Click(object sender, EventArgs e) {
            Text = "EchoJukebox";
            SetBackgroundImage("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\MainPageBg.jpg");
            SetButtonsVisibility(true);
            listBox1.Visible = false;
            listBox1.Enabled = false;
        }

        private void Search_Click(object sender, EventArgs e) {
            Text = "EchoJukebox :: Search";
            SetBackgroundImage("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\MainPageBg1.jpg");
            SetButtonsVisibility(false);
        }

        private void Playlist_Click(object sender, EventArgs e) {
            Text = "EchoJukebox :: Playlists";
            SetBackgroundImage("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\MainPageBg1.jpg");
            SetButtonsVisibility(false);
        }


        private void Pop_Click(object sender, EventArgs e) {
            listBox1.Items.Clear(); // Очищаем ListBox перед заполнением

            SetBackgroundImage("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\CategoryBg1.jpg");
            SetButtonsVisibility(false);
            listBox1.Visible = true;
            listBox1.Enabled = true;

            string[] musicFiles = Directory.GetFiles(musicFolderPath, "*.mp3"); // Фильтруем только файлы формата .mp3

            foreach (string musicFile in musicFiles) {
                TagLib.File file = TagLib.File.Create(musicFile); // Используем библиотеку TagLib для получения свойств файла

                if (file.Tag.Genres.Contains("Pop")) {
                    string fileName = Path.GetFileNameWithoutExtension(musicFile); // Выводим название файла в ListBox (без разрешения)
                    listBox1.Items.Add(fileName);
                }
            }
        }

        private void Rock_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();

            SetBackgroundImage("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\CategoryBg1.jpg");
            SetButtonsVisibility(false);
            listBox1.Visible = true;
            listBox1.Enabled = true;

            string[] musicFiles = Directory.GetFiles(musicFolderPath, "*.mp3");

            foreach (string musicFile in musicFiles) {
                TagLib.File file = TagLib.File.Create(musicFile);
                if (file.Tag.Genres.Contains("Rock")) {
                    string fileName = Path.GetFileNameWithoutExtension(musicFile);
                    listBox1.Items.Add(fileName);
                }
            }
        }

        private void HipHop_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();

            SetBackgroundImage("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\CategoryBg1.jpg");
            SetButtonsVisibility(false);
            listBox1.Visible = true;
            listBox1.Enabled = true;

            string[] musicFiles = Directory.GetFiles(musicFolderPath, "*.mp3");

            foreach (string musicFile in musicFiles) {
                TagLib.File file = TagLib.File.Create(musicFile);
                if (file.Tag.Genres.Contains("HipHop")) {
                    string fileName = Path.GetFileNameWithoutExtension(musicFile);
                    listBox1.Items.Add(fileName);
                }
            }
        }

        private void Electro_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();

            SetBackgroundImage("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\CategoryBg1.jpg");
            SetButtonsVisibility(false);
            listBox1.Visible = true;
            listBox1.Enabled = true;

            string[] musicFiles = Directory.GetFiles(musicFolderPath, "*.mp3");

            foreach (string musicFile in musicFiles) {
                TagLib.File file = TagLib.File.Create(musicFile);
                if (file.Tag.Genres.Contains("Electro")) {
                    string fileName = Path.GetFileNameWithoutExtension(musicFile);
                    listBox1.Items.Add(fileName);
                }
            }
        }

        private void RnB_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();

            SetBackgroundImage("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\CategoryBg1.jpg");
            SetButtonsVisibility(false);
            listBox1.Visible = true;
            listBox1.Enabled = true;

            string[] musicFiles = Directory.GetFiles(musicFolderPath, "*.mp3");

            foreach (string musicFile in musicFiles) {
                TagLib.File file = TagLib.File.Create(musicFile);
                if (file.Tag.Genres.Contains("RnB")) {
                    string fileName = Path.GetFileNameWithoutExtension(musicFile);
                    listBox1.Items.Add(fileName);
                }
            }
        }

        private void Latino_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();

            SetBackgroundImage("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\CategoryBg1.jpg");
            SetButtonsVisibility(false);
            listBox1.Visible = true;
            listBox1.Enabled = true;

            string[] musicFiles = Directory.GetFiles(musicFolderPath, "*.mp3");

            foreach (string musicFile in musicFiles) {
                TagLib.File file = TagLib.File.Create(musicFile);
                if (file.Tag.Genres.Contains("Latino")) {
                    string fileName = Path.GetFileNameWithoutExtension(musicFile);
                    listBox1.Items.Add(fileName);
                }
            }
        }

        private void Country_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();

            SetBackgroundImage("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\CategoryBg1.jpg");
            SetButtonsVisibility(false);
            listBox1.Visible = true;
            listBox1.Enabled = true;

            string[] musicFiles = Directory.GetFiles(musicFolderPath, "*.mp3");

            foreach (string musicFile in musicFiles) {
                TagLib.File file = TagLib.File.Create(musicFile);
                if (file.Tag.Genres.Contains("Country")) {
                    string fileName = Path.GetFileNameWithoutExtension(musicFile);
                    listBox1.Items.Add(fileName);
                }
            }
        }

        private void PunkRock_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();

            SetBackgroundImage("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\CategoryBg1.jpg");
            SetButtonsVisibility(false);
            listBox1.Visible = true;
            listBox1.Enabled = true;

            string[] musicFiles = Directory.GetFiles(musicFolderPath, "*.mp3");

            foreach (string musicFile in musicFiles) {
                TagLib.File file = TagLib.File.Create(musicFile);
                if (file.Tag.Genres.Contains("PunkRock")) {
                    string fileName = Path.GetFileNameWithoutExtension(musicFile);
                    listBox1.Items.Add(fileName);
                }
            }
        }

        private void KPop_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();

            SetBackgroundImage("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\CategoryBg1.jpg");
            SetButtonsVisibility(false);
            listBox1.Visible = true;
            listBox1.Enabled = true;

            string[] musicFiles = Directory.GetFiles(musicFolderPath, "*.mp3");

            foreach (string musicFile in musicFiles) {
                TagLib.File file = TagLib.File.Create(musicFile);
                if (file.Tag.Genres.Contains("Kpop")) {
                    string fileName = Path.GetFileNameWithoutExtension(musicFile);
                    listBox1.Items.Add(fileName);
                }
            }
        }

    }
}
