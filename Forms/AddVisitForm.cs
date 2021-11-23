using CorseProject.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CorseProject.DB;
using System.Linq;

namespace CorseProject.Forms
{
    public partial class AddVisitForm : Form
    {
        private List<Disease> diseases;
        private List<Procedure> procedures;
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
            UpdateDiseasesList();
            UpdateProceduresList();
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
        public void UpdateDiseasesList()
        {
            cbDiagnosis.Items.Clear();
            diseases = DataBase.GetDiseases();
            cbDiagnosis.Items.AddRange(diseases.Select(e => e.Name).ToArray());
        }
        public void UpdateProceduresList()
        {
            cbAssig.Items.Clear();
            procedures = DataBase.GetProcedures();
            cbAssig.Items.AddRange(procedures.Select(e => e.Name).ToArray());
        }
        private void bAddClick(object sender, EventArgs e)
        {
            int animalId = Convert.ToInt32(cbAnimals.SelectedItem.ToString().Remove(0, cbAnimals.SelectedItem.ToString().LastIndexOf(':') + 1));
            int employeeID = DataBase.GetEmployeeID(lUserName.Text);
            DateTime dateTime = (dtpDate.Value + dtpTime.Value.TimeOfDay); dateTime.AddSeconds(-dateTime.Second);
            Visit visit = new Visit(animalId, employeeID, dateTime);
            for (int i = 0; i < diseases.Count; i++)
            {
                if (!lbDiagnosis.Items.Contains(diseases[i].Name))
                {
                    diseases.RemoveAt(i);
                }
            }
            for (int i = 0; i < procedures.Count; i++)
            {
                if (!lbAssignment.Items.Contains(procedures[i].Name))
                {
                    procedures.RemoveAt(i);
                }
            }
            DataBase.AddVisit(visit, diseases, procedures);
            Close();
        }

        private void bAddAnimal_Click(object sender, EventArgs e)
        {
            CreateAnimalForm animalForm = new CreateAnimalForm();
            animalForm.ShowDialog();
        }

        private void bAddClient_Click(object sender, EventArgs e)
        {
            CreateClientForm clientForm = new CreateClientForm();
            clientForm.ShowDialog();
        }

        private void bAddDiagnosis_Click(object sender, EventArgs e)
        {
            string diagnosis = cbDiagnosis.SelectedItem?.ToString();
            if (diagnosis != null)
            {
                if (!lbDiagnosis.Items.Contains(diagnosis))
                {
                    lbDiagnosis.Items.Add(diagnosis);

                }
                cbDiagnosis.SelectionLength = 0;
                cbDiagnosis.SelectedIndex = -1;
            }

        }

        private void bAddAssig_Click(object sender, EventArgs e)
        {
            string assignment = cbAssig.SelectedItem?.ToString();
            if (assignment != null)
            {
                if (!lbAssignment.Items.Contains(assignment))
                {
                    lbAssignment.Items.Add(assignment);

                }
                cbAssig.SelectionLength = 0;
                cbAssig.SelectedIndex = -1;
            }
        }

        private void bCreateDiagnosis_Click(object sender, EventArgs e)
        {
            CreateDiagnosisForm createDiagnosisForm = new CreateDiagnosisForm();
            createDiagnosisForm.ShowDialog();
        }

        private void bCreateAssignment_Click(object sender, EventArgs e)
        {
            CreateAssignmentForm createAssignmentForm = new CreateAssignmentForm();
            createAssignmentForm.ShowDialog();
        }
    }
}
