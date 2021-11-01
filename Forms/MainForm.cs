using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CorseProject.Forms
{
    public partial class MainForm : Form
    {
        private User user;
        public MainForm(User user)
        {
            this.user = user;
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
            AddVisitForm addVisitForm = new AddVisitForm(user.Name);
            addVisitForm.Show();
                
        }
    }
}
