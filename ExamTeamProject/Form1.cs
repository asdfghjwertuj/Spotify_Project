using System;
using System.Drawing;
using System.Windows.Forms;


namespace ExamTeamProject {
    public partial class Form1 : Form {
        private PictureBox pbBackground;

        public Form1() {
            InitializeComponent();

            InitializeBackgroundImage();
            Text = "EchoJukebox";
            Icon = new Icon("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\Icon.ico");
        }

        // Изменение фона идет через PictureBox т.к. он более гибкий плане изменений

        private void InitializeBackgroundImage() {
            pbBackground = new PictureBox(); // создаем новый PictureBox
            pbBackground.SizeMode = PictureBoxSizeMode.StretchImage; // увеличение PictureBox пропорционально
            pbBackground.Dock = DockStyle.Fill; // растягиваем его на весь экран
            pbBackground.BackColor = Color.Transparent;

            this.Controls.Add(pbBackground);
            this.SendToBack(); // добавляем его на экран

            SetBackgroundImage("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\MainPageBg.jpg");
        }

        private void SetBackgroundImage(string imagePath) {
            pbBackground.Image = Image.FromFile(imagePath);
        }

        private void Home_Click(object sender, EventArgs e) {
            SetBackgroundImage("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\MainPageBg.jpg");
            MessageBox.Show("Home button is working", "Test", MessageBoxButtons.OK);
        }

        private void Search_Click(object sender, EventArgs e) {
            SetBackgroundImage("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\MainPageBg1.jpg");
            MessageBox.Show("Search button is working", "Test", MessageBoxButtons.OK);
        }

        private void Playlist_Click(object sender, EventArgs e) {
            SetBackgroundImage("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\MainPageBg1.jpg");
            MessageBox.Show("Play button is working", "Test", MessageBoxButtons.OK);
        }
    }
}

