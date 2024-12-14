namespace TemplateBackend.Models
{
    public class Transaction
    {
        private int id;
        private int accountId;
        private decimal amount;
        private string transactionType;
        private DateTime date;

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
            set => transactionType = value; 
        }
        public DateTime Date 
        { 
            get => date; 
            set => date = value; 
        }
    }
}