using CorseProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CorseProject.Forms
{
    public partial class CreateAnimalForm : Form
    {
        string photo = null;
        public CreateAnimalForm()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal(1, tbName.Text, tbGender.Text, tbType.Text, tbBreed.Text, Convert.ToDouble(tbAge.Text), photo);
            DataBase.AddAnimal(animal);
            Close();
        }

        private void bChoosePhoto_Click(object sender, EventArgs e)
        {
            if (openPhotoDialog.ShowDialog() == DialogResult.Cancel)
                return;
            photo = openPhotoDialog.FileName;
        }
    }
}
