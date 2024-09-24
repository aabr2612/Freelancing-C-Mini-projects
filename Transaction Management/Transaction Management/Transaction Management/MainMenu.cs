namespace Transaction_Management
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            TransactionDL.LoadTransactions();
        }

        private void BtnManageTransaction_Click(object sender, EventArgs e)
        {
            ManageTransactions manageTransactions = new ManageTransactions();
            manageTransactions.Show();
            Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            TransactionDL.SaveTransactions();
            Application.Exit();
        }
    }
}
