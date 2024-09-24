using System;
using System.Windows.Forms;

namespace Bus_Schedule_Management
{
    public partial class BusesAndScheduleManagement : Form
    {
        public BusesAndScheduleManagement()
        {
            InitializeComponent();
        }
        private void ManageScheduleBtn_Click(object sender, EventArgs e)
        {
            BusesManagement busesManagement = new BusesManagement();
            busesManagement.Show();
            Hide();
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
            Hide();
        }
        private void AddAdminsBtn_Click(object sender, EventArgs e)
        {
            ManageSchedule manageSchedule = new ManageSchedule();
            manageSchedule.Show();
            Hide();
        }
        private void AddRoutes_Click(object sender, EventArgs e)
        {
            AddRoute addRoute = new AddRoute();
            addRoute.Show();
            Hide();
        }
    }
}
