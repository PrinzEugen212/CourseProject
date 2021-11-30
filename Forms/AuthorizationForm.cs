using CorseProject.DB;
using CorseProject.Forms;
using CorseProject.Models;
using System;
using System.Windows.Forms;

namespace CorseProject
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            tbLogin.Text = "admin";
            tbPassword.Text = "admin";
        }

        private void bAuthorize_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;
            Employee employee = DataBase.GetEmployee(login);
            if (employee.Password == password)
            {
                MainForm mainForm = new MainForm(employee);
                this.Visible = false;
                mainForm.Show();
            }
        }

        private void tbClick(object sender, EventArgs e)
        {
            //TextBox tb = (TextBox)sender;
            //tb.Text = string.Empty;
        }
    }
}
