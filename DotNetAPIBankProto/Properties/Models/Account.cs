namespace TemplateBackend.Models
{
    public class Account
    {
        private int id;
        private string accountNumber;
        private string accountHolder;
        private decimal balance;

        public int Id 
        { 
            get => id; 
            set => id = value; 
        }
        public string AccountNumber 
        { 
            get => accountNumber; 
            set => accountNumber = value; 
        }
        public string AccountHolder 
        { 
            get => accountHolder; 
            set => accountHolder = value; 
        }
        public decimal Balance 
        { 
            get => balance; 
            set => balance = value; 
        }
    }
}