using CorseProject.DB;
using CorseProject.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CorseProject.Forms
{
    public partial class CreateAnimalForm : Form
    {
        private string photo = null;
        private string[] animalGenders = new string[] { "М", "Ж" };
        private List<Client> clients;
        public CreateAnimalForm()
        {
            InitializeComponent();
            UpdateClientsList();
            cbGender.Items.AddRange(animalGenders);
            var codecs = ImageCodecInfo.GetImageEncoders();
            var codecFilter = "Image Files|";
            foreach (var codec in codecs)
            {
                codecFilter += codec.FilenameExtension + ";";
            }
            openPhotoDialog.Filter = codecFilter;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Client client = clients.Single(x => x.FullName == cbClients.SelectedItem?.ToString());
            Animal animal = new Animal(client.ID ?? 0, tbName.Text, cbGender.SelectedItem.ToString(), tbType.Text, tbBreed.Text, Convert.ToDouble(tbAge.Text), photo);
            DataBase.AddAnimal(animal);
            try
            {
                File.Copy(photo, @$"{Config.GetValue("SavePhotoPath")}\{tbName.Text}{client.ID ?? 0}.{photo.Split('.').Last()}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void bChoosePhoto_Click(object sender, EventArgs e)
        {
            if (openPhotoDialog.ShowDialog() == DialogResult.Cancel)
                return;
            photo = openPhotoDialog.FileName;
            pbAnimal.Image = Image.FromFile(photo);
        }

        private void bCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        public void UpdateClientsList()
        {
            cbClients.Items.Clear();
            clients = DataBase.GetClients();
            cbClients.Items.AddRange(clients.Select(e => e.FullName).ToArray());
        }

        private void bAddClient_Click(object sender, EventArgs e)
        {
            CreateClientForm clientForm = new CreateClientForm();
            if (clientForm.ShowDialog() == DialogResult.OK)
            {
                UpdateClientsList();
            }
        }
    }
}
