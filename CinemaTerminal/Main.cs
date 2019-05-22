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
        public string imagePath = @"C:\CinemaTerminal\Posters\Poster_4.jpg";
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
            SelectVideo(1);
        }

        public void setImage(PictureBox pictureBox)
        {
            Bitmap image = new Bitmap(imagePath);
            pictureBox.Image = Image.FromFile(@"C:\CinemaTerminal\Posters\Poster_4.jpg");
        }
    }
}
