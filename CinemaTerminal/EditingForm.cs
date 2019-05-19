using CinemaTerminal.Classes;
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
    public partial class EditingForm : Form
    {
        SqlClass sql = new SqlClass();   
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
            //sql.Element = Convert.ToInt32(elementBox.Text);
            //sql.Name = nameText.Text;
            //sql.Description = descriptionText.Text;
            //sql.Rating = ratingText.Text;


            //bool success = sql.Insert(sql);

            //if (success == true)
            //{
            //    MessageBox.Show("Фильм добавлен!");
            //    //Clear();
            //}
            //else MessageBox.Show("Ошибка!");
        }


        private void EditingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.myDataSet.Film);


        }

        private void filmBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDataSet);

        }
    }
}
