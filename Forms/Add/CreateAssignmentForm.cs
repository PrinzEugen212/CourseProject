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
    public partial class CreateAssignmentForm : Form
    {
        public CreateAssignmentForm()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (AreFieldsFilledCorrectly())
            {
                DataBase.AddProcedure(new Models.Procedure(tbName.Text));
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private bool AreFieldsFilledCorrectly()
        {
            if (tbName.Text == string.Empty)
            {
                MessageBox.Show("Заполните название");
                return false;
            }
            return true;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
