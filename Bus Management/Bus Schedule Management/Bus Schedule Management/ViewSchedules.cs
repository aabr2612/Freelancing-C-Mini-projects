using System.Data.SqlClient;
using System.Data;
using System;
using System.Windows.Forms;

namespace Bus_Schedule_Management
{
    public partial class ViewSchedules : Form
    {
        readonly string role;
        public ViewSchedules(string role)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            LoadAlldata();
            this.role = role;
        }

        private void LoadAlldata()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Server=(local); Database=BusesDataManagement; Trusted_Connection=True"))
                {
                    conn.Open();
                    string query = "SELECT B.BusNumber, B.RouteNumber as [Stop Number], B.StationName, B.StationDescription, T.Route1, T.Route2, T.Route3, T.Route4, T.Route5, T.Route6, T.Route7, T.Route8 \r\nFROM TimeTable AS T \r\nJOIN BusRoutes AS B ON B.BusStationNumber = T.StationNumber\r\nGROUP BY B.BusNumber, B.RouteNumber, B.StationName, B.StationDescription, T.Route1, T.Route2, T.Route3, T.Route4, T.Route5, T.Route6, T.Route7, T.Route8\r\nORDER BY B.BusNumber, B.RouteNumber;\r\n";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Busnumber", SearchBar.Text);
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

        private void BackBtn_Click(object sender, System.EventArgs e)
        {
            if (role =="Admin")
            {
                ManageSchedule manageSchedule = new ManageSchedule();
                manageSchedule.Show();
                Hide();
            }
            else if(role=="User")
            {
                UserPage userPage = new UserPage();
                userPage.Show();
                Hide();
            }
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
                    command.Parameters.AddWithValue("@Busnumber", SearchBar.Text);
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

        private void SearchBtnn_Click(object sender, EventArgs e)
        {
            LoadBusTimeTable();
        }
    }
}
