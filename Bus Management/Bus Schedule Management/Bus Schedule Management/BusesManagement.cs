using System;
using System.Windows.Forms;

namespace Bus_Schedule_Management
{
    public partial class BusesManagement : Form
    {
        public BusesManagement()
        {
            InitializeComponent();
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            BusesAndScheduleManagement busesAndScheduleManagement = new BusesAndScheduleManagement();
            busesAndScheduleManagement.Show();
            Hide();
        }
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BNInput.Text))
            {
                MessageBox.Show("Missing Information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string result = BusManager.AddBus(BNInput.Text, DInput.Text);
                    if (result=="Success")
                    {
                        MessageBox.Show("Bus added Successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DInput.Text=null;
            BNInput.Text=null;
        }
    }
}
