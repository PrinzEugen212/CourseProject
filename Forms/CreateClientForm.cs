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
    }
}
