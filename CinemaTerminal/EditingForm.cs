using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace CinemaTerminal
{
    public partial class EditingForm : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        string sourceTreillerFile, sourcePosterFile, destinationTreillerFile, destinationPosterFile;

        public EditingForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.Hide();
            main.FormClosed += (s, args) => this.Close();
            main.Show();
            main.Focus();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.filmBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDataSet);
                File.Copy(sourceTreillerFile, destinationTreillerFile, true);
                File.Copy(sourcePosterFile, destinationPosterFile, true);
            }
            catch
            {
                MessageBox.Show("Заполните все ячейки", "Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }


        private void EditingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.myDataSet.Film);
        }

        private void filmBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            filmBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(myDataSet);

        }

        private void addTreilerOFD_Click(object sender, EventArgs e)
        {
            destinationTreillerFile = @"C:\CinemaTerminal\Videos\";
            openFile.Filter = "WMV|*.wmv";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                sourceTreillerFile = openFile.FileName;
                destinationTreillerFile += openFile.SafeFileName;
                treillerAddresBox.Text = openFile.FileName;
            }
        }

        private void addPosterOFD_Click(object sender, EventArgs e)
        {
            destinationPosterFile = @"C:\CinemaTerminal\Posters\";
            openFile.Filter = "JPG|*.jpg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                sourcePosterFile = openFile.FileName;
                destinationPosterFile += openFile.SafeFileName;
                posterAddresBox.Text = openFile.FileName;
            }
        }
    }
}
