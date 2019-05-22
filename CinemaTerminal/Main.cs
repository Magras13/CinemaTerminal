using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;
using System.IO;

namespace CinemaTerminal
{
    public partial class MainForm : Form
    {
        private Video video;
        private string[] videoPaths;
        private string folderPath = @"C:\CinemaTerminal\Videos\";
        private int selectedIndex = 0;
        private Size pnlSize;
        private Size formSize;

        Schedule schedule = new Schedule();
        EditingForm editing = new EditingForm();
        public MainForm()
        {
            InitializeComponent();

            setImage(poster01, "Poster_1.jpg");
            setImage(poster02, "Poster_2.jpg");
            setImage(poster03, "Poster_3.jpg");
            setImage(extraPoster01, "Poster_4.jpg");
            setImage(extraPoster02, "Poster_5.jpg");
            setImage(extraPoster03, "Poster_6.jpg");
            setImage(extraPoster04, "Poster_7.jpg");
            setImage(extraPoster05, "Poster_8.jpg");
            setImage(extraPoster06, "Poster_9.jpg");


            roundCorners(extraPoster01);
            roundCorners(extraPoster02);
            roundCorners(extraPoster03);
            roundCorners(extraPoster04);
            roundCorners(extraPoster05);
            roundCorners(extraPoster06);
            roundCorners(poster01);
            roundCorners(poster02);
            roundCorners(poster03);
            roundCorners(treilerPnl);
            roundCorners(VideoPnl);
        }

        private void scheduleIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            schedule.FormClosed += (s, args) => this.Close();
            schedule.Show();
            schedule.Focus();
        }

        public void roundCorners(Control element)
        {
            Rectangle rect = new Rectangle(0, 0, element.Width, element.Height);
            GraphicsPath g = new GraphicsPath();
            int d = 40;
            g.AddArc(rect.X, rect.Y, d, d, 180, 90);
            g.AddArc(rect.X + rect.Width - d, rect.Y, d, d, 270, 90);
            g.AddArc(rect.X + rect.Width - d, rect.Y + rect.Height - d, d, d, 0, 90);
            g.AddArc(rect.X, rect.Y + rect.Height - d, d, d, 90, 90);
            element.Region = new Region(g);
        }

        private void arrowRight_Click(object sender, EventArgs e)
        {
            if(poster01.Visible == true)
            {
                poster01.Visible = false;
                poster02.Visible = true;
                posterPnl1.BackColor = Color.FromArgb(166, 202, 240);
                posterPnl2.BackColor = Color.FromArgb(87, 176, 255);
            }
            else if (poster02.Visible == true)
            {
                poster02.Visible = false;
                poster03.Visible = true;
                posterPnl2.BackColor = Color.FromArgb(166, 202, 240);
                posterPnl3.BackColor = Color.FromArgb(87, 176, 255);
            }
        }

        private void arrowLeft_Click(object sender, EventArgs e)
        {
            if (poster03.Visible == true)
            {
                poster02.Visible = true;
                poster03.Visible = false;
                posterPnl2.BackColor = Color.FromArgb(87, 176, 255);
                posterPnl3.BackColor = Color.FromArgb(166, 202, 240);
            }
            else if (poster02.Visible == true)
            {
                poster01.Visible = true;
                poster02.Visible = false;
                posterPnl1.BackColor = Color.FromArgb(87, 176, 255);
                posterPnl2.BackColor = Color.FromArgb(166, 202, 240);
            }
        }

        private void posterPnl1_Click(object sender, EventArgs e)
        {
            poster01.Visible = true;
            poster02.Visible = false;
            poster03.Visible = false;
            posterPnl1.BackColor = Color.FromArgb(87, 176, 255);
            posterPnl2.BackColor = Color.FromArgb(166, 202, 240);
            posterPnl3.BackColor = Color.FromArgb(166, 202, 240);
        }

        private void posterPnl2_Click(object sender, EventArgs e)
        {
            poster01.Visible = false;
            poster02.Visible = true;
            poster03.Visible = false;
            posterPnl1.BackColor = Color.FromArgb(166, 202, 240);
            posterPnl2.BackColor = Color.FromArgb(87, 176, 255);
            posterPnl3.BackColor = Color.FromArgb(166, 202, 240);
        }

        private void posterPnl3_Click(object sender, EventArgs e)
        {
            poster01.Visible = false;
            poster02.Visible = false;
            poster03.Visible = true;
            posterPnl1.BackColor = Color.FromArgb(166, 202, 240);
            posterPnl2.BackColor = Color.FromArgb(166, 202, 240);
            posterPnl3.BackColor = Color.FromArgb(87, 176, 255);
        }

        private void AdminIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            editing.FormClosed += (s, args) => this.Close();
            editing.Show();
            editing.Focus();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.myDataSet.Film);
            // TODO: This line of code loads data into the 'myDataSet.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.myDataSet.Film);
            // TODO: This line of code loads data into the 'myDataSet.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.myDataSet.Film);
            // TODO: This line of code loads data into the 'myDataSet.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.myDataSet.Film);
            formSize = new Size(this.Width, this.Height);
            pnlSize = new Size(VideoPnl.Width, VideoPnl.Height);

            videoPaths = Directory.GetFiles(folderPath, "*.wmv");

            if (videoPaths != null)
            {
                foreach (string path in videoPaths)
                {
                    string vid = path.Replace(folderPath, string.Empty);
                    vid = vid.Replace(".wmv", string.Empty);
                }
            }
        }

        private void poster01_Click(object sender, EventArgs e)
        {
            filmBindingSource.Position = 0;
            SelectVideo(0);
        }

        private void backIcon_Click(object sender, EventArgs e)
        {
            video.Stop();
            video.Dispose();
            treilerPnl.Visible = false;
        }

        private void poster03_Click(object sender, EventArgs e)
        {
            filmBindingSource.Position = 2;
            SelectVideo(2);
        }

        public void SelectVideo(int myIndex)
        {
            treilerPnl.Visible = true;
            try
            {
                video.Stop();
                video.Dispose();
            }
            catch { }

            int index = myIndex;
            selectedIndex = index;
            video = new Video(videoPaths[index], false);
            video.Owner = VideoPnl;
            VideoPnl.Size = pnlSize;
            video.Play();
        }

        private void poster02_Click(object sender, EventArgs e)
        {
            filmBindingSource.Position = 1;
            SelectVideo(1);
        }

        public void setImage(PictureBox pictureBox, string fileName)
        {
            string image = @"C:\CinemaTerminal\Posters\";
            image += fileName;
            pictureBox.Image = Image.FromFile(image);
        }

        private void extraPoster01_Click(object sender, EventArgs e)
        {
            filmBindingSource.Position = 3;
            SelectVideo(3);
        }

        private void extraPoster02_Click(object sender, EventArgs e)
        {
            filmBindingSource.Position = 4;
            SelectVideo(4);
        }

        private void extraPoster03_Click(object sender, EventArgs e)
        {
            filmBindingSource.Position = 5;
            SelectVideo(5);
        }

        private void extraPoster04_Click(object sender, EventArgs e)
        {
            filmBindingSource.Position = 6;
            SelectVideo(6);
        }

        private void extraPoster05_Click(object sender, EventArgs e)
        {
            filmBindingSource.Position = 7;
            SelectVideo(7);
        }

        private void extraPoster06_Click(object sender, EventArgs e)
        {
            filmBindingSource.Position = 8;
            SelectVideo(8);
        }
    }
}
