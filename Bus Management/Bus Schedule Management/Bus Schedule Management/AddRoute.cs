using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bus_Schedule_Management
{
    public partial class AddRoute : Form
    {
        public AddRoute()
        {
            InitializeComponent();
            LoadBusNumbers();
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            BusesAndScheduleManagement busesAndScheduleManagement = new BusesAndScheduleManagement();
            busesAndScheduleManagement.Show();
            Hide();
        }
        private void LoadBusNumbers()
        {
            try
            {
                List<string> busNumbers = BusManager.GetAllBusNumbers();
                BusNumInput.DataSource = busNumbers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading bus numbers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddRouteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BusNumInput.Text) || string.IsNullOrEmpty(StationNameInput.Text) || string.IsNullOrEmpty(RoutePositionInput.Text))
            {
                MessageBox.Show("Missing Information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!int.TryParse(RoutePositionInput.Text, out int routeNumber))
                {
                    MessageBox.Show("Route Position must be a valid integer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    string result = BusManager.AddRoute(BusNumInput.Text, routeNumber, StationNameInput.Text, StationDesInput.Text);
                    if (result == "Route and station added successfully.")
                    {
                        MessageBox.Show("Route and station added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show(result, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void ClearInputs()
        {
            BusNumInput.Text= null;
            StationNameInput.Text= null;
            StationDesInput.Text= null;
            RoutePositionInput.Text= null;
        }
    }
}
