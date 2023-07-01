
namespace ExamTeamProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numberMusic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMusic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Создать плейлист";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить в плейлист";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberMusic,
            this.nameMusic,
            this.dateOfAdd,
            this.time});
            this.dataGridView1.Location = new System.Drawing.Point(143, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(533, 320);
            this.dataGridView1.TabIndex = 2;
            // 
            // numberMusic
            // 
            this.numberMusic.HeaderText = "#";
            this.numberMusic.Name = "numberMusic";
            this.numberMusic.Width = 28;
            // 
            // nameMusic
            // 
            this.nameMusic.HeaderText = "Название";
            this.nameMusic.Name = "nameMusic";
            this.nameMusic.Width = 300;
            // 
            // dateOfAdd
            // 
            this.dateOfAdd.HeaderText = "Дата добавления";
            this.dateOfAdd.Name = "dateOfAdd";
            // 
            // time
            // 
            this.time.HeaderText = "Время";
            this.time.Name = "time";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 129);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 199);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "Главная";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 671);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(1366, 750);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Spotify 95";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberMusic;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMusic;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
    }
}

