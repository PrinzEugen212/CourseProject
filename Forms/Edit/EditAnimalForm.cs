using CorseProject.DB;
using CorseProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CorseProject.Forms.Edit
{
    public partial class EditAnimalForm : Form
    {
        private string photo = null;
        private string[] animalGenders = new string[] { "М", "Ж" };
        private List<Client> clients;
        public EditAnimalForm(Animal animal)
        {
            InitializeComponent();
            clients.Add(DataBase.GetClient(animal.ClientID));
            cbClients.SelectedItem = clients.First().FullName;
            cbGender.SelectedItem = animal.Gender;
            tbType.Text = animal.Type;
            tbBreed.Text = animal.Breed;
            tbAge.Text = animal.Age.ToString();
            tbName.Text = animal.Name;
            try
            {
                pbAnimal.Image = Image.FromFile(animal.Photo);
            }
            catch { }
            SetFilter();
            UpdateClientsList();
        }
        private void SetFilter()
        {
            var codecs = ImageCodecInfo.GetImageEncoders();
            var codecFilter = "Image Files|";
            foreach (var codec in codecs)
            {
                codecFilter += codec.FilenameExtension + ";";
            }
            openPhotoDialog.Filter = codecFilter;
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            Client client = clients.First(x => x.FullName == cbClients.SelectedItem.ToString());
            Animal animal = new Animal(client.ID ?? 0, tbName.Text, cbGender.SelectedItem.ToString(), tbType.Text, tbBreed.Text, Convert.ToDouble(tbAge.Text), photo);
            DataBase.EditAnimal(animal);
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

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void bAddClient_Click(object sender, EventArgs e)
        {
            CreateClientForm clientForm = new CreateClientForm();
            if (clientForm.ShowDialog() == DialogResult.OK)
            {
                UpdateClientsList();
            }
        }
        public void UpdateClientsList()
        {
            cbClients.Items.Clear();
            clients = DataBase.GetClients();
            cbClients.Items.AddRange(clients.Select(e => e.FullName).ToArray());
        }
    }
}
