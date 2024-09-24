using System;
using System.Windows.Forms;

namespace Bus_Schedule_Management
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }
        private void AddAdminsBtn_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp("Admin");
            signUp.Show();
            Hide();
        }
        private void ManageScheduleBtn_Click(object sender, EventArgs e)
        {
            BusesAndScheduleManagement manageSchedule = new BusesAndScheduleManagement();
            manageSchedule.Show();
            Hide();
        }

        private void Inputs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void BottomContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TopContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Header_Click(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
