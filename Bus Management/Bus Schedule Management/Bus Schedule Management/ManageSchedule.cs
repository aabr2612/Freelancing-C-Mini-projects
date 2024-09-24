using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Data;

namespace Bus_Schedule_Management
{
    public partial class ManageSchedule : Form
    {
        public ManageSchedule()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            LoadBusNumbers();
            LoadBusTimeTable();
        }
        private void BackBtn_Click(object sender, System.EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
            Hide();
        }
        private void LoadBusNumbers()
        {
            try
            {
                List<string> busNumbers = BusManager.GetAllBusNumbers();
                BNInput.DataSource = busNumbers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading bus numbers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ViewScheduleBtn_Click(object sender, System.EventArgs e)
        {
            ViewSchedules viewSchedules = new ViewSchedules("Admin");
            viewSchedules.Show();
            Hide();
        }

        private void BN_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                List<string> stopNumbers = BusManager.GetAllStopNumbers(BNInput.Text);
                LoadBusTimeTable();
                SNInput.DataSource = stopNumbers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading bus numbers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddTimeBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BNInput.Text) || string.IsNullOrEmpty(SNInput.Text))
            {
                MessageBox.Show("Missing information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!IsValidTimeFormat(R1I.Text) || !IsValidTimeFormat(R2I.Text) || !IsValidTimeFormat(R3I.Text) ||
                     !IsValidTimeFormat(R4I.Text) || !IsValidTimeFormat(R5I.Text) || !IsValidTimeFormat(R6I.Text) ||
                     !IsValidTimeFormat(R7I.Text) || !IsValidTimeFormat(R8I.Text))
            {
                MessageBox.Show("Invalid time format! Please enter times in HH:mm format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string result = BusManager.AddTimeTableEntry(BNInput.Text, int.Parse(SNInput.Text), R1I.Text, R2I.Text, R3I.Text, R4I.Text, R5I.Text, R6I.Text, R7I.Text, R8I.Text);
                MessageBox.Show(result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBusTimeTable();
            }
        }
        private bool IsValidTimeFormat(string time)
        {
            string pattern = @"^([01]?[0-9]|2[0-3]):[0-5][0-9]$";
            return Regex.IsMatch(time, pattern);
        }
        private void LoadBusTimeTable()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Server=(local); Database=BusesDataManagement; Trusted_Connection=True"))
                {
                    conn.Open();
                    string query = "SELECT B.RouteNumber as [Stop Number], B.StationName, B.StationDescription, T.Route1, T.Route2, T.Route3, T.Route4, T.Route5, T.Route6, T.Route7, T.Route8 FROM TimeTable AS T JOIN BusRoutes AS B ON B.BusStationNumber = T.StationNumber WHERE B.BusNumber = @Busnumber";

                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Busnumber", BNInput.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    BusesTimeTable.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the Bus TimeTable: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BusesTimeTable_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (BusesTimeTable.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = BusesTimeTable.SelectedRows[0];
                    SNInput.Text = selectedRow.Cells["Stop Number"].Value.ToString();
                    R1I.Text = selectedRow.Cells["Route1"].Value.ToString();
                    R2I.Text = selectedRow.Cells["Route2"].Value.ToString();
                    R3I.Text = selectedRow.Cells["Route3"].Value.ToString();
                    R4I.Text = selectedRow.Cells["Route4"].Value.ToString();
                    R5I.Text = selectedRow.Cells["Route5"].Value.ToString();
                    R6I.Text = selectedRow.Cells["Route6"].Value.ToString();
                    R7I.Text = selectedRow.Cells["Route7"].Value.ToString();
                    R8I.Text = selectedRow.Cells["Route8"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading row data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BNInput.Text) || string.IsNullOrEmpty(SNInput.Text))
            {
                MessageBox.Show("Missing information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!IsValidTimeFormat(R1I.Text) || !IsValidTimeFormat(R2I.Text) || !IsValidTimeFormat(R3I.Text) ||
                     !IsValidTimeFormat(R4I.Text) || !IsValidTimeFormat(R5I.Text) || !IsValidTimeFormat(R6I.Text) ||
                     !IsValidTimeFormat(R7I.Text) || !IsValidTimeFormat(R8I.Text))
            {
                MessageBox.Show("Invalid time format! Please enter times in HH:mm format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string result = BusManager.ModifyTimeTableEntry(BNInput.Text, int.Parse(SNInput.Text), R1I.Text, R2I.Text, R3I.Text, R4I.Text, R5I.Text, R6I.Text, R7I.Text, R8I.Text);
                MessageBox.Show(result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBusTimeTable();
            }
        }
    }
}
