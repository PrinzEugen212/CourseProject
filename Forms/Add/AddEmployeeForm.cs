using CorseProject.DB;
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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(tbName.Text, tbLogin.Text, tbPassword.Text, tbPhone.Text, chbIsWorking.Checked, dtpBirthDate.Value, tbPost.Text, tbSpeciality.Text);
            DataBase.AddEmployee(employee);
            Close();
        }
    }
}
