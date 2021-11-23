using CorseProject.DB;
using System;
using System.Drawing;
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
            dgwTables.DataSource = DataBase.GetTable(button.Tag.ToString()).Tables[0];
            dgwTables.Columns["Id"].ReadOnly = true;
        }
    }
}
