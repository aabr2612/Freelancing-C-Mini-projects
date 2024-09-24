using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bus_Schedule_Management
{
    public partial class SignUp : Form
    {
        readonly string role;
        public SignUp(string role)
        {
            InitializeComponent();
            this.role=role;
        }
        private void ClearInputs()
        {
            UInput.Text=null;
            PInput.Text=null;
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            if(role=="User")
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                Hide();
            }
            else if(role=="Admin")
            {
                AdminPage adminPage = new AdminPage();
                adminPage.Show();
                Hide();
            }
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UInput.Text) || string.IsNullOrEmpty(PInput.Text))
            {
                MessageBox.Show("Missing Information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(IsUserInfoValid(UInput.Text,PInput.Text)=="Valid")
            {
                try
                {
                    string result = UserManager.UserSignUp(UInput.Text, PInput.Text, role);
                    if(result=="Success")
                    {
                        MessageBox.Show(role+" added Successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show(result, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(IsUserInfoValid(UInput.Text, PInput.Text), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }
        public string IsValidUsername(string username)
        {
            if (username.Length > 50)
            {
                return "Username must be smaller than 50 characters!";
            }
            Regex regex = new Regex("^[a-zA-Z0-9]*$");
            if (!regex.IsMatch(username))
            {
                return "Username must consists of numbers and letters only!";
            }

            return "Valid";
        }
        private string IsUserInfoValid(string UserName, string Password)
        {
            string message=IsValidUsername(UserName);
            if(message=="Valid")
            {
                message=IsValidPassword(Password);
            }
            return message;
        }

        private string IsValidPassword(string Password)
        {
            if (Password.Length > 20)
            {
                return "Password must be smaller than 20 characters!";
            }
            return "Valid";
        }
    }
}
