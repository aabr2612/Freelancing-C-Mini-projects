using System;
using System.Windows.Forms;

namespace Bus_Schedule_Management
{
    public partial class UserPage : Form
    {
        public UserPage()
        {
            InitializeComponent();
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }
        private void ManageScheduleBtn_Click(object sender, EventArgs e)
        {
            ViewSchedules viewSchedules = new ViewSchedules("User");
            viewSchedules.Show();
            Hide();
        }
    }
}
