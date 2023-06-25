﻿using System;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace ExamTeamProject {
    public partial class Form1 : Form {
        private PictureBox pbBackground;
        private string musicFolderPath = "C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Music";

        public Form1() {
            InitializeComponent();

            InitializeBackgroundImage();
            Text = "EchoJukebox";
            Icon = new Icon("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\Icon.ico");
            Home.Image = Image.FromFile("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\HomeIcon.png");
            Search.Image = Image.FromFile("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\SearchIcon.png");
            Playlist.Image = Image.FromFile("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\PlayIcon.png");
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.MaximizeBox = false; // Отключаем кнопку "Развернуть"
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

        private void Home_Click(object sender, EventArgs e) {
            SetBackgroundImage("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\MainPageBg.jpg");
            MessageBox.Show("Home button is working", "Test", MessageBoxButtons.OK);
        }

        private void Search_Click(object sender, EventArgs e) {
            SetBackgroundImage("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\MainPageBg1.jpg");
            MessageBox.Show("Search button is working", "Test", MessageBoxButtons.OK);
        }

        private void Playlist_Click(object sender, EventArgs e) {
            SetBackgroundImage("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Resources\\MainPageBg1.jpg");
            MessageBox.Show("Play button is working", "Test", MessageBoxButtons.OK);
        }

        private void KPop_Click(object sender, EventArgs e) {
            MessageBox.Show("Button is working", "Test", MessageBoxButtons.OK);
            string[] musicFiles = Directory.GetFiles(musicFolderPath, "*.mp3"); // Фильтруем только файлы формата .mp3

            foreach (string musicFile in musicFiles) {
                TagLib.File file = TagLib.File.Create(musicFile); // Используем библиотеку TagLib для получения свойств файла

                if (file.Tag.Genres.Contains("Kpop")) {
                    // Выводим название песни в ListBox или другой элемент управления
                    //listBox1.Items.Add(file.Tag.Title);
                }
            }
        }
    }
}
