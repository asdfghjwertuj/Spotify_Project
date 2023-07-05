﻿using System;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NAudio.Wave;

namespace ExamTeamProject {

    public partial class Form1 : Form {
        private PictureBox pbBackground;
        static string projectFolder = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 26);//путь к нашей папке спотифай чтото там
        private WaveOutEvent waveOut; // Объект для вывода звука
        private AudioFileReader audioFileReader; // Объект для чтения аудиофайла
        private Timer timer; // Декларация таймера
        string path = "";
        
        ThemeManager themeManager = new ThemeManager();

        private bool isFavorite = false;

        private string musicFolderPath = $"{projectFolder}\\ExamTeamProject\\Music";

        public Form1() {
            
            InitializeComponent();
            Favorite.Enabled = false;//фикс того чтобы сразу не появлялись кнопки управления
            Favorite.Visible = false;
            StopButton.Visible = false;
            SearchinBox.Visible = false;
            SearchinBox.Enabled = false;
            SerachingKey.Visible = false;            
            SerachingKey.Enabled = false;
            StopButton.Enabled = false;
            PauseButton.Visible = false;
            PauseButton.Enabled = false;
            NextButton.Visible = false;
            NextButton.Enabled = false;
            PreviousButton.Visible = false;
            PreviousButton.Enabled = false;
            InitializeBackgroundImage();
            
            Text = "EchoJukebox";
            Icon = new Icon($"{projectFolder}\\ExamTeamProject\\Resources\\Icon.ico");
            Home.Image = Image.FromFile($"{projectFolder}\\ExamTeamProject\\Resources\\HomeIcon.png");
            Search.Image = Image.FromFile($"{projectFolder}\\ExamTeamProject\\Resources\\SearchIcon.png");
            Playlist.Image = Image.FromFile($"{projectFolder}\\ExamTeamProject\\Resources\\PlayIcon.png");
            listBox1.Visible = false;
            listBox1.Enabled = false;
            progressBar1.Visible = false;
        }

        private void ThemeButton_Click(object sender, EventArgs e) {
            ChangeTheme();
        }

        private void ChangeTheme() {
            string currentTheme = themeManager.GetCurrentTheme();
            if (currentTheme == "Light") {
                themeManager.SetThemeState(new DarkThemeState());
                themeManager.ApplyTheme();
                string path = themeManager.SetThemeAndBackground(themeManager, new DarkThemeState(), 9);
                SetBackgroundImage(path);
                ThemeButton.BackColor = Color.FromArgb(7, 40, 11);
                SongPlayingInterface.BackColor = Color.FromArgb(7, 40, 11);
            }
            else if (currentTheme == "Dark") {
                themeManager.SetThemeState(new LightThemeState());
                themeManager.ApplyTheme();
                string path = themeManager.SetThemeAndBackground(themeManager, new LightThemeState(), 9);
                SetBackgroundImage(path);
                ThemeButton.BackColor = Color.FromArgb(89, 216, 101);
                SongPlayingInterface.BackColor = Color.FromArgb(89, 216, 101);
            }
        }

        private void InitializeBackgroundImage() {

            pbBackground = new PictureBox(); // создаем новый PictureBox
            pbBackground.SizeMode = PictureBoxSizeMode.StretchImage; // увеличение PictureBox пропорционально
            pbBackground.Dock = DockStyle.Fill; // растягиваем его на весь экран
            pbBackground.BackColor = Color.Transparent;

            this.Controls.Add(pbBackground);
            this.SendToBack(); // добавляем его на экран

            string path = themeManager.SetThemeAndBackground(themeManager, new LightThemeState(), 9);
            SetBackgroundImage(path);
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
        
        private void SearchingInterfaceVisibility(bool isVisible)
        {
            SearchinBox.Visible = isVisible;
            SearchinBox.Enabled = isVisible;
            SerachingKey.Visible = isVisible;
            SerachingKey.Enabled = isVisible;
        }
            private void SongPlayingInterfaceVisibility(bool isVisible) {
            SongName.Visible = isVisible;
            ArtistName.Visible = isVisible;
            DurationLabel.Visible = isVisible;
            RemainingTimeLabel.Visible = isVisible;
            SongPlayingInterface.Visible = isVisible;
            progressBar1.Visible = isVisible;
            PauseButton.Visible = isVisible;
            PauseButton.Enabled = isVisible;
            StopButton.Visible = isVisible;
            StopButton.Enabled = isVisible;
            NextButton.Visible = isVisible;
            NextButton.Enabled = isVisible;
            PreviousButton.Visible = isVisible;
            PreviousButton.Enabled = isVisible;
            Favorite.Visible = isVisible;
            Favorite.Enabled = isVisible;
            
            if (isVisible == true)//фикс того чтобы сразу не появлялись кнопки управления
            {
                SongPlayingInterface.BringToFront();
                SongName.BringToFront();
                ArtistName.BringToFront();
                DurationLabel.BringToFront();
                RemainingTimeLabel.BringToFront();
                PauseButton.BringToFront();
                StopButton.BringToFront();
                NextButton.BringToFront();
                PreviousButton.BringToFront();
                progressBar1.BringToFront();
                Favorite.BringToFront();
                Favorite.BringToFront();
            }
        }


        private void PopulateListBoxByGenre(string genre) {
            listBox1.Items.Clear(); // Очищаем ListBox перед заполнением
            SetButtonsVisibility(false);
            SearchingInterfaceVisibility(false);
            listBox1.Visible = true;
            listBox1.Enabled = true;

            string[] musicFiles = Directory.GetFiles(musicFolderPath, "*.mp3"); // Фильтруем только файлы формата .mp3

            foreach (string musicFile in musicFiles) {
                TagLib.File file = TagLib.File.Create(musicFile);  // Используем библиотеку TagLib для получения свойств файла
                if (file.Tag.Genres.Contains(genre)) {
                    string fileName = Path.GetFileNameWithoutExtension(musicFile);
                    listBox1.Items.Add(fileName);
                }
            }
        }


        private void Timer_Tick(object sender, EventArgs e) {
            if (audioFileReader != null) {
                progressBar1.Value = (int)audioFileReader.CurrentTime.TotalSeconds;
                TimeSpan totalDuration = audioFileReader.TotalTime;
                TimeSpan remainingTime = totalDuration - audioFileReader.CurrentTime;
                RemainingTimeLabel.Text = remainingTime.ToString(@"mm\:ss");
            }
        }

        private void PlaySelectedTrack() {
            SongPlayingInterfaceVisibility(true);
            if (listBox1.SelectedItem != null) {
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
                    audioFileReader = new AudioFileReader(musicFilePath);

                    // Подключение AudioFileReader к WaveOutEvent для воспроизведения
                    waveOut = new WaveOutEvent();
                    waveOut.Init(audioFileReader);

                    TagLib.File file = TagLib.File.Create(musicFilePath);

                    SongName.Text = file.Tag.Title;
                    ArtistName.Text = file.Tag.FirstPerformer;
                    TimeSpan totalDuration = audioFileReader.TotalTime; // Получение общей длительности трека
                    // Преобразование длительности в строку и установка в DurationLabel
                    DurationLabel.Text = totalDuration.ToString(@"mm\:ss");

                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = (int)audioFileReader.TotalTime.TotalSeconds;

                    timer = new Timer();
                    timer.Interval = 100; // Интервал обновления в миллисекундах
                    timer.Tick += Timer_Tick;
                    timer.Start();

                    // Воспроизведение песни
                    waveOut.Play();
                }
                catch (Exception ex) {
                    MessageBox.Show("Music playback error: " + ex.Message);
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e) {
            PlaySelectedTrack();
        }

        #region menu buttons
        private void Home_Click(object sender, EventArgs e) {
            Text = "EchoJukebox";
            StopButton_Click(sender, e);
            if (themeManager.GetCurrentTheme() == "Light") {
                path = themeManager.SetThemeAndBackground(themeManager, new LightThemeState(), 9);
            }
            else if (themeManager.GetCurrentTheme() == "Dark") {
                path = themeManager.SetThemeAndBackground(themeManager, new DarkThemeState(), 9);
            }
            SetBackgroundImage(path);
            SetButtonsVisibility(true);
            SongPlayingInterfaceVisibility(false);
            SearchingInterfaceVisibility(false);
            listBox1.Visible = false;
            listBox1.Enabled = false;
            ThemeButton.Visible = true;
            ThemeButton.Enabled = true;

        }

        private void Search_Click(object sender, EventArgs e) {
            Text = "EchoJukebox :: Search";
            listBox1.Items.Clear();
            SearchinBox.Clear();
            SearchingInterfaceVisibility(true);
            listBox1.Enabled = true;
            listBox1.Visible = true;
            listBox1.BringToFront();
            
            StopButton_Click(sender, e);
            if (themeManager.GetCurrentTheme() == "Light") {
                path = themeManager.SetThemeAndBackground(themeManager, new LightThemeState(), 10);
            }
            else if (themeManager.GetCurrentTheme() == "Dark") {
                path = themeManager.SetThemeAndBackground(themeManager, new DarkThemeState(), 10);
            }

            SetBackgroundImage(path);
            SetButtonsVisibility(false);
            SongPlayingInterfaceVisibility(false);
            listBox1.Visible = false;
            listBox1.Enabled = false;
            ThemeButton.Visible = false;
            ThemeButton.Enabled = false;
            SearchinBox_TextChanged(sender, e);
        }
        private void SearchinBox_TextChanged(object sender, EventArgs e)//поиск песен
        {
            listBox1.Items.Clear();
            SearchingInterfaceVisibility(true);
            listBox1.Enabled = true;
            listBox1.Visible = true;
            listBox1.SelectedItem = null;
            
            string musicFolderPath = $"{projectFolder}\\ExamTeamProject\\Music";
            string[] musicFiles = Directory.GetFiles(musicFolderPath, "*.mp3");


            foreach (var file in musicFiles)
            {
                TagLib.File fileInfo = TagLib.File.Create(file);
                string fileName = Path.GetFileNameWithoutExtension(file);
                if (fileName.ToLower().Contains(SearchinBox.Text.ToLower())&& SearchinBox.Text!=String.Empty)//поиск символа введенного в названиях песен
                {
                    listBox1.Items.Add(fileName);
                }
                
                
            }
        }
        private void Playlist_Click(object sender, EventArgs e) {
            Text = "EchoJukebox :: Playlists";
            StopButton_Click(sender, e);
            if (themeManager.GetCurrentTheme() == "Light") {
                path = themeManager.SetThemeAndBackground(themeManager, new LightThemeState(), 10);
            }
            else if (themeManager.GetCurrentTheme() == "Dark") {
                path = themeManager.SetThemeAndBackground(themeManager, new DarkThemeState(), 10);
            }
            SetBackgroundImage(path);
            SetButtonsVisibility(false);
            SearchingInterfaceVisibility(false);
            SongPlayingInterfaceVisibility(false);
            listBox1.Visible = false;
            listBox1.Enabled = false;
            ThemeButton.Visible = false;
            ThemeButton.Enabled = false;
        }
        #endregion

        #region category buttons
        private void Pop_Click(object sender, EventArgs e) {
            ThemeButton.Visible = false;
            ThemeButton.Enabled = false;
            if (themeManager.GetCurrentTheme() == "Light") {
                path = themeManager.SetThemeAndBackground(themeManager, new LightThemeState(), 0);
            }
            else if (themeManager.GetCurrentTheme() == "Dark") {
                path = themeManager.SetThemeAndBackground(themeManager, new DarkThemeState(), 0);
            }
            SetBackgroundImage(path);
            PopulateListBoxByGenre("Pop");
        }

        private void Rock_Click(object sender, EventArgs e) {
            ThemeButton.Visible = false;
            ThemeButton.Enabled = false;
            if (themeManager.GetCurrentTheme() == "Light") {
                path = themeManager.SetThemeAndBackground(themeManager, new LightThemeState(), 1);
            }
            else if (themeManager.GetCurrentTheme() == "Dark") {
                path = themeManager.SetThemeAndBackground(themeManager, new DarkThemeState(), 1);
            }
            SetBackgroundImage(path);
            PopulateListBoxByGenre("Rock");
        }

        private void HipHop_Click(object sender, EventArgs e) {
            ThemeButton.Visible = false;
            ThemeButton.Enabled = false;
            if (themeManager.GetCurrentTheme() == "Light") {
                path = themeManager.SetThemeAndBackground(themeManager, new LightThemeState(), 2);
            }
            else if (themeManager.GetCurrentTheme() == "Dark") {
                path = themeManager.SetThemeAndBackground(themeManager, new DarkThemeState(), 2);
            }
            SetBackgroundImage(path);
            PopulateListBoxByGenre("HipHop");
        }

        private void Electro_Click(object sender, EventArgs e) {
            ThemeButton.Visible = false;
            ThemeButton.Enabled = false;
            if (themeManager.GetCurrentTheme() == "Light") {
                path = themeManager.SetThemeAndBackground(themeManager, new LightThemeState(), 3);
            }
            else if (themeManager.GetCurrentTheme() == "Dark") {
                path = themeManager.SetThemeAndBackground(themeManager, new DarkThemeState(), 3);
            }
            SetBackgroundImage(path);
            PopulateListBoxByGenre("Electro");
        }

        private void RnB_Click(object sender, EventArgs e) {
            ThemeButton.Visible = false;
            ThemeButton.Enabled = false;
            if (themeManager.GetCurrentTheme() == "Light") {
                path = themeManager.SetThemeAndBackground(themeManager, new LightThemeState(), 4);
            }
            else if (themeManager.GetCurrentTheme() == "Dark") {
                path = themeManager.SetThemeAndBackground(themeManager, new DarkThemeState(), 4);
            }
            SetBackgroundImage(path);
            PopulateListBoxByGenre("RnB");
        }

        private void Latino_Click(object sender, EventArgs e) {
            ThemeButton.Visible = false;
            ThemeButton.Enabled = false;
            if (themeManager.GetCurrentTheme() == "Light") {
                path = themeManager.SetThemeAndBackground(themeManager, new LightThemeState(), 5);
            }
            else if (themeManager.GetCurrentTheme() == "Dark") {
                path = themeManager.SetThemeAndBackground(themeManager, new DarkThemeState(), 5);
            }
            SetBackgroundImage(path);
            PopulateListBoxByGenre("Latino");
        }

        private void Country_Click(object sender, EventArgs e) {
            ThemeButton.Visible = false;
            ThemeButton.Enabled = false;
            if (themeManager.GetCurrentTheme() == "Light") {
                path = themeManager.SetThemeAndBackground(themeManager, new LightThemeState(), 6);
            }
            else if (themeManager.GetCurrentTheme() == "Dark") {
                path = themeManager.SetThemeAndBackground(themeManager, new DarkThemeState(), 6);
            }
            SetBackgroundImage(path);
            PopulateListBoxByGenre("Country");
        }

        private void PunkRock_Click(object sender, EventArgs e) {
            ThemeButton.Visible = false;
            ThemeButton.Enabled = false;
            if (themeManager.GetCurrentTheme() == "Light") {
                path = themeManager.SetThemeAndBackground(themeManager, new LightThemeState(), 7);
            }
            else if (themeManager.GetCurrentTheme() == "Dark") {
                path = themeManager.SetThemeAndBackground(themeManager, new DarkThemeState(), 7);
            }
            SetBackgroundImage(path);
            PopulateListBoxByGenre("PunkRock");
        }

        private void KPop_Click(object sender, EventArgs e) {
            ThemeButton.Visible = false;
            ThemeButton.Enabled = false;
            if (themeManager.GetCurrentTheme() == "Light") {
                path = themeManager.SetThemeAndBackground(themeManager, new LightThemeState(), 8);
            }
            else if (themeManager.GetCurrentTheme() == "Dark") {
                path = themeManager.SetThemeAndBackground(themeManager, new DarkThemeState(), 8);
            }
            SetBackgroundImage(path); PopulateListBoxByGenre("Kpop");
        }
        #endregion

        #region music playing interface buttons 
        private void PauseButton_Click(object sender, EventArgs e) {
            if (waveOut != null) {
                if (waveOut.PlaybackState == PlaybackState.Playing) {
                    // Ставим трек на паузу
                    waveOut.Pause();
                }
                else if (waveOut.PlaybackState == PlaybackState.Paused) {
                    // Возобновляем воспроизведение трека
                    waveOut.Play();
                }
            }
        }

        private void StopButton_Click(object sender, EventArgs e) {
            if (waveOut != null && (waveOut.PlaybackState == PlaybackState.Playing || waveOut.PlaybackState == PlaybackState.Paused)) {
                // Останавливаем воспроизведение трека
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
                audioFileReader.Dispose();
                audioFileReader = null;

                if (timer != null) {
                    timer.Stop();
                    timer.Tick -= Timer_Tick;
                    timer.Dispose();
                    timer = null;
                }

                // Сбрасываем элементы интерфейса
                SongName.Text = "Song";
                ArtistName.Text = "Artist";
                progressBar1.Value = 0;
                SongPlayingInterfaceVisibility(false);
            }
        }

        private void NextButton_Click(object sender, EventArgs e) {
            if (listBox1.Items.Count > 0) {
                int currentIndex = listBox1.SelectedIndex;
                int nextIndex = currentIndex + 1;

                // Проверяем, не достигли ли конца списка треков
                if (nextIndex >= listBox1.Items.Count) {
                    // Если достигли конца, переключаемся на первый трек
                    nextIndex = 0;
                }

                listBox1.SelectedIndex = nextIndex; // Выбираем следующий трек в ListBox

                PlaySelectedTrack();
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e) {
            if (listBox1.Items.Count > 0) {
                int currentIndex = listBox1.SelectedIndex;
                int previousIndex = currentIndex - 1;

                // Проверяем, не достигли ли начала списка треков
                if (previousIndex < 0) {
                    // Если достигли начала, переключаемся на последний трек
                    previousIndex = listBox1.Items.Count - 1;
                }

                // Выбираем предыдущий трек в ListBox
                listBox1.SelectedIndex = previousIndex;

                PlaySelectedTrack();
            }
        }

        private void Favorite_Click(object sender, EventArgs e) {
            if (isFavorite) {
                Favorite.Image = Image.FromFile($"{projectFolder}\\ExamTeamProject\\Resources\\FavoriteIcon.png");
                isFavorite = false;
            }
            else {
                Favorite.Image = Image.FromFile($"{projectFolder}\\ExamTeamProject\\Resources\\FavoriteIcon1.png");
                isFavorite = true;
            }
        }
        #endregion

        
    }

    #region State Pattern
    // Интерфейс состояния темы
    public abstract class ThemeState {
        public abstract void ApplyTheme(ThemeManager themeManager);
        public abstract string GetThemeName();
    }

    // Конкретные классы состояний темы
    public class LightThemeState : ThemeState {
        public override void ApplyTheme(ThemeManager themeManager) {
            themeManager.GetBackgroundPath(9);
        }
        public override string GetThemeName() {
            return "Light";
        }
    }

    public class DarkThemeState : ThemeState {
        public override void ApplyTheme(ThemeManager themeManager) {
            themeManager.GetBackgroundPath(9);
        }
        public override string GetThemeName() {
            return "Dark";
        }
    }

    // Класс, управляющий темой приложения
    public class ThemeManager {
        private ThemeState currentThemeState;
        static private string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        private string LightfolderPath = Path.Combine(userProfilePath, "source", "repos", "Spotify_Project", "ExamTeamProject", "Resources", "LightBg");
        static private string userProfilePath2 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        private string DarkfolderPath = Path.Combine(userProfilePath, "source", "repos", "Spotify_Project", "ExamTeamProject", "Resources", "DarkBg");
        private string[] lightBackgrounds; // Массив светлых фонов
        private string[] darkBackgrounds; // Массив темных фонов

        public ThemeManager() {
            LoadImages();
        }

        private void LoadImages() {
            lightBackgrounds = Directory.GetFiles(LightfolderPath);
            darkBackgrounds = Directory.GetFiles(DarkfolderPath);
            Array.Sort(lightBackgrounds);
            Array.Sort(darkBackgrounds);
        }

        public void SetThemeState(ThemeState state) {
            currentThemeState = state;
        }

        public void ApplyTheme() {
            currentThemeState.ApplyTheme(this);
        }

        public string GetCurrentTheme() {
            return currentThemeState.GetThemeName();
        }

        public string GetBackgroundPath(int backgroundIndex) {

            string imagePath;

            if (currentThemeState is LightThemeState) {
                imagePath = lightBackgrounds[backgroundIndex]; // Выбираем светлый фон по индексу
            }
            else if (currentThemeState is DarkThemeState) {
                imagePath = darkBackgrounds[backgroundIndex]; // Выбираем темный фон по индексу
            }
            else {
                // Обработка ошибки ( выбор другого фона по умолчанию )
                imagePath = "";
            }

            return imagePath;
        }

        public string SetThemeAndBackground(ThemeManager themeManager, ThemeState themeState, int backgroundIndex) {
            themeManager.SetThemeState(themeState);
            themeManager.ApplyTheme();
            string backgroundPath = themeManager.GetBackgroundPath(backgroundIndex);
            return backgroundPath;
        }
    }
    #endregion
}
