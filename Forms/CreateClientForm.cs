using CorseProject.DB;
using CorseProject.Models;
using System;
using System.Windows.Forms;

namespace CorseProject.Forms
{
    public partial class CreateClientForm : Form
    {
        public CreateClientForm()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Client client = new Client(tbName.Text, tbPhone.Text, dtpDate.Value);
            DataBase.AddClient(client);
            Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
