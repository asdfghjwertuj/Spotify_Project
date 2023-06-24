using System.Drawing;
using System.Windows.Forms;

namespace ExamTeamProject {
    public partial class Form1 : Form
    {
        // Получаем максимального горизонтального и вертикального размера монитора
        int horizontalResolution = Screen.PrimaryScreen.Bounds.Width;
        int verticalResolution = Screen.PrimaryScreen.Bounds.Height;
        public Form1() {
            InitializeComponent();

            //SetBackgroundImage("C:\\Users\\Admin\\Source\\Repos\\Spotify_Project\\ExamTeamProject\\MainPageBg.jpg");

            //Устанавливаем минимальный и максимальный размер окна
            this.MaximumSize = new Size(horizontalResolution, verticalResolution);
            this.MinimumSize = new Size(800, 600);
        }
        //private void SetBackgroundImage(string imagePath) {
        //    PictureBox pbBackground = new PictureBox();
        //    pbBackground.Image = Image.FromFile(imagePath);
        //    pbBackground.SizeMode = PictureBoxSizeMode.StretchImage;
        //    pbBackground.Dock = DockStyle.Fill;
        //    pbBackground.BackColor = Color.Transparent;

        //    this.Controls.Add(pbBackground);
        //    this.SendToBack();
        //}
    }
}
