using System.Globalization;

namespace Transaction_Management
{
    internal class TransactionDL
    {
        static readonly List<Transaction> transactions = new List<Transaction>();
        static readonly string filePath = "Transaction.txt";
        public static List<Transaction> GetTransactions()
        {
            return transactions;
        }
        public static string AddTransaction(Transaction transaction)
        {
            string message;
            try
            {
                string newTransaction = $"{transaction.TransactionId},{transaction.TransactionDate.ToString("o")},{transaction.TransactionDetails},{transaction.TransactionCategory},{transaction.TransactionAmount}";
                File.AppendAllText(filePath, newTransaction + Environment.NewLine);
                transactions.Add(transaction);
                message = "Success";
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return message;
        }
        public static string UpdateTransaction(Transaction transaction)
        {
            string message="";
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts[0] == transaction.TransactionId)
                    {
                        for (int j=0;j<transactions.Count;j++)
                        {
                            if(transactions[j].TransactionId == transaction.TransactionId)
                            {
                                transactions[j].TransactionDate = transaction.TransactionDate;
                                transactions[j].TransactionCategory=transaction.TransactionCategory;
                                transactions[j].TransactionAmount=transaction.TransactionAmount;
                                transactions[j].TransactionDetails=transaction.TransactionDetails;
                            }
                        }
                        lines[i] = $"{transaction.TransactionId},{transaction.TransactionDate.ToString("o")},{transaction.TransactionDetails},{transaction.TransactionCategory},{transaction.TransactionAmount}";
                        message = "Success";
                        break;
                    }
                }
                File.WriteAllLines(filePath, lines);
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return message;
        }
        public static string RemoveTransaction(string transactionID)
        {
            string message;
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                List<string> updatedLines = new List<string>();
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts[0] != transactionID)
                    {
                        updatedLines.Add(line);
                    }
                }
                File.WriteAllLines(filePath, [.. updatedLines]);
                transactions.RemoveAll(t => t.TransactionId == transactionID);
                message = "Success";
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return message;
        }
        public static void LoadTransactions()
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 5)
                    {
                        try
                        {
                            Transaction transaction = new Transaction(parts[0], DateTime.Parse(parts[1], null, DateTimeStyles.RoundtripKind), parts[2], parts[3], double.Parse(parts[4]));
                            transactions.Add(transaction);
                        }
                        catch (FormatException)
                        {

                        }
                    }
                }
            }
        }
        public static void SaveTransactions()
        {
            try
            {
                List<string> lines = new List<string>();
                foreach (Transaction transaction in transactions)
                {
                    string line = $"{transaction.TransactionId},{transaction.TransactionDate},{transaction.TransactionDetails},{transaction.TransactionCategory},{transaction.TransactionAmount}";
                    lines.Add(line);
                }
                File.WriteAllLines(filePath, lines);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
