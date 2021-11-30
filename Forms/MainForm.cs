using CorseProject.DB;
using CorseProject.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CorseProject.Forms
{
    public partial class MainForm : Form
    {
        private Employee employee;
        string tag;
        public MainForm(Employee user)
        {
            this.employee = user;
            InitializeComponent();
            lUserName.Text = user.Name;
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void lAddVisitClick(object sender, EventArgs e)
        {
            AddVisitForm addVisitForm = new AddVisitForm(employee.Name);
            addVisitForm.Show();
        }

        private void lMouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void lMouseMove(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            label.BackColor = Color.FromArgb(209, 209, 224);
        }

        private void GetTableByButtonTag(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            dgwTables.DataSource = DataBase.GetTableByName(button.Tag.ToString()).Tables[0];
            tag = button.Tag.ToString();
            for (int i = 0; i < dgwTables.Columns.Count; i++)
            {
                dgwTables.Columns[i].ReadOnly = true;
            }
        }

        private void lAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.Show();
        }

        private void lEditLast_Click(object sender, EventArgs e)
        {
            EditVisitForm addVisitForm = new EditVisitForm(employee.Name, DataBase.GetLastVisit(employee.ID ?? 0));
            addVisitForm.Show();
        }

        private void dgwTables_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(tag == null)
            {
                return;
            }
            switch (tag)
            {
                case "Clients": return;
                case "Animals": return;
                case "Visits": return;
                case "Employees": return;
                case "ProceduresList": return;
                case "Diseases": return;
            }
        }
    }
}
