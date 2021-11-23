using CorseProject.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CorseProject.Forms
{
    public partial class CreateDiagnosisForm : Form
    {
        public CreateDiagnosisForm()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (tbDiagnosis.Text != string.Empty)
            {
                DataBase.AddDisease(new Models.Disease(tbDiagnosis.Text));
                Close();
            }
            else
            {
                MessageBox.Show("Напишите диагноз, который вы хотите добавить");
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
