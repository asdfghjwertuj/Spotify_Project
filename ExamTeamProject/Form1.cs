using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamTeamProject {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            SetBackgroundImage("C:\\Users\\pktb\\source\\repos\\ExamTeamProject\\ExamTeamProject\\MainPageBg.jpg");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SetBackgroundImage(string imagePath) {
            PictureBox pbBackground = new PictureBox();
            pbBackground.Image = Image.FromFile(imagePath);
            pbBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBackground.Dock = DockStyle.Fill;
            pbBackground.BackColor = Color.Transparent;

            this.Controls.Add(pbBackground);
            this.SendToBack();
        }
    }
}
