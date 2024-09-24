using System;
using System.Windows.Forms;

namespace Contact_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ContactMngBtn_Click_1(object sender, EventArgs e)
        {
            ManageContacts manageContacts = new ManageContacts();
            manageContacts.Show();
            Hide();
        }
    }
}
