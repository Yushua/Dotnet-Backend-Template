namespace TemplateBackend.Models
{
    public class Account
    {
        private int id;
        private string accountNumber;
        private string accountHolder;
        private decimal balance;

        public Account(string accountNumber, string accountHolder)
        {
            this.accountNumber = accountNumber ?? throw new ArgumentNullException(nameof(accountNumber));
            this.accountHolder = accountHolder ?? throw new ArgumentNullException(nameof(accountHolder));
        }

        public int Id 
        { 
            get => id; 
            set => id = value; 
        }
        public string AccountNumber 
        { 
            get => accountNumber; 
            set => accountNumber = value ?? throw new ArgumentNullException(nameof(AccountNumber)); 
        }
        public string AccountHolder 
        { 
            get => accountHolder; 
            set => accountHolder = value ?? throw new ArgumentNullException(nameof(AccountHolder)); 
        }
        public decimal Balance 
        { 
            get => balance; 
            set => balance = value; 
        }
    }
}
