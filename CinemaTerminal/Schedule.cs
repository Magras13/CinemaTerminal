using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTerminal
{
    public partial class Schedule : Form
    {
        Hall hall = new Hall();
        public Schedule()
        {
            InitializeComponent();
        }

        private void scheduleIcon_Click(object sender, EventArgs e)
        {
            this.Hide();
            hall.FormClosed += (s, args) => this.Close();
            hall.Show();
            hall.Focus();
        }
    }
}
