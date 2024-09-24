using System;
using System.Windows.Forms;

namespace Bus_Schedule_Management
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string result = UserManager.UserSignIn(UInput.Text,PInput.Text);
                if (result=="Admin" || result=="User")
                {
                    MessageBox.Show("Signed In successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result=="Admin")
                    {
                        AdminPage adminPage = new AdminPage();
                        adminPage.Show();
                        Hide();
                    }
                    else
                    {
                        UserPage userPage = new UserPage();
                        userPage.Show();
                        Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Credentials!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
