using CorseProject.DB;
using CorseProject.Models;
using System;
using System.Windows.Forms;

namespace CorseProject.Forms
{
    public partial class CreateAnimalForm : Form
    {
        private string photo = null;
        private string[] animalGenders = new string[] { "М", "Ж" };
        public CreateAnimalForm()
        {
            InitializeComponent();
            cbGender.Items.AddRange(animalGenders);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal(1, tbName.Text, cbGender.SelectedItem.ToString(), tbType.Text, tbBreed.Text, Convert.ToDouble(tbAge.Text), photo);
            DataBase.AddAnimal(animal);
            Close();
        }

        private void bChoosePhoto_Click(object sender, EventArgs e)
        {
            if (openPhotoDialog.ShowDialog() == DialogResult.Cancel)
                return;
            photo = openPhotoDialog.FileName;
        }

        private void bCancelClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
