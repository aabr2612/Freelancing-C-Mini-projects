namespace Transaction_Management
{
    public partial class ManageTransactions : Form
    {
        public ManageTransactions()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        // Clears input fields for adding transaction
        private void ClearInputAT()
        {
            TDetInput.Text = null;
            TDateInput.Value = DateTime.Now;
            CategoryInput.Text = null;
            TAmountInput.Text = null;
        }

        // Handles adding a new transaction
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TAmountInput.Text) ||
            string.IsNullOrEmpty(TDetInput.Text) ||
            CategoryInput.SelectedItem == null)
            {
                // Show warning
                MessageBox.Show("Missing information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (double.TryParse(TAmountInput.Text, out double amount) && amount > 0)
                {
                    // Get transactions
                    List<Transaction> transactions = TransactionDL.GetTransactions();
                    string TransactionID;
                    if (transactions.Count == 0)
                    {
                        TransactionID = "1";
                    }
                    else
                    {
                        TransactionID = (int.Parse(transactions[transactions.Count - 1].TransactionId) + 1).ToString();
                    }
                    try
                    {
                        // Create transaction
                        Transaction transaction = new Transaction(TransactionID, TDateInput.Value, TDetInput.Text, CategoryInput.Text, amount);
                        string message = TransactionDL.AddTransaction(transaction);
                        if (message == "Success")
                        {
                            // Success message
                            MessageBox.Show("Transaction added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearInputAT();
                            LoadTransactionsData();
                        }
                        else
                        {
                            // Failure message
                            MessageBox.Show(message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Error message
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Invalid amount
                    MessageBox.Show("Please enter a valid amount of transaction! Entry failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Clears input fields for deleting transaction
        private void ClearInputDT()
        {
            TID.Text = null;
            TDate.Value = DateTime.Now;
            TCategory.Text = null;
            TDetails.Text = null;
            TAmount.Text = null;
        }

        // Clears input fields for searching transaction
        private void ClearInputST()
        {
            TIDST.Text = null;
            TCST.Text = null;
            TDST.Text = null;
            TAST.Text = null;
        }

        // Handles deleting a transaction
        private void BtnDeleteTransaction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TID.Text))
            {
                // Show warning
                MessageBox.Show("Missing TransactionID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Remove transaction
                    string message = TransactionDL.RemoveTransaction(TID.Text);
                    ClearInputDT();
                    LoadTransactionsData();
                    if (message == "Success")
                    {
                        // Success message
                        MessageBox.Show("Transaction deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Failure message
                        MessageBox.Show("Transaction not deleted!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    // Error message
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Handles selection change in DataGridDT
        private void DataGridDT_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (DataGridDT.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = DataGridDT.SelectedRows[0];
                    if (selectedRow.Index >= 0 && selectedRow.Index < DataGridDT.Rows.Count)
                    {
                        // Populate fields
                        TID.Text = selectedRow.Cells["Column1DT"].Value?.ToString();
                        TDetails.Text = selectedRow.Cells["Column3DT"].Value?.ToString();
                        TCategory.Text = selectedRow.Cells["Column4DT"].Value?.ToString();
                        TAmount.Text = selectedRow.Cells["Column5DT"].Value?.ToString();
                        if (DateTime.TryParse(selectedRow.Cells["Column2DT"].Value?.ToString(), out DateTime Td))
                        {
                            TDate.Value = Td;
                        }
                        else
                        {
                            ClearInputDT();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handles selection change in DataGridUT
        private void DataGridUT_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (DataGridUT.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = DataGridUT.SelectedRows[0];
                    if (selectedRow.Index >= 0 && selectedRow.Index < DataGridUT.Rows.Count)
                    {
                        // Populate fields
                        TIDUT.Text = selectedRow.Cells["Column1UT"].Value?.ToString();
                        TDetailsUT.Text = selectedRow.Cells["Column3UT"].Value?.ToString();
                        TCategoryUT.Text = selectedRow.Cells["Column4UT"].Value?.ToString();
                        TAmountUT.Text = selectedRow.Cells["Column5UT"].Value?.ToString();
                        if (DateTime.TryParse(selectedRow.Cells["Column2UT"].Value?.ToString(), out DateTime Td))
                        {
                            TDateUT.Value = Td;
                        }
                        else
                        {
                            ClearInputUT();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Loads transactions data into grids
        private void LoadTransactionsData()
        {
            List<Transaction> transactions = TransactionDL.GetTransactions();
            DataGridUT.DataSource = null;
            DataGridUT.Rows.Clear();
            foreach (Transaction t in transactions)
            {
                DataGridUT.Rows.Add(
                    t.TransactionId,
                    t.TransactionDate.ToString(),
                    t.TransactionDetails,
                    t.TransactionCategory,
                    t.TransactionAmount.ToString()
                    );
            }
            DataGridDT.DataSource = null;
            DataGridDT.Rows.Clear();
            foreach (Transaction t in transactions)
            {
                DataGridDT.Rows.Add(
                    t.TransactionId,
                    t.TransactionDate.ToString(),
                    t.TransactionDetails,
                    t.TransactionCategory,
                    t.TransactionAmount.ToString()
                    );
            }
            DataGridAT.DataSource = null;
            DataGridAT.Rows.Clear();
            foreach (Transaction t in transactions)
            {
                DataGridAT.Rows.Add(
                    t.TransactionId,
                    t.TransactionDate.ToString(),
                    t.TransactionDetails,
                    t.TransactionCategory,
                    t.TransactionAmount.ToString()
                    );
            }
            DataGridVT.DataSource = null;
            DataGridVT.Rows.Clear();
            foreach (Transaction t in transactions)
            {
                DataGridVT.Rows.Add(
                    t.TransactionId,
                    t.TransactionDate.ToString(),
                    t.TransactionDetails,
                    t.TransactionCategory,
                    t.TransactionAmount.ToString()
                    );
            }
        }

        // Clears input fields for updating transaction
        private void ClearInputUT()
        {
            TIDUT.Text = null;
            TDateUT.Value = DateTime.Now;
            TCategoryUT.Text = null;
            TDetailsUT.Text = null;
            TAmountUT.Text = null;
        }

        // Handles updating a transaction
        private void BtnUpdateTransaction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TAmountUT.Text) ||
        string.IsNullOrEmpty(TDetailsUT.Text) ||
        string.IsNullOrEmpty(TCategoryUT.Text) ||
        string.IsNullOrEmpty(TIDUT.Text))
            {
                // Show warning
                MessageBox.Show("Missing information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (double.TryParse(TAmountUT.Text, out double amount) && amount > 0)
                {
                    string TransactionID = TIDUT.Text;
                    try
                    {
                        // Update transaction
                        Transaction transaction = new Transaction(TransactionID, TDateUT.Value, TDetailsUT.Text, TCategoryUT.Text, amount);
                        string message = TransactionDL.UpdateTransaction(transaction);
                        if (message == "Success")
                        {
                            // Success message
                            MessageBox.Show("Transaction updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearInputUT();
                            LoadTransactionsData();
                        }
                        else
                        {
                            // Failure message
                            MessageBox.Show("Transaction updation failed!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Error message
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Invalid amount
                    MessageBox.Show("Please enter a valid amount of transaction! Updation failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Handles selection change in DataGridVT
        private void DataGridVT_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (DataGridVT.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = DataGridVT.SelectedRows[0];
                    if (selectedRow.Index >= 0 && selectedRow.Index < DataGridVT.Rows.Count)
                    {
                        // Populate fields
                        TIDVT.Text = selectedRow.Cells["Column1VT"].Value?.ToString();
                        TDVT.Text = selectedRow.Cells["Column3VT"].Value?.ToString();
                        TCVT.Text = selectedRow.Cells["Column4VT"].Value?.ToString();
                        TAVT.Text = selectedRow.Cells["Column5VT"].Value?.ToString();
                        if (DateTime.TryParse(selectedRow.Cells["Column2VT"].Value?.ToString(), out DateTime Td))
                        {
                            TDTVT.Value = Td;
                        }
                        else
                        {
                            ClearInputDT();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handles searching transactions
        private void BtnST_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ValueST.Text))
            {
                // Show warning
                MessageBox.Show("Missing info to search!", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Get transactions
                List<Transaction> transactions = TransactionDL.GetTransactions();
                List<Transaction> results = new List<Transaction>();
                if (AttributeST.Text == "Amount")
                {
                    if (double.TryParse(ValueST.Text, out double amount))
                    {
                        results = transactions.Where(t => t.TransactionAmount == amount).ToList();
                    }
                    else
                    {
                        // Invalid amount
                        MessageBox.Show("Please enter a valid number for the amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (AttributeST.Text == "Description")
                {
                    results = transactions.Where(t => t.TransactionDetails.Contains(ValueST.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                }
                else if (AttributeST.Text == "Category")
                {
                    results = transactions.Where(t => t.TransactionCategory.Equals(ValueST.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                }
                else if (AttributeST.Text == "ID")
                {
                    results = transactions.Where(t => t.TransactionId.Equals(ValueST.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                }
                else
                {
                    // Invalid attribute
                    MessageBox.Show("Invalid attribute selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadResults(results);
            }
        }

        // Loads search results into DataGridST
        private void LoadResults(List<Transaction> results)
        {
            DataGridST.DataSource = null;
            DataGridST.Rows.Clear();
            foreach (Transaction t in results)
            {
                DataGridST.Rows.Add(
                    t.TransactionId,
                    t.TransactionDate.ToString(),
                    t.TransactionDetails,
                    t.TransactionCategory,
                    t.TransactionAmount.ToString()
                    );
            }
        }

        // Handles selection change in DataGridST
        private void DataGridST_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (DataGridST.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = DataGridST.SelectedRows[0];
                    if (selectedRow.Index >= 0 && selectedRow.Index < DataGridST.Rows.Count)
                    {
                        // Populate fields
                        TIDST.Text = selectedRow.Cells["Column1ST"].Value?.ToString();
                        TDST.Text = selectedRow.Cells["Column3ST"].Value?.ToString();
                        TCST.Text = selectedRow.Cells["Column4ST"].Value?.ToString();
                        TAST.Text = selectedRow.Cells["Column5ST"].Value?.ToString();
                        if (DateTime.TryParse(selectedRow.Cells["Column2ST"].Value?.ToString(), out DateTime Td))
                        {
                            TDTST.Value = Td;
                        }
                        else
                        {
                            ClearInputST();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Exits the application
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Navigates back to the main menu
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            LoadTransactionsData();
        }
    }
}
