
namespace Transaction_Management
{
    internal class Transaction
    {
        private string transactionId;
        private DateTime transactionDate;
        private string transactionDetails;
        private string transactionCategory;
        private double transactionAmount;
        public Transaction(string transactionId, DateTime transactionDate, string transactionDetails, string transactionCategory, double transactionAmount)
        {
            this.transactionId=transactionId;
            this.transactionDate=transactionDate;
            this.transactionDetails=transactionDetails;
            this.transactionCategory=transactionCategory;
            this.transactionAmount=transactionAmount;
        }
        public string TransactionId { get => transactionId; set => transactionId=value; }
        public DateTime TransactionDate { get => transactionDate; set => transactionDate=value; }
        public string TransactionDetails { get => transactionDetails; set => transactionDetails=value; }
        public string TransactionCategory { get => transactionCategory; set => transactionCategory=value; }
        public double TransactionAmount { get => transactionAmount; set => transactionAmount=value; }
    }
}
