namespace TemplateBackend.Models
{
    public class Transaction
    {
        private int id;
        private int accountId;
        private decimal amount;
        private string transactionType;
        private DateTime date;

        // Constructor to initialize the fields
        public Transaction(int accountId, decimal amount, string transactionType, DateTime date)
        {
            this.accountId = accountId;
            this.amount = amount;
            this.transactionType = transactionType ?? throw new ArgumentNullException(nameof(transactionType), "Transaction type cannot be null.");
            this.date = date;
        }

        public int Id 
        { 
            get => id; 
            set => id = value; 
        }

        public int AccountId 
        { 
            get => accountId; 
            set => accountId = value; 
        }

        public decimal Amount 
        { 
            get => amount; 
            set => amount = value; 
        }

        public string TransactionType 
        { 
            get => transactionType; 
            set => transactionType = value ?? throw new ArgumentNullException(nameof(TransactionType), "Transaction type cannot be null.");
        }

        public DateTime Date 
        { 
            get => date; 
            set => date = value; 
        }
    }
}
