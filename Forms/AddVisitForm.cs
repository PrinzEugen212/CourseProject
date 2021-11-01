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
    public partial class AddVisitForm : Form
    {
        public AddVisitForm(string userName)
        {
            InitializeComponent();
            lUserName.Text = userName;
            UpdateLists();
        }
        public void UpdateLists()
        {
            UpdateAnimalsList();
            UpdateClientsList();
        }
        public void UpdateAnimalsList()
        {
            cbAnimals.Items.Clear();
            cbAnimals.Items.AddRange(DataBase.GetAnimalsAndClients().ToArray());
        }
        public void UpdateClientsList()
        {
            cbClients.Items.Clear();
            cbClients.Items.AddRange(DataBase.GetClients().ToArray());
        }
        private void bAddClick(object sender, EventArgs e)
        {
            int animalId = Convert.ToInt32(cbAnimals.SelectedItem.ToString().Remove(0, cbAnimals.SelectedItem.ToString().LastIndexOf(':')));

            Visit visit = new Visit(1, animalId, dtpDate.Value + dtpTime.Value.TimeOfDay, tbDiagnosis.Text, tbAssigment.Text);
            DataBase.AddVisit(visit);
            Close();
        }

        private void bAddAnimal_Click(object sender, EventArgs e)
        {
            CreateAnimalForm animalForm = new CreateAnimalForm();
            animalForm.Show();
        }

        private void bAddClient_Click(object sender, EventArgs e)
        {
            CreateClientForm clientForm = new CreateClientForm();
            clientForm.Show();
        }
    }
}
