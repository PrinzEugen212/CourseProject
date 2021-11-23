using CorseProject.DB;
using CorseProject.Forms;
using System;
using System.Windows.Forms;

namespace CorseProject
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();

        }

        private void bAuthorize_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbLogin.Text;
            User user = DataBase.GetUser(login);
            if (user.Password == password)
            {
                MainForm mainForm = new MainForm(user);
                this.Visible = false;
                mainForm.Show();
            }
        }

        private void tbClick(object sender, EventArgs e)
        {
            tbLogin.Text = "admin";
            tbPassword.Text = "admin";
            //TextBox tb = (TextBox)sender;
            //tb.Text = string.Empty;
        }
    }
}
